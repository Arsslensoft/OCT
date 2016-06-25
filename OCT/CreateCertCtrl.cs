using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;

using Al.Security.CA;
using System.Threading;
using OpenSSL.X509;
using OpenSSL.Crypto;
using OpenSSL.Core;

namespace OCT
{
    public partial class CreateCertCtrl : UserControl
    {
        public CreateCertCtrl()
        {
            InitializeComponent();
            nameFrm1.Init();
        }
        string filename;
        delegate void ExtWork();

        void ExtensionsWork()
        {
            if (!InvokeRequired)
            {
                List<Al.Security.CA.X509Ext> Extensions = new List<X509Ext>();
                bool critical = false;
                bool enabled = false;
                // Key Identifiers
                bool skid = false;
                bool akid = false;
                extentionsfrm1.KeyIDWork(ref skid, ref akid, ref critical);
                SubjectKeyIdentifierExt skidd = new SubjectKeyIdentifierExt();
                skidd.Critical = critical;
                    AuthorityKeyIdentifierExt akidd = new AuthorityKeyIdentifierExt();
                akidd.Critical = critical;
                if (skid)
                    Extensions.Add(skidd);
                if (akid)
                    Extensions.Add(akidd);            
                
                // CUSTOM
                // Basic Constraints
                BasicConstraintsExt bc = null;
                extentionsfrm1.BasicConstraintWork(ref bc, ref critical);
                bc.Critical = critical;
                if (bc != null)
                    Extensions.Add(bc);
                else
                    throw new ArgumentException("Basic Constraints is required");
                //  Key Usage
                List<X509KeyUsages> keyusage = new List<X509KeyUsages>();

                extentionsfrm1.KeyUsageWork(ref keyusage, ref critical);
                if (keyusage != null)
                {
                    X509KeyUsageExt k = new X509KeyUsageExt(keyusage);
                    k.Critical = critical;
                    Extensions.Add(k);
                }
                else
                    throw new ArgumentException("No Key Usage Option was defined");
                // Extended Key Usage
               List<X509ExtendedKeyUsages> keypid = null;
                List<string> customoid=null;
                extentionsfrm1.ExtendedKeyUsageWork(ref keypid, ref customoid, ref critical);

                if (keypid != null)
                {
                    X509ExtendedKeyUsageExt kext = null;
                    if (customoid != null)
                        kext = new X509ExtendedKeyUsageExt(keypid, customoid);
                    else
                        kext = new X509ExtendedKeyUsageExt(keypid);

                    kext.Critical = critical;

                    Extensions.Add(kext);
                }
           
                // Name Constraints
                List<GlobalName> Permitted = null;
                List<GlobalName> Excluded = null;
                enabled = false;
                extentionsfrm1.NameConstraintsWork(ref enabled, ref Permitted, ref Excluded, ref critical);
                if (enabled)
                {
                    List<NameConstraintsExt> nexts = new List<NameConstraintsExt>();
                    if(Permitted != null)
                    {
                        foreach (GlobalName g in Permitted)
                        {
                            NameConstraintsExt nce = new NameConstraintsExt(g, true);
                          //  nce.Critical = critical;
                            nexts.Add(nce);
                        }
                    }
                    if (Excluded != null)
                    {
                        foreach (GlobalName g in Excluded)
                        {
                            NameConstraintsExt nce = new NameConstraintsExt(g, false);
                           // nce.Critical = critical;
                            nexts.Add(nce);
                        }
                    }
                    NameConstraintsExt ncef = new NameConstraintsExt(nexts);
                    ncef.Critical = critical;
                    Extensions.Add(ncef);
                }
                //  Authority Access Informations
                List<AuthorityInfoAccessExt> authseq = null;
                enabled = false;
                extentionsfrm1.AuthorityInfoWork(ref enabled, ref critical, ref authseq);
                if (enabled && authseq != null)
                {
                AuthorityInfoAccessExt ext = new AuthorityInfoAccessExt(authseq);
                        ext.Critical = critical;
                      Extensions.Add(ext);
                    
                }
                // Policy Settings
                bool polen = false;
                enabled = false;
                int inhibmap = 0;
                int explicitmap = 0;
                int inhib = 0;
                extentionsfrm1.PolicySettingsWork(ref polen, ref enabled, ref critical, ref inhibmap, ref explicitmap, ref inhib);
                if (polen)
                {
                    PolicyConstraintsExt pc = new PolicyConstraintsExt((int)explicitmap, (int)inhibmap);
                    pc.Critical = critical;
                    Extensions.Add(pc);
                //   certificateGenerator.AddExtension(X509Extensions.PolicyConstraints, critical, new DerOctetSequence(new byte[] { 128, 1, explicitmap, 129, 1, inhibmap }));
                }
                if (enabled)
                {
                    InhibAnyPolicyConstraintsExt inh = new InhibAnyPolicyConstraintsExt(inhib);
                    inh.Critical = critical;
                    Extensions.Add(inh);
                }
           
                // Subject Alt Names
                enabled = false;
                List<GlobalName> names = null;
                extentionsfrm1.SubjectAltWork(ref enabled, ref critical, ref names);
                if (names != null && enabled)
                {
                    SubjectAltNameExt saltext = new SubjectAltNameExt(names);
                    saltext.Critical = critical;
                    Extensions.Add(saltext);
                }
                // Issuer Alt Names
                enabled = false;
                names = null;
                extentionsfrm1.IssuerAltWork(ref enabled, ref critical, ref names);
                if (names != null && enabled)
                {
                    if (names.Count > 0)
                    {
                        IssuerAltNameExt saltext = new IssuerAltNameExt(names);
                        saltext.Critical = critical;
                        Extensions.Add(saltext);
                    }
               
                }
                // Crl/Issuer Distribution Points

                polen = false;
                enabled = false;
                CrlDistributionPointsExt crlext = null;
                IssuingDistributionPointsExt issuerext=null;
                extentionsfrm1.CrlIssuerDPWork(ref polen, ref enabled, ref crlext, ref issuerext, ref critical);
                if (polen && crlext != null)
                {
                    crlext.Critical = critical;
                    Extensions.Add(crlext);
                }
                if (enabled && issuerext != null)
                {
                    issuerext.Critical = critical;
                    Extensions.Add(issuerext);
                }


                // Policy Information
                enabled = false;
                CertificatePoliciesExt pols = null;
                extentionsfrm1.PolicyWork(ref enabled, ref critical, ref pols);
                if (enabled && pols != null)
                {
                    pols.Critical = critical;
                    Extensions.Add(pols);
                }
                // Netscape Informations
                enabled = false;
                polen = false;
                string nsurl = "";
                string nscomment = "";
                string nspol = "";
                string nscarevurl = "";
                string nsrevurl = "";
                string sslname = "";
                extentionsfrm1.NetscapeWork(ref critical, ref enabled, ref nscomment, ref nsurl, ref nspol,ref nscarevurl,ref nsrevurl,ref sslname);

                if (enabled)
                {
                    List<NetscapeKeyUsage> nk = new List<NetscapeKeyUsage>();

                    foreach (X509ExtendedKeyUsages k in keypid)
                    {
                        if (k == X509ExtendedKeyUsages.clientAuth)
                            nk.Add(NetscapeKeyUsage.client);
                        else if (k == X509ExtendedKeyUsages.codeSigning)
                            nk.Add(NetscapeKeyUsage.objsign);
                   
                        else if (k == X509ExtendedKeyUsages.emailProtection)
                            nk.Add(NetscapeKeyUsage.email);
                        else if (k == X509ExtendedKeyUsages.serverAuth)
                            nk.Add(NetscapeKeyUsage.server);
                        
                        if (bc.Value.Contains("TRUE"))
                        {
                            if(k == X509ExtendedKeyUsages.serverAuth || k == X509ExtendedKeyUsages.clientAuth)
                                  nk.Add(NetscapeKeyUsage.sslCA);
                        
                            if(k == X509ExtendedKeyUsages.emailProtection)
                               nk.Add(NetscapeKeyUsage.emailCA);
                         
                            if(k == X509ExtendedKeyUsages.codeSigning)
                               nk.Add(NetscapeKeyUsage.objCA);
                            
                        }
                    }
                    NsKeyUsageExt nsk = new NsKeyUsageExt(nk);
                    nsk.Critical = critical;
                    Extensions.Add(nsk);
                }
                if (!string.IsNullOrEmpty(nscomment))
                {
                    NsCommentExt nsext = new NsCommentExt(nscomment);
                    nsext.Critical = critical;
                    Extensions.Add(nsext);

                }
                if (!string.IsNullOrEmpty(nsurl))
                {
                    NsUrlExt nsext = new NsUrlExt(nsurl);
                    nsext.Critical = critical;
                    Extensions.Add(nsext);

                }
                if (!string.IsNullOrEmpty(nscarevurl))
                {
                    nsCaRevocationUrlExt nsext = new nsCaRevocationUrlExt(nscarevurl);
                    nsext.Critical = critical;
                    Extensions.Add(nsext);

                }
                if (!string.IsNullOrEmpty(nspol))
                {
                    nsCaPolicyUrlExt nsext = new nsCaPolicyUrlExt(nspol);
                    nsext.Critical = critical;
                    Extensions.Add(nsext);

                }
                if (!string.IsNullOrEmpty(nsrevurl))
                {
                    nsRevocationUrlExt nsext = new nsRevocationUrlExt(nsrevurl);
                    nsext.Critical = critical;
                    Extensions.Add(nsext);

                }
                if (!string.IsNullOrEmpty(sslname))
                {
                    nsSslServerNameExt nsext = new nsSslServerNameExt(sslname);
                    nsext.Critical = critical;
                    Extensions.Add(nsext);

                }
                //  17 : Custom Extensions
                List<CustomExtension> custom = extentionsfrm1.GetCustoms();
                if (custom.Count > 0)
                {
                    foreach (CustomExtension c in custom)
                            Extensions.Add(c);
                        
                }

                X509ExtensionManager.Export(Application.StartupPath + @"\ext.cfg", Extensions);
                SectionManager.Clean();
                MainForm.mf.configbox.Text = File.ReadAllText(Application.StartupPath + @"\ext.cfg");
            
            }
            else
            this.Invoke(new ExtWork(ExtensionsWork));
            
        }
        CertExportFrm cfrm;
        delegate void InvokeTab(SuperTabItem tab);
        void SelectTab(SuperTabItem tab)
        {
            if (InvokeRequired)
                this.Invoke(new InvokeTab(SelectTab), tab);
            else
                superTabControl2.SelectedTab = tab;
        }
        void DoWork()
        {
            try
            {
                // Step 1
                if (nameFrm1.GetNames())
                {
                    X509Name subject = new X509Name();

                    // TODO FIX NAME FRM
                    int progress = 0;
                    int cur = 0;
                    foreach (KeyValuePair<string, string> keyp in nameFrm1.bind.Vals)
                    {
                        progress = (int)((double)((cur / nameFrm1.bind.Vals.Count) * 100));
                        backgroundWorker1.ReportProgress(progress, 1);
                       
                        subject.AddEntryByName(keyp.Key.ToUpper(), keyp.Value);
                        cur++;
                    }



                    backgroundWorker1.ReportProgress(100, 1);

                    // Step 2
                    progress = 0;
                    cur = 0;

                    if (keyGenerationFrm1.GenerateKey())
                    {

                        Al.Security.CA.KeyGenerationBind keyb = keyGenerationFrm1.bind;
                        CryptoKey KeyPair = keyb.KeyPair;

                        //               var serialNumber =
                        //BigIntegers.CreateRandomInRange(
                        //    BigInteger.One, BigInteger.ValueOf(Int64.MaxValue), keyb.SRandom);
                        // CUTOM SERIAL
                        SimpleSerialNumber serial = null;
                        int serialn = 0;
                        if (keyGenerationFrm1.serialnumber.Value != null && keyGenerationFrm1.serialnumber.Value != 0)
                            serial = new SimpleSerialNumber(keyGenerationFrm1.serialnumber.Value);


                        backgroundWorker1.ReportProgress(100, 2);

                        // STEP 3
                        if (!configbox.Checked)
                          ExtensionsWork();
                        Configuration config = new Configuration(Application.StartupPath + @"\ext.cfg");
                        backgroundWorker1.ReportProgress(100, 3);
                        DateTime notbe = nameFrm1.notbefore.Value;
                        TimeSpan vali = nameFrm1.notafter.Value.Subtract(notbe);
                        // STEP 4 SAVE
                        X509CertificateAuthority ca = null;
                        if (serial != null)
                            ca = X509CertificateAuthority.SelfSigned(config, serial,
                          KeyPair, keyb.SignatureAlgorithm, subject, notbe,
                         vali);
                        else
                            ca = X509CertificateAuthority.SelfSigned(config, new SimpleSerialNumber(),
            KeyPair, keyb.SignatureAlgorithm, subject, notbe,
           vali);


                        //  cfrm = new CertExportFrm();
                        cfrm.certificate = ca.Certificate;
                        cfrm.Key = KeyPair;

                        backgroundWorker1.ReportProgress(100, 4);
                    }
                    else SelectTab( superTabItem5);


                }
                else SelectTab(superTabItem4);
                
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void buttonItem1_Click(object sender, EventArgs e)
        {
            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "*.cer|*.cer|*.crt|*.crt";
            //if (sfd.ShowDialog() == DialogResult.OK)
            //{
            //    filename = sfd.FileName;
            if (!backgroundWorker1.IsBusy)
            {
                cfrm = new CertExportFrm();
                backgroundWorker1.RunWorkerAsync();
            }
           // }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
          
         DoWork();
      
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int step = (int)e.UserState;
            int progress = e.ProgressPercentage;

            switch (step)
            {
                case 1:
                    stepItem1.Value = progress;
                    break;
                case 2:
                         stepItem2.Value = progress;
                    break;
                case 3:
                    stepItem3.Value = progress;
                    break;
                default:
                    stepItem4.Value = progress;
                    break;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            stepItem4.Value = 100;
           // MessageBoxEx.Show("Certificate Generation Complete ", "Certificate", MessageBoxButtons.OK, MessageBoxIcon.Information);
         if(cfrm.certificate != null)
            cfrm.ShowDialog();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            try
            {
                SectionManager.Clean();
                SectionManager.FixedSectionValues.Clear();
                extentionsfrm1.ResetAll();
            }
            catch (Exception ex)
            {
                Log.ShowInfo(ex.Message, "RESET GENERATOR");
            }
        }
    }
}
