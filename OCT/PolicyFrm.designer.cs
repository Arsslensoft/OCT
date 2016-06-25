namespace OCT
{
    partial class PolicyFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PolicyFrm));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cps = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.noticeref = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.org = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.textBoxX3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.notice = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.textBoxX4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Policy OID is required");
            this.regularExpressionValidator1 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.regularExpressionValidator2 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.regularExpressionValidator3 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.labelX1.Size = new System.Drawing.Size(422, 21);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Policy Object Identifier *: ";
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
            this.textBoxX1.Location = new System.Drawing.Point(12, 39);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(422, 22);
            this.textBoxX1.TabIndex = 1;
            this.superValidator1.SetValidator1(this.textBoxX1, this.requiredFieldValidator1);
            this.superValidator1.SetValidator2(this.textBoxX1, this.regularExpressionValidator1);
            this.textBoxX1.WatermarkText = "Enter a valid OID";
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
            this.textBoxX2.Enabled = false;
            this.textBoxX2.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.textBoxX2, true);
            this.textBoxX2.Location = new System.Drawing.Point(12, 96);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.PreventEnterBeep = true;
            this.textBoxX2.Size = new System.Drawing.Size(422, 22);
            this.textBoxX2.TabIndex = 2;
            this.superValidator1.SetValidator1(this.textBoxX2, this.regularExpressionValidator2);
            this.textBoxX2.WatermarkText = "Enter a cps url";
            // 
            // cps
            // 
            this.cps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.cps.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cps.ForeColor = System.Drawing.Color.Black;
            this.cps.Location = new System.Drawing.Point(12, 67);
            this.cps.Name = "cps";
            this.cps.Size = new System.Drawing.Size(422, 23);
            this.cps.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cps.TabIndex = 40;
            this.cps.Text = "Certification Practice Statement :";
            this.cps.CheckedChanged += new System.EventHandler(this.cps_CheckedChanged);
            // 
            // noticeref
            // 
            this.noticeref.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.noticeref.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.noticeref.ForeColor = System.Drawing.Color.Black;
            this.noticeref.Location = new System.Drawing.Point(12, 124);
            this.noticeref.Name = "noticeref";
            this.noticeref.Size = new System.Drawing.Size(422, 23);
            this.noticeref.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.noticeref.TabIndex = 10;
            this.noticeref.Text = "Notice Reference";
            this.noticeref.CheckedChanged += new System.EventHandler(this.noticeref_CheckedChanged);
            // 
            // org
            // 
            this.org.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.org.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.org.Enabled = false;
            this.org.ForeColor = System.Drawing.Color.Black;
            this.org.Location = new System.Drawing.Point(23, 153);
            this.org.Name = "org";
            this.org.Size = new System.Drawing.Size(411, 23);
            this.org.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.org.TabIndex = 15;
            this.org.Text = "Organisation :";
            this.org.CheckedChanged += new System.EventHandler(this.org_CheckedChanged);
            // 
            // textBoxX3
            // 
            this.textBoxX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX3.Border.Class = "TextBoxBorder";
            this.textBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX3.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX3.Enabled = false;
            this.textBoxX3.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.textBoxX3, true);
            this.textBoxX3.Location = new System.Drawing.Point(23, 182);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.PreventEnterBeep = true;
            this.textBoxX3.Size = new System.Drawing.Size(411, 22);
            this.textBoxX3.TabIndex = 3;
            this.superValidator1.SetValidator1(this.textBoxX3, this.regularExpressionValidator3);
            this.textBoxX3.WatermarkText = "Enter your organisation name";
            // 
            // notice
            // 
            this.notice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.notice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.notice.Enabled = false;
            this.notice.ForeColor = System.Drawing.Color.Black;
            this.notice.Location = new System.Drawing.Point(23, 210);
            this.notice.Name = "notice";
            this.notice.Size = new System.Drawing.Size(411, 23);
            this.notice.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.notice.TabIndex = 12;
            this.notice.Text = "Notice Text :";
            this.notice.CheckedChanged += new System.EventHandler(this.notice_CheckedChanged);
            // 
            // textBoxX4
            // 
            this.textBoxX4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX4.Border.Class = "TextBoxBorder";
            this.textBoxX4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX4.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX4.Enabled = false;
            this.textBoxX4.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.textBoxX4, true);
            this.textBoxX4.Location = new System.Drawing.Point(23, 239);
            this.textBoxX4.Name = "textBoxX4";
            this.textBoxX4.PreventEnterBeep = true;
            this.textBoxX4.Size = new System.Drawing.Size(411, 22);
            this.textBoxX4.TabIndex = 4;
            this.textBoxX4.WatermarkText = "Enter your notice text";
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Policy OID is required";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // regularExpressionValidator1
            // 
            this.regularExpressionValidator1.ErrorMessage = "Enter a valid OID";
            this.regularExpressionValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator1.ValidationExpression = "\\A[0-2](\\.[0-9]+)+\\z";
            // 
            // regularExpressionValidator2
            // 
            this.regularExpressionValidator2.ErrorMessage = "Enter a valid CPS URL";
            this.regularExpressionValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator2.ValidationExpression = "^(ht|f)tp(s?)\\:\\/\\/[0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*(:(0-9)*)*(\\/?)([a-zA-Z0-9\\-\\." +
    "\\?\\,\\\'\\/\\\\\\+&amp;%\\$#_]*)?$";
            // 
            // regularExpressionValidator3
            // 
            this.regularExpressionValidator3.EmptyValueIsValid = true;
            this.regularExpressionValidator3.ErrorMessage = "Enter a valid organisation name";
            this.regularExpressionValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator3.ValidationExpression = "^[a-zA-Z\'\'-\'\\s]{1,40}$";
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
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(271, 272);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(160, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX1.TabIndex = 5;
            this.buttonX1.Text = "Add Policy";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // PolicyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 305);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.notice);
            this.Controls.Add(this.textBoxX4);
            this.Controls.Add(this.org);
            this.Controls.Add(this.textBoxX3);
            this.Controls.Add(this.noticeref);
            this.Controls.Add(this.cps);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PolicyFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Policy";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.Controls.CheckBoxX cps;
        private DevComponents.DotNetBar.Controls.CheckBoxX noticeref;
        private DevComponents.DotNetBar.Controls.CheckBoxX org;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX3;
        private DevComponents.DotNetBar.Controls.CheckBoxX notice;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX4;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator1;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator2;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator3;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        internal DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
    }
}