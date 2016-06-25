using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Text.RegularExpressions;
using Al.Security.CA;

namespace OCT
{
    public partial class Extentionsfrm : UserControl
    {
        public Extentionsfrm()
        {
            InitializeComponent();
        }
        bool CheckedBo(CheckBoxItem it)
        {
            return it.Checked;
        }
        Regex OidRegex = new Regex(@"\A[0-2](\.[0-9]+)+\z");
        List<string> ExtractOids()
        {
            List<string> oids = new List<string>();
            foreach (string oid in exoidtxt.Text.Split(','))
                if (OidRegex.IsMatch(oid))
                    oids.Add(oid);

            return oids;
        }

      public  void KeyUsageWork(ref List<X509KeyUsages> KeyUsages, ref bool critical)
        {
            KeyUsages = new List<X509KeyUsages>();
            critical = keyusagecrit.Checked;
            bool chk = DigitalSignature.Checked || NonRepudiation.Checked || CrlSign.Checked || KeyAgreement.Checked || KeyCertSign.Checked || KeyEncipherment.Checked || EncipherOnly.Checked || DecipherOnly.Checked || DataEncipherment.Checked;
            if (chk)
            {
             
                if (CheckedBo(DigitalSignature))
                    KeyUsages.Add(X509KeyUsages.digitalSignature);

                if (CheckedBo(NonRepudiation))
                    KeyUsages.Add(X509KeyUsages.nonRepudiation);

                if (CheckedBo(CrlSign))
                    KeyUsages.Add(X509KeyUsages.cRLSign);

                if (CheckedBo(KeyAgreement))
                    KeyUsages.Add(X509KeyUsages.keyAgreement);

                if (CheckedBo(KeyCertSign))
                    KeyUsages.Add(X509KeyUsages.keyCertSign);

                if (CheckedBo(KeyEncipherment))
                    KeyUsages.Add(X509KeyUsages.keyEncipherment);

                if (CheckedBo(EncipherOnly))
                    KeyUsages.Add(X509KeyUsages.encipherOnly);

                if (CheckedBo(DecipherOnly))
                    KeyUsages.Add(X509KeyUsages.decipherOnly);

                if (CheckedBo(DataEncipherment))
                    KeyUsages.Add(X509KeyUsages.dataEncipherment);


            }
            
        }
      public void ExtendedKeyUsageWork(ref List<X509ExtendedKeyUsages> keys,ref List<string> customku, ref bool critical)
        {
            critical = exkeycrit.Checked;
            customku = ExtractOids();
        

            bool chk = ClientAuth.Checked || ServerAuth.Checked || emailprot.Checked || msEFS.Checked || TimeStamping.Checked || msSGC.Checked || nsSGC.Checked || msCTLSign.Checked || CodeSign.Checked || msCodeInd.Checked;
            if (chk)
            {
                keys = new List<X509ExtendedKeyUsages>();

                if (CheckedBo(ClientAuth))
                    keys.Add(X509ExtendedKeyUsages.clientAuth);

                if (CheckedBo(ServerAuth))
                    keys.Add(X509ExtendedKeyUsages.serverAuth);

                if (CheckedBo(emailprot))
                    keys.Add(X509ExtendedKeyUsages.emailProtection);

                if (CheckedBo(msEFS))
                    keys.Add(X509ExtendedKeyUsages.msEFS);

                if (CheckedBo(TimeStamping))
                    keys.Add(X509ExtendedKeyUsages.timeStamping);

                if (CheckedBo(msSGC))
                    keys.Add(X509ExtendedKeyUsages.msSGC);

                if (CheckedBo(nsSGC))
                    keys.Add(X509ExtendedKeyUsages.nsSGC);

                if (CheckedBo(msCTLSign))
                    keys.Add(X509ExtendedKeyUsages.msCTLSign);

                if (CheckedBo(msCodeInd))
                    keys.Add(X509ExtendedKeyUsages.msCodeInd);

                if (CheckedBo(CodeSign))
                    keys.Add(X509ExtendedKeyUsages.codeSigning);

                if (CheckedBo(OCSP))
                    customku.Add("1.3.6.1.5.5.7.3.9");

              
                
            }
   
        }
      public void BasicConstraintWork(ref BasicConstraintsExt constraints, ref bool critical)
        {
            critical = cacrit.Checked;
            if (integerInput1.Value >= 0)
                constraints = new BasicConstraintsExt(true,integerInput1.Value);
            else if (isCA.Checked)
                constraints = new BasicConstraintsExt(true,-1);
            else
                constraints = new BasicConstraintsExt(false,-1);
        }
      public void KeyIDWork(ref bool skid, ref bool akid, ref bool critical)
        {
            skid = skeyid.Checked;
            akid = akeyid.Checked;
            critical = akeycrit.Checked;
        }
      public void NameConstraintsWork(ref bool enabled, ref  List<GlobalName> Permitted, ref List<GlobalName> Excluded, ref bool critical)
        {
            critical = namecrit.Checked;
            enabled = (listView1.Items.Count > 0) || (listView2.Items.Count > 0);
            if (listView1.Items.Count > 0)
            {
                Permitted = new List<GlobalName>();
                foreach (ListViewItem it in listView1.Items)
                {
                    if (it.Tag is GlobalName)
                    {
                        GlobalName gn = (GlobalName)it.Tag;
                        Permitted.Add(gn);
                    }
                }
            }
            else Permitted = null;


            if (listView2.Items.Count > 0)
            {
                Excluded = new List<GlobalName>();
                foreach (ListViewItem it in listView2.Items)
                {
                    if (it.Tag is GlobalName)
                    {
                        GlobalName gn = (GlobalName)it.Tag;
                        Excluded.Add(gn);
                    }
                }
            }
            else Excluded = null;

        }
      public void AuthorityInfoWork(ref bool enabled, ref bool critical, ref List<AuthorityInfoAccessExt> authseq)
        {
           authseq = new List<AuthorityInfoAccessExt>();
            critical = authacscrit.Checked;
            enabled = (listView3.Items.Count > 0);
            if(enabled)
            {
                foreach(ListViewItem it in listView3.Items)
                {
                    if (it.Tag is GlobalName)
                    {
                        GlobalName gn = (GlobalName)it.Tag;
                        if(it.Text.StartsWith("[OCSP]"))
                        {
                            List<GlobalName> sgn = new List<GlobalName>();
                            sgn.Add(gn);
                             AccessInformationEntry acd = new  AccessInformationEntry(true, sgn);
                              authseq.Add(new AuthorityInfoAccessExt( acd));
                        }
                        else
                        {
                            List<GlobalName> sgn = new List<GlobalName>();
                            sgn.Add(gn);
                            AccessInformationEntry acd = new AccessInformationEntry(false, sgn);
                             authseq.Add(new AuthorityInfoAccessExt( acd));

                        }
                    }
                }
         
      
            }
            else authseq = null;
        }

