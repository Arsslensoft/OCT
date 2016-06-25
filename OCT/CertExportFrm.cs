using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;
using OpenSSL.Crypto;
using OpenSSL.Core;
using OpenSSL.X509;
using DevComponents.Editors;


namespace OCT
{
    public partial class CertExportFrm : DevComponents.DotNetBar.Metro.MetroForm
    {

        public CertExportFrm()
        {
            InitializeComponent();
        }
        public OpenSSL.X509.X509Certificate certificate;
        public CryptoKey Key;
        public string FileName;
      
        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                superValidator1.SetValidator1(textBoxX1, null);
                superValidator1.SetValidator1(c, null);
          if (pem.Checked)
                {
             //       superValidator1.SetValidator1(textBoxX1, new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Password is required for Key Encryption"));
                    superValidator1.SetValidator1(c, new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Cipher is required for Key Encryption"));

                }
          //else if(pfx.Checked)
          //    superValidator1.SetValidator1(textBoxX1, new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Password is required for Key Encryption"));

                      if (superValidator1.Validate())
                      {
                          superValidator1.SetValidator1(textBoxX1, null);
                          superValidator1.SetValidator1(c, null);
                          string devpath = "";
                          if (MainForm.cai != null)
                              if (MainForm.cai.DevPath != null)
                                  devpath = MainForm.cai.DevPath;
                          SaveFileDialog sfd = new SaveFileDialog();
                          sfd.Filter = "Origisign Temp Certificate|*.ogtc";
                          if(devpath != "")
                          sfd.InitialDirectory = devpath;

                          if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                          {
                              FileName = sfd.FileName;
                              //if (pkcs7.Checked)
                              //    File.WriteAllBytes(Path.ChangeExtension(FileName, ".p7b"), certificate.Export(System.Security.Cryptography.X509Certificates.X509ContentType.Pkcs7));


                              if (pfx.Checked)
                              {
                                  using (var bio = BIO.File(Path.ChangeExtension(FileName, ".pfx"), "w"))
                                  {
                                      OpenSSL.Core.Stack<X509Certificate> caStack = new OpenSSL.Core.Stack<X509Certificate>();
                                      //    caStack.Add(certificate);

                                      using (var pfx12 = new PKCS12(textBoxX1.Text, Key, certificate, caStack))
                                          pfx12.Write(bio);

                                  }
                              }
                              if (cert.Checked)
                              {
                                  using (var bio = BIO.File(Path.ChangeExtension(FileName, ".cer"), "w"))
                                      certificate.Write(bio);

                              }
                              if (pem.Checked)
                              {
                                  ComboItem ci = (ComboItem)c.SelectedItem;
                                 
                                  using (var bio = BIO.File(Path.ChangeExtension(FileName, ".key"), "w"))
                                      Key.WritePrivateKey(bio, (Cipher)ci.Value, textBoxX1.Text);
                              }




                              this.Close();
                          }
                      }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
     
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Security.Cryptography.X509Certificates.X509Certificate2 cert = new System.Security.Cryptography.X509Certificates.X509Certificate2(certificate.DER);
                System.Security.Cryptography.X509Certificates.X509Certificate2UI.DisplayCertificate(cert, this.Handle);
            }
            catch
            {

            }
        }
        void LoadCiphers()
        {
            try
            {
                foreach (string s in Cipher.AllNamesSorted)
                {
                    ComboItem it = new ComboItem();
                    it.Text = s.ToUpper();
                    it.Value = Cipher.CreateByName(s);
                    c.Items.Add(it);
                }
            }
            catch
            {

            }
        }
        private void CertExportFrm_Load(object sender, EventArgs e)
        {
            LoadCiphers();
        }
    }
}