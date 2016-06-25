using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

using DevComponents.DotNetBar;
using OpenSSL.X509;
using OpenSSL.Crypto;
using OpenSSL.Core;

namespace OCT
{
    public partial class CreateCSR : UserControl
    {
        public CreateCSR()
        {
            InitializeComponent();
            nameFrm1.Init();
        }
        CSRExportFrm cfrm;
        
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

                //    X509Name subjectDN = new X509Name(oids, values);

                  

                 backgroundWorker1.ReportProgress(100, 1);

                    // Step 2
                    progress = 0;
                    cur = 0;

                       if (keyGenerationFrm1.GenerateKey())
                    {

                   Al.Security.CA.KeyGenerationBind keyb = keyGenerationFrm1.bind;
                        CryptoKey KeyPair = keyb.KeyPair;
                         
                //        Al.Security.CA.KeyGenerationBind keyb = keyGenerationFrm1.bind;
               

            backgroundWorker1.ReportProgress(100, 2);

                //        // STEP 3
                    
               backgroundWorker1.ReportProgress(100, 3);

            // STEP 4 SAVE

          //generate
               X509Request req = null;
               int version = 2; // Version 2 is X.509 Version 3
            
               req = new X509Request(version, subject, KeyPair);
             
               cfrm.Key = KeyPair;
               cfrm.certificate = req;
                    }
                       else SelectTab(superTabItem5);


                }
                else SelectTab(superTabItem4);

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
                    stepItem1.Value = progress;
                    break;
                case 2:
                    stepItem2.Value = progress;
                    break;
                default:
                    stepItem3.Value = progress;
                    break;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            stepItem3.Value = 100;
            // MessageBoxEx.Show("Certificate Generation Complete ", "Certificate", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (cfrm.certificate != null)
                cfrm.ShowDialog();
        }
        private void buttonItem1_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                cfrm = new CSRExportFrm();
                backgroundWorker1.RunWorkerAsync();
            }
        }
    }
}
