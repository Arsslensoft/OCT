namespace OCT
{
    partial class CrlControl
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX23 = new DevComponents.DotNetBar.LabelX();
            this.nextupdtime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX22 = new DevComponents.DotNetBar.LabelX();
            this.updtime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.revtime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextupdtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revtime)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelEx1.Controls.Add(this.labelX4);
            this.panelEx1.Controls.Add(this.revtime);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.comboBox1);
            this.panelEx1.Controls.Add(this.buttonX4);
            this.panelEx1.Controls.Add(this.buttonX3);
            this.panelEx1.Controls.Add(this.buttonX2);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.textBoxX1);
            this.panelEx1.Controls.Add(this.buttonX1);
            this.panelEx1.Controls.Add(this.labelX23);
            this.panelEx1.Controls.Add(this.nextupdtime);
            this.panelEx1.Controls.Add(this.labelX22);
            this.panelEx1.Controls.Add(this.updtime);
            this.panelEx1.Controls.Add(this.itemPanel1);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(829, 555);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(0, 340);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(372, 19);
            this.labelX3.TabIndex = 37;
            this.labelX3.Text = "Crl Reason";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Unspecified",
            "KeyCompromise",
            "CACompromise",
            "AffiliationChanged",
            "Superseded",
            "CessationOfOperation",
            "CertificateHold",
            "Unknown",
            "RemoveFromCrl",
            "PrivilegeWithdrawn",
            "AACompromise"});
            this.comboBox1.Location = new System.Drawing.Point(3, 359);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(571, 21);
            this.comboBox1.TabIndex = 36;
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Location = new System.Drawing.Point(580, 408);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(75, 23);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX4.TabIndex = 35;
            this.buttonX4.Text = "Add";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(661, 408);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(75, 23);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX3.TabIndex = 34;
            this.buttonX3.Text = "Remove";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(742, 408);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX2.TabIndex = 33;
            this.buttonX2.Text = "Clear";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(13, 492);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(642, 19);
            this.labelX2.TabIndex = 32;
            this.labelX2.Text = "Existing Crl";
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
            this.textBoxX1.Location = new System.Drawing.Point(13, 517);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(642, 20);
            this.textBoxX1.TabIndex = 31;
            this.textBoxX1.WatermarkText = "Existing Crl Path";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(661, 516);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(143, 24);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonX1.TabIndex = 30;
            this.buttonX1.Text = "Import Crl";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // labelX23
            // 
            this.labelX23.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX23.ForeColor = System.Drawing.Color.Black;
            this.labelX23.Location = new System.Drawing.Point(432, 445);
            this.labelX23.Name = "labelX23";
            this.labelX23.Size = new System.Drawing.Size(372, 19);
            this.labelX23.TabIndex = 29;
            this.labelX23.Text = "Next Update Time";
            // 
            // nextupdtime
            // 
            // 
            // 
            // 
            this.nextupdtime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.nextupdtime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.nextupdtime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.nextupdtime.ButtonDropDown.Visible = true;
            this.nextupdtime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.nextupdtime.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
            this.nextupdtime.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.nextupdtime.IsPopupCalendarOpen = false;
            this.nextupdtime.Location = new System.Drawing.Point(432, 470);
            // 
            // 
            // 
            this.nextupdtime.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.nextupdtime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.nextupdtime.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.nextupdtime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.nextupdtime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.nextupdtime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.nextupdtime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.nextupdtime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.nextupdtime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.nextupdtime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.nextupdtime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.nextupdtime.MonthCalendar.DayClickAutoClosePopup = false;
            this.nextupdtime.MonthCalendar.DisplayMonth = new System.DateTime(2014, 8, 1, 0, 0, 0, 0);
            this.nextupdtime.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.nextupdtime.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.nextupdtime.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.nextupdtime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.nextupdtime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.nextupdtime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.nextupdtime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.nextupdtime.MonthCalendar.TodayButtonVisible = true;
            this.nextupdtime.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.nextupdtime.Name = "nextupdtime";
            this.nextupdtime.Size = new System.Drawing.Size(372, 20);
            this.nextupdtime.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.nextupdtime.TabIndex = 28;
            // 
            // labelX22
            // 
            this.labelX22.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX22.ForeColor = System.Drawing.Color.Black;
            this.labelX22.Location = new System.Drawing.Point(13, 445);
            this.labelX22.Name = "labelX22";
            this.labelX22.Size = new System.Drawing.Size(372, 19);
            this.labelX22.TabIndex = 27;
            this.labelX22.Text = "Update Time";
            // 
            // updtime
            // 
            // 
            // 
            // 
            this.updtime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.updtime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.updtime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.updtime.ButtonDropDown.Visible = true;
            this.updtime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.updtime.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
            this.updtime.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.updtime.IsPopupCalendarOpen = false;
            this.updtime.Location = new System.Drawing.Point(13, 470);
            // 
            // 
            // 
            this.updtime.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.updtime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.updtime.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.updtime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.updtime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.updtime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.updtime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.updtime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.updtime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.updtime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.updtime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.updtime.MonthCalendar.DayClickAutoClosePopup = false;
            this.updtime.MonthCalendar.DisplayMonth = new System.DateTime(2014, 8, 1, 0, 0, 0, 0);
            this.updtime.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.updtime.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.updtime.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.updtime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.updtime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.updtime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.updtime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.updtime.MonthCalendar.TodayButtonVisible = true;
            this.updtime.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.updtime.Name = "updtime";
            this.updtime.Size = new System.Drawing.Size(372, 20);
            this.updtime.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.updtime.TabIndex = 26;
            this.updtime.TimeSelectorTimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H;
            // 
            // itemPanel1
            // 
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemPanel1.DragDropSupport = true;
            this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel1.Location = new System.Drawing.Point(0, 23);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(829, 311);
            this.itemPanel1.TabIndex = 1;
            this.itemPanel1.Text = "itemPanel1";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX1.Location = new System.Drawing.Point(0, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(829, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Certificate List";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Crl Files (*.crl)|*.crl";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Certificate (*.cer, *.crt)|*.cer;*.crt";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(3, 386);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(372, 19);
            this.labelX4.TabIndex = 39;
            this.labelX4.Text = "Revocation Time";
            // 
            // revtime
            // 
            // 
            // 
            // 
            this.revtime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.revtime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.revtime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.revtime.ButtonDropDown.Visible = true;
            this.revtime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.revtime.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
            this.revtime.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.revtime.IsPopupCalendarOpen = false;
            this.revtime.Location = new System.Drawing.Point(3, 411);
            // 
            // 
            // 
            this.revtime.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.revtime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.revtime.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.revtime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.revtime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.revtime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.revtime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.revtime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.revtime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.revtime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.revtime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.revtime.MonthCalendar.DayClickAutoClosePopup = false;
            this.revtime.MonthCalendar.DisplayMonth = new System.DateTime(2014, 8, 1, 0, 0, 0, 0);
            this.revtime.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.revtime.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.revtime.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.revtime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.revtime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.revtime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.revtime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.revtime.MonthCalendar.TodayButtonVisible = true;
            this.revtime.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.revtime.Name = "revtime";
            this.revtime.Size = new System.Drawing.Size(571, 20);
            this.revtime.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.revtime.TabIndex = 38;
            this.revtime.TimeSelectorTimeFormat = DevComponents.Editors.DateTimeAdv.eTimeSelectorFormat.Time24H;
            // 
            // CrlControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelEx1);
            this.Name = "CrlControl";
            this.Size = new System.Drawing.Size(829, 555);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nextupdtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revtime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.LabelX labelX23;
        internal DevComponents.Editors.DateTimeAdv.DateTimeInput nextupdtime;
        private DevComponents.DotNetBar.LabelX labelX22;
        internal DevComponents.Editors.DateTimeAdv.DateTimeInput updtime;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevComponents.DotNetBar.LabelX labelX4;
        internal DevComponents.Editors.DateTimeAdv.DateTimeInput revtime;
    }
}
