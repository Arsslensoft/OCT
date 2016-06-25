using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace OCT
{
    public partial class PassForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public PassForm()
        {
            InitializeComponent();
        }
        internal string pass = null;
        private void buttonX1_Click(object sender, EventArgs e)
        {
            pass = textBoxX1.Text;
            this.Close();
        }

        private void textBoxX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonX1_Click(this, EventArgs.Empty);
        }

      
    }
}