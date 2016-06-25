using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.Editors;
using Al.Security.CA;

namespace OCT
{
    public partial class GeneralNameFrm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Al.Security.CA.GlobalName GName= null;
        bool AI = false;
        bool NC = false;

        public GeneralNameFrm()
        {
            InitializeComponent();
            LoadTags();
        }

        public GeneralNameFrm(bool ai,bool nc)
        {
            InitializeComponent();
            LoadTags();
            NC = nc;
            AI = ai;
        }
       
        public GeneralNameFrm(bool auth)
        {
            InitializeComponent();
            LoadTags();
            AI = auth;
            checkBoxX1.Visible = auth;

        }
        ComboItem GetItem(GeneralNameHook tag, string name)
        {
            ComboItem cv = new ComboItem();
            cv.Text = name;
            cv.Value = (int)tag;
            return cv;
        }
        void LoadTags()
        {
         //   comboBoxEx2.Items.Add(GetItem(GeneralName.X400Address, "X400 Address"));
            comboBoxEx2.Items.Add(GetItem(GeneralNameHook.URI, "Uniform Resource Identifier"));
            comboBoxEx2.Items.Add(GetItem(GeneralNameHook.email, "Email"));
            comboBoxEx2.Items.Add(GetItem(GeneralNameHook.RID, "Registered ID"));
            if(!NC)
             comboBoxEx2.Items.Add(GetItem(GeneralNameHook.IP, "IP Address"));
          //  comboBoxEx2.Items.Add(GetItem(GeneralName.EdiPartyName, "Edi Party Name"));

            comboBoxEx2.Items.Add(GetItem(GeneralNameHook.DNS, "Dns Name"));
            if(!AI)
            comboBoxEx2.Items.Add(GetItem(GeneralNameHook.dirName, "Directory Name"));

            comboBoxEx2.Items.Add(GetItem(GeneralNameHook.otherName, "Other Name"));
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                if (superValidator1.Validate())
                {
                    if(comboBoxEx2.SelectedItem != null)
                    {
                        GName = new GlobalName((GeneralNameHook)((ComboItem)comboBoxEx2.SelectedItem).Value, textBoxX1.Text);
                        this.Close();
                     }
                    else
                        MessageBoxEx.Show("Please select a type", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log.ShowOperationFailed(ex, "X509 Global Name");
            }
        }

        private void comboBoxEx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GeneralNameHook hk = (GeneralNameHook)((ComboItem)comboBoxEx2.SelectedItem).Value;
                if (hk == GeneralNameHook.IP)
                    superValidator1.SetValidator1(textBoxX1, new DevComponents.DotNetBar.Validator.RegularExpressionValidator("Please type a valid IP Address", @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}", false));
                else if (hk == GeneralNameHook.URI)
                    superValidator1.SetValidator1(textBoxX1, new DevComponents.DotNetBar.Validator.RegularExpressionValidator("Please type a valid URL", @"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?$", false));
                else if (hk == GeneralNameHook.email)
                    superValidator1.SetValidator1(textBoxX1, new DevComponents.DotNetBar.Validator.RegularExpressionValidator("Please type a valid Email", @"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$", false));
                else
                    superValidator1.SetValidator1(textBoxX1, null);


            }
            catch
            {

            }
        }
    }
}