      public void SubjectAltWork(ref bool enabled, ref bool critical, ref List<GlobalName> Names)
        {
         
            critical = subjaltcrit.Checked;
            enabled = (listView5.Items.Count > 0);
          
            if (enabled)
            {
                Names = new List<GlobalName>();
                foreach (ListViewItem it in listView5.Items)
                {
                    if (it.Tag is GlobalName)
                    {
                        GlobalName gn = (GlobalName)it.Tag;
                        Names.Add(gn);
                    }
                }
                

            }
            else Names = null;
        }
      public void IssuerAltWork(ref bool enabled, ref bool critical, ref List<GlobalName> Names)
        {

            critical = issueraltcrit.Checked;
            enabled = (listView6.Items.Count > 0);

            if (enabled)
            {
                Names = new List<GlobalName>();
                foreach (ListViewItem it in listView6.Items)
                {
                    if (it.Tag is GlobalName)
                    {
                        GlobalName gn = (GlobalName)it.Tag;
                        Names.Add(gn);
                    }
                }
            

            }
            else Names = null;
        }
      public void CrlIssuerDPWork(ref bool crlenabled, ref bool issuerenabled, ref CrlDistributionPointsExt crl, ref IssuingDistributionPointsExt issuer, ref bool critical)
        {

            List<DistributionPointEntry> crls = new List<DistributionPointEntry>();
            List<DistributionPointEntry> issuers = new List<DistributionPointEntry>();
            foreach (ListViewItem it in listView7.Items)
            {
                if (it.Tag is DistributionPointEntry)
                {
                    if (it.Text.StartsWith("[CRL]"))
                        crls.Add((DistributionPointEntry)it.Tag);
                    else issuers.Add((DistributionPointEntry)it.Tag);
                }
            }

            crlenabled = (crls.Count > 0);
            issuerenabled = (issuers.Count > 0);
            if (crlenabled)
                crl = new CrlDistributionPointsExt(crls);
            else crl = null;

            if (issuerenabled)
                issuer = new IssuingDistributionPointsExt(issuers[0]);
            else issuer = null;
            if (issuers.Count > 1)
                Log.ShowInfo("Only 1 issuing distribution point will be used", "ISSUING DISTRIBUTION POINTS");
            critical = crlcrit.Checked;
         
       
        }
      public void PolicyWork(ref bool enabled, ref bool critical, ref CertificatePoliciesExt policies)
        {
            enabled = (listView8.Items.Count > 0);
            critical = polcrit.Checked;
            if (enabled)
            {
                List<PolicyInformationEntry> pols = new List<PolicyInformationEntry>();
                foreach (ListViewItem it in listView8.Items)
                {
                    if (it.Tag is PolicyInformationEntry)
                        pols.Add((PolicyInformationEntry)it.Tag);
                    
                }
                policies =new CertificatePoliciesExt(pols);

            }
            else policies = null;
        }
      public void PolicySettingsWork(ref bool polconstraintenabled, ref bool inhibpolicyenabled, ref bool critical, ref int inhibmap, ref int explicitpol, ref int inhibany)
        {
            if (inhibpolmap.Value > 0 || reqexpol.Value>0)
                polconstraintenabled = true;

            if (inhibitpol.Value > 0)
                inhibpolicyenabled = true;

            if (inhibpolicyenabled)
                inhibany = inhibitpol.Value;
            else
                inhibany = 0;

            if (polconstraintenabled)
            {
                explicitpol = reqexpol.Value;
                inhibmap = inhibpolmap.Value;
            }
            else
            {
                explicitpol = 0;
                inhibmap = 0;
            }
        }
      public void NetscapeWork(ref bool critical, ref bool nskeyusage, ref string nscom, ref string nsurls,ref string nspolicy,ref string carevul, ref string revurl, ref string sslname)
        {
            nscom = nscomment.Text;
            nsurls = nsurl.Text;
            nspolicy = nspolurl.Text;
            sslname = nssslname.Text;
            carevul = nscarevurl.Text;
            revurl = nsrevurl.Text;

            nskeyusage = netskeyusage.Checked;
            critical = netscrit.Checked;
        }
        #region Name Constraints
        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                GeneralNameFrm frm = new GeneralNameFrm(false,true);
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

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                GeneralNameFrm frm = new GeneralNameFrm(false,true);
                frm.ShowDialog();
                if (frm.GName != null)
                {
                    ListViewItem it = new ListViewItem();
                    it.Text = frm.comboBoxEx2.Text + ":" + frm.textBoxX1.Text;
                    it.Tag = frm.GName;
                    listView2.Items.Add(it);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    foreach (int it in listView1.SelectedIndices)
                        listView1.Items.RemoveAt(it);

                }

