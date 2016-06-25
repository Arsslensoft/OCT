using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;

namespace OCT
{
    public partial class CAIFrm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public CAIFrm()
        {
            InitializeComponent();
        }


        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                if (superValidator1.Validate())
                {
                    CAI cai = new CAI();
                    cai.CAName = textBoxX1.Text;
                    cai.CAOid = textBoxX2.Text;
                    cai.OCAID = textBoxX3.Text;
                    if (Directory.Exists(textBoxX4.Text))
                    {
                        cai.DevPath = textBoxX4.Text;
                        SaveFileDialog sfd = new SaveFileDialog();
                        
                        sfd.Filter = "*.cai|*.cai";
                        if (File.Exists(Application.StartupPath + @"\default.cai"))
                        {
                            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                cai.Save(sfd.FileName);
                        }
                        else
                            cai.Save(Application.StartupPath + @"\default.cai");
                        this.Close();
                    }


                }
            }
            catch
            {

            }
        }
    }
}