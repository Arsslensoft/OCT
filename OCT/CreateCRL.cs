using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

using DevComponents.DotNetBar;
using Al.Security.Security;
using Al.Security.Asn1.X509;
using Al.Security.X509;
using Al.Security.X509.Extension;
using System.Collections;

namespace OCT
{
    public partial class CreateCRL : UserControl
    {
        public CreateCRL()
        {
            InitializeComponent();
        
        }

        X509Crl crldata = null;
        void DoWork()
        {
            try
            {

   
               
                Al.Security.X509.X509V2CrlGenerator crl = new Al.Security.X509.X509V2CrlGenerator();
                X509Certificate cert = DotNetUtilities.FromX509Certificate((System.Security.Cryptography.X509Certificates.X509Certificate)CACert);
                backgroundWorker1.ReportProgress(100, 1);
         
                crl.SetIssuerDN(cert.SubjectDN);
                crl.SetNextUpdate(crlControl1.nextupdtime.Value);
                crl.SetThisUpdate(crlControl1.updtime.Value);
                crl.SetSignatureAlgorithm(cert.SigAlgOid);
                if (crlControl1.CRL != null)
                    crl.AddCrl(crlControl1.CRL);
                crl.AddExtension(X509Extensions.AuthorityKeyIdentifier,
                  false, new AuthorityKeyIdentifierStructure(cert));
                List<CrlEntryItem> certs = crlControl1.GetCertificateList();
                foreach (CrlEntryItem ent in certs)
                    crl.AddCrlEntry(ent.Certificate.SerialNumber, ent.RevocationTime, ent.Reason);

             crldata =   crl.Generate(CP);
             

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        delegate void InvokeTab(SuperTabItem tab);
        void SelectTab(SuperTabItem tab)
        {
            if (InvokeRequired)
                this.Invoke(new InvokeTab(SelectTab), tab);
            else
                superTabControl2.SelectedTab = tab;
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
                    stepItem6.Value = progress;
                    break;
                default:
                    stepItem3.Value = progress;
                    break;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
            
                // MessageBoxEx.Show("Certificate Generation Complete ", "Certificate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (crldata != null)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Certificate Revocation List *.crl|*.crl";
                    if (sfd.ShowDialog() == DialogResult.OK)
                        File.WriteAllBytes(sfd.FileName, crldata.GetEncoded());
                  
                    stepItem3.Value = 100;
                }
            }
            catch
            {

            }
        }
        private void buttonItem1_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
        
                backgroundWorker1.RunWorkerAsync();
            }
        }

        System.Security.Cryptography.X509Certificates.X509Certificate2 CACert;
        Al.Security.Crypto.AsymmetricKeyParameter CP;
        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {

                if (cadlg.ShowDialog() == DialogResult.OK)
                {
                    if (cadlg.FileName.EndsWith(".p12") || cadlg.FileName.EndsWith(".pfx"))
                    {
                        PassForm frm = new PassForm();
                        frm.ShowDialog();
                        if (frm.pass != null)
                        {
                            textBoxX1.Text = cadlg.FileName;
                        
                           
                            CACert = new System.Security.Cryptography.X509Certificates.X509Certificate2(cadlg.FileName, frm.pass);
                            Al.Security.Pkcs.Pkcs12Store st = new Al.Security.Pkcs.Pkcs12Store(File.OpenRead(cadlg.FileName), frm.pass.ToCharArray());
                            IEnumerator en = st.Aliases.GetEnumerator();
                            en.MoveNext();
                          CP=   st.GetKey(en.Current.ToString()).Key;
                    //        System.Security.Cryptography.RSACryptoServiceProvider rsa = (System.Security.Cryptography.RSACryptoServiceProvider)CACert.PrivateKey;
                       
                            stepItem5.Value = 100;
                            buttonX2.Enabled = true;
                            superTabItem1.Visible = true;
                        
                           
                        }
                        else
                            throw new ArgumentException("PKCS12 password was not defined");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "CA Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                if (CACert != null)
                    System.Security.Cryptography.X509Certificates.X509Certificate2UI.DisplayCertificate(CACert, this.Handle);
            }
            catch (Exception ex)
            {
                Log.LogEx(ex);
            }
        }


    }
}
