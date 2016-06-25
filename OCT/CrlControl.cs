using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Al.Security.X509;
using DevComponents.DotNetBar;
using Al.Security.CA;
using Al.Security.Asn1.X509;

namespace OCT
{
    public partial class CrlControl : UserControl
    {
        public CrlControl()
        {
            InitializeComponent();
            updtime.Value = DateTime.Now;
            nextupdtime.Value = DateTime.Now.AddDays(7);
            revtime.Value = DateTime.Now;
        }
       int GetReasonIndex(string reason)
       {
           for(int i = 0; i < ReasonString.Length ;i++)
           {
               if(ReasonString[i].ToLower() == reason.ToLower())
                 return i;
           }
           return 0;
       }
     readonly string[] ReasonString = new string[]
		{
			"Unspecified", "KeyCompromise", "CACompromise", "AffiliationChanged",
			"Superseded", "CessationOfOperation", "CertificateHold", "Unknown",
			"RemoveFromCrl", "PrivilegeWithdrawn", "AACompromise"
		};
        public Al.Security.X509.X509Crl CRL;
        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBoxX1.Text = openFileDialog1.FileName;

                    X509CrlParser CRLp = new Al.Security.X509.X509CrlParser();
                   CRL = CRLp.ReadCrl(File.ReadAllBytes(textBoxX1.Text));
                }
                    
                
            }
            catch
            {

            }
        }
        delegate List<CrlEntryItem> GetCertsDelegate();
        public List<CrlEntryItem> GetCertificateList()
        {
            if (this.InvokeRequired)
            {
                List<CrlEntryItem> certs = new List<CrlEntryItem>();
                foreach (LabelItem it in itemPanel1.Items)
                    certs.Add((CrlEntryItem)it.Tag);
            
                return certs;
            }
            else return (List<CrlEntryItem>)this.Invoke(new GetCertsDelegate(GetCertificateList));
        }
        private void buttonX4_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    LabelItem it = new LabelItem();
                    X509CertificateParser cp = new X509CertificateParser();
                 X509Certificate cert =    cp.ReadCertificate(File.ReadAllBytes(openFileDialog2.FileName));
                 CrlEntryItem crle = new CrlEntryItem();
                 crle.Certificate = cert;
                 crle.Reason = GetReasonIndex(comboBox1.Text);
                 crle.RevocationTime = revtime.Value;
                 it.Tag = crle;
                 it.Text = cert.SubjectDN.ToString();
                 
                 itemPanel1.Items.Add(it);

                }
            }
            catch
            {

            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (LabelItem lb in itemPanel1.SelectedItems)
                    itemPanel1.Items.Remove(lb);
            }
            catch
            {

            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                itemPanel1.Items.Clear();
            }
            catch
            {

            }
        }

    }
    public class CrlEntryItem
{
        public X509Certificate Certificate;
        public int Reason;
        public DateTime RevocationTime;

}
}
