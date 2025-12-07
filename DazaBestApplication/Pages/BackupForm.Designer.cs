namespace DazaBestApplication.Pages
{
    partial class BackupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            TopPanel = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            panel2 = new Panel();
            panel4 = new Panel();
            bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            Restorebackuptxtbox = new Bunifu.UI.WinForms.BunifuTextBox();
            bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            label2 = new Label();
            panel3 = new Panel();
            ManualBackupBTN = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            SelectDirectoryBTN = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            backupscheduledropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            label16 = new Label();
            backupdirectorytxtbox = new TextBox();
            label14 = new Label();
            clouduploadbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            bunifuShadowPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.White;
            TopPanel.Controls.Add(panel1);
            TopPanel.Controls.Add(label1);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Padding = new Padding(10, 0, 10, 0);
            TopPanel.Size = new Size(900, 50);
            TopPanel.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(10, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 5);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Courier New", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 0);
            label1.Name = "label1";
            label1.Size = new Size(465, 50);
            label1.TabIndex = 0;
            label1.Text = "Backup And Restore";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.backups_1_;
            pictureBox1.Location = new Point(21, 171);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(20);
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // bunifuShadowPanel1
            // 
            bunifuShadowPanel1.BackColor = Color.Transparent;
            bunifuShadowPanel1.BorderColor = Color.WhiteSmoke;
            bunifuShadowPanel1.BorderRadius = 1;
            bunifuShadowPanel1.BorderThickness = 1;
            bunifuShadowPanel1.Controls.Add(panel2);
            bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            bunifuShadowPanel1.Location = new Point(336, 101);
            bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            bunifuShadowPanel1.PanelColor = Color.WhiteSmoke;
            bunifuShadowPanel1.PanelColor2 = Color.WhiteSmoke;
            bunifuShadowPanel1.ShadowColor = Color.DarkGray;
            bunifuShadowPanel1.ShadowDept = 2;
            bunifuShadowPanel1.ShadowDepth = 10;
            bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            bunifuShadowPanel1.ShadowTopLeftVisible = false;
            bunifuShadowPanel1.Size = new Size(529, 460);
            bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            bunifuShadowPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(8, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(510, 438);
            panel2.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(bunifuButton2);
            panel4.Controls.Add(Restorebackuptxtbox);
            panel4.Controls.Add(bunifuButton1);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Fill;
            panel4.Font = new Font("Courier New", 9.75F, FontStyle.Bold);
            panel4.Location = new Point(0, 269);
            panel4.Name = "panel4";
            panel4.Size = new Size(510, 169);
            panel4.TabIndex = 1;
            panel4.Paint += panel4_Paint;
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
            bunifuButton2.ButtonText = "Restore";
            bunifuButton2.ButtonTextMarginLeft = 0;
            bunifuButton2.ColorContrastOnClick = 45;
            bunifuButton2.ColorContrastOnHover = 45;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            bunifuButton2.CustomizableEdges = borderEdges6;
            bunifuButton2.DialogResult = DialogResult.None;
            bunifuButton2.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton2.DisabledFillColor = Color.Empty;
            bunifuButton2.DisabledForecolor = Color.Empty;
            bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            bunifuButton2.Font = new Font("Segoe UI", 9F);
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
            bunifuButton2.Location = new Point(326, 121);
            bunifuButton2.Name = "bunifuButton2";
            bunifuButton2.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton2.OnDisabledState.BorderRadius = 1;
            bunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton2.OnDisabledState.BorderThickness = 1;
            bunifuButton2.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            bunifuButton2.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunifuButton2.OnDisabledState.IconLeftImage = null;
            bunifuButton2.OnDisabledState.IconRightImage = null;
            bunifuButton2.onHoverState.BorderColor = Color.FromArgb(220, 74, 74);
            bunifuButton2.onHoverState.BorderRadius = 1;
            bunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton2.onHoverState.BorderThickness = 1;
            bunifuButton2.onHoverState.FillColor = Color.FromArgb(220, 74, 74);
            bunifuButton2.onHoverState.ForeColor = Color.White;
            bunifuButton2.onHoverState.IconLeftImage = null;
            bunifuButton2.onHoverState.IconRightImage = null;
            bunifuButton2.OnIdleState.BorderColor = Color.Maroon;
            bunifuButton2.OnIdleState.BorderRadius = 1;
            bunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton2.OnIdleState.BorderThickness = 1;
            bunifuButton2.OnIdleState.FillColor = Color.Maroon;
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
            bunifuButton2.Size = new Size(159, 35);
            bunifuButton2.TabIndex = 17;
            bunifuButton2.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton2.TextAlignment = HorizontalAlignment.Center;
            bunifuButton2.TextMarginLeft = 0;
            bunifuButton2.TextPadding = new Padding(0);
            bunifuButton2.UseDefaultRadiusAndThickness = true;
            bunifuButton2.Click += bunifuButton2_Click;
            // 
            // Restorebackuptxtbox
            // 
            Restorebackuptxtbox.AcceptsReturn = false;
            Restorebackuptxtbox.AcceptsTab = false;
            Restorebackuptxtbox.AnimationSpeed = 200;
            Restorebackuptxtbox.AutoCompleteMode = AutoCompleteMode.None;
            Restorebackuptxtbox.AutoCompleteSource = AutoCompleteSource.None;
            Restorebackuptxtbox.AutoSizeHeight = true;
            Restorebackuptxtbox.BackColor = Color.Transparent;
            Restorebackuptxtbox.BackgroundImage = (Image)resources.GetObject("Restorebackuptxtbox.BackgroundImage");
            Restorebackuptxtbox.BorderColorActive = Color.DodgerBlue;
            Restorebackuptxtbox.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            Restorebackuptxtbox.BorderColorHover = Color.FromArgb(105, 181, 255);
            Restorebackuptxtbox.BorderColorIdle = Color.Silver;
            Restorebackuptxtbox.BorderRadius = 1;
            Restorebackuptxtbox.BorderThickness = 1;
            Restorebackuptxtbox.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            Restorebackuptxtbox.CharacterCasing = CharacterCasing.Normal;
            Restorebackuptxtbox.DefaultFont = new Font("Segoe UI", 9.25F);
            Restorebackuptxtbox.DefaultText = "";
            Restorebackuptxtbox.FillColor = Color.White;
            Restorebackuptxtbox.HideSelection = true;
            Restorebackuptxtbox.IconLeft = null;
            Restorebackuptxtbox.IconLeftCursor = Cursors.IBeam;
            Restorebackuptxtbox.IconPadding = 10;
            Restorebackuptxtbox.IconRight = null;
            Restorebackuptxtbox.IconRightCursor = Cursors.IBeam;
            Restorebackuptxtbox.Location = new Point(176, 62);
            Restorebackuptxtbox.MaxLength = 32767;
            Restorebackuptxtbox.MinimumSize = new Size(1, 1);
            Restorebackuptxtbox.Modified = false;
            Restorebackuptxtbox.Multiline = false;
            Restorebackuptxtbox.Name = "Restorebackuptxtbox";
            stateProperties5.BorderColor = Color.DodgerBlue;
            stateProperties5.FillColor = Color.Empty;
            stateProperties5.ForeColor = Color.Empty;
            stateProperties5.PlaceholderForeColor = Color.Empty;
            Restorebackuptxtbox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties6.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties6.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties6.PlaceholderForeColor = Color.DarkGray;
            Restorebackuptxtbox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties7.FillColor = Color.Empty;
            stateProperties7.ForeColor = Color.Empty;
            stateProperties7.PlaceholderForeColor = Color.Empty;
            Restorebackuptxtbox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = Color.Silver;
            stateProperties8.FillColor = Color.White;
            stateProperties8.ForeColor = Color.Empty;
            stateProperties8.PlaceholderForeColor = Color.Empty;
            Restorebackuptxtbox.OnIdleState = stateProperties8;
            Restorebackuptxtbox.Padding = new Padding(3);
            Restorebackuptxtbox.PasswordChar = '\0';
            Restorebackuptxtbox.PlaceholderForeColor = Color.Silver;
            Restorebackuptxtbox.PlaceholderText = "Choose File Here";
            Restorebackuptxtbox.ReadOnly = false;
            Restorebackuptxtbox.ScrollBars = ScrollBars.None;
            Restorebackuptxtbox.SelectedText = "";
            Restorebackuptxtbox.SelectionLength = 0;
            Restorebackuptxtbox.SelectionStart = 0;
            Restorebackuptxtbox.ShortcutsEnabled = true;
            Restorebackuptxtbox.Size = new Size(309, 39);
            Restorebackuptxtbox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            Restorebackuptxtbox.TabIndex = 16;
            Restorebackuptxtbox.TextAlign = HorizontalAlignment.Left;
            Restorebackuptxtbox.TextMarginBottom = 0;
            Restorebackuptxtbox.TextMarginLeft = 3;
            Restorebackuptxtbox.TextMarginTop = 1;
            Restorebackuptxtbox.TextPlaceholder = "Choose File Here";
            Restorebackuptxtbox.UseSystemPasswordChar = false;
            Restorebackuptxtbox.WordWrap = true;
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
            bunifuButton1.ButtonText = "Select";
            bunifuButton1.ButtonTextMarginLeft = 0;
            bunifuButton1.ColorContrastOnClick = 45;
            bunifuButton1.ColorContrastOnHover = 45;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            bunifuButton1.CustomizableEdges = borderEdges7;
            bunifuButton1.DialogResult = DialogResult.None;
            bunifuButton1.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton1.DisabledFillColor = Color.Empty;
            bunifuButton1.DisabledForecolor = Color.Empty;
            bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            bunifuButton1.Font = new Font("Segoe UI", 9F);
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
            bunifuButton1.Location = new Point(21, 62);
            bunifuButton1.Name = "bunifuButton1";
            bunifuButton1.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton1.OnDisabledState.BorderRadius = 1;
            bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.OnDisabledState.BorderThickness = 1;
            bunifuButton1.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            bunifuButton1.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunifuButton1.OnDisabledState.IconLeftImage = null;
            bunifuButton1.OnDisabledState.IconRightImage = null;
            bunifuButton1.onHoverState.BorderColor = Color.FromArgb(220, 74, 74);
            bunifuButton1.onHoverState.BorderRadius = 1;
            bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.onHoverState.BorderThickness = 1;
            bunifuButton1.onHoverState.FillColor = Color.FromArgb(220, 74, 74);
            bunifuButton1.onHoverState.ForeColor = Color.White;
            bunifuButton1.onHoverState.IconLeftImage = null;
            bunifuButton1.onHoverState.IconRightImage = null;
            bunifuButton1.OnIdleState.BorderColor = Color.Maroon;
            bunifuButton1.OnIdleState.BorderRadius = 1;
            bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.OnIdleState.BorderThickness = 1;
            bunifuButton1.OnIdleState.FillColor = Color.Maroon;
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
            bunifuButton1.Size = new Size(159, 32);
            bunifuButton1.TabIndex = 15;
            bunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton1.TextAlignment = HorizontalAlignment.Center;
            bunifuButton1.TextMarginLeft = 0;
            bunifuButton1.TextPadding = new Padding(0);
            bunifuButton1.UseDefaultRadiusAndThickness = true;
            bunifuButton1.Click += bunifuButton1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 19);
            label2.Name = "label2";
            label2.Size = new Size(233, 30);
            label2.TabIndex = 14;
            label2.Text = "Restore Database:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(clouduploadbtn);
            panel3.Controls.Add(ManualBackupBTN);
            panel3.Controls.Add(SelectDirectoryBTN);
            panel3.Controls.Add(backupscheduledropdown);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(backupdirectorytxtbox);
            panel3.Controls.Add(label14);
            panel3.Dock = DockStyle.Top;
            panel3.Font = new Font("Courier New", 9.75F, FontStyle.Bold);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(510, 269);
            panel3.TabIndex = 0;
            // 
            // ManualBackupBTN
            // 
            ManualBackupBTN.AllowAnimations = true;
            ManualBackupBTN.AllowMouseEffects = true;
            ManualBackupBTN.AllowToggling = false;
            ManualBackupBTN.AnimationSpeed = 200;
            ManualBackupBTN.AutoGenerateColors = false;
            ManualBackupBTN.AutoRoundBorders = false;
            ManualBackupBTN.AutoSizeLeftIcon = true;
            ManualBackupBTN.AutoSizeRightIcon = true;
            ManualBackupBTN.BackColor = Color.Transparent;
            ManualBackupBTN.BackColor1 = Color.FromArgb(51, 122, 183);
            ManualBackupBTN.BackgroundImage = (Image)resources.GetObject("ManualBackupBTN.BackgroundImage");
            ManualBackupBTN.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            ManualBackupBTN.ButtonText = "Manual Backup";
            ManualBackupBTN.ButtonTextMarginLeft = 0;
            ManualBackupBTN.ColorContrastOnClick = 45;
            ManualBackupBTN.ColorContrastOnHover = 45;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            ManualBackupBTN.CustomizableEdges = borderEdges8;
            ManualBackupBTN.DialogResult = DialogResult.None;
            ManualBackupBTN.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            ManualBackupBTN.DisabledFillColor = Color.Empty;
            ManualBackupBTN.DisabledForecolor = Color.Empty;
            ManualBackupBTN.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            ManualBackupBTN.Font = new Font("Segoe UI", 9F);
            ManualBackupBTN.ForeColor = Color.White;
            ManualBackupBTN.IconLeft = null;
            ManualBackupBTN.IconLeftAlign = ContentAlignment.MiddleLeft;
            ManualBackupBTN.IconLeftCursor = Cursors.Default;
            ManualBackupBTN.IconLeftPadding = new Padding(11, 3, 3, 3);
            ManualBackupBTN.IconMarginLeft = 11;
            ManualBackupBTN.IconPadding = 10;
            ManualBackupBTN.IconRight = null;
            ManualBackupBTN.IconRightAlign = ContentAlignment.MiddleRight;
            ManualBackupBTN.IconRightCursor = Cursors.Default;
            ManualBackupBTN.IconRightPadding = new Padding(3, 3, 7, 3);
            ManualBackupBTN.IconSize = 25;
            ManualBackupBTN.IdleBorderColor = Color.Empty;
            ManualBackupBTN.IdleBorderRadius = 0;
            ManualBackupBTN.IdleBorderThickness = 0;
            ManualBackupBTN.IdleFillColor = Color.Empty;
            ManualBackupBTN.IdleIconLeftImage = null;
            ManualBackupBTN.IdleIconRightImage = null;
            ManualBackupBTN.IndicateFocus = false;
            ManualBackupBTN.Location = new Point(326, 212);
            ManualBackupBTN.Name = "ManualBackupBTN";
            ManualBackupBTN.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            ManualBackupBTN.OnDisabledState.BorderRadius = 1;
            ManualBackupBTN.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            ManualBackupBTN.OnDisabledState.BorderThickness = 1;
            ManualBackupBTN.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            ManualBackupBTN.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            ManualBackupBTN.OnDisabledState.IconLeftImage = null;
            ManualBackupBTN.OnDisabledState.IconRightImage = null;
            ManualBackupBTN.onHoverState.BorderColor = Color.FromArgb(220, 74, 74);
            ManualBackupBTN.onHoverState.BorderRadius = 1;
            ManualBackupBTN.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            ManualBackupBTN.onHoverState.BorderThickness = 1;
            ManualBackupBTN.onHoverState.FillColor = Color.FromArgb(220, 74, 74);
            ManualBackupBTN.onHoverState.ForeColor = Color.White;
            ManualBackupBTN.onHoverState.IconLeftImage = null;
            ManualBackupBTN.onHoverState.IconRightImage = null;
            ManualBackupBTN.OnIdleState.BorderColor = Color.Maroon;
            ManualBackupBTN.OnIdleState.BorderRadius = 1;
            ManualBackupBTN.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            ManualBackupBTN.OnIdleState.BorderThickness = 1;
            ManualBackupBTN.OnIdleState.FillColor = Color.Maroon;
            ManualBackupBTN.OnIdleState.ForeColor = Color.White;
            ManualBackupBTN.OnIdleState.IconLeftImage = null;
            ManualBackupBTN.OnIdleState.IconRightImage = null;
            ManualBackupBTN.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            ManualBackupBTN.OnPressedState.BorderRadius = 1;
            ManualBackupBTN.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            ManualBackupBTN.OnPressedState.BorderThickness = 1;
            ManualBackupBTN.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            ManualBackupBTN.OnPressedState.ForeColor = Color.White;
            ManualBackupBTN.OnPressedState.IconLeftImage = null;
            ManualBackupBTN.OnPressedState.IconRightImage = null;
            ManualBackupBTN.Size = new Size(159, 35);
            ManualBackupBTN.TabIndex = 18;
            ManualBackupBTN.TextAlign = ContentAlignment.MiddleCenter;
            ManualBackupBTN.TextAlignment = HorizontalAlignment.Center;
            ManualBackupBTN.TextMarginLeft = 0;
            ManualBackupBTN.TextPadding = new Padding(0);
            ManualBackupBTN.UseDefaultRadiusAndThickness = true;
            ManualBackupBTN.Click += ManualBackupBTN_Click;
            // 
            // SelectDirectoryBTN
            // 
            SelectDirectoryBTN.AllowAnimations = true;
            SelectDirectoryBTN.AllowMouseEffects = true;
            SelectDirectoryBTN.AllowToggling = false;
            SelectDirectoryBTN.AnimationSpeed = 200;
            SelectDirectoryBTN.AutoGenerateColors = false;
            SelectDirectoryBTN.AutoRoundBorders = false;
            SelectDirectoryBTN.AutoSizeLeftIcon = true;
            SelectDirectoryBTN.AutoSizeRightIcon = true;
            SelectDirectoryBTN.BackColor = Color.Transparent;
            SelectDirectoryBTN.BackColor1 = Color.FromArgb(51, 122, 183);
            SelectDirectoryBTN.BackgroundImage = (Image)resources.GetObject("SelectDirectoryBTN.BackgroundImage");
            SelectDirectoryBTN.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            SelectDirectoryBTN.ButtonText = "Select Directory";
            SelectDirectoryBTN.ButtonTextMarginLeft = 0;
            SelectDirectoryBTN.ColorContrastOnClick = 45;
            SelectDirectoryBTN.ColorContrastOnHover = 45;
            borderEdges9.BottomLeft = true;
            borderEdges9.BottomRight = true;
            borderEdges9.TopLeft = true;
            borderEdges9.TopRight = true;
            SelectDirectoryBTN.CustomizableEdges = borderEdges9;
            SelectDirectoryBTN.DialogResult = DialogResult.None;
            SelectDirectoryBTN.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            SelectDirectoryBTN.DisabledFillColor = Color.Empty;
            SelectDirectoryBTN.DisabledForecolor = Color.Empty;
            SelectDirectoryBTN.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            SelectDirectoryBTN.Font = new Font("Segoe UI", 9F);
            SelectDirectoryBTN.ForeColor = Color.White;
            SelectDirectoryBTN.IconLeft = null;
            SelectDirectoryBTN.IconLeftAlign = ContentAlignment.MiddleLeft;
            SelectDirectoryBTN.IconLeftCursor = Cursors.Default;
            SelectDirectoryBTN.IconLeftPadding = new Padding(11, 3, 3, 3);
            SelectDirectoryBTN.IconMarginLeft = 11;
            SelectDirectoryBTN.IconPadding = 10;
            SelectDirectoryBTN.IconRight = null;
            SelectDirectoryBTN.IconRightAlign = ContentAlignment.MiddleRight;
            SelectDirectoryBTN.IconRightCursor = Cursors.Default;
            SelectDirectoryBTN.IconRightPadding = new Padding(3, 3, 7, 3);
            SelectDirectoryBTN.IconSize = 25;
            SelectDirectoryBTN.IdleBorderColor = Color.Empty;
            SelectDirectoryBTN.IdleBorderRadius = 0;
            SelectDirectoryBTN.IdleBorderThickness = 0;
            SelectDirectoryBTN.IdleFillColor = Color.Empty;
            SelectDirectoryBTN.IdleIconLeftImage = null;
            SelectDirectoryBTN.IdleIconRightImage = null;
            SelectDirectoryBTN.IndicateFocus = false;
            SelectDirectoryBTN.Location = new Point(351, 66);
            SelectDirectoryBTN.Name = "SelectDirectoryBTN";
            SelectDirectoryBTN.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            SelectDirectoryBTN.OnDisabledState.BorderRadius = 1;
            SelectDirectoryBTN.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            SelectDirectoryBTN.OnDisabledState.BorderThickness = 1;
            SelectDirectoryBTN.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            SelectDirectoryBTN.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            SelectDirectoryBTN.OnDisabledState.IconLeftImage = null;
            SelectDirectoryBTN.OnDisabledState.IconRightImage = null;
            SelectDirectoryBTN.onHoverState.BorderColor = Color.FromArgb(220, 74, 74);
            SelectDirectoryBTN.onHoverState.BorderRadius = 1;
            SelectDirectoryBTN.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            SelectDirectoryBTN.onHoverState.BorderThickness = 1;
            SelectDirectoryBTN.onHoverState.FillColor = Color.FromArgb(220, 74, 74);
            SelectDirectoryBTN.onHoverState.ForeColor = Color.White;
            SelectDirectoryBTN.onHoverState.IconLeftImage = null;
            SelectDirectoryBTN.onHoverState.IconRightImage = null;
            SelectDirectoryBTN.OnIdleState.BorderColor = Color.Maroon;
            SelectDirectoryBTN.OnIdleState.BorderRadius = 1;
            SelectDirectoryBTN.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            SelectDirectoryBTN.OnIdleState.BorderThickness = 1;
            SelectDirectoryBTN.OnIdleState.FillColor = Color.Maroon;
            SelectDirectoryBTN.OnIdleState.ForeColor = Color.White;
            SelectDirectoryBTN.OnIdleState.IconLeftImage = null;
            SelectDirectoryBTN.OnIdleState.IconRightImage = null;
            SelectDirectoryBTN.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            SelectDirectoryBTN.OnPressedState.BorderRadius = 1;
            SelectDirectoryBTN.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            SelectDirectoryBTN.OnPressedState.BorderThickness = 1;
            SelectDirectoryBTN.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            SelectDirectoryBTN.OnPressedState.ForeColor = Color.White;
            SelectDirectoryBTN.OnPressedState.IconLeftImage = null;
            SelectDirectoryBTN.OnPressedState.IconRightImage = null;
            SelectDirectoryBTN.Size = new Size(134, 26);
            SelectDirectoryBTN.TabIndex = 17;
            SelectDirectoryBTN.TextAlign = ContentAlignment.MiddleCenter;
            SelectDirectoryBTN.TextAlignment = HorizontalAlignment.Center;
            SelectDirectoryBTN.TextMarginLeft = 0;
            SelectDirectoryBTN.TextPadding = new Padding(0);
            SelectDirectoryBTN.UseDefaultRadiusAndThickness = true;
            SelectDirectoryBTN.Click += SelectDirectoryBTN_Click;
            // 
            // backupscheduledropdown
            // 
            backupscheduledropdown.BackColor = Color.Transparent;
            backupscheduledropdown.BackgroundColor = Color.White;
            backupscheduledropdown.BorderColor = Color.Gray;
            backupscheduledropdown.BorderRadius = 1;
            backupscheduledropdown.Color = Color.Gray;
            backupscheduledropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            backupscheduledropdown.DisabledBackColor = Color.FromArgb(240, 240, 240);
            backupscheduledropdown.DisabledBorderColor = Color.FromArgb(204, 204, 204);
            backupscheduledropdown.DisabledColor = Color.FromArgb(240, 240, 240);
            backupscheduledropdown.DisabledForeColor = Color.FromArgb(109, 109, 109);
            backupscheduledropdown.DisabledIndicatorColor = Color.DarkGray;
            backupscheduledropdown.DrawMode = DrawMode.OwnerDrawFixed;
            backupscheduledropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            backupscheduledropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            backupscheduledropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            backupscheduledropdown.FillDropDown = true;
            backupscheduledropdown.FillIndicator = false;
            backupscheduledropdown.FlatStyle = FlatStyle.Flat;
            backupscheduledropdown.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backupscheduledropdown.ForeColor = Color.Black;
            backupscheduledropdown.FormattingEnabled = true;
            backupscheduledropdown.Icon = null;
            backupscheduledropdown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            backupscheduledropdown.IndicatorColor = Color.DarkGray;
            backupscheduledropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            backupscheduledropdown.IndicatorThickness = 2;
            backupscheduledropdown.IsDropdownOpened = false;
            backupscheduledropdown.ItemBackColor = Color.White;
            backupscheduledropdown.ItemBorderColor = Color.White;
            backupscheduledropdown.ItemForeColor = Color.Black;
            backupscheduledropdown.ItemHeight = 20;
            backupscheduledropdown.ItemHighLightColor = Color.DodgerBlue;
            backupscheduledropdown.ItemHighLightForeColor = Color.White;
            backupscheduledropdown.ItemTopMargin = 3;
            backupscheduledropdown.Location = new Point(22, 165);
            backupscheduledropdown.Name = "backupscheduledropdown";
            backupscheduledropdown.Size = new Size(463, 26);
            backupscheduledropdown.TabIndex = 16;
            backupscheduledropdown.Text = null;
            backupscheduledropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            backupscheduledropdown.TextLeftMargin = 5;
            backupscheduledropdown.SelectedValueChanged += backupscheduledropdown_SelectedValueChanged;
            // 
            // label16
            // 
            label16.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(22, 124);
            label16.Name = "label16";
            label16.Size = new Size(233, 30);
            label16.TabIndex = 15;
            label16.Text = "Auto Backup Schedule :";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // backupdirectorytxtbox
            // 
            backupdirectorytxtbox.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backupdirectorytxtbox.Location = new Point(22, 66);
            backupdirectorytxtbox.Name = "backupdirectorytxtbox";
            backupdirectorytxtbox.Size = new Size(330, 26);
            backupdirectorytxtbox.TabIndex = 14;
            // 
            // label14
            // 
            label14.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(22, 21);
            label14.Name = "label14";
            label14.Size = new Size(233, 30);
            label14.TabIndex = 13;
            label14.Text = "Backup Directory :";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // clouduploadbtn
            // 
            clouduploadbtn.AllowAnimations = true;
            clouduploadbtn.AllowMouseEffects = true;
            clouduploadbtn.AllowToggling = false;
            clouduploadbtn.AnimationSpeed = 200;
            clouduploadbtn.AutoGenerateColors = false;
            clouduploadbtn.AutoRoundBorders = false;
            clouduploadbtn.AutoSizeLeftIcon = true;
            clouduploadbtn.AutoSizeRightIcon = true;
            clouduploadbtn.BackColor = Color.Transparent;
            clouduploadbtn.BackColor1 = Color.FromArgb(51, 122, 183);
            clouduploadbtn.BackgroundImage = (Image)resources.GetObject("clouduploadbtn.BackgroundImage");
            clouduploadbtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            clouduploadbtn.ButtonText = "Upload to Cloud";
            clouduploadbtn.ButtonTextMarginLeft = 0;
            clouduploadbtn.ColorContrastOnClick = 45;
            clouduploadbtn.ColorContrastOnHover = 45;
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            clouduploadbtn.CustomizableEdges = borderEdges10;
            clouduploadbtn.DialogResult = DialogResult.None;
            clouduploadbtn.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            clouduploadbtn.DisabledFillColor = Color.Empty;
            clouduploadbtn.DisabledForecolor = Color.Empty;
            clouduploadbtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            clouduploadbtn.Font = new Font("Segoe UI", 9F);
            clouduploadbtn.ForeColor = Color.White;
            clouduploadbtn.IconLeft = null;
            clouduploadbtn.IconLeftAlign = ContentAlignment.MiddleLeft;
            clouduploadbtn.IconLeftCursor = Cursors.Default;
            clouduploadbtn.IconLeftPadding = new Padding(11, 3, 3, 3);
            clouduploadbtn.IconMarginLeft = 11;
            clouduploadbtn.IconPadding = 10;
            clouduploadbtn.IconRight = null;
            clouduploadbtn.IconRightAlign = ContentAlignment.MiddleRight;
            clouduploadbtn.IconRightCursor = Cursors.Default;
            clouduploadbtn.IconRightPadding = new Padding(3, 3, 7, 3);
            clouduploadbtn.IconSize = 25;
            clouduploadbtn.IdleBorderColor = Color.Empty;
            clouduploadbtn.IdleBorderRadius = 0;
            clouduploadbtn.IdleBorderThickness = 0;
            clouduploadbtn.IdleFillColor = Color.Empty;
            clouduploadbtn.IdleIconLeftImage = null;
            clouduploadbtn.IdleIconRightImage = null;
            clouduploadbtn.IndicateFocus = false;
            clouduploadbtn.Location = new Point(161, 212);
            clouduploadbtn.Name = "clouduploadbtn";
            clouduploadbtn.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            clouduploadbtn.OnDisabledState.BorderRadius = 1;
            clouduploadbtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            clouduploadbtn.OnDisabledState.BorderThickness = 1;
            clouduploadbtn.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            clouduploadbtn.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            clouduploadbtn.OnDisabledState.IconLeftImage = null;
            clouduploadbtn.OnDisabledState.IconRightImage = null;
            clouduploadbtn.onHoverState.BorderColor = Color.FromArgb(220, 74, 74);
            clouduploadbtn.onHoverState.BorderRadius = 1;
            clouduploadbtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            clouduploadbtn.onHoverState.BorderThickness = 1;
            clouduploadbtn.onHoverState.FillColor = Color.FromArgb(220, 74, 74);
            clouduploadbtn.onHoverState.ForeColor = Color.White;
            clouduploadbtn.onHoverState.IconLeftImage = null;
            clouduploadbtn.onHoverState.IconRightImage = null;
            clouduploadbtn.OnIdleState.BorderColor = Color.Maroon;
            clouduploadbtn.OnIdleState.BorderRadius = 1;
            clouduploadbtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            clouduploadbtn.OnIdleState.BorderThickness = 1;
            clouduploadbtn.OnIdleState.FillColor = Color.Maroon;
            clouduploadbtn.OnIdleState.ForeColor = Color.White;
            clouduploadbtn.OnIdleState.IconLeftImage = null;
            clouduploadbtn.OnIdleState.IconRightImage = null;
            clouduploadbtn.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            clouduploadbtn.OnPressedState.BorderRadius = 1;
            clouduploadbtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            clouduploadbtn.OnPressedState.BorderThickness = 1;
            clouduploadbtn.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            clouduploadbtn.OnPressedState.ForeColor = Color.White;
            clouduploadbtn.OnPressedState.IconLeftImage = null;
            clouduploadbtn.OnPressedState.IconRightImage = null;
            clouduploadbtn.Size = new Size(159, 35);
            clouduploadbtn.TabIndex = 19;
            clouduploadbtn.TextAlign = ContentAlignment.MiddleCenter;
            clouduploadbtn.TextAlignment = HorizontalAlignment.Center;
            clouduploadbtn.TextMarginLeft = 0;
            clouduploadbtn.TextPadding = new Padding(0);
            clouduploadbtn.UseDefaultRadiusAndThickness = true;
            clouduploadbtn.Click += bunifuButton3_Click;
            // 
            // BackupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 662);
            Controls.Add(bunifuShadowPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BackupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BackupForm";
            Load += BackupForm_Load;
            TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            bunifuShadowPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private Panel panel2;
        private Panel panel4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private Bunifu.UI.WinForms.BunifuTextBox Restorebackuptxtbox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Label label2;
        private Panel panel3;
        private Bunifu.UI.WinForms.BunifuDropdown backupscheduledropdown;
        private Label label16;
        private TextBox backupdirectorytxtbox;
        private Label label14;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SelectDirectoryBTN;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ManualBackupBTN;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton clouduploadbtn;
    }
}