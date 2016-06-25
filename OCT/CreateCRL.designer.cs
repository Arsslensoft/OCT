namespace OCT
{
    partial class CreateCRL
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.superTabControl2 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.progressSteps1 = new DevComponents.DotNetBar.ProgressSteps();
            this.stepItem3 = new DevComponents.DotNetBar.StepItem();
            this.crlControl1 = new OCT.CrlControl();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.stepItem5 = new DevComponents.DotNetBar.StepItem();
            this.cadlg = new System.Windows.Forms.OpenFileDialog();
            this.stepItem6 = new DevComponents.DotNetBar.StepItem();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl2)).BeginInit();
            this.superTabControl2.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // superTabControl2
            // 
            this.superTabControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl2.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl2.ControlBox.MenuBox.Name = "";
            this.superTabControl2.ControlBox.Name = "";
            this.superTabControl2.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl2.ControlBox.MenuBox,
            this.superTabControl2.ControlBox.CloseBox});
            this.superTabControl2.Controls.Add(this.superTabControlPanel1);
            this.superTabControl2.Controls.Add(this.superTabControlPanel2);
            this.superTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl2.ForeColor = System.Drawing.Color.Black;
            this.superTabControl2.Location = new System.Drawing.Point(0, 0);
            this.superTabControl2.Name = "superTabControl2";
            this.superTabControl2.ReorderTabsEnabled = true;
            this.superTabControl2.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControl2.SelectedTabIndex = 0;
            this.superTabControl2.Size = new System.Drawing.Size(927, 377);
            this.superTabControl2.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl2.TabIndex = 5;
            this.superTabControl2.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem2,
            this.superTabItem1,
            this.buttonItem1});
            this.superTabControl2.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.superTabControl2.Text = "Complete";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.AutoScroll = true;
            this.superTabControlPanel1.Controls.Add(this.crlControl1);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 24);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(927, 353);
            this.superTabControlPanel1.TabIndex = 0;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "CRL";
            this.superTabItem1.Visible = false;
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "Generate";
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // progressSteps1
            // 
            this.progressSteps1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.progressSteps1.BackgroundStyle.Class = "ProgressSteps";
            this.progressSteps1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressSteps1.ContainerControlProcessDialogKey = true;
            this.progressSteps1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressSteps1.ForeColor = System.Drawing.Color.Black;
            this.progressSteps1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.stepItem5,
            this.stepItem6,
            this.stepItem3});
            this.progressSteps1.Location = new System.Drawing.Point(0, 377);
            this.progressSteps1.Name = "progressSteps1";
            this.progressSteps1.Size = new System.Drawing.Size(927, 23);
            this.progressSteps1.TabIndex = 4;
            // 
            // stepItem3
            // 
            this.stepItem3.Name = "stepItem3";
            this.stepItem3.SymbolSize = 13F;
            this.stepItem3.Text = "Step 2 : Complete";
            // 
            // crlControl1
            // 
            this.crlControl1.AutoScroll = true;
            this.crlControl1.BackColor = System.Drawing.Color.Transparent;
            this.crlControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crlControl1.Location = new System.Drawing.Point(0, 0);
            this.crlControl1.Name = "crlControl1";
            this.crlControl1.Size = new System.Drawing.Size(927, 353);
            this.crlControl1.TabIndex = 0;
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel2;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "Certificates";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.buttonX2);
            this.superTabControlPanel2.Controls.Add(this.buttonX1);
            this.superTabControlPanel2.Controls.Add(this.textBoxX1);
            this.superTabControlPanel2.Controls.Add(this.labelX1);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 24);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(927, 353);
            this.superTabControlPanel2.TabIndex = 2;
            this.superTabControlPanel2.TabItem = this.superTabItem2;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Enabled = false;
            this.buttonX2.Location = new System.Drawing.Point(830, 91);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(91, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX2.TabIndex = 10;
            this.buttonX2.Text = "View Informations";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(749, 91);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX1.TabIndex = 7;
            this.buttonX1.Text = "Browse";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
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
            this.textBoxX1.Location = new System.Drawing.Point(58, 91);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(675, 20);
            this.textBoxX1.TabIndex = 1;
            this.textBoxX1.WatermarkText = "Choose your CA Certificate PKCS12";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(58, 62);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(675, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "CA Certificate";
            // 
            // stepItem5
            // 
            this.stepItem5.Name = "stepItem5";
            this.stepItem5.SymbolSize = 13F;
            this.stepItem5.Text = "Select CA";
            // 
            // cadlg
            // 
            this.cadlg.FileName = "CA";
            this.cadlg.Filter = "PKCS12|*.p12;*.pfx|Any Supported File|*.*";
            // 
            // stepItem6
            // 
            this.stepItem6.Name = "stepItem6";
            this.stepItem6.SymbolSize = 13F;
            this.stepItem6.Text = "Step 1 : CRL";
            // 
            // CreateCRL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.superTabControl2);
            this.Controls.Add(this.progressSteps1);
            this.Name = "CreateCRL";
            this.Size = new System.Drawing.Size(927, 400);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl2)).EndInit();
            this.superTabControl2.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevComponents.DotNetBar.SuperTabControl superTabControl2;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ProgressSteps progressSteps1;
        private DevComponents.DotNetBar.StepItem stepItem3;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private CrlControl crlControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        private DevComponents.DotNetBar.StepItem stepItem5;
        private System.Windows.Forms.OpenFileDialog cadlg;
        private DevComponents.DotNetBar.StepItem stepItem6;
    }
}
