using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Globalization;
using DevComponents.Editors;
//Linq;
using DevComponents.DotNetBar.Controls;
using Al.Security.CA;
using OpenSSL.X509;
namespace OCT
{
    public partial class NameFrm : UserControl
    {
        public x509NameBind bind;
      
        /// <summary>
        /// Gets the list of countries based on ISO 3166-1
        /// </summary>
        /// <returns>Returns the list of countries based on ISO 3166-1</returns>
        public Dictionary<string,string> GetCountriesByIso3166()
        {
            Dictionary<string, string> clist = new Dictionary<string, string>();
        
                clist.Add("AF", "Afghanistan");
                clist.Add("AX", "Åland Islands");
                clist.Add("AL", "Albania");
                clist.Add("DZ", "Algeria");
                clist.Add("AS", "American Samoa");
                clist.Add("AD", "Andorra");
                clist.Add("AO", "Angola");
                clist.Add("AI", "Anguilla");
                clist.Add("AQ", "Antarctica");
                clist.Add("AG", "Antigua and Barbuda");
                clist.Add("AR", "Argentina");
                clist.Add("AM", "Armenia");
                clist.Add("AW", "Aruba");
                clist.Add("AU", "Australia");
                clist.Add("AT", "Austria");
                clist.Add("AZ", "Azerbaijan");
                clist.Add("BS", "Bahamas");
                clist.Add("BH", "Bahrain");
                clist.Add("BD", "Bangladesh");
                clist.Add("BB", "Barbados");
                clist.Add("BY", "Belarus");
                clist.Add("BE", "Belgium");
                clist.Add("BZ", "Belize");
                clist.Add("BJ", "Benin");
                clist.Add("BM", "Bermuda");
                clist.Add("BT", "Bhutan");
                clist.Add("BO", "Bolivia");
                clist.Add("BA", "Bosnia and Herzegovina");
                clist.Add("BW", "Botswana");
                clist.Add("BV", "Bouvet Island");
                clist.Add("BR", "Brazil");
                clist.Add("IO", "British Indian Ocean Territory");
                clist.Add("BN", "Brunei Darussalam");
                clist.Add("BG", "Bulgaria");
                clist.Add("BF", "Burkina Faso");
                clist.Add("BI", "Burundi");
                clist.Add("KH", "Cambodia");
                clist.Add("CM", "Cameroon");
                clist.Add("CA", "Canada");
                clist.Add("CV", "Cape Verde");
                clist.Add("KY", "Cayman Islands");
                clist.Add("CF", "Central African Republic");
                clist.Add("TD", "Chad");
                clist.Add("CL", "Chile");
                clist.Add("CN", "China");
                clist.Add("CX", "Christmas Island");
                clist.Add("CC", "Cocos (Keeling) Islands");
                clist.Add("CO", "Colombia");
                clist.Add("KM", "Comoros");
                clist.Add("CG", "Congo");
                clist.Add("CD", "Congo, The Democratic Republic of The");
                clist.Add("CK", "Cook Islands");
                clist.Add("CR", "Costa Rica");
                clist.Add("CI", "Cote D'ivoire");
                clist.Add("HR", "Croatia");
                clist.Add("CU", "Cuba");
                clist.Add("CY", "Cyprus");
                clist.Add("CZ", "Czech Republic");
                clist.Add("DK", "Denmark");
                clist.Add("DJ", "Djibouti");
                clist.Add("DM", "Dominica");
                clist.Add("DO", "Dominican Republic");
                clist.Add("EC", "Ecuador");
                clist.Add("EG", "Egypt");
                clist.Add("SV", "El Salvador");
                clist.Add("GQ", "Equatorial Guinea");
                clist.Add("ER", "Eritrea");
                clist.Add("EE", "Estonia");
                clist.Add("ET", "Ethiopia");
                clist.Add("FK", "Falkland Islands (Malvinas)");
                clist.Add("FO", "Faroe Islands");
                clist.Add("FJ", "Fiji");
                clist.Add("FI", "Finland");
                clist.Add("FR", "France");
                clist.Add("GF", "French Guiana");
                clist.Add("PF", "French Polynesia");
                clist.Add("TF", "French Southern Territories");
                clist.Add("GA", "Gabon");
                clist.Add("GM", "Gambia");
                clist.Add("GE", "Georgia");
                clist.Add("DE", "Germany");
                clist.Add("GH", "Ghana");
                clist.Add("GI", "Gibraltar");
                clist.Add("GR", "Greece");
                clist.Add("GL", "Greenland");
                clist.Add("GD", "Grenada");
                clist.Add("GP", "Guadeloupe");
                clist.Add("GU", "Guam");
                clist.Add("GT", "Guatemala");
                clist.Add("GG", "Guernsey");
                clist.Add("GN", "Guinea");
                clist.Add("GW", "Guinea-bissau");
                clist.Add("GY", "Guyana");
                clist.Add("HT", "Haiti");
                clist.Add("HM", "Heard Island and Mcdonald Islands");
                clist.Add("VA", "Holy See (Vatican City State)");
                clist.Add("HN", "Honduras");
                clist.Add("HK", "Hong Kong");
                clist.Add("HU", "Hungary");
                clist.Add("IS", "Iceland");
                clist.Add("IN", "India");
                clist.Add("ID", "Indonesia");
                clist.Add("IR", "Iran, Islamic Republic of");
                clist.Add("IQ", "Iraq");
                clist.Add("IE", "Ireland");
                clist.Add("IM", "Isle of Man");
                clist.Add("IL", "Israel");
                clist.Add("IT", "Italy");
                clist.Add("JM", "Jamaica");
                clist.Add("JP", "Japan");
                clist.Add("JE", "Jersey");
                clist.Add("JO", "Jordan");
                clist.Add("KZ", "Kazakhstan");
                clist.Add("KE", "Kenya");
                clist.Add("KI", "Kiribati");
                clist.Add("KP", "Korea, Democratic People's Republic of");
                clist.Add("KR", "Korea, Republic of");
                clist.Add("KW", "Kuwait");
                clist.Add("KG", "Kyrgyzstan");
                clist.Add("LA", "Lao People's Democratic Republic");
                clist.Add("LV", "Latvia");
                clist.Add("LB", "Lebanon");
                clist.Add("LS", "Lesotho");
                clist.Add("LR", "Liberia");
                clist.Add("LY", "Libyan Arab Jamahiriya");
                clist.Add("LI", "Liechtenstein");
                clist.Add("LT", "Lithuania");
                clist.Add("LU", "Luxembourg");
                clist.Add("MO", "Macao");
                clist.Add("MK", "Macedonia, The Former Yugoslav Republic of");
                clist.Add("MG", "Madagascar");
                clist.Add("MW", "Malawi");
                clist.Add("MY", "Malaysia");
                clist.Add("MV", "Maldives");
                clist.Add("ML", "Mali");
                clist.Add("MT", "Malta");
                clist.Add("MH", "Marshall Islands");
                clist.Add("MQ", "Martinique");
                clist.Add("MR", "Mauritania");
                clist.Add("MU", "Mauritius");
                clist.Add("YT", "Mayotte");
                clist.Add("MX", "Mexico");
                clist.Add("FM", "Micronesia, Federated States of");
                clist.Add("MD", "Moldova, Republic of");
                clist.Add("MC", "Monaco");
                clist.Add("MN", "Mongolia");
                clist.Add("ME", "Montenegro");
                clist.Add("MS", "Montserrat");
                clist.Add("MA", "Morocco");
                clist.Add("MZ", "Mozambique");
                clist.Add("MM", "Myanmar");
                clist.Add("NA", "Namibia");
                clist.Add("NR", "Nauru");
                clist.Add("NP", "Nepal");
                clist.Add("NL", "Netherlands");
                clist.Add("AN", "Netherlands Antilles");
                clist.Add("NC", "New Caledonia");
                clist.Add("NZ", "New Zealand");
                clist.Add("NI", "Nicaragua");
                clist.Add("NE", "Niger");
                clist.Add("NG", "Nigeria");
                clist.Add("NU", "Niue");
                clist.Add("NF", "Norfolk Island");
                clist.Add("MP", "Northern Mariana Islands");
                clist.Add("NO", "Norway");
                clist.Add("OM", "Oman");
                clist.Add("PK", "Pakistan");
                clist.Add("PW", "Palau");
                clist.Add("PS", "Palestinian Territory, Occupied");
                clist.Add("PA", "Panama");
                clist.Add("PG", "Papua New Guinea");
                clist.Add("PY", "Paraguay");
                clist.Add("PE", "Peru");
                clist.Add("PH", "Philippines");
                clist.Add("PN", "Pitcairn");
                clist.Add("PL", "Poland");
                clist.Add("PT", "Portugal");
                clist.Add("PR", "Puerto Rico");
                clist.Add("QA", "Qatar");
                clist.Add("RE", "Reunion");
                clist.Add("RO", "Romania");
                clist.Add("RU", "Russian Federation");
                clist.Add("RW", "Rwanda");
                clist.Add("SH", "Saint Helena");
                clist.Add("KN", "Saint Kitts and Nevis");
                clist.Add("LC", "Saint Lucia");
                clist.Add("PM", "Saint Pierre and Miquelon");
                clist.Add("VC", "Saint Vincent and The Grenadines");
                clist.Add("WS", "Samoa");
                clist.Add("SM", "San Marino");
                clist.Add("ST", "Sao Tome and Principe");
                clist.Add("SA", "Saudi Arabia");
                clist.Add("SN", "Senegal");
                clist.Add("RS", "Serbia");
                clist.Add("SC", "Seychelles");
                clist.Add("SL", "Sierra Leone");
                clist.Add("SG", "Singapore");
                clist.Add("SK", "Slovakia");
                clist.Add("SI", "Slovenia");
                clist.Add("SB", "Solomon Islands");
                clist.Add("SO", "Somalia");
                clist.Add("ZA", "South Africa");
                clist.Add("GS", "South Georgia and The South Sandwich Islands");
                clist.Add("ES", "Spain");
                clist.Add("LK", "Sri Lanka");
                clist.Add("SD", "Sudan");
                clist.Add("SR", "Suriname");
                clist.Add("SJ", "Svalbard and Jan Mayen");
                clist.Add("SZ", "Swaziland");
                clist.Add("SE", "Sweden");
                clist.Add("CH", "Switzerland");
                clist.Add("SY", "Syrian Arab Republic");
                clist.Add("TW", "Taiwan, Province of China");
                clist.Add("TJ", "Tajikistan");
                clist.Add("TZ", "Tanzania, United Republic of");
                clist.Add("TH", "Thailand");
                clist.Add("TL", "Timor-leste");
                clist.Add("TG", "Togo");
                clist.Add("TK", "Tokelau");
                clist.Add("TO", "Tonga");
                clist.Add("TT", "Trinidad and Tobago");
                clist.Add("TN", "Tunisia");
                clist.Add("TR", "Turkey");
                clist.Add("TM", "Turkmenistan");
                clist.Add("TC", "Turks and Caicos Islands");
                clist.Add("TV", "Tuvalu");
                clist.Add("UG", "Uganda");
                clist.Add("UA", "Ukraine");
                clist.Add("AE", "United Arab Emirates");
                clist.Add("GB", "United Kingdom");
                clist.Add("US", "United States");
                clist.Add("UM", "United States Minor Outlying Islands");
                clist.Add("UY", "Uruguay");
                clist.Add("UZ", "Uzbekistan");
                clist.Add("VU", "Vanuatu");
                clist.Add("VE", "Venezuela");
                clist.Add("VN", "Viet Nam");
                clist.Add("VG", "Virgin Islands, British");
                clist.Add("VI", "Virgin Islands, U.S.");
                clist.Add("WF", "Wallis and Futuna");
                clist.Add("EH", "Western Sahara");
                clist.Add("YE", "Yemen");
                clist.Add("ZM", "Zambia");
                clist.Add("ZW", "Zimbabwe");
          //  clist.Keys.ToList().Sort();
   
            return clist;
        }
        public NameFrm()
        {
            InitializeComponent();

        }
        public void Init()
        {
          
            foreach (KeyValuePair<string,string> rf in GetCountriesByIso3166())
            {
                ComboItem it = new ComboItem();
                it.Text = rf.Value + " (" + rf.Key + ")";
                it.Value = rf.Key;
                countryofcitizenship.Items.Add(it);
                countryofresidence.Items.Add(it);
                jurisdictionOfIncorporationCountryName.Items.Add(it);
                c.Items.Add(it);
            }
            notafter.Value = DateTime.Now.AddYears(1);
            notbefore.Value = DateTime.Now;
        }
        private void NameFrm_Load(object sender, EventArgs e)
        {
          

        }

