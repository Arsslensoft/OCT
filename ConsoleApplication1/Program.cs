using Al.Security.Asn1;
using Al.Security.Asn1.X509;
using Al.Security.Crypto.Digests;
using Al.Security.Crypto.Parameters;
using Al.Security.X509;
using Al.Security.X509.Extension;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Print(byte[] output, string tab)
        {

            string hex = BitConverter.ToString(output);
            int perline = 0;
            string line = "";
            foreach (string h in hex.Split('-'))
            {
                line += h + ":";
                perline++;
                if (perline == 15)
                {
                  line =  line.Remove(line.Length - 1, 1);
                    Print(tab +line);
                    line = "";
                    perline = 0;
                }
            }
            if (line.Length > 0)
            {
                line = line.Remove(line.Length - 1, 1);
                Print(tab +line);
            }
        }
        static StreamWriter str;
        static void Print(string output)
        {
            if (outputfile == "stdout")
                Console.WriteLine(output);
            else
                str.WriteLine(output);
        }
        private static string GetRFC822Date(DateTime date)
        {
            int offset = TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).Hours;
            string timeZone = "+" + offset.ToString().PadLeft(2, '0');

            if (offset < 0)
            {
                int i = offset * -1;
                timeZone = "-" + i.ToString().PadLeft(2, '0');
            }

            return date.ToString("ddd, dd MMM yyyy HH:mm:ss " + timeZone.PadRight(5, '0'));
        }
        static string outputfile = "stdout";
       static string certfile = "stdin";
        static void Main(string[] args)
        {
         
            foreach (string s in args)
            {
                if (s.StartsWith("-out:"))
                    outputfile = s.Replace("-out:","");
                if (s.StartsWith("-in:"))
                    certfile = s.Replace("-in:", "");
            }
            if (outputfile != "stdout")
                str = new StreamWriter(outputfile, false);
            System.Security.Cryptography.X509Certificates.X509Certificate2 cer = new System.Security.Cryptography.X509Certificates.X509Certificate2(File.ReadAllBytes(certfile));
               Al.Security.X509.X509Certificate CERT = Al.Security.Security.DotNetUtilities.FromX509Certificate(cer);
            Print("Certificate");
            Print("     Data");
            Print("         Version : " + cer.Version.ToString());
            Print("         Valid : " + cer.Verify().ToString());
            Print("         Serial Number:");
            Print("             " + cer.SerialNumber);
            Print("         Signature Algorithm : ");
            Print("             " + cer.SignatureAlgorithm.FriendlyName);
            Print("         Issuer   : "+cer.Issuer);
            Print("         Validity :   ");
            Print("             Not Before : " + GetRFC822Date(cer.NotBefore));
            Print("             Not After  : " + GetRFC822Date(cer.NotAfter));
            Print("         Subject  : " + cer.Subject);
            Print("         Subject Public Key Info:" );
            Print("             Public Key Exchange Algorithm: " + cer.PublicKey.Key.KeyExchangeAlgorithm);
            Print("             Public Key: " + cer.PublicKey.Key.KeySize.ToString() +" bit");
            Print("             Modulus:" );
            Print(cer.GetPublicKey(),"              ");
            if(CERT.GetPublicKey() is Al.Security.Crypto.Parameters.RsaKeyParameters)
            {
                RsaKeyParameters rsa = (RsaKeyParameters)CERT.GetPublicKey();
                Print("             Exponent:" + rsa.Exponent);
            }
            else if (CERT.GetPublicKey() is Al.Security.Crypto.Parameters.DsaKeyParameters)
            {
                DsaKeyParameters dsa = (DsaKeyParameters)CERT.GetPublicKey();
                Print("             DSA Parameters:");
                Print("                 G:");
                Print("                     " + dsa.Parameters.G.ToString());
                Print("                 P:");
                Print("                     " + dsa.Parameters.P.ToString());
                Print("                 Q:");
                Print("                     " + dsa.Parameters.Q.ToString());

            }
           // Extensions
            Print("         X509 Extensions");
            string extab = "            ";
            bool critical = true;
            foreach (string oid in CERT.GetCriticalExtensionOids())
            {
                Print(" ");

                X509Extension ext = new X509Extension(true, CERT.GetExtensionValue(oid));

                if (oid == X509Extensions.BasicConstraints.Id)
                {

                    BasicConstraints bc = BasicConstraints.GetInstance(ext);
                    Print(extab + "Basic Constraints Extension");
                    Print(extab + "  Critical:" + critical.ToString());
                    Print(extab + "     CA:" + bc.IsCA().ToString());
                    if (bc.PathLenConstraint != null)
                        Print(extab + "     Path Length:" + bc.PathLenConstraint.ToString());
                    else
                        Print(extab + "     Path Length:Null");
                }
                else if (oid == X509Extensions.KeyUsage.Id)
                {

                    KeyUsage keyu = KeyUsage.GetInstance(ext);
                    Print(extab + "Key Usage Extension");
                    Print(extab + "  Critical:" + critical.ToString());
                    Print(extab + "     Key Usages:" + keyu.ToString());

                }
                else if (oid == X509Extensions.ExtendedKeyUsage.Id)
                {

                    ExtendedKeyUsage keyu = ExtendedKeyUsage.GetInstance(ext);



                    Print(extab + "Extended Key Usage Extension");
                    Print(extab + "  Critical:" + critical.ToString());
                    Print(extab + "     Extended Key Usages:");
                    foreach (DerObjectIdentifier id in keyu.GetAllUsages())
                        Print(extab + "         " + id.Id);
                }
                else if (oid == X509Extensions.SubjectKeyIdentifier.Id)
                {

                    SubjectKeyIdentifier keyu = SubjectKeyIdentifier.GetInstance(ext);
                    Print(extab + "Subject Key Identifier Extension");
                    Print(extab + "  Critical:" + critical.ToString());
                    Print(extab + "     Key Identifier:");
                    Print(keyu.GetKeyIdentifier(), extab + "         ");
                }
                else if (oid == X509Extensions.AuthorityKeyIdentifier.Id)
                {

                    AuthorityKeyIdentifier keyu = AuthorityKeyIdentifier.GetInstance(ext);
                    Print(extab + "Authority Key Identifier Extension");
                    Print(extab + "  Critical:" + critical.ToString());
                    Print(extab + "     Key Identifier:");
                    Print(keyu.GetKeyIdentifier(), extab + "         ");
                }
                else if (oid == X509Extensions.SubjectAlternativeName.Id)
                {
                    Asn1Object asn1Object = X509ExtensionUtilities.FromExtensionValue(ext.Value);

                    GeneralNames keyu = GeneralNames.GetInstance(asn1Object);

                    Print(extab + "Subject Alternative Name Extension");
                    Print(extab + "  Critical:" + critical.ToString());
                    Print(extab + "     General Names:");

                    foreach (GeneralName gen in keyu.GetNames())
                    {
                        string tagname = "Dns Name:";
                        if (gen.TagNo == GeneralName.EdiPartyName)
                            tagname = "Edi Party Name:";
                        else if (gen.TagNo == GeneralName.IPAddress)
                            tagname = "IP Address:";
                        else if (gen.TagNo == GeneralName.OtherName)
                            tagname = "Other Name:";
                        else if (gen.TagNo == GeneralName.RegisteredID)
                            tagname = "Registered ID:";
                        else if (gen.TagNo == GeneralName.Rfc822Name)
                            tagname = "Rfc822 Name:";
                        else if (gen.TagNo == GeneralName.UniformResourceIdentifier)
                            tagname = "URI:";
                        else if (gen.TagNo == GeneralName.X400Address)
                            tagname = "X400 Address:";
                        else if (gen.TagNo == GeneralName.DirectoryName)
                            tagname = "Directory Name:";

                        Print(extab + "         " + tagname + " " + gen.Name);
                    }
                }
                else if (oid == X509Extensions.IssuerAlternativeName.Id)
                {
                    Asn1Object asn1Object = X509ExtensionUtilities.FromExtensionValue(ext.Value);

                    GeneralNames keyu = GeneralNames.GetInstance(asn1Object);

                    Print(extab + "Issuer Alternative Name Extension");
                    Print(extab + "  Critical:" + critical.ToString());
                    Print(extab + "     General Names:");

                    foreach (GeneralName gen in keyu.GetNames())
                    {
                        string tagname = "Dns Name:";
                        if (gen.TagNo == GeneralName.EdiPartyName)
                            tagname = "Edi Party Name:";
                        else if (gen.TagNo == GeneralName.IPAddress)
                            tagname = "IP Address:";
                        else if (gen.TagNo == GeneralName.OtherName)
                            tagname = "Other Name:";
                        else if (gen.TagNo == GeneralName.RegisteredID)
                            tagname = "Registered ID:";
                        else if (gen.TagNo == GeneralName.Rfc822Name)
                            tagname = "Rfc822 Name:";
                        else if (gen.TagNo == GeneralName.UniformResourceIdentifier)
                            tagname = "URI:";
                        else if (gen.TagNo == GeneralName.X400Address)
                            tagname = "X400 Address:";
                        else if (gen.TagNo == GeneralName.DirectoryName)
                            tagname = "Directory Name:";

                        Print(extab + "         " + tagname + " " + gen.Name);
                    }
                }
                else if (oid == X509Extensions.AuthorityInfoAccess.Id)
                {

                    AuthorityInformationAccess keyu = AuthorityInformationAccess.GetInstance(ext);
                    Print(extab + "Authority Information Access Extension");
                    Print(extab + "  Critical:" + critical.ToString());
                    Print(extab + "     Access Descriptions:");
                    foreach (AccessDescription acc in keyu.GetAccessDescriptions())
                    {
                        Print(extab + "         Method:" + acc.AccessMethod.Id);
                        GeneralName gen = acc.AccessLocation;
                        string tagname = "Dns Name:";
                        if (gen.TagNo == GeneralName.EdiPartyName)
                            tagname = "Edi Party Name:";
                        else if (gen.TagNo == GeneralName.IPAddress)
                            tagname = "IP Address:";
                        else if (gen.TagNo == GeneralName.OtherName)
                            tagname = "Other Name:";
                        else if (gen.TagNo == GeneralName.RegisteredID)
                            tagname = "Registered ID:";
                        else if (gen.TagNo == GeneralName.Rfc822Name)
                            tagname = "Rfc822 Name:";
                        else if (gen.TagNo == GeneralName.UniformResourceIdentifier)
                            tagname = "URI:";
                        else if (gen.TagNo == GeneralName.X400Address)
                            tagname = "X400 Address:";
                        else if (gen.TagNo == GeneralName.DirectoryName)
                            tagname = "Directory Name:";
                        Print(extab + "         Access Location:" + tagname + "=" + gen.Name);
                    }

                }
                else if (oid == X509Extensions.SubjectInfoAccess.Id)
                {

                    AuthorityInformationAccess keyu = AuthorityInformationAccess.GetInstance(ext);
                    Print(extab + "Subject Information Access Extension");
                    Print(extab + "  Critical:" + critical.ToString());
                    Print(extab + "     Access Descriptions:");
                    foreach (AccessDescription acc in keyu.GetAccessDescriptions())
                    {
                        Print(extab + "         Method:" + acc.AccessMethod.Id);
                        GeneralName gen = acc.AccessLocation;
                        string tagname = "Dns Name:";
                        if (gen.TagNo == GeneralName.EdiPartyName)
                            tagname = "Edi Party Name:";
                        else if (gen.TagNo == GeneralName.IPAddress)
                            tagname = "IP Address:";
                        else if (gen.TagNo == GeneralName.OtherName)
                            tagname = "Other Name:";
                        else if (gen.TagNo == GeneralName.RegisteredID)
                            tagname = "Registered ID:";
                        else if (gen.TagNo == GeneralName.Rfc822Name)
                            tagname = "Rfc822 Name:";
                        else if (gen.TagNo == GeneralName.UniformResourceIdentifier)
                            tagname = "URI:";
                        else if (gen.TagNo == GeneralName.X400Address)
                            tagname = "X400 Address:";
                        else if (gen.TagNo == GeneralName.DirectoryName)
                            tagname = "Directory Name:";
                        Print(extab + "         Access Location:" + tagname + "=" + gen.Name);
                    }

                }
                else if (oid == X509Extensions.CrlDistributionPoints.Id)
                {
                    Asn1Object asn1Object = X509ExtensionUtilities.FromExtensionValue(ext.Value);
                    CrlDistPoint keyu = CrlDistPoint.GetInstance(asn1Object);


                    Print(extab + "Crl Distribution Points Extension");
                    Print(extab + "  Critical:" + critical.ToString());
                    Print(extab + "     Distribution Points:");
                    foreach (DistributionPoint acc in keyu.GetDistributionPoints())
                    {
                        if (acc.Reasons != null)
                            Print(extab + "         Reasons:" + acc.Reasons.GetString());
                        else Print(extab + "         Reasons:Null");

                        if (acc.CrlIssuer != null)
                        {
                            Print(extab + "         Crl Issuer:");
                            foreach (GeneralName gen in acc.CrlIssuer.GetNames())
                            {

                                string tagname = "Dns Name:";
                                if (gen.TagNo == GeneralName.EdiPartyName)
                                    tagname = "Edi Party Name:";
                                else if (gen.TagNo == GeneralName.IPAddress)
                                    tagname = "IP Address:";
                                else if (gen.TagNo == GeneralName.OtherName)
                                    tagname = "Other Name:";
                                else if (gen.TagNo == GeneralName.RegisteredID)
                                    tagname = "Registered ID:";
                                else if (gen.TagNo == GeneralName.Rfc822Name)
                                    tagname = "Rfc822 Name:";
                                else if (gen.TagNo == GeneralName.UniformResourceIdentifier)
                                    tagname = "URI:";
                                else if (gen.TagNo == GeneralName.X400Address)
                                    tagname = "X400 Address:";
                                else if (gen.TagNo == GeneralName.DirectoryName)
                                    tagname = "Directory Name:";
                                Print(extab + "            " + tagname + ": " + gen.Name);
                            }

                        }
                        else Print(extab + "         Crl Issuer:Null");
                        Print(extab + "         Distribution Point Name:");
                        if (acc.DistributionPointName.PointType == DistributionPointName.FullName)
                        {
                            GeneralNames sgen = GeneralNames.GetInstance(acc.DistributionPointName.Name);
                            foreach (GeneralName gen in sgen.GetNames())
                            {
                                string tagname = "Dns Name:";
                                if (gen.TagNo == GeneralName.EdiPartyName)
                                    tagname = "Edi Party Name:";
                                else if (gen.TagNo == GeneralName.IPAddress)
                                    tagname = "IP Address:";
                                else if (gen.TagNo == GeneralName.OtherName)
                                    tagname = "Other Name:";
                                else if (gen.TagNo == GeneralName.RegisteredID)
                                    tagname = "Registered ID:";
                                else if (gen.TagNo == GeneralName.Rfc822Name)
                                    tagname = "Rfc822 Name:";
                                else if (gen.TagNo == GeneralName.UniformResourceIdentifier)
                                    tagname = "URI:";
                                else if (gen.TagNo == GeneralName.X400Address)
                                    tagname = "X400 Address:";
                                else if (gen.TagNo == GeneralName.DirectoryName)
                                    tagname = "Directory Name:";
                                Print(extab + "                " + tagname + " " + gen.Name);
                            }
                        }
                        else Print(extab + "                Not Supported by OCT");


                    }
                }
                
            }
            critical = false;
            foreach (string oid in CERT.GetNonCriticalExtensionOids())
            {
                Print(" ");
      
                X509Extension ext = new X509Extension(true, CERT.GetExtensionValue(oid));
         
                if (oid== X509Extensions.BasicConstraints.Id)
                {
                 
                    BasicConstraints bc = BasicConstraints.GetInstance(ext);
                    Print(extab + "Basic Constraints Extension");
                    Print(extab + "  Critical:" + critical.ToString());
                    Print(extab + "     CA:" + bc.IsCA().ToString());
                    if(bc.PathLenConstraint != null)
                    Print(extab + "     Path Length:" + bc.PathLenConstraint.ToString());
                    else
                    Print(extab + "     Path Length:Null");
                }
                else if (oid == X509Extensions.KeyUsage.Id)
                {
                  
                    KeyUsage keyu = KeyUsage.GetInstance(ext);
                    Print(extab + "Key Usage Extension");
                    Print(extab + "  Critical:" + critical.ToString());
                    Print(extab + "     Key Usages:" +keyu.ToString());
                    
                }
                else if (oid == X509Extensions.ExtendedKeyUsage.Id)
                {
           
                    ExtendedKeyUsage keyu = ExtendedKeyUsage.GetInstance(ext);

                   
                 
                    Print(extab + "Extended Key Usage Extension");
                    Print(extab + "  Critical:" + critical.ToString());
                    Print(extab + "     Extended Key Usages:");
                    foreach (DerObjectIdentifier id in keyu.GetAllUsages())
                        Print(extab + "         " + id.Id);
                }
                else if (oid == X509Extensions.SubjectKeyIdentifier.Id)
                {

                    SubjectKeyIdentifier keyu = SubjectKeyIdentifier.GetInstance(ext);
                    Print(extab + "Subject Key Identifier Extension");
                    Print(extab + "  Critical:" + critical.ToString());
                    Print(extab + "     Key Identifier:");
                    Print(keyu.GetKeyIdentifier(),extab + "         ");
                }
                else if (oid == X509Extensions.AuthorityKeyIdentifier.Id)
                {

                    AuthorityKeyIdentifier keyu = AuthorityKeyIdentifier.GetInstance(ext);
                    Print(extab + "Authority Key Identifier Extension");
                    Print(extab + "  Critical:" + critical.ToString());
                    Print(extab + "     Key Identifier:");
                    Print(keyu.GetKeyIdentifier(), extab + "         ");
                }
                else if (oid == X509Extensions.SubjectAlternativeName.Id)
                {
                    Asn1Object asn1Object = X509ExtensionUtilities.FromExtensionValue(ext.Value);

                    GeneralNames keyu = GeneralNames.GetInstance(asn1Object);
             
                    Print(extab + "Subject Alternative Name Extension");
                    Print(extab + "  Critical:" + critical.ToString());
                    Print(extab + "     General Names:");
               
                    foreach(GeneralName gen in keyu.GetNames())
                    {
                             string tagname = "Dns Name:";
                             if (gen.TagNo == GeneralName.EdiPartyName)
                                 tagname = "Edi Party Name:";
                             else if (gen.TagNo == GeneralName.IPAddress)
                                 tagname = "IP Address:";
                             else if (gen.TagNo == GeneralName.OtherName)
                                 tagname = "Other Name:";
                             else if (gen.TagNo == GeneralName.RegisteredID)
                                 tagname = "Registered ID:";
                             else if (gen.TagNo == GeneralName.Rfc822Name)
                                 tagname = "Rfc822 Name:";
                             else if (gen.TagNo == GeneralName.UniformResourceIdentifier)
                                 tagname = "URI:";
                             else if (gen.TagNo == GeneralName.X400Address)
                                 tagname = "X400 Address:";
                             else if (gen.TagNo == GeneralName.DirectoryName)
                                 tagname = "Directory Name:";
                       
                            Print(extab + "         "+tagname+" "+gen.Name);
                    }
                }
                else if (oid == X509Extensions.IssuerAlternativeName.Id)
                {
                    Asn1Object asn1Object = X509ExtensionUtilities.FromExtensionValue(ext.Value);

                    GeneralNames keyu = GeneralNames.GetInstance(asn1Object);

                    Print(extab + "Issuer Alternative Name Extension");
                    Print(extab + "  Critical:" + critical.ToString());
                    Print(extab + "     General Names:");

                    foreach (GeneralName gen in keyu.GetNames())
                    {
                        string tagname = "Dns Name:";
                        if (gen.TagNo == GeneralName.EdiPartyName)
                            tagname = "Edi Party Name:";
                        else if (gen.TagNo == GeneralName.IPAddress)
                            tagname = "IP Address:";
                        else if (gen.TagNo == GeneralName.OtherName)
                            tagname = "Other Name:";
                        else if (gen.TagNo == GeneralName.RegisteredID)
                            tagname = "Registered ID:";
                        else if (gen.TagNo == GeneralName.Rfc822Name)
                            tagname = "Rfc822 Name:";
                        else if (gen.TagNo == GeneralName.UniformResourceIdentifier)
                            tagname = "URI:";
                        else if (gen.TagNo == GeneralName.X400Address)
                            tagname = "X400 Address:";
                        else if (gen.TagNo == GeneralName.DirectoryName)
                            tagname = "Directory Name:";

                        Print(extab + "         " + tagname + " " + gen.Name);
                    }
                }
                else if (oid == X509Extensions.AuthorityInfoAccess.Id)
                {

                    AuthorityInformationAccess keyu = AuthorityInformationAccess.GetInstance(ext);
                    Print(extab + "Authority Information Access Extension");
                    Print(extab + "  Critical:" + critical.ToString());
                    Print(extab + "     Access Descriptions:");
                    foreach (AccessDescription acc in keyu.GetAccessDescriptions())
                    {
                        Print(extab + "         Method:"+acc.AccessMethod.Id);
                        GeneralName gen = acc.AccessLocation;
                        string tagname = "Dns Name:";
                        if (gen.TagNo == GeneralName.EdiPartyName)
                            tagname = "Edi Party Name:";
                        else if (gen.TagNo == GeneralName.IPAddress)
                            tagname = "IP Address:";
                        else if (gen.TagNo == GeneralName.OtherName)
                            tagname = "Other Name:";
                        else if (gen.TagNo == GeneralName.RegisteredID)
                            tagname = "Registered ID:";
                        else if (gen.TagNo == GeneralName.Rfc822Name)
                            tagname = "Rfc822 Name:";
                        else if (gen.TagNo == GeneralName.UniformResourceIdentifier)
                            tagname = "URI:";
                        else if (gen.TagNo == GeneralName.X400Address)
                            tagname = "X400 Address:";
                        else if (gen.TagNo == GeneralName.DirectoryName)
                            tagname = "Directory Name:";
                        Print(extab + "         Access Location:" + tagname +"="+gen.Name);
                    }

                }
                else if (oid == X509Extensions.SubjectInfoAccess.Id)
                {
                   
                    AuthorityInformationAccess keyu = AuthorityInformationAccess.GetInstance(ext);
                    Print(extab + "Subject Information Access Extension");
                    Print(extab + "  Critical:" + critical.ToString());
                    Print(extab + "     Access Descriptions:");
                    foreach (AccessDescription acc in keyu.GetAccessDescriptions())
                    {
                        Print(extab + "         Method:" + acc.AccessMethod.Id);
                        GeneralName gen = acc.AccessLocation;
                        string tagname = "Dns Name:";
                        if (gen.TagNo == GeneralName.EdiPartyName)
                            tagname = "Edi Party Name:";
                        else if (gen.TagNo == GeneralName.IPAddress)
                            tagname = "IP Address:";
                        else if (gen.TagNo == GeneralName.OtherName)
                            tagname = "Other Name:";
                        else if (gen.TagNo == GeneralName.RegisteredID)
                            tagname = "Registered ID:";
                        else if (gen.TagNo == GeneralName.Rfc822Name)
                            tagname = "Rfc822 Name:";
                        else if (gen.TagNo == GeneralName.UniformResourceIdentifier)
                            tagname = "URI:";
                        else if (gen.TagNo == GeneralName.X400Address)
                            tagname = "X400 Address:";
                        else if (gen.TagNo == GeneralName.DirectoryName)
                            tagname = "Directory Name:";
                        Print(extab + "         Access Location:" + tagname + "=" + gen.Name);
                    }

                }
                else if (oid == X509Extensions.CrlDistributionPoints.Id)
                {
                    Asn1Object asn1Object = X509ExtensionUtilities.FromExtensionValue(ext.Value);
                    CrlDistPoint keyu = CrlDistPoint.GetInstance(asn1Object);
                   

                    Print(extab + "Crl Distribution Points Extension");
                    Print(extab + "  Critical:" + critical.ToString());
                    Print(extab + "     Distribution Points:");
                  foreach (DistributionPoint acc in keyu.GetDistributionPoints())
                    {
                      if(acc.Reasons != null)
                        Print(extab + "         Reasons:" + acc.Reasons.GetString());
                      else Print(extab + "         Reasons:Null");
                     
                        if (acc.CrlIssuer != null)
                        {
                               Print(extab + "         Crl Issuer:");
                            foreach (GeneralName gen in acc.CrlIssuer.GetNames())
                            {

                                string tagname = "Dns Name:";
                                if (gen.TagNo == GeneralName.EdiPartyName)
                                    tagname = "Edi Party Name:";
                                else if (gen.TagNo == GeneralName.IPAddress)
                                    tagname = "IP Address:";
                                else if (gen.TagNo == GeneralName.OtherName)
                                    tagname = "Other Name:";
                                else if (gen.TagNo == GeneralName.RegisteredID)
                                    tagname = "Registered ID:";
                                else if (gen.TagNo == GeneralName.Rfc822Name)
                                    tagname = "Rfc822 Name:";
                                else if (gen.TagNo == GeneralName.UniformResourceIdentifier)
                                    tagname = "URI:";
                                else if (gen.TagNo == GeneralName.X400Address)
                                    tagname = "X400 Address:";
                                else if (gen.TagNo == GeneralName.DirectoryName)
                                    tagname = "Directory Name:";
                                Print(extab + "            " + tagname + ": " + gen.Name);
                            }

                        }
                        else Print(extab + "         Crl Issuer:Null");
                        Print(extab + "         Distribution Point Name:");
                        if (acc.DistributionPointName.PointType == DistributionPointName.FullName)
                        {
                            GeneralNames sgen = GeneralNames.GetInstance(acc.DistributionPointName.Name);
                            foreach (GeneralName gen in sgen.GetNames())
                            {
                                string tagname = "Dns Name:";
                                if (gen.TagNo == GeneralName.EdiPartyName)
                                    tagname = "Edi Party Name:";
                                else if (gen.TagNo == GeneralName.IPAddress)
                                    tagname = "IP Address:";
                                else if (gen.TagNo == GeneralName.OtherName)
                                    tagname = "Other Name:";
                                else if (gen.TagNo == GeneralName.RegisteredID)
                                    tagname = "Registered ID:";
                                else if (gen.TagNo == GeneralName.Rfc822Name)
                                    tagname = "Rfc822 Name:";
                                else if (gen.TagNo == GeneralName.UniformResourceIdentifier)
                                    tagname = "URI:";
                                else if (gen.TagNo == GeneralName.X400Address)
                                    tagname = "X400 Address:";
                                else if (gen.TagNo == GeneralName.DirectoryName)
                                    tagname = "Directory Name:";
                                Print(extab + "                " + tagname + " " + gen.Name);
                            }
                        }
                        else Print(extab + "                Not Supported by OCT");
                     

                  }
                }
              

            }
            // Signature
            Print("     Signature Algorithm: "+cer.SignatureAlgorithm.FriendlyName +" "+(CERT.GetSignature().Length * 8) +" bit");
            Print(CERT.GetSignature(), "        ");
            
            Print("     SHA1 Fingerprint : " );
            Print(Sha1(CERT.GetEncoded()), "        ");
            Print("     SHA224 Fingerprint : ");
            Print(Sha224(CERT.GetEncoded()), "        ");
            Print("     SHA256 Fingerprint : ");
            Print(Sha256(CERT.GetEncoded()), "        ");
            Print("     SHA384 Fingerprint : ");
            Print(Sha384(CERT.GetEncoded()), "        ");
            Print("     SHA512 Fingerprint : ");
            Print(Sha512(CERT.GetEncoded()), "        ");
            Print("     MD5 Fingerprint : ");
            Print(MD5(CERT.GetEncoded()), "        ");

            Print("Issuer Base64:" + Convert.ToBase64String(CERT.IssuerDN.GetDerEncoded()));
            Print("Subject Base64:" + Convert.ToBase64String(CERT.SubjectDN.GetDerEncoded()));
            Print("Serial Base64:" + Convert.ToBase64String(CERT.SerialNumber.ToByteArray()));
          if(outputfile == "stdout")
            Console.Read();
          else
            str.Close();
        }
        static byte[] Sha256(byte[] dat)
        {
            Sha256Digest digester = new Sha256Digest();
            byte[] retValue = new byte[digester.GetDigestSize()];
            digester.BlockUpdate(dat,0,dat.Length);
            digester.DoFinal(retValue, 0);
            return retValue;
        }
        static byte[] Sha512(byte[] dat)
        {
            Sha512Digest digester = new Sha512Digest();
            byte[] retValue = new byte[digester.GetDigestSize()];
            digester.BlockUpdate(dat, 0, dat.Length);
            digester.DoFinal(retValue, 0);
            return retValue;
        }
        static byte[] Sha1(byte[] dat)
        {
            Sha1Digest digester = new Sha1Digest();
            byte[] retValue = new byte[digester.GetDigestSize()];
            digester.BlockUpdate(dat, 0, dat.Length);
            digester.DoFinal(retValue, 0);
            return retValue;
        }
        static byte[] Sha224(byte[] dat)
        {
            Sha224Digest digester = new Sha224Digest();
            byte[] retValue = new byte[digester.GetDigestSize()];
            digester.BlockUpdate(dat, 0, dat.Length);
            digester.DoFinal(retValue, 0);
            return retValue;
        }
        static byte[] Sha384(byte[] dat)
        {
            Sha384Digest digester = new Sha384Digest();
            byte[] retValue = new byte[digester.GetDigestSize()];
            digester.BlockUpdate(dat, 0, dat.Length);
            digester.DoFinal(retValue, 0);
            return retValue;
        }
        static byte[] MD5(byte[] dat)
        {
            MD5Digest digester = new MD5Digest();
            byte[] retValue = new byte[digester.GetDigestSize()];
            digester.BlockUpdate(dat, 0, dat.Length);
            digester.DoFinal(retValue, 0);
            return retValue;
        }
    }
}
