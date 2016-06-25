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
    public partial class CreateCertWizard : DevComponents.DotNetBar.Metro.MetroForm
    {
        public CreateCertWizard()
        {
            InitializeComponent();
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateCertWizard_Load(object sender, EventArgs e)
        {

        }

        private void textBoxX1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonX1_Click(this, EventArgs.Empty);
        }
        public string name;
        private void buttonX1_Click(object sender, EventArgs e)
        {
            name = textBoxX1.Text;
            this.Close();
        }
    }
}