        private void groupPanel3_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            bind = null;
       
        }
        string x509customname = "";
        void LoadText(TextBoxX c)
        {

            if (bind.Vals.ContainsKey(bind.TryGetOID(c.Name)))
            {
                c.Text = bind.Vals[bind.TryGetOID(c.Name)];
                x509customname += (c.Name + "=" + c.Text).ToLower()+"," ;
            }
        }
        void GetCountry(string code, ComboBoxEx c)
        {
            foreach (ComboItem it in c.Items)
                if (it.Value.ToString() == code)
                {
                    c.SelectedItem = it;

                    break;
                }

        }
        void LoadCombo(ComboBoxEx c)
        {
            if (bind.Vals.ContainsKey(bind.TryGetOID(c.Name)))
            {
                GetCountry(bind.Vals[bind.TryGetOID(c.Name)], c);
                x509customname += (c.Name + "=" + bind.Vals[bind.TryGetOID(c.Name)]).ToLower() + ",";

            }
        }
        public void LoadCertificate(Al.Security.X509.X509Certificate cert)
        {
            System.Collections.IList oids = cert.SubjectDN.GetOidList();
            System.Collections.IList values = cert.SubjectDN.GetValueList();
            bind = new x509NameBind();
            for (int i = 0; i < oids.Count; i++)
                bind.Add(((Al.Security.Asn1.DerObjectIdentifier)oids[i]).Id, (string)values[i]);

            LoadNames();
        }
        bool SetCustoms()
        {
            
            string str = x509names.Text;
            if (!string.IsNullOrEmpty(str))
            {
                if (str.IndexOf('/') == -1 &&
                str.IndexOf('=') == -1)
                {

                    return false;
                }

                string[] parts = str.Split('/');
                foreach (string part in parts)
                {
                    if (part == "")
                        continue;
                    string[] nv = part.Split('=');
                    string name = nv[0];
                    string value = nv[1];
                    bind.Add(name, value);
                }
            }
            return true;
        }
        public void LoadNames()
        {
            try
            {
                x509customname = "";
                LoadText(cn);
                LoadText(o);
                LoadText(ou);
                LoadText(emailaddress);
                LoadText(st);
                LoadText(l);
                LoadText(street);
                LoadText(dc);
                LoadText(uid);
                LoadCombo(c);

                LoadText(surname);
                LoadText(givenname);
                LoadText(initials);
                LoadText(gender);
                LoadText(uniqueidentifier);
                LoadText(telephonenumber);
                LoadText(pseudonym);
                LoadText(postaladdress);
                LoadCombo(countryofcitizenship);
                LoadCombo(countryofresidence);

                // EV SSL
                LoadCombo(jurisdictionOfIncorporationCountryName);
                LoadText(businessCategory);
                LoadText(jurisdictionOfIncorporationLocalityName);
                LoadText(jurisdictionOfIncorporationStateOrProvinceName);
                // Custom
                foreach (KeyValuePair<string, string> s in bind.Vals)
                {
                    if (!x509customname.Contains((s.Key + "=" + s.Value).ToLower()))
                        x509names.Text += s.Key + "=" + s.Value+"/";
                    
                }
                if (x509names.Text.EndsWith("/"))
                   x509names.Text=  x509names.Text.Remove(x509names.Text.Length - 1, 1);
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Loading x509 Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        bool SetText(TextBoxX txt)
        {
            if (!string.IsNullOrEmpty(txt.Text))
                return bind.Add(txt.Name, txt.Text);
            else
                return true;
        }
        bool SetCombo(ComboBoxEx txt)
        {
            if (txt.SelectedItem != null)
                return bind.Add(txt.Name, ((ComboItem)txt.SelectedItem).Value.ToString());
            else
                return true;
        }
       public delegate bool InvokeBoolInterThread();
        public bool GetNames()
        {
            try
            {
                if (!InvokeRequired)
                {
             
                        bind = new x509NameBind();
                    if (superValidator1.Validate())
                    {
                        // Basic informations
                        bool res = SetText(cn);
                        res &= SetText(o);
                        res &= SetText(ou);
                        res &= SetText(emailaddress);
                        res &= SetText(st);
                        res &= SetText(l);
                        res &= SetText(street);
                        res &= SetText(dc);
                        res &= SetText(uid);
                        res &= SetCombo(c);

                        res &= SetText(surname);
                        res &= SetText(givenname);
                        res &= SetText(initials);
                        res &= SetText(gender);
                        res &= SetText(uniqueidentifier);
                        res &= SetText(telephonenumber);
                        res &= SetText(pseudonym);
                        res &= SetText(postaladdress);
                        res &= SetCombo(countryofcitizenship);
                        res &= SetCombo(countryofresidence);

                        // EV SSL
                        res &= SetCombo(jurisdictionOfIncorporationCountryName);
                        res &= SetText(businessCategory);
                        res &= SetText(jurisdictionOfIncorporationLocalityName);
                        res &= SetText(jurisdictionOfIncorporationStateOrProvinceName);

                        // Custom 
                        res &= SetCustoms();

                        bind.ReverseOrder();
                        if (!res)
                        {
                            MessageBoxEx.Show("Failed: Some of x509 names was skipped", "Saving Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        return true;

                    }
                }
                else
                    return (bool)Invoke(new InvokeBoolInterThread(GetNames));
           
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Saving x509 Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return false;
        }
        /*
cn
o
ou
email
st
l
street
dc
uid
c
------------
surname
givenname
initials
gender
uinique
tel
pseudo
postal
czen
cres
  */
        private void buttonX2_Click(object sender, EventArgs e)
        {

        }


    }
}