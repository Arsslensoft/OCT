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
    public partial class KeyGenerationFrm : UserControl{
        public KeyGenerationBind bind;
        public KeyGenerationFrm()
        {
            InitializeComponent();
            bind
                 = new KeyGenerationBind();
        }
        ComboItem GetHash(string hash,int size, string algo)
        {
            ComboItem cv = new ComboItem();
            cv.Text = hash+size.ToString();
            cv.Value = hash+size.ToString();
            return cv;
        }
        ComboItem GetItem(int value)
        {
            ComboItem cv = new ComboItem();
            cv.Text = value.ToString();
            cv.Value = value;
            return cv;
        }
        void SelectKeySize(int size)
        {
            foreach (ComboItem it in keysize.Items)
            {
                if ((int)it.Value == size)
                {
                    keysize.SelectedItem = it;
                    break;
                }
            }
        }
        void SelectHash(string hash, int size)
        {
            foreach (ComboItem it in sigalg.Items)
            {
                if ((string)it.Value == hash+size.ToString())
                {
                    sigalg.SelectedItem = it;
                    break;
                }
            }
        }
        public void SetKeyParameters(string prov, int ikeysize, int serial, string hash, int hashsize)
        {
            keysize.Items.Clear();
            sigalg.Items.Clear();
            if (prov == "RSA")
            {
               // itemPanel1.SelectedIndices.Add(0);
                keyprov.Text = "Arsslensoft RSA Key Provider";
                LoadRSAComboItems();
                LoadShaComboItems("RSA");
                LoadMD5ComboItems("RSA");
                LoadRIPEMDComboItems("RSA");
              
                sigalg.SelectedIndex = 0;
                keysize.SelectedIndex = 2;
            }
            else if (prov == "DSA")
            {
               // itemPanel1.SelectedIndices.Add(1);
                keyprov.Text = "Arsslensoft DSA Key Provider";
                LoadDSAComboItems();
                LoadShaComboItems("RSA");
                LoadMD5ComboItems("RSA");
                LoadRIPEMDComboItems("RSA");
                sigalg.SelectedIndex = 0;
                keysize.SelectedIndex = 1;
          

            }
            SelectKeySize(ikeysize);
            serialnumber.Value = serial;
            SelectHash(hash, hashsize);
        }
        void LoadRSAComboItems()
        {

            keysize.Items.Add(GetItem(512));
            keysize.Items.Add(GetItem(1024));
            keysize.Items.Add(GetItem(2048));
            keysize.Items.Add(GetItem(4096));
            keysize.Items.Add(GetItem(8192));
            keysize.Items.Add(GetItem(16384));
        }
        void LoadDSAComboItems()
        {

            keysize.Items.Add(GetItem(512));
            keysize.Items.Add(GetItem(1024));

        }

        void LoadShaComboItems(string algo)
        {
            if (algo == "RSA")
            {
                sigalg.Items.Add(GetHash("SHA", 1, algo));
                sigalg.Items.Add(GetHash("SHA", 224, algo));
                sigalg.Items.Add(GetHash("SHA", 256, algo));
                sigalg.Items.Add(GetHash("SHA", 384, algo));
                sigalg.Items.Add(GetHash("SHA", 512, algo));
    
            }
            else if (algo == "DSA")
              sigalg.Items.Add(GetHash("SHA", 1, algo));

        }
      
        void LoadMD5ComboItems(string algo)
        {
            if (algo == "RSA")
            {
        
                sigalg.Items.Add(GetHash("MD", 4, algo));
                sigalg.Items.Add(GetHash("MD", 5, algo));
            }
          

        }
        void LoadRIPEMDComboItems(string algo)
        {
            if (algo == "RSA")
            {
                sigalg.Items.Add(GetHash("RIPEMD", 160, algo));
        
            }
       
        }
      
        private void itemPanel1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (itemPanel1.SelectedItems.Count > 0)
                {
                    keysize.Items.Clear();
                    sigalg.Items.Clear();
                    keysize.Enabled = true;
                    sigalg.Text = "";
                    keysize.Text = "";
                    keyprov.Text = itemPanel1.SelectedItems[0].Text;
                    string prov = itemPanel1.SelectedItems[0].Text.Replace(" Key Provider", "").Replace("Arsslensoft ", "");




                    if (prov == "RSA")
                    {
                        LoadRSAComboItems();
                        LoadShaComboItems("RSA");
                        LoadMD5ComboItems("RSA");
                        LoadRIPEMDComboItems("RSA");
                        sigalg.SelectedIndex = 0;
                        keysize.SelectedIndex =2;
                    }
                    else if (prov == "DSA")
                    {
                        LoadDSAComboItems();
                        LoadShaComboItems("RSA");
                        LoadMD5ComboItems("RSA");
                        LoadRIPEMDComboItems("RSA");
                        sigalg.SelectedIndex = 0;
                        keysize.SelectedIndex = 1;
               
                     
                    }
  
                }
                
            }
            catch
            {

            }
        }
        public string KeyProvider
        {
            get
            {
                return keyprov.Text.Replace(" Key Provider", "").Replace("Arsslensoft ", "");
            }
        }
        public bool GenerateKey()
        {
            if (!InvokeRequired)
            {
                if (superValidator1.Validate())
                {
                    bind.SignatureAlgorithm = bind.GetMessageDigest( ((ComboItem)sigalg.SelectedItem).Value.ToString());
                    bind.KeyProvider = keyprov.Text.Replace(" Key Provider", "").Replace("Arsslensoft ", "");
                    bind.KeySize = int.Parse(keysize.Text);

                    bind.Generate();
                    return true;
                }
             
                return false;
            }
            else return (bool)Invoke(new OCT.NameFrm.InvokeBoolInterThread(GenerateKey));
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
           
        }

    }
}