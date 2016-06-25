namespace OCT
{
    partial class CertExportFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CertExportFrm));
            this.cert = new System.Windows.Forms.CheckBox();
            this.pem = new System.Windows.Forms.CheckBox();
            this.pfx = new System.Windows.Forms.CheckBox();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.c = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cert
            // 
            this.cert.AutoSize = true;
            this.cert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cert.ForeColor = System.Drawing.Color.Black;
            this.cert.Location = new System.Drawing.Point(12, 31);
            this.cert.Name = "cert";
            this.cert.Size = new System.Drawing.Size(102, 17);
            this.cert.TabIndex = 0;
            this.cert.Text = "Certificate (cer)";
            this.cert.UseVisualStyleBackColor = false;
            // 
            // pem
            // 
            this.pem.AutoSize = true;
            this.pem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pem.ForeColor = System.Drawing.Color.Black;
            this.pem.Location = new System.Drawing.Point(12, 54);
            this.pem.Name = "pem";
            this.pem.Size = new System.Drawing.Size(151, 17);
            this.pem.TabIndex = 2;
            this.pem.Text = "PEM Encoded (OpenSSL)";
            this.pem.UseVisualStyleBackColor = false;
            // 
            // pfx
            // 
            this.pfx.AutoSize = true;
            this.pfx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pfx.ForeColor = System.Drawing.Color.Black;
            this.pfx.Location = new System.Drawing.Point(12, 77);
            this.pfx.Name = "pfx";
            this.pfx.Size = new System.Drawing.Size(79, 17);
            this.pfx.TabIndex = 3;
            this.pfx.Text = "Pfx/Pkcs12";
            this.pfx.UseVisualStyleBackColor = false;
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
            this.textBoxX1.Location = new System.Drawing.Point(12, 129);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(302, 22);
            this.textBoxX1.TabIndex = 5;
            this.textBoxX1.UseSystemPasswordChar = true;
            this.textBoxX1.WatermarkText = "Enter password if you use Pfx/PKCS12 and PEM Key";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(12, 100);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(310, 23);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Password : ";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(249, 212);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX1.TabIndex = 7;
            this.buttonX1.Text = "Export";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(164, 212);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(79, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX2.TabIndex = 8;
            this.buttonX2.Text = "View";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // c
            // 
            this.c.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.c.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.c.DisplayMember = "Text";
            this.c.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.c.ForeColor = System.Drawing.Color.Black;
            this.c.FormattingEnabled = true;
            this.highlighter1.SetHighlightOnFocus(this.c, true);
            this.c.ItemHeight = 16;
            this.c.Location = new System.Drawing.Point(12, 182);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(302, 22);
            this.c.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.c.TabIndex = 24;
            this.c.WatermarkText = "Choose your country";
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.ForeColor = System.Drawing.Color.Black;
            this.labelX10.Location = new System.Drawing.Point(12, 157);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(291, 19);
            this.labelX10.TabIndex = 23;
            this.labelX10.Text = "PEM Key Encryption Cipher";
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
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
            // CertExportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 247);
            this.Controls.Add(this.c);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.pfx);
            this.Controls.Add(this.pem);
            this.Controls.Add(this.cert);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CertExportFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certificate Export";
            this.Load += new System.EventHandler(this.CertExportFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cert;
        private System.Windows.Forms.CheckBox pem;
        private System.Windows.Forms.CheckBox pfx;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx c;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
    }
}