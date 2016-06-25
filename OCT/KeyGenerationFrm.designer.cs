namespace OCT
{
    partial class KeyGenerationFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Arsslensoft RSA Key Provider");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Arsslensoft DSA Key Provider");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyGenerationFrm));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.serialnumber = new DevComponents.Editors.IntegerInput();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.sigalg = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.keysize = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.keyprov = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.itemPanel1 = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Select a signature algorithm");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Select a key size");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.panelEx1.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialnumber)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.CanvasColor = System.Drawing.Color.Transparent;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupPanel3);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(552, 371);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // groupPanel3
            // 
            this.groupPanel3.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.serialnumber);
            this.groupPanel3.Controls.Add(this.labelX5);
            this.groupPanel3.Controls.Add(this.sigalg);
            this.groupPanel3.Controls.Add(this.labelX4);
            this.groupPanel3.Controls.Add(this.keysize);
            this.groupPanel3.Controls.Add(this.labelX2);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel3.Location = new System.Drawing.Point(0, 141);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(552, 215);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 2;
            this.groupPanel3.Text = "Key Data";
            // 
            // serialnumber
            // 
            // 
            // 
            // 
            this.serialnumber.BackgroundStyle.Class = "DateTimeInputBackground";
            this.serialnumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.serialnumber.ButtonCalculator.Tooltip = "";
            this.serialnumber.ButtonClear.Tooltip = "";
            this.serialnumber.ButtonCustom.Tooltip = "";
            this.serialnumber.ButtonCustom2.Tooltip = "";
            this.serialnumber.ButtonDropDown.Tooltip = "";
            this.serialnumber.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.serialnumber.ButtonFreeText.Tooltip = "";
            this.highlighter1.SetHighlightOnFocus(this.serialnumber, true);
            this.serialnumber.Location = new System.Drawing.Point(9, 137);
            this.serialnumber.Name = "serialnumber";
            this.serialnumber.ShowUpDown = true;
            this.serialnumber.Size = new System.Drawing.Size(493, 22);
            this.serialnumber.TabIndex = 9;
            this.serialnumber.WatermarkText = "Enter Serial Number (Auto Generated If not defined)";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(9, 109);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(347, 22);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "Serial Number : ";
            // 
            // sigalg
            // 
            this.sigalg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.sigalg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.sigalg.DisplayMember = "Text";
            this.sigalg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sigalg.FormattingEnabled = true;
            this.sigalg.ItemHeight = 16;
            this.sigalg.Location = new System.Drawing.Point(3, 81);
            this.sigalg.Name = "sigalg";
            this.sigalg.Size = new System.Drawing.Size(499, 22);
            this.sigalg.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.sigalg.TabIndex = 7;
            this.superValidator1.SetValidator1(this.sigalg, this.requiredFieldValidator3);
            this.sigalg.WatermarkText = "Select a signature algorithm";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(9, 53);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(347, 22);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "Signature Algorithm : ";
            // 
            // keysize
            // 
            this.keysize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.keysize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.keysize.DisplayMember = "Text";
            this.keysize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.keysize.FormattingEnabled = true;
            this.keysize.ItemHeight = 16;
            this.keysize.Location = new System.Drawing.Point(9, 25);
            this.keysize.Name = "keysize";
            this.keysize.Size = new System.Drawing.Size(493, 22);
            this.keysize.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.keysize.TabIndex = 3;
            this.superValidator1.SetValidator1(this.keysize, this.requiredFieldValidator2);
            this.keysize.WatermarkText = "Select your key size";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(9, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(347, 16);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Key Size : ";
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.keyprov);
            this.groupPanel1.Controls.Add(this.itemPanel1);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(552, 141);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Key Pair Provider";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(9, 85);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(130, 16);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Select your key provider :";
            // 
            // keyprov
            // 
            this.keyprov.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.keyprov.Border.Class = "TextBoxBorder";
            this.keyprov.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.keyprov.ButtonCustom.Tooltip = "";
            this.keyprov.ButtonCustom2.Tooltip = "";
            this.keyprov.DisabledBackColor = System.Drawing.Color.White;
            this.keyprov.Enabled = false;
            this.keyprov.ForeColor = System.Drawing.Color.Black;
            this.keyprov.Location = new System.Drawing.Point(145, 84);
            this.keyprov.Name = "keyprov";
            this.keyprov.PreventEnterBeep = true;
            this.keyprov.Size = new System.Drawing.Size(357, 22);
            this.keyprov.TabIndex = 2;
            this.keyprov.WatermarkText = "Select a key pair provider";
            // 
            // itemPanel1
            // 
            this.itemPanel1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.itemPanel1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.itemPanel1.ForeColor = System.Drawing.Color.Black;
            this.itemPanel1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.itemPanel1.Location = new System.Drawing.Point(9, 25);
            this.itemPanel1.MultiSelect = false;
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(493, 53);
            this.itemPanel1.TabIndex = 1;
            this.itemPanel1.Text = "itemPanel1";
            this.itemPanel1.UseCompatibleStateImageBehavior = false;
            this.itemPanel1.View = System.Windows.Forms.View.List;
            this.itemPanel1.SelectedIndexChanged += new System.EventHandler(this.itemPanel1_SelectedIndexChanged);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(9, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(157, 16);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Select your key provider :";
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "Select a signature algorithm";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Select a key size";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // KeyGenerationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "KeyGenerationFrm";
            this.Size = new System.Drawing.Size(552, 371);
            this.panelEx1.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serialnumber)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ListViewEx itemPanel1;
        private  System.Windows.Forms.ListViewItem RSA;
        private  System.Windows.Forms.ListViewItem DSA;
        private  System.Windows.Forms.ListViewItem ECDSA_P192;
        private  System.Windows.Forms.ListViewItem ECDSA_P224;
        private  System.Windows.Forms.ListViewItem ECDSA_P256;
        private  System.Windows.Forms.ListViewItem ECDSA_P384;
        private  System.Windows.Forms.ListViewItem ECDSA_P521;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX keyprov;
        private DevComponents.DotNetBar.Controls.ComboBoxEx keysize;
        private DevComponents.DotNetBar.Controls.ComboBoxEx sigalg;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private  System.Windows.Forms.ListViewItem ECDSA_B571;
        private  System.Windows.Forms.ListViewItem ECDSA_B163;
        private  System.Windows.Forms.ListViewItem ECDSA_B233;
        private  System.Windows.Forms.ListViewItem ECDSA_B283;
        private System.Windows.Forms.ListViewItem ECDSA_B409;
        private DevComponents.DotNetBar.LabelX labelX5;
        internal DevComponents.Editors.IntegerInput serialnumber;
    }
}