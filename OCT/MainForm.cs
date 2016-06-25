using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;
using System.IO;
using System.Diagnostics;
using OpenSSL.X509;


namespace OCT
{
    public partial class MainForm : MetroForm
    {
        internal static MainForm mf;
        internal static CAI cai;
        void LoadOids()
        {
            try
            {
                int nid = X509Name.CreateNidObject("1.3.6.1.4.1.311.60.2.1.3", "jurisdictionOfIncorporationCountryName", "jurisdictionOfIncorporationCountryName");
                nid = X509Name.CreateNidObject("1.3.6.1.4.1.311.60.2.1.2", "jurisdictionOfIncorporationStateOrProvinceName", "jurisdictionOfIncorporationStateOrProvinceName");
                nid = X509Name.CreateNidObject("2.5.4.15", "businessCategory", "businessCategory");
                nid = X509Name.CreateNidObject("1.3.6.1.4.1.311.60.2.1.1", "jurisdictionOfIncorporationLocalityName", "jurisdictionOfIncorporationLocalityName");

            }
            catch
            {

            }
        }
        public MainForm()
        {
          
            MainForm.cai = new CAI();
            if (File.Exists(Application.StartupPath + @"\default.cai"))
                cai.Load(Application.StartupPath + @"\default.cai");
            else
            {
                new CAIFrm().ShowDialog();
                cai.Load(Application.StartupPath + @"\default.cai");
            }
            InitializeComponent();
            LoadOids();
            this.Text += " - " + MainForm.cai.CAName + " (" + MainForm.cai.CAOid + ")";
            MainForm.mf = this;
        }

        private void panelDockContainer5_Click(object sender, EventArgs e)
        {

        }

        public void AddTab(UserControl ctrl,string name)
        {
            try
            {
                PanelDockContainer pdc = new PanelDockContainer();
                pdc.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
                pdc.Location = new System.Drawing.Point(3, 28);
                pdc.Name = "CONTROLID" + bar5.Items.Count.ToString();
                pdc.Size = new System.Drawing.Size(553, 265);
                pdc.Style.Alignment = System.Drawing.StringAlignment.Center;
                pdc.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
                pdc.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
                pdc.Style.GradientAngle = 90;
                pdc.TabIndex = 2;
                ctrl.Dock = DockStyle.Fill;
                pdc.Controls.Add(ctrl);

                DockContainerItem dci = new DockContainerItem();
                dci.Control = pdc;
               // ho.AddProperty(props, dci, pdc, proj);
                dci.Name = "TAB" + bar5.Items.Count.ToString();
                pdc.Tag = dci;
                dci.Text = name;
                bar5.Controls.Add(pdc);
                bar5.Items.Add(dci);
                bar5.SelectedDockContainerItem = dci;
                dci.Tag = ctrl;


            }
            catch
            {

            }
        }

        private void certbtn_Click(object sender, EventArgs e)
        {
            try
            {
                CreateCertWizard frm = new CreateCertWizard();
                frm.ShowDialog();
                if (!string.IsNullOrEmpty(frm.name))
                    AddTab(new CreateCertCtrl(), "Self Signed " +frm.name);
                
            }
            catch
            {

            }
        }

        private void csrbtn_Click(object sender, EventArgs e)
        {
            try
            {
                CreateCertWizard frm = new CreateCertWizard();
                frm.ShowDialog();
                if (!string.IsNullOrEmpty(frm.name))
                    AddTab(new CreateCSR(), "CSR " + frm.name);

            }
            catch
            {

            }
        }

        private void signcertbtn_Click(object sender, EventArgs e)
        {
            try
            {
                CreateCertWizard frm = new CreateCertWizard();
                frm.ShowDialog();
                if (!string.IsNullOrEmpty(frm.name))
                    AddTab(new SIGNCertFrm(), "Sign " + frm.name);

            }
            catch
            {

            }
        }

        private void crlbtn_Click(object sender, EventArgs e)
        {
            try
            {
                CreateCertWizard frm = new CreateCertWizard();
                frm.ShowDialog();
                if (!string.IsNullOrEmpty(frm.name))
                    AddTab(new CreateCRL(), "CRL " + frm.name);

            }
            catch
            {

            }
        }

        private void extensionsbtn_Click(object sender, EventArgs e)
        {
            try
            {
                CreateCertWizard frm = new CreateCertWizard();
                frm.ShowDialog();
                if (!string.IsNullOrEmpty(frm.name))
                    AddTab(new ExtensionEditorControl(), "EXTENSION " + frm.name);

            }
            catch
            {

            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bar5_Closing(object sender, BarClosingEventArgs e)
        {
            if (bar5.SelectedDockContainerItem == starttab)
                e.Cancel = true;
        }

        private void startPage1_Load(object sender, EventArgs e)
        {

        }

        private void buttonItem26_Click(object sender, EventArgs e)
        {
            AboutForm frm = new AboutForm();
            frm.ShowDialog();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {

        }

        private void winstore_Click(object sender, EventArgs e)
        {
            Process.Start("certmgr.msc");
        }

        private void buttonItem24_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"\nss\bin");
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {

        }
      
    
      

    }
}