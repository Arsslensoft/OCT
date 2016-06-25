namespace OCT
{
    partial class CreateCertCtrl
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
            this.superTabControl2 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel6 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.extentionsfrm1 = new OCT.Extentionsfrm();
            this.superTabItem6 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.nameFrm1 = new OCT.NameFrm();
            this.superTabItem4 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel5 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.keyGenerationFrm1 = new OCT.KeyGenerationFrm();
            this.superTabItem5 = new DevComponents.DotNetBar.SuperTabItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.progressSteps1 = new DevComponents.DotNetBar.ProgressSteps();
            this.stepItem1 = new DevComponents.DotNetBar.StepItem();
            this.stepItem2 = new DevComponents.DotNetBar.StepItem();
            this.stepItem3 = new DevComponents.DotNetBar.StepItem();
            this.stepItem4 = new DevComponents.DotNetBar.StepItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.configbox = new DevComponents.DotNetBar.CheckBoxItem();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl2)).BeginInit();
            this.superTabControl2.SuspendLayout();
            this.superTabControlPanel6.SuspendLayout();
            this.superTabControlPanel4.SuspendLayout();
            this.superTabControlPanel5.SuspendLayout();
            this.SuspendLayout();
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
            this.superTabControl2.Controls.Add(this.superTabControlPanel4);
            this.superTabControl2.Controls.Add(this.superTabControlPanel6);
            this.superTabControl2.Controls.Add(this.superTabControlPanel5);
            this.superTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl2.ForeColor = System.Drawing.Color.Black;
            this.superTabControl2.Location = new System.Drawing.Point(0, 0);
            this.superTabControl2.Name = "superTabControl2";
            this.superTabControl2.ReorderTabsEnabled = true;
            this.superTabControl2.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControl2.SelectedTabIndex = 0;
            this.superTabControl2.Size = new System.Drawing.Size(851, 501);
            this.superTabControl2.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl2.TabIndex = 3;
            this.superTabControl2.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem4,
            this.superTabItem5,
            this.superTabItem6,
            this.buttonItem1,
            this.buttonItem2,
            this.configbox});
            this.superTabControl2.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.superTabControl2.Text = "Complete";
            // 
            // superTabControlPanel6
            // 
            this.superTabControlPanel6.Controls.Add(this.extentionsfrm1);
            this.superTabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel6.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanel6.Name = "superTabControlPanel6";
            this.superTabControlPanel6.Size = new System.Drawing.Size(851, 501);
            this.superTabControlPanel6.TabIndex = 0;
            this.superTabControlPanel6.TabItem = this.superTabItem6;
            // 
            // extentionsfrm1
            // 
            this.extentionsfrm1.BackColor = System.Drawing.Color.Transparent;
            this.extentionsfrm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extentionsfrm1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extentionsfrm1.ForeColor = System.Drawing.Color.Black;
            this.extentionsfrm1.Location = new System.Drawing.Point(0, 0);
            this.extentionsfrm1.Name = "extentionsfrm1";
            this.extentionsfrm1.Size = new System.Drawing.Size(851, 501);
            this.extentionsfrm1.TabIndex = 0;
            // 
            // superTabItem6
            // 
            this.superTabItem6.AttachedControl = this.superTabControlPanel6;
            this.superTabItem6.GlobalItem = false;
            this.superTabItem6.Name = "superTabItem6";
            this.superTabItem6.Text = "X.509 Extensions";
            // 
            // superTabControlPanel4
            // 
            this.superTabControlPanel4.Controls.Add(this.nameFrm1);
            this.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel4.Location = new System.Drawing.Point(0, 24);
            this.superTabControlPanel4.Name = "superTabControlPanel4";
            this.superTabControlPanel4.Size = new System.Drawing.Size(851, 477);
            this.superTabControlPanel4.TabIndex = 1;
            this.superTabControlPanel4.TabItem = this.superTabItem4;
            // 
            // nameFrm1
            // 
            this.nameFrm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nameFrm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameFrm1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameFrm1.ForeColor = System.Drawing.Color.Black;
            this.nameFrm1.Location = new System.Drawing.Point(0, 0);
            this.nameFrm1.Name = "nameFrm1";
            this.nameFrm1.Size = new System.Drawing.Size(851, 477);
            this.nameFrm1.TabIndex = 0;
            // 
            // superTabItem4
            // 
            this.superTabItem4.AttachedControl = this.superTabControlPanel4;
            this.superTabItem4.GlobalItem = false;
            this.superTabItem4.Name = "superTabItem4";
            this.superTabItem4.Text = "Certificate Informations";
            // 
            // superTabControlPanel5
            // 
            this.superTabControlPanel5.Controls.Add(this.keyGenerationFrm1);
            this.superTabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel5.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanel5.Name = "superTabControlPanel5";
            this.superTabControlPanel5.Size = new System.Drawing.Size(851, 501);
            this.superTabControlPanel5.TabIndex = 0;
            this.superTabControlPanel5.TabItem = this.superTabItem5;
            // 
            // keyGenerationFrm1
            // 
            this.keyGenerationFrm1.BackColor = System.Drawing.Color.Transparent;
            this.keyGenerationFrm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyGenerationFrm1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyGenerationFrm1.ForeColor = System.Drawing.Color.Black;
            this.keyGenerationFrm1.Location = new System.Drawing.Point(0, 0);
            this.keyGenerationFrm1.Name = "keyGenerationFrm1";
            this.keyGenerationFrm1.Size = new System.Drawing.Size(851, 501);
            this.keyGenerationFrm1.TabIndex = 0;
            // 
            // superTabItem5
            // 
            this.superTabItem5.AttachedControl = this.superTabControlPanel5;
            this.superTabItem5.GlobalItem = false;
            this.superTabItem5.Name = "superTabItem5";
            this.superTabItem5.Text = "Key Configuration";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "Generate";
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "Reset Generator";
            this.buttonItem2.Click += new System.EventHandler(this.buttonItem2_Click);
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
            this.stepItem1,
            this.stepItem2,
            this.stepItem3,
            this.stepItem4});
            this.progressSteps1.Location = new System.Drawing.Point(0, 501);
            this.progressSteps1.Name = "progressSteps1";
            this.progressSteps1.Size = new System.Drawing.Size(851, 23);
            this.progressSteps1.TabIndex = 2;
            // 
            // stepItem1
            // 
            this.stepItem1.Name = "stepItem1";
            this.stepItem1.ProgressColors = new System.Drawing.Color[0];
            this.stepItem1.SymbolSize = 13F;
            this.stepItem1.Text = "Step 1: Certificate Informations";
            // 
            // stepItem2
            // 
            this.stepItem2.Name = "stepItem2";
            this.stepItem2.SymbolSize = 13F;
            this.stepItem2.Text = "Step 2 : Key Configuration";
            // 
            // stepItem3
            // 
            this.stepItem3.Name = "stepItem3";
            this.stepItem3.SymbolSize = 13F;
            this.stepItem3.Text = "Step 3 : X.509 Extensions";
            // 
            // stepItem4
            // 
            this.stepItem4.Name = "stepItem4";
            this.stepItem4.SymbolSize = 13F;
            this.stepItem4.Text = "Step 4 : Complete";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // configbox
            // 
            this.configbox.Name = "configbox";
            this.configbox.Text = "Do not generate a config";
            // 
            // CreateCertCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.superTabControl2);
            this.Controls.Add(this.progressSteps1);
            this.Name = "CreateCertCtrl";
            this.Size = new System.Drawing.Size(851, 524);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl2)).EndInit();
            this.superTabControl2.ResumeLayout(false);
            this.superTabControlPanel6.ResumeLayout(false);
            this.superTabControlPanel4.ResumeLayout(false);
            this.superTabControlPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperTabControl superTabControl2;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel4;
        private NameFrm nameFrm1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem4;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel6;
        private Extentionsfrm extentionsfrm1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem6;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel5;
        private KeyGenerationFrm keyGenerationFrm1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem5;
        private DevComponents.DotNetBar.ProgressSteps progressSteps1;
        private DevComponents.DotNetBar.StepItem stepItem1;
        private DevComponents.DotNetBar.StepItem stepItem2;
        private DevComponents.DotNetBar.StepItem stepItem3;
        private DevComponents.DotNetBar.StepItem stepItem4;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.CheckBoxItem configbox;
    }
}
