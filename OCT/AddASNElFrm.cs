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
    public partial class AddASNElFrm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public AddASNElFrm()
        {
            InitializeComponent();
        }
        ComboItem GetTypeItem(ElementType el)
        {
            ComboItem c = new ComboItem();
            c.Text = el.ToString();
            c.Tag = el;
            return c;
        }

        private void AddASNElFrm_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (string s in comboBoxEx2.AutoCompleteCustomSource)
                {
                    ElementType el = (ElementType)Enum.Parse(typeof(ElementType), s);
                    comboBoxEx2.Items.Add(GetTypeItem(el));
                }
            }
            catch
            {
            }
        }

        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {

        }
        public ASNElement ASNEl = null;
        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                if (superValidator1.Validate() && comboBoxEx2.SelectedItem != null)
                {
                    ElementType el = (ElementType)((ComboItem)comboBoxEx2.SelectedItem).Tag;
                    string name = textBoxX1.Text;
                    string value = textBoxX2.Text;
                    if (el == ElementType.SEQUENCE)
                        ASNEl = new ASNElement(el, name);
                    else
                        ASNEl = new ASNElement(el, name, value);

                    this.Close();
                }
            }
            catch(Exception ex)
            {
                Log.ShowInfo(ex.Message, "ADD ASN.1");
            }
        }


    }
}