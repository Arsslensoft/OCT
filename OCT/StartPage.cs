using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace OCT
{
    public partial class StartPage : UserControl
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
         
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                LinkLabel lnk = (LinkLabel)sender;
                Process.Start(lnk.Text);
            }
        }

    
    }
}
