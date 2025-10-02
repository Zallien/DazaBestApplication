namespace DazaBestApplication.Modals
{
    partial class ProductModalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductModalForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            panel1 = new Panel();
            CloseModal = new Bunifu.UI.WinForms.BunifuImageButton();
            Modaltitle = new Label();
            pictureBox1 = new PictureBox();
            bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            label2 = new Label();
            ProductNametxt = new Bunifu.UI.WinForms.BunifuTextBox();
            Productpricetxt = new Bunifu.UI.WinForms.BunifuTextBox();
            label3 = new Label();
            panel2 = new Panel();
            ProductModalButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 192, 45);
            panel1.Controls.Add(CloseModal);
            panel1.Controls.Add(Modaltitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 40);
            panel1.TabIndex = 1;
            // 
            // CloseModal
            // 
            CloseModal.ActiveImage = null;
            CloseModal.AllowAnimations = true;
            CloseModal.AllowBuffering = false;
            CloseModal.AllowToggling = false;
            CloseModal.AllowZooming = true;
            CloseModal.AllowZoomingOnFocus = false;
            CloseModal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CloseModal.BackColor = Color.Transparent;
            CloseModal.DialogResult = DialogResult.None;
            CloseModal.ErrorImage = (Image)resources.GetObject("CloseModal.ErrorImage");
            CloseModal.FadeWhenInactive = false;
            CloseModal.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            CloseModal.Image = Properties.Resources.logout;
            CloseModal.ImageActive = null;
            CloseModal.ImageLocation = null;
            CloseModal.ImageMargin = 20;
            CloseModal.ImageSize = new Size(10, 10);
            CloseModal.ImageZoomSize = new Size(30, 30);
            CloseModal.InitialImage = (Image)resources.GetObject("CloseModal.InitialImage");
            CloseModal.Location = new Point(412, 5);
            CloseModal.Name = "CloseModal";
            CloseModal.Rotation = 0;
            CloseModal.ShowActiveImage = true;
            CloseModal.ShowCursorChanges = true;
            CloseModal.ShowImageBorders = true;
            CloseModal.ShowSizeMarkers = false;
            CloseModal.Size = new Size(30, 30);
            CloseModal.TabIndex = 1;
            CloseModal.ToolTipText = "";
            CloseModal.WaitOnLoad = false;
            CloseModal.Zoom = 20;
            CloseModal.ZoomSpeed = 10;
            CloseModal.Click += CloseModal_Click;
            // 
            // Modaltitle
            // 
            Modaltitle.BackColor = Color.Transparent;
            Modaltitle.Dock = DockStyle.Left;
            Modaltitle.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Modaltitle.Location = new Point(0, 0);
            Modaltitle.Name = "Modaltitle";
            Modaltitle.Size = new Size(154, 40);
            Modaltitle.TabIndex = 0;
            Modaltitle.Text = "Add Product";
            Modaltitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
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
            bunifuButton1.ButtonText = "Insert Image";
            bunifuButton1.ButtonTextMarginLeft = 0;
            bunifuButton1.ColorContrastOnClick = 45;
            bunifuButton1.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            bunifuButton1.CustomizableEdges = borderEdges1;
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
            bunifuButton1.Location = new Point(12, 172);
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
            bunifuButton1.Size = new Size(120, 30);
            bunifuButton1.TabIndex = 3;
            bunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton1.TextAlignment = HorizontalAlignment.Center;
            bunifuButton1.TextMarginLeft = 0;
            bunifuButton1.TextPadding = new Padding(0);
            bunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // label2
            // 
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(138, 46);
            label2.Name = "label2";
            label2.Size = new Size(144, 30);
            label2.TabIndex = 4;
            label2.Text = "Product Name :";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductNametxt
            // 
            ProductNametxt.AcceptsReturn = false;
            ProductNametxt.AcceptsTab = false;
            ProductNametxt.AnimationSpeed = 200;
            ProductNametxt.AutoCompleteMode = AutoCompleteMode.None;
            ProductNametxt.AutoCompleteSource = AutoCompleteSource.None;
            ProductNametxt.AutoSizeHeight = true;
            ProductNametxt.BackColor = Color.Transparent;
            ProductNametxt.BackgroundImage = (Image)resources.GetObject("ProductNametxt.BackgroundImage");
            ProductNametxt.BorderColorActive = Color.DodgerBlue;
            ProductNametxt.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            ProductNametxt.BorderColorHover = Color.FromArgb(105, 181, 255);
            ProductNametxt.BorderColorIdle = Color.Silver;
            ProductNametxt.BorderRadius = 1;
            ProductNametxt.BorderThickness = 1;
            ProductNametxt.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            ProductNametxt.CharacterCasing = CharacterCasing.Normal;
            ProductNametxt.DefaultFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductNametxt.DefaultText = "";
            ProductNametxt.FillColor = Color.White;
            ProductNametxt.HideSelection = true;
            ProductNametxt.IconLeft = null;
            ProductNametxt.IconLeftCursor = Cursors.IBeam;
            ProductNametxt.IconPadding = 10;
            ProductNametxt.IconRight = null;
            ProductNametxt.IconRightCursor = Cursors.IBeam;
            ProductNametxt.Location = new Point(146, 76);
            ProductNametxt.MaxLength = 32767;
            ProductNametxt.MinimumSize = new Size(1, 1);
            ProductNametxt.Modified = false;
            ProductNametxt.Multiline = false;
            ProductNametxt.Name = "ProductNametxt";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            ProductNametxt.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            ProductNametxt.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            ProductNametxt.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.Empty;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            ProductNametxt.OnIdleState = stateProperties4;
            ProductNametxt.Padding = new Padding(3);
            ProductNametxt.PasswordChar = '\0';
            ProductNametxt.PlaceholderForeColor = Color.Silver;
            ProductNametxt.PlaceholderText = "Enter text";
            ProductNametxt.ReadOnly = false;
            ProductNametxt.ScrollBars = ScrollBars.None;
            ProductNametxt.SelectedText = "";
            ProductNametxt.SelectionLength = 0;
            ProductNametxt.SelectionStart = 0;
            ProductNametxt.ShortcutsEnabled = true;
            ProductNametxt.Size = new Size(292, 40);
            ProductNametxt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            ProductNametxt.TabIndex = 5;
            ProductNametxt.TextAlign = HorizontalAlignment.Left;
            ProductNametxt.TextMarginBottom = 0;
            ProductNametxt.TextMarginLeft = 3;
            ProductNametxt.TextMarginTop = 1;
            ProductNametxt.TextPlaceholder = "Enter text";
            ProductNametxt.UseSystemPasswordChar = false;
            ProductNametxt.WordWrap = true;
            // 
            // Productpricetxt
            // 
            Productpricetxt.AcceptsReturn = false;
            Productpricetxt.AcceptsTab = false;
            Productpricetxt.AnimationSpeed = 200;
            Productpricetxt.AutoCompleteMode = AutoCompleteMode.None;
            Productpricetxt.AutoCompleteSource = AutoCompleteSource.None;
            Productpricetxt.AutoSizeHeight = true;
            Productpricetxt.BackColor = Color.Transparent;
            Productpricetxt.BackgroundImage = (Image)resources.GetObject("Productpricetxt.BackgroundImage");
            Productpricetxt.BorderColorActive = Color.DodgerBlue;
            Productpricetxt.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            Productpricetxt.BorderColorHover = Color.FromArgb(105, 181, 255);
            Productpricetxt.BorderColorIdle = Color.Silver;
            Productpricetxt.BorderRadius = 1;
            Productpricetxt.BorderThickness = 1;
            Productpricetxt.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            Productpricetxt.CharacterCasing = CharacterCasing.Normal;
            Productpricetxt.DefaultFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Productpricetxt.DefaultText = "";
            Productpricetxt.FillColor = Color.White;
            Productpricetxt.HideSelection = true;
            Productpricetxt.IconLeft = null;
            Productpricetxt.IconLeftCursor = Cursors.IBeam;
            Productpricetxt.IconPadding = 10;
            Productpricetxt.IconRight = null;
            Productpricetxt.IconRightCursor = Cursors.IBeam;
            Productpricetxt.Location = new Point(146, 140);
            Productpricetxt.MaxLength = 32767;
            Productpricetxt.MinimumSize = new Size(1, 1);
            Productpricetxt.Modified = false;
            Productpricetxt.Multiline = false;
            Productpricetxt.Name = "Productpricetxt";
            stateProperties5.BorderColor = Color.DodgerBlue;
            stateProperties5.FillColor = Color.Empty;
            stateProperties5.ForeColor = Color.Empty;
            stateProperties5.PlaceholderForeColor = Color.Empty;
            Productpricetxt.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties6.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties6.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties6.PlaceholderForeColor = Color.DarkGray;
            Productpricetxt.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties7.FillColor = Color.Empty;
            stateProperties7.ForeColor = Color.Empty;
            stateProperties7.PlaceholderForeColor = Color.Empty;
            Productpricetxt.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = Color.Silver;
            stateProperties8.FillColor = Color.White;
            stateProperties8.ForeColor = Color.Empty;
            stateProperties8.PlaceholderForeColor = Color.Empty;
            Productpricetxt.OnIdleState = stateProperties8;
            Productpricetxt.Padding = new Padding(3);
            Productpricetxt.PasswordChar = '\0';
            Productpricetxt.PlaceholderForeColor = Color.Silver;
            Productpricetxt.PlaceholderText = "Enter text";
            Productpricetxt.ReadOnly = false;
            Productpricetxt.ScrollBars = ScrollBars.None;
            Productpricetxt.SelectedText = "";
            Productpricetxt.SelectionLength = 0;
            Productpricetxt.SelectionStart = 0;
            Productpricetxt.ShortcutsEnabled = true;
            Productpricetxt.Size = new Size(217, 40);
            Productpricetxt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            Productpricetxt.TabIndex = 7;
            Productpricetxt.TextAlign = HorizontalAlignment.Left;
            Productpricetxt.TextMarginBottom = 0;
            Productpricetxt.TextMarginLeft = 3;
            Productpricetxt.TextMarginTop = 1;
            Productpricetxt.TextPlaceholder = "Enter text";
            Productpricetxt.UseSystemPasswordChar = false;
            Productpricetxt.WordWrap = true;
            // 
            // label3
            // 
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(138, 109);
            label3.Name = "label3";
            label3.Size = new Size(144, 30);
            label3.TabIndex = 6;
            label3.Text = "Product Price :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(ProductModalButton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 222);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 5, 10, 5);
            panel2.Size = new Size(450, 40);
            panel2.TabIndex = 10;
            // 
            // ProductModalButton
            // 
            ProductModalButton.AllowAnimations = true;
            ProductModalButton.AllowMouseEffects = true;
            ProductModalButton.AllowToggling = false;
            ProductModalButton.AnimationSpeed = 200;
            ProductModalButton.AutoGenerateColors = false;
            ProductModalButton.AutoRoundBorders = false;
            ProductModalButton.AutoSizeLeftIcon = true;
            ProductModalButton.AutoSizeRightIcon = true;
            ProductModalButton.BackColor = Color.Transparent;
            ProductModalButton.BackColor1 = Color.FromArgb(51, 122, 183);
            ProductModalButton.BackgroundImage = (Image)resources.GetObject("ProductModalButton.BackgroundImage");
            ProductModalButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            ProductModalButton.ButtonText = "Add Product";
            ProductModalButton.ButtonTextMarginLeft = 0;
            ProductModalButton.ColorContrastOnClick = 45;
            ProductModalButton.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            ProductModalButton.CustomizableEdges = borderEdges2;
            ProductModalButton.DialogResult = DialogResult.None;
            ProductModalButton.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            ProductModalButton.DisabledFillColor = Color.Empty;
            ProductModalButton.DisabledForecolor = Color.Empty;
            ProductModalButton.Dock = DockStyle.Right;
            ProductModalButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            ProductModalButton.Font = new Font("Segoe UI", 9F);
            ProductModalButton.ForeColor = Color.White;
            ProductModalButton.IconLeft = null;
            ProductModalButton.IconLeftAlign = ContentAlignment.MiddleLeft;
            ProductModalButton.IconLeftCursor = Cursors.Default;
            ProductModalButton.IconLeftPadding = new Padding(11, 3, 3, 3);
            ProductModalButton.IconMarginLeft = 11;
            ProductModalButton.IconPadding = 10;
            ProductModalButton.IconRight = null;
            ProductModalButton.IconRightAlign = ContentAlignment.MiddleRight;
            ProductModalButton.IconRightCursor = Cursors.Default;
            ProductModalButton.IconRightPadding = new Padding(3, 3, 7, 3);
            ProductModalButton.IconSize = 25;
            ProductModalButton.IdleBorderColor = Color.Empty;
            ProductModalButton.IdleBorderRadius = 0;
            ProductModalButton.IdleBorderThickness = 0;
            ProductModalButton.IdleFillColor = Color.Empty;
            ProductModalButton.IdleIconLeftImage = null;
            ProductModalButton.IdleIconRightImage = null;
            ProductModalButton.IndicateFocus = false;
            ProductModalButton.Location = new Point(330, 5);
            ProductModalButton.Name = "ProductModalButton";
            ProductModalButton.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            ProductModalButton.OnDisabledState.BorderRadius = 1;
            ProductModalButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            ProductModalButton.OnDisabledState.BorderThickness = 1;
            ProductModalButton.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            ProductModalButton.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            ProductModalButton.OnDisabledState.IconLeftImage = null;
            ProductModalButton.OnDisabledState.IconRightImage = null;
            ProductModalButton.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            ProductModalButton.onHoverState.BorderRadius = 1;
            ProductModalButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            ProductModalButton.onHoverState.BorderThickness = 1;
            ProductModalButton.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            ProductModalButton.onHoverState.ForeColor = Color.White;
            ProductModalButton.onHoverState.IconLeftImage = null;
            ProductModalButton.onHoverState.IconRightImage = null;
            ProductModalButton.OnIdleState.BorderColor = Color.DodgerBlue;
            ProductModalButton.OnIdleState.BorderRadius = 1;
            ProductModalButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            ProductModalButton.OnIdleState.BorderThickness = 1;
            ProductModalButton.OnIdleState.FillColor = Color.DodgerBlue;
            ProductModalButton.OnIdleState.ForeColor = Color.White;
            ProductModalButton.OnIdleState.IconLeftImage = null;
            ProductModalButton.OnIdleState.IconRightImage = null;
            ProductModalButton.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            ProductModalButton.OnPressedState.BorderRadius = 1;
            ProductModalButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            ProductModalButton.OnPressedState.BorderThickness = 1;
            ProductModalButton.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            ProductModalButton.OnPressedState.ForeColor = Color.White;
            ProductModalButton.OnPressedState.IconLeftImage = null;
            ProductModalButton.OnPressedState.IconRightImage = null;
            ProductModalButton.Size = new Size(110, 30);
            ProductModalButton.TabIndex = 1;
            ProductModalButton.TextAlign = ContentAlignment.MiddleCenter;
            ProductModalButton.TextAlignment = HorizontalAlignment.Center;
            ProductModalButton.TextMarginLeft = 0;
            ProductModalButton.TextPadding = new Padding(0);
            ProductModalButton.UseDefaultRadiusAndThickness = true;
            ProductModalButton.Click += ProductModalButton_Click;
            // 
            // ProductModalForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 262);
            Controls.Add(panel2);
            Controls.Add(Productpricetxt);
            Controls.Add(label3);
            Controls.Add(ProductNametxt);
            Controls.Add(label2);
            Controls.Add(bunifuButton1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ProductModalForm";
            Text = "ProductModal";
            Load += ProductModalForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Bunifu.UI.WinForms.BunifuImageButton CloseModal;
        private Label Modaltitle;
        private PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Label label2;
        private Bunifu.UI.WinForms.BunifuTextBox ProductNametxt;
        private Bunifu.UI.WinForms.BunifuTextBox Productpricetxt;
        private Label label3;
        private Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ProductModalButton;
    }
}