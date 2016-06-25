namespace OCT
{
    partial class AddASNElFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddASNElFrm));
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxEx2 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator6 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Name is required");
            this.requiredFieldValidator5 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Value is required");
            this.requiredFieldValidator4 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Element type is required");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxX1
            // 
            this.textBoxX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX1.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.textBoxX1, true);
            this.textBoxX1.Location = new System.Drawing.Point(12, 33);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(420, 22);
            this.textBoxX1.TabIndex = 1;
            this.superValidator1.SetValidator1(this.textBoxX1, this.requiredFieldValidator6);
            this.textBoxX1.WatermarkText = "Enter a Name";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(191, 15);
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "Name *: ";
            // 
            // textBoxX2
            // 
            this.textBoxX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX2.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.textBoxX2, true);
            this.textBoxX2.Location = new System.Drawing.Point(12, 82);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.PreventEnterBeep = true;
            this.textBoxX2.Size = new System.Drawing.Size(420, 22);
            this.textBoxX2.TabIndex = 2;
            this.superValidator1.SetValidator1(this.textBoxX2, this.requiredFieldValidator5);
            this.textBoxX2.WatermarkText = "Enter a Value";
            this.textBoxX2.TextChanged += new System.EventHandler(this.textBoxX2_TextChanged);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(12, 61);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(191, 15);
            this.labelX2.TabIndex = 10;
            this.labelX2.Text = "Value *: ";
            // 
            // comboBoxEx2
            // 
            this.comboBoxEx2.AutoCompleteCustomSource.AddRange(new string[] {
            "BOOLEAN",
            "NULL",
            "INTEGER ",
            "ENUM",
            "OID ",
            "UTCTIME",
            "GENERALIZEDTIME",
            "OCTETSTRING",
            "BITSTRING",
            "UNIVERSALSTRING",
            "IA5STRING ",
            "UTF8String ",
            "BMPSTRING ",
            "VISIBLESTRING ",
            "PRINTABLESTRING",
            "T61STRING ",
            "TELETEXSTRING",
            "GeneralString",
            "NUMERICSTRING",
            "NUMERIC",
            "SEQUENCE"});
            this.comboBoxEx2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxEx2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEx2.DisplayMember = "Text";
            this.comboBoxEx2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx2.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx2.FormattingEnabled = true;
            this.highlighter1.SetHighlightOnFocus(this.comboBoxEx2, true);
            this.comboBoxEx2.ItemHeight = 16;
            this.comboBoxEx2.Location = new System.Drawing.Point(12, 131);
            this.comboBoxEx2.Name = "comboBoxEx2";
            this.comboBoxEx2.Size = new System.Drawing.Size(420, 22);
            this.comboBoxEx2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.comboBoxEx2.TabIndex = 3;
            this.superValidator1.SetValidator1(this.comboBoxEx2, this.requiredFieldValidator4);
            this.comboBoxEx2.WatermarkText = "Choose your type";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(12, 110);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(420, 15);
            this.labelX3.TabIndex = 13;
            this.labelX3.Text = "Element Type* : ";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(327, 174);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(105, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX1.TabIndex = 4;
            this.buttonX1.Text = "Add";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // requiredFieldValidator6
            // 
            this.requiredFieldValidator6.ErrorMessage = "Name is required";
            this.requiredFieldValidator6.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator5
            // 
            this.requiredFieldValidator5.ErrorMessage = "Value is required";
            this.requiredFieldValidator5.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.ErrorMessage = "Element type is required";
            this.requiredFieldValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(12, 174);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(276, 35);
            this.labelX4.TabIndex = 15;
            this.labelX4.Text = "Note : Please respect the type value to prevent unknow <br/>errors in certificate" +
    " generation";
            // 
            // AddASNElFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 203);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.comboBoxEx2);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddASNElFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add ASN.1 Element";
            this.Load += new System.EventHandler(this.AddASNElFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX1;
        internal DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.LabelX labelX2;
        internal DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator4;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator5;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator6;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private DevComponents.DotNetBar.LabelX labelX4;
    }
}