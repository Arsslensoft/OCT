using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace OCT
{
    public partial class AboutCtrl : UserControl
    {
        public AboutCtrl()
        {
            InitializeComponent();
            labelX1.Text.Replace("{user}", Environment.UserName);
        }
    }
}