                if (listView2.SelectedItems.Count > 0)
                {
                    foreach (int it in listView2.SelectedIndices)
                        listView2.Items.RemoveAt(it);

                }
            }
            catch (Exception ex)
            {

            }
        }

        #endregion

        #region Authority Info
        private void buttonX4_Click(object sender, EventArgs e)
        {
            try
            {
                GeneralNameFrm frm = new GeneralNameFrm(true);
                frm.ShowDialog();
                if (frm.GName != null)
                {
                    ListViewItem it = new ListViewItem();
                    string ty = "[CAIssuer] ";
                    if (frm.checkBoxX1.Checked)
                        ty = "[OCSP] ";
                    it.Text = ty + frm.comboBoxEx2.Text + ":" + frm.textBoxX1.Text;
                    it.Tag = frm.GName;

                    listView3.Items.Add(it);
                }
            }
            catch (Exception ex)
            {

            }

        }
        private void buttonX5_Click(object sender, EventArgs e)
        {

            try
            {
                if (listView3.SelectedItems.Count > 0)
                {
                    foreach (int it in listView3.SelectedIndices)
                        listView3.Items.RemoveAt(it);

                }

           
            }
            catch (Exception ex)
            {

            }
        }
        #endregion


        #region Subject Alt
        private void buttonX9_Click(object sender, EventArgs e)
        {

            try
            {
                GeneralNameFrm frm = new GeneralNameFrm();
                frm.ShowDialog();
                if (frm.GName != null)
                {
                    ListViewItem it = new ListViewItem();
         
                    it.Text =  frm.comboBoxEx2.Text + ":" + frm.textBoxX1.Text;
                    it.Tag = frm.GName;

                    listView5.Items.Add(it);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView5.SelectedItems.Count > 0)
                {
                    foreach (int it in listView5.SelectedIndices)
                        listView5.Items.RemoveAt(it);

                }


            }
            catch (Exception ex)
            {

            }
        }

        #endregion

        #region Issuer Alt
        private void buttonX11_Click(object sender, EventArgs e)
        {
            try
            {
                GeneralNameFrm frm = new GeneralNameFrm();
                frm.ShowDialog();
                if (frm.GName != null)
                {
                    ListViewItem it = new ListViewItem();

                    it.Text =frm.comboBoxEx2.Text + ":" + frm.textBoxX1.Text;
                    it.Tag = frm.GName;

                    listView6.Items.Add(it);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void buttonX10_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView6.SelectedItems.Count > 0)
                {
                    foreach (int it in listView6.SelectedIndices)
                        listView6.Items.RemoveAt(it);

                }


            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        #region DPOINT
        private void buttonX13_Click(object sender, EventArgs e)
        {
            try
            {
                DistPointFrm frm = new DistPointFrm();
                frm.ShowDialog();
                if (frm.DPoint != null)
                {
                    ListViewItem it = new ListViewItem();
                    string ty = "[CRL] ";
                    if (frm.checkBoxX1.Checked)
                    {
                        ty = "[ISSUER] DISTRIBUTION POINT";
                        it.Text = ty ;
                    }
                    else
                    it.Text = ty+frm.textBoxX1.Text;
                    it.Tag = frm.DPoint;

                    listView7.Items.Add(it);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void buttonX12_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView7.SelectedItems.Count > 0)
                {
                    foreach (int it in listView7.SelectedIndices)
                    {
                        DistributionPointEntry dp = (DistributionPointEntry)listView7.Items[it].Tag;
                        SectionManager.RemoveFixedSection(dp.SectionName);
                        listView7.Items.RemoveAt(it);
                    }
                }


            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        #region Policy
        private void buttonX15_Click(object sender, EventArgs e)
        {
            try
            {
                PolicyFrm frm = new PolicyFrm();
                frm.ShowDialog();
                if (frm.Policy != null)
                {
                    ListViewItem it = new ListViewItem();
                  
                    it.Text = frm.textBoxX1.Text;
                    it.Tag = frm.Policy;

                    listView8.Items.Add(it);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void buttonX14_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView8.SelectedItems.Count > 0)
                {
                    foreach (int it in listView8.SelectedIndices)
                    {
                          PolicyInformationEntry dp = (PolicyInformationEntry)listView8.Items[it].Tag;

                          SectionManager.RemoveFixedSection(dp.Name); 
                        SectionManager.RemoveFixedSection(dp.SectionName);
                 
                        listView8.Items.RemoveAt(it);
                    }
                }


            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        public List<CustomExtension> GetCustoms()
        {
            List<CustomExtension> ce = new List<CustomExtension>();
            foreach (ListViewItem it in listView9.Items)
            {
                if (it.Tag is CustomExtension)
                    ce.Add((CustomExtension)it.Tag);
            }
            return ce;
        }
        private void panelEx1_Click(object sender, EventArgs e)
        {

        }
        #region Custom Extension
        private void buttonX17_Click(object sender, EventArgs e)
        {
            try
            {
                ExtensionFrm frm = new ExtensionFrm();
                frm.ShowDialog();
                if (frm.CExtension != null)
                {
                    ListViewItem it = new ListViewItem();

                    it.Text = frm.textBoxX1.Text;
                    it.Tag = frm.CExtension;

                    listView9.Items.Add(it);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void buttonX16_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView9.SelectedItems.Count > 0)
                {
                    foreach (int it in listView9.SelectedIndices)
                        listView9.Items.RemoveAt(it);

                }


            }
            catch (Exception ex)
            {

            }
        }
        #endregion 

        private void cattcerts_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void itemPanel2_ItemClick(object sender, EventArgs e)
        {

        }

        private void msCodeInd_Click(object sender, EventArgs e)
        {

        }

        private void OCSP_Click(object sender, EventArgs e)
        {

        }

        private void expandablePanel6_Click(object sender, EventArgs e)
        {

        }

        private void netskeyusage_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void netscrit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelX6_Click(object sender, EventArgs e)
        {

        }

        private void labelX18_Click(object sender, EventArgs e)
        {

        }

        public void ResetAll()
        {
          
            listView1.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();
        //    listView4.Items.Clear();
            listView5.Items.Clear();
            listView6.Items.Clear();
            listView7.Items.Clear();
            listView8.Items.Clear();
          //  listView9.Items.Clear();
          //  listView10.Items.Clear();
        }
    }
}