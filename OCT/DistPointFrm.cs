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
    public partial class DistPointFrm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public DistPointFrm()
        {
            InitializeComponent();
        }
       List<ReasonsHook> GetFlags()
        {
            List<ReasonsHook> fla = new List<ReasonsHook>();
            bool check = cacompromise.Checked || keycompromise.Checked || affiliationchanged.Checked
                || cessationofoperation.Checked || certificatehold.Checked || superseded.Checked || priviledgewithdrawn.Checked
                || aacompromise.Checked;

            if (!check)
                return fla;
            else
            {

                if (cacompromise.Checked)
                    fla.Add(ReasonsHook.CACompromise);
                if (keycompromise.Checked)
                    fla.Add(ReasonsHook.keyCompromise);

                if (affiliationchanged.Checked)
                    fla.Add(ReasonsHook.affiliationChanged);
                if (cessationofoperation.Checked)
                    fla.Add(ReasonsHook.cessationOfOperation);

                if (certificatehold.Checked)
                    fla.Add(ReasonsHook.certificateHold);
                if (superseded.Checked)
                    fla.Add(ReasonsHook.superseded);
                if (priviledgewithdrawn.Checked)
                    fla.Add(ReasonsHook.privilegeWithdrawn);
                if (aacompromise.Checked)
                    fla.Add(ReasonsHook.AACompromise);

                return fla;

            }
        }
     public   Al.Security.CA.DistributionPointEntry DPoint = null;
        private void buttonX12_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    foreach (int it in listView1.SelectedIndices)
                        listView1.Items.RemoveAt(it);

                }


            }
            catch (Exception ex)
            {

            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                GeneralNameFrm frm = new GeneralNameFrm();
                frm.ShowDialog();
                if (frm.GName != null)
                {
                    ListViewItem it = new ListViewItem();
     
                    it.Text = frm.comboBoxEx2.Text + ":" + frm.textBoxX1.Text;
                    it.Tag = frm.GName;

                    listView1.Items.Add(it);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void buttonX13_Click(object sender, EventArgs e)
        {
            try
            {
                if (crlacc != null || checkBoxX1.Checked)
                {

                    List<GlobalName> gn = new List<GlobalName>();
                    foreach (ListViewItem it in listView1.Items)
                    {
                        if (it.Tag is GlobalName)
                            gn.Add((GlobalName)it.Tag);
                        
                    }

                   
                        if (!checkBoxX1.Checked && crlacc != null)
                        {
                            List<GlobalName> crli = new List<GlobalName>();
                            crli.Add(crlacc);

                            DPoint = new DistributionPointEntry(GetFlags(), gn, crli);
                        }
                        else  if (listView1.Items.Count > 0)
                    //    DistributionPointName dpn = new DistributionPointName(new GeneralNames(crlacc));
                        DPoint = new DistributionPointEntry(GetFlags(), gn, indirectcrl.Checked ,cattcerts.Checked,cattcerts.Checked,usercerts.Checked);
                    
                    this.Close();
                }
                else MessageBoxEx.Show("Please add a CRL access point (URL, IP...)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       public GlobalName crlacc = null;
        private void buttonX2_Click(object sender, EventArgs e)
        {
                 GeneralNameFrm frm = new GeneralNameFrm();
                frm.ShowDialog();
                if (frm.GName != null)
                {
                    crlacc = frm.GName;
                    textBoxX1.Text = frm.textBoxX1.Text;
                }
        }

        private void checkBoxX1_CheckedChanged(object sender, EventArgs e)
        {
            indirectcrl.Enabled = checkBoxX1.Checked;
            cacerts.Enabled = checkBoxX1.Checked;
            cattcerts.Enabled = checkBoxX1.Checked;
            usercerts.Enabled = checkBoxX1.Checked;
        }
    }
}