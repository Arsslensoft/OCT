using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Al.Security.CA;

namespace OCT
{
    public partial class PolicyFrm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public PolicyFrm()
        {
            InitializeComponent();
            try{
                if (MainForm.cai != null)
                    if (MainForm.cai.CAOid != null)
                        textBoxX1.Text = MainForm.cai.CAOid+".";
                }
                catch{

                }
        }

        private void cps_CheckedChanged(object sender, EventArgs e)
        {
            textBoxX2.Enabled = cps.Checked;
            regularExpressionValidator2.EmptyValueIsValid = !cps.Checked;
        }

        private void noticeref_CheckedChanged(object sender, EventArgs e)
        {
            org.Enabled = noticeref.Checked;

            notice.Enabled = noticeref.Checked;
        }

        private void org_CheckedChanged(object sender, EventArgs e)
        {
            textBoxX3.Enabled = org.Checked;
            regularExpressionValidator3.EmptyValueIsValid = !org.Checked;
        }

        private void notice_CheckedChanged(object sender, EventArgs e)
        {
            textBoxX4.Enabled = notice.Checked;
        }
        public  Al.Security.CA.PolicyInformationEntry Policy = null;
        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                if (superValidator1.Validate())
                {
                    string tcps = null;
                    string torg = null;
                    string tnotice = null;
                    string toid= textBoxX1.Text;

                    if (textBoxX2.Text.Length > 0)
                        tcps = textBoxX2.Text;

                    if (textBoxX3.Text.Length > 0)
                        torg = textBoxX3.Text;

                    if (textBoxX4.Text.Length > 0)
                        tnotice = textBoxX4.Text;

                    Policy =  new PolicyInformationEntry(toid,tcps, torg,  tnotice);
                 this.Close();
                }
            }
            catch (Exception ex)
            {
                Log.LogEx(ex);
            }
        }
    }
}