namespace DazaBestApplication.Pages
{
    partial class Settings
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState7 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState8 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState9 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState10 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState11 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState12 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            TopPanel = new Panel();
            label1 = new Label();
            MainContainer = new Panel();
            DatabaseSettingsPanel = new Panel();
            bunifuDropdown1 = new Bunifu.UI.WinForms.BunifuDropdown();
            bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            bunifuToggleSwitch2 = new Bunifu.UI.WinForms.BunifuToggleSwitch();
            textBox7 = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label12 = new Label();
            POSInventorySettingsPanel = new Panel();
            bunifuToggleSwitch1 = new Bunifu.UI.WinForms.BunifuToggleSwitch();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            GeneralSettingsPanel = new Panel();
            bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            HeaderMessage = new TextBox();
            ContactInfo = new TextBox();
            BusinessName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            TopPanel.SuspendLayout();
            MainContainer.SuspendLayout();
            DatabaseSettingsPanel.SuspendLayout();
            POSInventorySettingsPanel.SuspendLayout();
            GeneralSettingsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.Controls.Add(label1);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Padding = new Padding(10, 0, 10, 0);
            TopPanel.Size = new Size(900, 50);
            TopPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Courier New", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 0);
            label1.Name = "label1";
            label1.Size = new Size(245, 50);
            label1.TabIndex = 0;
            label1.Text = "Settings";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainContainer
            // 
            MainContainer.AutoScroll = true;
            MainContainer.Controls.Add(DatabaseSettingsPanel);
            MainContainer.Controls.Add(POSInventorySettingsPanel);
            MainContainer.Controls.Add(GeneralSettingsPanel);
            MainContainer.Dock = DockStyle.Fill;
            MainContainer.Location = new Point(0, 50);
            MainContainer.Name = "MainContainer";
            MainContainer.Padding = new Padding(30, 10, 0, 0);
            MainContainer.Size = new Size(900, 612);
            MainContainer.TabIndex = 2;
            // 
            // DatabaseSettingsPanel
            // 
            DatabaseSettingsPanel.BackColor = Color.Transparent;
            DatabaseSettingsPanel.Controls.Add(bunifuDropdown1);
            DatabaseSettingsPanel.Controls.Add(bunifuButton2);
            DatabaseSettingsPanel.Controls.Add(bunifuToggleSwitch2);
            DatabaseSettingsPanel.Controls.Add(textBox7);
            DatabaseSettingsPanel.Controls.Add(label17);
            DatabaseSettingsPanel.Controls.Add(label16);
            DatabaseSettingsPanel.Controls.Add(label15);
            DatabaseSettingsPanel.Controls.Add(label14);
            DatabaseSettingsPanel.Controls.Add(label12);
            DatabaseSettingsPanel.Dock = DockStyle.Top;
            DatabaseSettingsPanel.Location = new Point(30, 406);
            DatabaseSettingsPanel.Name = "DatabaseSettingsPanel";
            DatabaseSettingsPanel.Size = new Size(853, 207);
            DatabaseSettingsPanel.TabIndex = 2;
            // 
            // bunifuDropdown1
            // 
            bunifuDropdown1.BackColor = Color.Transparent;
            bunifuDropdown1.BackgroundColor = Color.White;
            bunifuDropdown1.BorderColor = Color.Gray;
            bunifuDropdown1.BorderRadius = 1;
            bunifuDropdown1.Color = Color.Gray;
            bunifuDropdown1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            bunifuDropdown1.DisabledBackColor = Color.FromArgb(240, 240, 240);
            bunifuDropdown1.DisabledBorderColor = Color.FromArgb(204, 204, 204);
            bunifuDropdown1.DisabledColor = Color.FromArgb(240, 240, 240);
            bunifuDropdown1.DisabledForeColor = Color.FromArgb(109, 109, 109);
            bunifuDropdown1.DisabledIndicatorColor = Color.DarkGray;
            bunifuDropdown1.DrawMode = DrawMode.OwnerDrawFixed;
            bunifuDropdown1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            bunifuDropdown1.DropDownStyle = ComboBoxStyle.DropDownList;
            bunifuDropdown1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            bunifuDropdown1.FillDropDown = true;
            bunifuDropdown1.FillIndicator = false;
            bunifuDropdown1.FlatStyle = FlatStyle.Flat;
            bunifuDropdown1.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bunifuDropdown1.ForeColor = Color.Black;
            bunifuDropdown1.FormattingEnabled = true;
            bunifuDropdown1.Icon = null;
            bunifuDropdown1.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            bunifuDropdown1.IndicatorColor = Color.DarkGray;
            bunifuDropdown1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            bunifuDropdown1.IndicatorThickness = 2;
            bunifuDropdown1.IsDropdownOpened = false;
            bunifuDropdown1.ItemBackColor = Color.White;
            bunifuDropdown1.ItemBorderColor = Color.White;
            bunifuDropdown1.ItemForeColor = Color.Black;
            bunifuDropdown1.ItemHeight = 20;
            bunifuDropdown1.ItemHighLightColor = Color.DodgerBlue;
            bunifuDropdown1.ItemHighLightForeColor = Color.White;
            bunifuDropdown1.ItemTopMargin = 3;
            bunifuDropdown1.Location = new Point(268, 113);
            bunifuDropdown1.Name = "bunifuDropdown1";
            bunifuDropdown1.Size = new Size(277, 26);
            bunifuDropdown1.TabIndex = 14;
            bunifuDropdown1.Text = null;
            bunifuDropdown1.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            bunifuDropdown1.TextLeftMargin = 5;
            // 
            // bunifuButton2
            // 
            bunifuButton2.AllowAnimations = true;
            bunifuButton2.AllowMouseEffects = true;
            bunifuButton2.AllowToggling = false;
            bunifuButton2.AnimationSpeed = 200;
            bunifuButton2.AutoGenerateColors = false;
            bunifuButton2.AutoRoundBorders = false;
            bunifuButton2.AutoSizeLeftIcon = true;
            bunifuButton2.AutoSizeRightIcon = true;
            bunifuButton2.BackColor = Color.Transparent;
            bunifuButton2.BackColor1 = Color.FromArgb(51, 122, 183);
            bunifuButton2.BackgroundImage = (Image)resources.GetObject("bunifuButton2.BackgroundImage");
            bunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton2.ButtonText = "Restore Backup";
            bunifuButton2.ButtonTextMarginLeft = 0;
            bunifuButton2.ColorContrastOnClick = 45;
            bunifuButton2.ColorContrastOnHover = 45;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            bunifuButton2.CustomizableEdges = borderEdges4;
            bunifuButton2.DialogResult = DialogResult.None;
            bunifuButton2.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton2.DisabledFillColor = Color.Empty;
            bunifuButton2.DisabledForecolor = Color.Empty;
            bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            bunifuButton2.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuButton2.ForeColor = Color.White;
            bunifuButton2.IconLeft = null;
            bunifuButton2.IconLeftAlign = ContentAlignment.MiddleLeft;
            bunifuButton2.IconLeftCursor = Cursors.Default;
            bunifuButton2.IconLeftPadding = new Padding(11, 3, 3, 3);
            bunifuButton2.IconMarginLeft = 11;
            bunifuButton2.IconPadding = 10;
            bunifuButton2.IconRight = null;
            bunifuButton2.IconRightAlign = ContentAlignment.MiddleRight;
            bunifuButton2.IconRightCursor = Cursors.Default;
            bunifuButton2.IconRightPadding = new Padding(3, 3, 7, 3);
            bunifuButton2.IconSize = 25;
            bunifuButton2.IdleBorderColor = Color.Empty;
            bunifuButton2.IdleBorderRadius = 0;
            bunifuButton2.IdleBorderThickness = 0;
            bunifuButton2.IdleFillColor = Color.Empty;
            bunifuButton2.IdleIconLeftImage = null;
            bunifuButton2.IdleIconRightImage = null;
            bunifuButton2.IndicateFocus = false;
            bunifuButton2.Location = new Point(259, 148);
            bunifuButton2.Name = "bunifuButton2";
            bunifuButton2.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton2.OnDisabledState.BorderRadius = 1;
            bunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton2.OnDisabledState.BorderThickness = 1;
            bunifuButton2.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            bunifuButton2.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunifuButton2.OnDisabledState.IconLeftImage = null;
            bunifuButton2.OnDisabledState.IconRightImage = null;
            bunifuButton2.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            bunifuButton2.onHoverState.BorderRadius = 1;
            bunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton2.onHoverState.BorderThickness = 1;
            bunifuButton2.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            bunifuButton2.onHoverState.ForeColor = Color.White;
            bunifuButton2.onHoverState.IconLeftImage = null;
            bunifuButton2.onHoverState.IconRightImage = null;
            bunifuButton2.OnIdleState.BorderColor = Color.DodgerBlue;
            bunifuButton2.OnIdleState.BorderRadius = 1;
            bunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton2.OnIdleState.BorderThickness = 1;
            bunifuButton2.OnIdleState.FillColor = Color.DodgerBlue;
            bunifuButton2.OnIdleState.ForeColor = Color.White;
            bunifuButton2.OnIdleState.IconLeftImage = null;
            bunifuButton2.OnIdleState.IconRightImage = null;
            bunifuButton2.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            bunifuButton2.OnPressedState.BorderRadius = 1;
            bunifuButton2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton2.OnPressedState.BorderThickness = 1;
            bunifuButton2.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            bunifuButton2.OnPressedState.ForeColor = Color.White;
            bunifuButton2.OnPressedState.IconLeftImage = null;
            bunifuButton2.OnPressedState.IconRightImage = null;
            bunifuButton2.Size = new Size(149, 28);
            bunifuButton2.TabIndex = 9;
            bunifuButton2.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton2.TextAlignment = HorizontalAlignment.Center;
            bunifuButton2.TextMarginLeft = 0;
            bunifuButton2.TextPadding = new Padding(0);
            bunifuButton2.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuToggleSwitch2
            // 
            bunifuToggleSwitch2.Animation = 5;
            bunifuToggleSwitch2.AnimationSpeed = 5;
            bunifuToggleSwitch2.BackColor = Color.Transparent;
            bunifuToggleSwitch2.BackgroundImage = (Image)resources.GetObject("bunifuToggleSwitch2.BackgroundImage");
            bunifuToggleSwitch2.Checked = true;
            bunifuToggleSwitch2.InnerCirclePadding = 3;
            bunifuToggleSwitch2.Location = new Point(171, 78);
            bunifuToggleSwitch2.Margin = new Padding(5, 3, 5, 3);
            bunifuToggleSwitch2.Name = "bunifuToggleSwitch2";
            bunifuToggleSwitch2.Size = new Size(54, 28);
            bunifuToggleSwitch2.TabIndex = 13;
            bunifuToggleSwitch2.ThumbMargin = 3;
            toggleState7.BackColor = Color.DarkGray;
            toggleState7.BackColorInner = Color.White;
            toggleState7.BorderColor = Color.DarkGray;
            toggleState7.BorderColorInner = Color.White;
            toggleState7.BorderRadius = 17;
            toggleState7.BorderRadiusInner = 11;
            toggleState7.BorderThickness = 1;
            toggleState7.BorderThicknessInner = 1;
            bunifuToggleSwitch2.ToggleStateDisabled = toggleState7;
            toggleState8.BackColor = Color.Empty;
            toggleState8.BackColorInner = Color.Empty;
            toggleState8.BorderColor = Color.FromArgb(236, 0, 140);
            toggleState8.BorderColorInner = Color.Empty;
            toggleState8.BorderRadius = 1;
            toggleState8.BorderRadiusInner = 1;
            toggleState8.BorderThickness = 1;
            toggleState8.BorderThicknessInner = 1;
            bunifuToggleSwitch2.ToggleStateOff = toggleState8;
            toggleState9.BackColor = Color.DodgerBlue;
            toggleState9.BackColorInner = Color.White;
            toggleState9.BorderColor = Color.DodgerBlue;
            toggleState9.BorderColorInner = Color.White;
            toggleState9.BorderRadius = 15;
            toggleState9.BorderRadiusInner = 9;
            toggleState9.BorderThickness = 1;
            toggleState9.BorderThicknessInner = 1;
            bunifuToggleSwitch2.ToggleStateOn = toggleState9;
            bunifuToggleSwitch2.Value = true;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(231, 43);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(314, 26);
            textBox7.TabIndex = 12;
            // 
            // label17
            // 
            label17.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(40, 148);
            label17.Name = "label17";
            label17.Size = new Size(233, 30);
            label17.TabIndex = 10;
            label17.Text = "Restore from Backup :";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(40, 113);
            label16.Name = "label16";
            label16.Size = new Size(233, 30);
            label16.TabIndex = 9;
            label16.Text = "Auto Backup Schedule :";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(40, 78);
            label15.Name = "label15";
            label15.Size = new Size(233, 30);
            label15.TabIndex = 8;
            label15.Text = "AutoBackup :";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(40, 43);
            label14.Name = "label14";
            label14.Size = new Size(233, 30);
            label14.TabIndex = 7;
            label14.Text = "Backup Directory :";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(12, 3);
            label12.Name = "label12";
            label12.Size = new Size(232, 30);
            label12.TabIndex = 2;
            label12.Text = "Database Settings";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // POSInventorySettingsPanel
            // 
            POSInventorySettingsPanel.BackColor = Color.Transparent;
            POSInventorySettingsPanel.Controls.Add(bunifuToggleSwitch1);
            POSInventorySettingsPanel.Controls.Add(textBox5);
            POSInventorySettingsPanel.Controls.Add(textBox4);
            POSInventorySettingsPanel.Controls.Add(label11);
            POSInventorySettingsPanel.Controls.Add(label10);
            POSInventorySettingsPanel.Controls.Add(label9);
            POSInventorySettingsPanel.Controls.Add(label8);
            POSInventorySettingsPanel.Controls.Add(label7);
            POSInventorySettingsPanel.Dock = DockStyle.Top;
            POSInventorySettingsPanel.Location = new Point(30, 195);
            POSInventorySettingsPanel.Name = "POSInventorySettingsPanel";
            POSInventorySettingsPanel.Size = new Size(853, 211);
            POSInventorySettingsPanel.TabIndex = 1;
            // 
            // bunifuToggleSwitch1
            // 
            bunifuToggleSwitch1.Animation = 5;
            bunifuToggleSwitch1.AnimationSpeed = 5;
            bunifuToggleSwitch1.BackColor = Color.Transparent;
            bunifuToggleSwitch1.BackgroundImage = (Image)resources.GetObject("bunifuToggleSwitch1.BackgroundImage");
            bunifuToggleSwitch1.Checked = true;
            bunifuToggleSwitch1.InnerCirclePadding = 3;
            bunifuToggleSwitch1.Location = new Point(231, 80);
            bunifuToggleSwitch1.Margin = new Padding(5, 3, 5, 3);
            bunifuToggleSwitch1.Name = "bunifuToggleSwitch1";
            bunifuToggleSwitch1.Size = new Size(54, 28);
            bunifuToggleSwitch1.TabIndex = 8;
            bunifuToggleSwitch1.ThumbMargin = 3;
            toggleState10.BackColor = Color.DarkGray;
            toggleState10.BackColorInner = Color.White;
            toggleState10.BorderColor = Color.DarkGray;
            toggleState10.BorderColorInner = Color.White;
            toggleState10.BorderRadius = 17;
            toggleState10.BorderRadiusInner = 11;
            toggleState10.BorderThickness = 1;
            toggleState10.BorderThicknessInner = 1;
            bunifuToggleSwitch1.ToggleStateDisabled = toggleState10;
            toggleState11.BackColor = Color.Empty;
            toggleState11.BackColorInner = Color.Empty;
            toggleState11.BorderColor = Color.FromArgb(236, 0, 140);
            toggleState11.BorderColorInner = Color.Empty;
            toggleState11.BorderRadius = 1;
            toggleState11.BorderRadiusInner = 1;
            toggleState11.BorderThickness = 1;
            toggleState11.BorderThicknessInner = 1;
            bunifuToggleSwitch1.ToggleStateOff = toggleState11;
            toggleState12.BackColor = Color.DodgerBlue;
            toggleState12.BackColorInner = Color.White;
            toggleState12.BorderColor = Color.DodgerBlue;
            toggleState12.BorderColorInner = Color.White;
            toggleState12.BorderRadius = 15;
            toggleState12.BorderRadiusInner = 9;
            toggleState12.BorderThickness = 1;
            toggleState12.BorderThicknessInner = 1;
            bunifuToggleSwitch1.ToggleStateOn = toggleState12;
            bunifuToggleSwitch1.Value = true;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(231, 170);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(314, 26);
            textBox5.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(231, 45);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(314, 26);
            textBox4.TabIndex = 6;
            // 
            // label11
            // 
            label11.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(40, 170);
            label11.Name = "label11";
            label11.Size = new Size(233, 30);
            label11.TabIndex = 5;
            label11.Text = "VAT {%} :";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 127);
            label10.Name = "label10";
            label10.Size = new Size(232, 30);
            label10.TabIndex = 4;
            label10.Text = "Sales Settings";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(40, 80);
            label9.Name = "label9";
            label9.Size = new Size(245, 30);
            label9.TabIndex = 3;
            label9.Text = "Track Exp Date :";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(40, 45);
            label8.Name = "label8";
            label8.Size = new Size(233, 30);
            label8.TabIndex = 2;
            label8.Text = "Stock Thresholds :";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 0);
            label7.Name = "label7";
            label7.Size = new Size(232, 30);
            label7.TabIndex = 1;
            label7.Text = "Inventory Settings";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GeneralSettingsPanel
            // 
            GeneralSettingsPanel.BackColor = Color.Transparent;
            GeneralSettingsPanel.Controls.Add(bunifuButton1);
            GeneralSettingsPanel.Controls.Add(HeaderMessage);
            GeneralSettingsPanel.Controls.Add(ContactInfo);
            GeneralSettingsPanel.Controls.Add(BusinessName);
            GeneralSettingsPanel.Controls.Add(label6);
            GeneralSettingsPanel.Controls.Add(label5);
            GeneralSettingsPanel.Controls.Add(label4);
            GeneralSettingsPanel.Controls.Add(label3);
            GeneralSettingsPanel.Controls.Add(label2);
            GeneralSettingsPanel.Dock = DockStyle.Top;
            GeneralSettingsPanel.Location = new Point(30, 10);
            GeneralSettingsPanel.Name = "GeneralSettingsPanel";
            GeneralSettingsPanel.Size = new Size(853, 185);
            GeneralSettingsPanel.TabIndex = 0;
            // 
            // bunifuButton1
            // 
            bunifuButton1.AllowAnimations = true;
            bunifuButton1.AllowMouseEffects = true;
            bunifuButton1.AllowToggling = false;
            bunifuButton1.AnimationSpeed = 200;
            bunifuButton1.AutoGenerateColors = false;
            bunifuButton1.AutoRoundBorders = false;
            bunifuButton1.AutoSizeLeftIcon = true;
            bunifuButton1.AutoSizeRightIcon = true;
            bunifuButton1.BackColor = Color.Transparent;
            bunifuButton1.BackColor1 = Color.FromArgb(51, 122, 183);
            bunifuButton1.BackgroundImage = (Image)resources.GetObject("bunifuButton1.BackgroundImage");
            bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.ButtonText = "Change Logo";
            bunifuButton1.ButtonTextMarginLeft = 0;
            bunifuButton1.ColorContrastOnClick = 45;
            bunifuButton1.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            bunifuButton1.CustomizableEdges = borderEdges3;
            bunifuButton1.DialogResult = DialogResult.None;
            bunifuButton1.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton1.DisabledFillColor = Color.Empty;
            bunifuButton1.DisabledForecolor = Color.Empty;
            bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            bunifuButton1.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuButton1.ForeColor = Color.White;
            bunifuButton1.IconLeft = null;
            bunifuButton1.IconLeftAlign = ContentAlignment.MiddleLeft;
            bunifuButton1.IconLeftCursor = Cursors.Default;
            bunifuButton1.IconLeftPadding = new Padding(11, 3, 3, 3);
            bunifuButton1.IconMarginLeft = 11;
            bunifuButton1.IconPadding = 10;
            bunifuButton1.IconRight = null;
            bunifuButton1.IconRightAlign = ContentAlignment.MiddleRight;
            bunifuButton1.IconRightCursor = Cursors.Default;
            bunifuButton1.IconRightPadding = new Padding(3, 3, 7, 3);
            bunifuButton1.IconSize = 25;
            bunifuButton1.IdleBorderColor = Color.Empty;
            bunifuButton1.IdleBorderRadius = 0;
            bunifuButton1.IdleBorderThickness = 0;
            bunifuButton1.IdleFillColor = Color.Empty;
            bunifuButton1.IdleIconLeftImage = null;
            bunifuButton1.IdleIconRightImage = null;
            bunifuButton1.IndicateFocus = false;
            bunifuButton1.Location = new Point(216, 105);
            bunifuButton1.Name = "bunifuButton1";
            bunifuButton1.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton1.OnDisabledState.BorderRadius = 1;
            bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.OnDisabledState.BorderThickness = 1;
            bunifuButton1.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            bunifuButton1.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunifuButton1.OnDisabledState.IconLeftImage = null;
            bunifuButton1.OnDisabledState.IconRightImage = null;
            bunifuButton1.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            bunifuButton1.onHoverState.BorderRadius = 1;
            bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.onHoverState.BorderThickness = 1;
            bunifuButton1.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            bunifuButton1.onHoverState.ForeColor = Color.White;
            bunifuButton1.onHoverState.IconLeftImage = null;
            bunifuButton1.onHoverState.IconRightImage = null;
            bunifuButton1.OnIdleState.BorderColor = Color.DodgerBlue;
            bunifuButton1.OnIdleState.BorderRadius = 1;
            bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.OnIdleState.BorderThickness = 1;
            bunifuButton1.OnIdleState.FillColor = Color.DodgerBlue;
            bunifuButton1.OnIdleState.ForeColor = Color.White;
            bunifuButton1.OnIdleState.IconLeftImage = null;
            bunifuButton1.OnIdleState.IconRightImage = null;
            bunifuButton1.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            bunifuButton1.OnPressedState.BorderRadius = 1;
            bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.OnPressedState.BorderThickness = 1;
            bunifuButton1.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            bunifuButton1.OnPressedState.ForeColor = Color.White;
            bunifuButton1.OnPressedState.IconLeftImage = null;
            bunifuButton1.OnPressedState.IconRightImage = null;
            bunifuButton1.Size = new Size(138, 28);
            bunifuButton1.TabIndex = 8;
            bunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton1.TextAlignment = HorizontalAlignment.Center;
            bunifuButton1.TextMarginLeft = 0;
            bunifuButton1.TextPadding = new Padding(0);
            bunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // HeaderMessage
            // 
            HeaderMessage.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HeaderMessage.Location = new Point(216, 140);
            HeaderMessage.Name = "HeaderMessage";
            HeaderMessage.Size = new Size(329, 26);
            HeaderMessage.TabIndex = 7;
            HeaderMessage.Tag = "GeneralSettings_Headermessage";
            // 
            // ContactInfo
            // 
            ContactInfo.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContactInfo.Location = new Point(216, 70);
            ContactInfo.Name = "ContactInfo";
            ContactInfo.Size = new Size(329, 26);
            ContactInfo.TabIndex = 6;
            ContactInfo.Tag = "GeneralSettings_Contactinfo";
            // 
            // BusinessName
            // 
            BusinessName.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BusinessName.Location = new Point(216, 35);
            BusinessName.Name = "BusinessName";
            BusinessName.Size = new Size(329, 26);
            BusinessName.TabIndex = 5;
            BusinessName.Tag = "GeneralSettings_BussinessName";
            // 
            // label6
            // 
            label6.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(40, 140);
            label6.Name = "label6";
            label6.Size = new Size(170, 30);
            label6.TabIndex = 4;
            label6.Text = "Header Message :";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 105);
            label5.Name = "label5";
            label5.Size = new Size(170, 30);
            label5.TabIndex = 3;
            label5.Text = "Business Logo :";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 70);
            label4.Name = "label4";
            label4.Size = new Size(170, 30);
            label4.TabIndex = 2;
            label4.Text = "Contact Info :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 35);
            label3.Name = "label3";
            label3.Size = new Size(170, 30);
            label3.TabIndex = 1;
            label3.Text = "Business Name :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 3);
            label2.Name = "label2";
            label2.Size = new Size(232, 30);
            label2.TabIndex = 0;
            label2.Text = "General Settings";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 662);
            Controls.Add(MainContainer);
            Controls.Add(TopPanel);
            Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            TopPanel.ResumeLayout(false);
            MainContainer.ResumeLayout(false);
            DatabaseSettingsPanel.ResumeLayout(false);
            DatabaseSettingsPanel.PerformLayout();
            POSInventorySettingsPanel.ResumeLayout(false);
            POSInventorySettingsPanel.PerformLayout();
            GeneralSettingsPanel.ResumeLayout(false);
            GeneralSettingsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Label label1;
        private Panel MainContainer;
        private Panel DatabaseSettingsPanel;
        private Panel POSInventorySettingsPanel;
        private Panel GeneralSettingsPanel;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label17;
        private TextBox BusinessName;
        private TextBox textBox7;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox HeaderMessage;
        private TextBox ContactInfo;
        private Bunifu.UI.WinForms.BunifuToggleSwitch bunifuToggleSwitch2;
        private Bunifu.UI.WinForms.BunifuToggleSwitch bunifuToggleSwitch1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown1;
    }
}