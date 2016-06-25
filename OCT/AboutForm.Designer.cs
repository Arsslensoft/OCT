namespace OCT
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.aboutCtrl1 = new OCT.AboutCtrl();
            this.SuspendLayout();
            // 
            // aboutCtrl1
            // 
            this.aboutCtrl1.BackColor = System.Drawing.Color.Transparent;
            this.aboutCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutCtrl1.Location = new System.Drawing.Point(0, 0);
            this.aboutCtrl1.Name = "aboutCtrl1";
            this.aboutCtrl1.Size = new System.Drawing.Size(625, 375);
            this.aboutCtrl1.TabIndex = 0;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 375);
            this.Controls.Add(this.aboutCtrl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Origisign Certification Tool";
            this.ResumeLayout(false);

        }

        #endregion

        private AboutCtrl aboutCtrl1;
    }
}