namespace OCT
{
    partial class AboutCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutCtrl));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(21, 184);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(636, 188);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = resources.GetString("labelX1.Text");
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // reflectionImage1
            // 
            this.reflectionImage1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage1.Image")));
            this.reflectionImage1.Location = new System.Drawing.Point(164, 3);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(369, 175);
            this.reflectionImage1.TabIndex = 3;
            // 
            // AboutCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.reflectionImage1);
            this.Name = "AboutCtrl";
            this.Size = new System.Drawing.Size(656, 372);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
    }
}
