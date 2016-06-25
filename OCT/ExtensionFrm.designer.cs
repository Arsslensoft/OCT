namespace OCT
{
    partial class ExtensionFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtensionFrm));
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Value is required");
            this.regularExpressionValidator1 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Value type is required");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Value is required");
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.advTree1 = new DevComponents.AdvTree.AdvTree();
            this.node1 = new DevComponents.AdvTree.Node();
            this.node2 = new DevComponents.AdvTree.Node();
            this.extseqst = new DevComponents.DotNetBar.ElementStyle();
            this.rootextst = new DevComponents.DotNetBar.ElementStyle();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.sequencest = new DevComponents.DotNetBar.ElementStyle();
            this.stringst = new DevComponents.DotNetBar.ElementStyle();
            this.boolst = new DevComponents.DotNetBar.ElementStyle();
            this.integersst = new DevComponents.DotNetBar.ElementStyle();
            this.defst = new DevComponents.DotNetBar.ElementStyle();
            this.node3 = new DevComponents.AdvTree.Node();
            this.elementStyle2 = new DevComponents.DotNetBar.ElementStyle();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).BeginInit();
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
            this.textBoxX1.Location = new System.Drawing.Point(6, 43);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(595, 20);
            this.textBoxX1.TabIndex = 1;
            this.superValidator1.SetValidator1(this.textBoxX1, this.requiredFieldValidator3);
            this.superValidator1.SetValidator2(this.textBoxX1, this.regularExpressionValidator1);
            this.textBoxX1.WatermarkText = "Enter a OID";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(6, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(572, 15);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Object Identifier *: ";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(521, 375);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(105, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX1.TabIndex = 5;
            this.buttonX1.Text = "Add Extension";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "Value is required";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // regularExpressionValidator1
            // 
            this.regularExpressionValidator1.ErrorMessage = "Enter a valid OID";
            this.regularExpressionValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator1.ValidationExpression = "\\A[0-2](\\.[0-9]+)+\\z";
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
            this.requiredFieldValidator1.ErrorMessage = "Value type is required";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Value is required";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(6, 69);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(572, 15);
            this.labelX3.TabIndex = 8;
            this.labelX3.Text = "ASN.1 Structure : ";
            this.labelX3.Click += new System.EventHandler(this.labelX3_Click);
            // 
            // advTree1
            // 
            this.advTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTree1.AllowDrop = true;
            this.advTree1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.advTree1.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTree1.ForeColor = System.Drawing.Color.Black;
            this.advTree1.Location = new System.Drawing.Point(12, 90);
            this.advTree1.Name = "advTree1";
            this.advTree1.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node1});
            this.advTree1.NodesConnector = this.nodeConnector1;
            this.advTree1.NodeStyle = this.elementStyle1;
            this.advTree1.PathSeparator = ";";
            this.advTree1.Size = new System.Drawing.Size(614, 279);
            this.advTree1.Styles.Add(this.elementStyle1);
            this.advTree1.Styles.Add(this.rootextst);
            this.advTree1.Styles.Add(this.extseqst);
            this.advTree1.Styles.Add(this.sequencest);
            this.advTree1.Styles.Add(this.stringst);
            this.advTree1.Styles.Add(this.boolst);
            this.advTree1.Styles.Add(this.integersst);
            this.advTree1.Styles.Add(this.defst);
            this.advTree1.TabIndex = 11;
            this.advTree1.Text = "advTree1";
            // 
            // node1
            // 
            this.node1.Expanded = true;
            this.node1.Name = "node1";
            this.node1.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node2});
            this.node1.Style = this.rootextst;
            this.node1.Text = "Extension";
            // 
            // node2
            // 
            this.node2.Name = "node2";
            this.node2.Style = this.extseqst;
            this.node2.Text = "Extension Sequence";
            // 
            // extseqst
            // 
            this.extseqst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.extseqst.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(224)))), ((int)(((byte)(252)))));
            this.extseqst.BackColorGradientAngle = 90;
            this.extseqst.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.extseqst.BorderBottomWidth = 1;
            this.extseqst.BorderColor = System.Drawing.Color.DarkGray;
            this.extseqst.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.extseqst.BorderLeftWidth = 1;
            this.extseqst.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.extseqst.BorderRightWidth = 1;
            this.extseqst.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.extseqst.BorderTopWidth = 1;
            this.extseqst.CornerDiameter = 4;
            this.extseqst.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.extseqst.Description = "BlueLight";
            this.extseqst.Name = "extseqst";
            this.extseqst.PaddingBottom = 1;
            this.extseqst.PaddingLeft = 1;
            this.extseqst.PaddingRight = 1;
            this.extseqst.PaddingTop = 1;
            this.extseqst.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(84)))), ((int)(((byte)(115)))));
            // 
            // rootextst
            // 
            this.rootextst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.rootextst.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.rootextst.BackColorGradientAngle = 90;
            this.rootextst.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.rootextst.BorderBottomWidth = 1;
            this.rootextst.BorderColor = System.Drawing.Color.DarkGray;
            this.rootextst.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.rootextst.BorderLeftWidth = 1;
            this.rootextst.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.rootextst.BorderRightWidth = 1;
            this.rootextst.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.rootextst.BorderTopWidth = 1;
            this.rootextst.CornerDiameter = 4;
            this.rootextst.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.rootextst.Description = "Blue";
            this.rootextst.Name = "rootextst";
            this.rootextst.PaddingBottom = 1;
            this.rootextst.PaddingLeft = 1;
            this.rootextst.PaddingRight = 1;
            this.rootextst.PaddingTop = 1;
            this.rootextst.TextColor = System.Drawing.Color.Black;
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.Color.Black;
            // 
            // sequencest
            // 
            this.sequencest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(108)))), ((int)(((byte)(152)))));
            this.sequencest.BackColor2 = System.Drawing.Color.Navy;
            this.sequencest.BackColorGradientAngle = 90;
            this.sequencest.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.sequencest.BorderBottomWidth = 1;
            this.sequencest.BorderColor = System.Drawing.Color.Navy;
            this.sequencest.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.sequencest.BorderLeftWidth = 1;
            this.sequencest.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.sequencest.BorderRightWidth = 1;
            this.sequencest.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.sequencest.BorderTopWidth = 1;
            this.sequencest.CornerDiameter = 4;
            this.sequencest.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.sequencest.Description = "BlueNight";
            this.sequencest.Name = "sequencest";
            this.sequencest.PaddingBottom = 1;
            this.sequencest.PaddingLeft = 1;
            this.sequencest.PaddingRight = 1;
            this.sequencest.PaddingTop = 1;
            this.sequencest.TextColor = System.Drawing.Color.White;
            // 
            // stringst
            // 
            this.stringst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.stringst.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(149)))), ((int)(((byte)(151)))));
            this.stringst.BackColorGradientAngle = 90;
            this.stringst.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.stringst.BorderBottomWidth = 1;
            this.stringst.BorderColor = System.Drawing.Color.DarkGray;
            this.stringst.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.stringst.BorderLeftWidth = 1;
            this.stringst.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.stringst.BorderRightWidth = 1;
            this.stringst.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.stringst.BorderTopWidth = 1;
            this.stringst.CornerDiameter = 4;
            this.stringst.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.stringst.Description = "Red";
            this.stringst.Name = "stringst";
            this.stringst.PaddingBottom = 1;
            this.stringst.PaddingLeft = 1;
            this.stringst.PaddingRight = 1;
            this.stringst.PaddingTop = 1;
            this.stringst.TextColor = System.Drawing.Color.Black;
            // 
            // boolst
            // 
            this.boolst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.boolst.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(188)))), ((int)(((byte)(202)))));
            this.boolst.BackColorGradientAngle = 90;
            this.boolst.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.boolst.BorderBottomWidth = 1;
            this.boolst.BorderColor = System.Drawing.Color.DarkGray;
            this.boolst.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.boolst.BorderLeftWidth = 1;
            this.boolst.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.boolst.BorderRightWidth = 1;
            this.boolst.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.boolst.BorderTopWidth = 1;
            this.boolst.CornerDiameter = 4;
            this.boolst.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.boolst.Description = "Teal";
            this.boolst.Name = "boolst";
            this.boolst.PaddingBottom = 1;
            this.boolst.PaddingLeft = 1;
            this.boolst.PaddingRight = 1;
            this.boolst.PaddingTop = 1;
            this.boolst.TextColor = System.Drawing.Color.Black;
            // 
            // integersst
            // 
            this.integersst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.integersst.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(158)))), ((int)(((byte)(222)))));
            this.integersst.BackColorGradientAngle = 90;
            this.integersst.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.integersst.BorderBottomWidth = 1;
            this.integersst.BorderColor = System.Drawing.Color.DarkGray;
            this.integersst.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.integersst.BorderLeftWidth = 1;
            this.integersst.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.integersst.BorderRightWidth = 1;
            this.integersst.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.integersst.BorderTopWidth = 1;
            this.integersst.CornerDiameter = 4;
            this.integersst.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.integersst.Description = "Purple";
            this.integersst.Name = "integersst";
            this.integersst.PaddingBottom = 1;
            this.integersst.PaddingLeft = 1;
            this.integersst.PaddingRight = 1;
            this.integersst.PaddingTop = 1;
            this.integersst.TextColor = System.Drawing.Color.Black;
            // 
            // defst
            // 
            this.defst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(226)))));
            this.defst.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(201)))), ((int)(((byte)(151)))));
            this.defst.BackColorGradientAngle = 90;
            this.defst.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.defst.BorderBottomWidth = 1;
            this.defst.BorderColor = System.Drawing.Color.DarkGray;
            this.defst.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.defst.BorderLeftWidth = 1;
            this.defst.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.defst.BorderRightWidth = 1;
            this.defst.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.defst.BorderTopWidth = 1;
            this.defst.CornerDiameter = 4;
            this.defst.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.defst.Description = "Green";
            this.defst.Name = "defst";
            this.defst.PaddingBottom = 1;
            this.defst.PaddingLeft = 1;
            this.defst.PaddingRight = 1;
            this.defst.PaddingTop = 1;
            this.defst.TextColor = System.Drawing.Color.Black;
            // 
            // node3
            // 
            this.node3.Expanded = true;
            this.node3.Name = "node3";
            this.node3.Style = this.elementStyle2;
            this.node3.Text = "node3";
            // 
            // elementStyle2
            // 
            this.elementStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(226)))));
            this.elementStyle2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(201)))), ((int)(((byte)(151)))));
            this.elementStyle2.BackColorGradientAngle = 90;
            this.elementStyle2.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderBottomWidth = 1;
            this.elementStyle2.BorderColor = System.Drawing.Color.DarkGray;
            this.elementStyle2.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderLeftWidth = 1;
            this.elementStyle2.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderRightWidth = 1;
            this.elementStyle2.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderTopWidth = 1;
            this.elementStyle2.CornerDiameter = 4;
            this.elementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle2.Description = "Green";
            this.elementStyle2.Name = "elementStyle2";
            this.elementStyle2.PaddingBottom = 1;
            this.elementStyle2.PaddingLeft = 1;
            this.elementStyle2.PaddingRight = 1;
            this.elementStyle2.PaddingTop = 1;
            this.elementStyle2.TextColor = System.Drawing.Color.Black;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(410, 375);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(105, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX2.TabIndex = 4;
            this.buttonX2.Text = "Save Extension";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(299, 375);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(105, 23);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX3.TabIndex = 3;
            this.buttonX3.Text = "Load Extension";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Origisign X509 Extension|*.ocext";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Origisign X509 Extension|*.ocext";
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Location = new System.Drawing.Point(188, 375);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(105, 23);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX4.TabIndex = 2;
            this.buttonX4.Text = "Add Element";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // ExtensionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 406);
            this.Controls.Add(this.buttonX4);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.advTree1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExtensionFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New X509 Extension";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.AdvTree.AdvTree advTree1;
        private DevComponents.AdvTree.Node node1;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.AdvTree.Node node2;
        private DevComponents.DotNetBar.ElementStyle extseqst;
        private DevComponents.DotNetBar.ElementStyle rootextst;
        private DevComponents.AdvTree.Node node3;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ElementStyle sequencest;
        private DevComponents.DotNetBar.ElementStyle stringst;
        private DevComponents.DotNetBar.ElementStyle integersst;
        private DevComponents.DotNetBar.ElementStyle boolst;
        private DevComponents.DotNetBar.ElementStyle defst;
        private DevComponents.DotNetBar.ElementStyle elementStyle2;
    }
}