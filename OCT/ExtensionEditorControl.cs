using Al.Security.CA;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using DevComponents.Editors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCT
{
    public partial class ExtensionEditorControl : UserControl
    {
        public ExtensionEditorControl()
        {
            InitializeComponent();
        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }
        Node ASNode(ASNElement el)
        {
            Node c = new Node();
            c.Text = el.Name;
            if (!string.IsNullOrEmpty(el.Value))
                c.Text += " : " + el.Value;

            c.Tooltip = "Type : " + el.EType.ToString();
            c.Style = GetNodeStyle(el.EType);
            c.Tag = el;
            return c;
        }
        private void labelX3_Click(object sender, EventArgs e)
        {
            
        }
        ElementStyle GetNodeStyle(ElementType t)
        {
            if (t == ElementType.SEQUENCE)
                return sequencest;
            else if (t == ElementType.BOOLEAN)
                return boolst;
            else if (t == ElementType.INTEGER || t == ElementType.ENUM)
                return integersst;
            else if (t.ToString().ToLower().EndsWith("string"))
                return stringst;
            else
                return defst;

            // strings blue night 4 / green 5
        }
        List<ASNElement> Elements = new List<ASNElement>();
        private void buttonX4_Click(object sender, EventArgs e)
        {
            try
            {
                AddASNElFrm frm = new AddASNElFrm();
                frm.ShowDialog();
                if (frm.ASNEl != null)
                {
                    Node nd = advTree1.SelectedNode;
                    if (nd != null && nd != node1 && nd != node2)
                    {
                        if (nd.Tag != null)
                        {
                            if (nd.Tag is ASNElement)
                            {
                                ASNElement el = (ASNElement)nd.Tag;
                                if (el.EType == ElementType.SEQUENCE)
                                {
                                    if (el.AddElement(frm.ASNEl))
                                    {
                                        Node c = ASNode(frm.ASNEl);
                                        nd.Nodes.Add(c);
                                    }
                                }
                                else Log.ShowInfo("Only Sequence can contain child asn.1 elements", "ADD ASN.1");
                            }
                        }
                    }
                    else if (nd == node2)
                    {
                        Elements.Add(frm.ASNEl);
                        Node c = ASNode(frm.ASNEl);
                        nd.Nodes.Add(c);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.LogEx(ex);
            }
        }
        void AddNodes(Node n,ASNElement e)
        {
                foreach (ASNElement el in e.Childs)
                    {
                        Node nd = ASNode(el);
                        n.Nodes.Add(nd);
                        AddNodes(nd, el);
                    }
        }
        private void buttonX3_Click(object sender, EventArgs e)
        {
            try
            {
                CustomExtension cext = new CustomExtension("");
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    
                    cext.LoadFromXml(openFileDialog1.FileName);
                    textBoxX1.Text = cext.NativeName;
                    Elements = cext.Elements;
                    foreach (ASNElement el in cext.Elements)
                    {
                        Node nd = ASNode(el);
                        node2.Nodes.Add(nd);
                        AddNodes(nd, el);
                    }
                    
                }
            }
            catch(Exception ex)
            {
                Log.ShowInfo(ex.Message,"OPEN EXTENSION");
            }
        }

   
        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                if (superValidator1.Validate())
                {
                    CustomExtension cext = new CustomExtension(textBoxX1.Text);
                    cext.Elements = Elements;
                    if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        cext.SaveXml(saveFileDialog1.FileName);
                }
            }
            catch(Exception ex)
            {
                Log.ShowInfo(ex.Message, "SAVE EXTENSION");
            }
        }

       
    }
}
