namespace OCT
{
    partial class GeneralNameFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralNameFrm));
            this.comboBoxEx2 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("You should enter a value");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEx2
            // 
            this.comboBoxEx2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxEx2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEx2.DisplayMember = "Text";
            this.comboBoxEx2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx2.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx2.FormattingEnabled = true;
            this.highlighter1.SetHighlightOnFocus(this.comboBoxEx2, true);
            this.comboBoxEx2.ItemHeight = 16;
            this.comboBoxEx2.Location = new System.Drawing.Point(12, 33);
            this.comboBoxEx2.Name = "comboBoxEx2";
            this.comboBoxEx2.Size = new System.Drawing.Size(327, 22);
            this.comboBoxEx2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.comboBoxEx2.TabIndex = 1;
            this.comboBoxEx2.WatermarkText = "Choose your type";
            this.comboBoxEx2.SelectedIndexChanged += new System.EventHandler(this.comboBoxEx2_SelectedIndexChanged);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(12, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(327, 15);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Type* : ";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(12, 61);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(327, 15);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Value *: ";
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
            this.textBoxX1.Location = new System.Drawing.Point(12, 82);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(327, 22);
            this.textBoxX1.TabIndex = 2;
            this.superValidator1.SetValidator1(this.textBoxX1, this.requiredFieldValidator2);
            this.textBoxX1.WatermarkText = "Enter a value";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(243, 129);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(96, 23);
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
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "You should enter a value";
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
            // checkBoxX1
            // 
            this.checkBoxX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX1.ForeColor = System.Drawing.Color.Black;
            this.checkBoxX1.Location = new System.Drawing.Point(12, 129);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.Size = new System.Drawing.Size(225, 23);
            this.checkBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.checkBoxX1.TabIndex = 3;
            this.checkBoxX1.Text = "Is OCSP ?";
            this.checkBoxX1.Visible = false;
            // 
            // GeneralNameFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 153);
            this.Controls.Add(this.checkBoxX1);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.comboBoxEx2);
            this.Controls.Add(this.labelX2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GeneralNameFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "X509 Global Name";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        internal DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx2;
        internal DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        internal DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;

    }
}