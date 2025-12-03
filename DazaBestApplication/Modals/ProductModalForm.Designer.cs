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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            panel1 = new Panel();
            panel3 = new Panel();
            CloseModal = new Bunifu.UI.WinForms.BunifuImageButton();
            Modaltitle = new Label();
            AddProductPic = new PictureBox();
            AddProductBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            label2 = new Label();
            ProductNametxt = new Bunifu.UI.WinForms.BunifuTextBox();
            Productpricetxt = new Bunifu.UI.WinForms.BunifuTextBox();
            label3 = new Label();
            panel2 = new Panel();
            bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ProductModalButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            label1 = new Label();
            ProductCategories = new Bunifu.UI.WinForms.BunifuDropdown();
            label4 = new Label();
            Businessdropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddProductPic).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(CloseModal);
            panel1.Controls.Add(Modaltitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 40);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Maroon;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(460, 5);
            panel3.TabIndex = 2;
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
            CloseModal.Image = Properties.Resources.close;
            CloseModal.ImageActive = null;
            CloseModal.ImageLocation = null;
            CloseModal.ImageMargin = 20;
            CloseModal.ImageSize = new Size(10, 10);
            CloseModal.ImageZoomSize = new Size(30, 30);
            CloseModal.InitialImage = (Image)resources.GetObject("CloseModal.InitialImage");
            CloseModal.Location = new Point(422, 3);
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
            Modaltitle.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Modaltitle.Location = new Point(9, -2);
            Modaltitle.Name = "Modaltitle";
            Modaltitle.Size = new Size(154, 40);
            Modaltitle.TabIndex = 0;
            Modaltitle.Text = "Add Product";
            Modaltitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddProductPic
            // 
            AddProductPic.BorderStyle = BorderStyle.FixedSingle;
            AddProductPic.Location = new Point(12, 55);
            AddProductPic.Name = "AddProductPic";
            AddProductPic.Size = new Size(120, 120);
            AddProductPic.SizeMode = PictureBoxSizeMode.StretchImage;
            AddProductPic.TabIndex = 2;
            AddProductPic.TabStop = false;
            // 
            // AddProductBtn
            // 
            AddProductBtn.AllowAnimations = true;
            AddProductBtn.AllowMouseEffects = true;
            AddProductBtn.AllowToggling = false;
            AddProductBtn.AnimationSpeed = 200;
            AddProductBtn.AutoGenerateColors = false;
            AddProductBtn.AutoRoundBorders = false;
            AddProductBtn.AutoSizeLeftIcon = true;
            AddProductBtn.AutoSizeRightIcon = true;
            AddProductBtn.BackColor = Color.Transparent;
            AddProductBtn.BackColor1 = Color.FromArgb(51, 122, 183);
            AddProductBtn.BackgroundImage = (Image)resources.GetObject("AddProductBtn.BackgroundImage");
            AddProductBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            AddProductBtn.ButtonText = "Insert Image";
            AddProductBtn.ButtonTextMarginLeft = 0;
            AddProductBtn.ColorContrastOnClick = 45;
            AddProductBtn.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            AddProductBtn.CustomizableEdges = borderEdges1;
            AddProductBtn.DialogResult = DialogResult.None;
            AddProductBtn.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            AddProductBtn.DisabledFillColor = Color.Empty;
            AddProductBtn.DisabledForecolor = Color.Empty;
            AddProductBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            AddProductBtn.Font = new Font("Courier New", 9F, FontStyle.Bold);
            AddProductBtn.ForeColor = Color.White;
            AddProductBtn.IconLeft = null;
            AddProductBtn.IconLeftAlign = ContentAlignment.MiddleLeft;
            AddProductBtn.IconLeftCursor = Cursors.Default;
            AddProductBtn.IconLeftPadding = new Padding(11, 3, 3, 3);
            AddProductBtn.IconMarginLeft = 11;
            AddProductBtn.IconPadding = 10;
            AddProductBtn.IconRight = null;
            AddProductBtn.IconRightAlign = ContentAlignment.MiddleRight;
            AddProductBtn.IconRightCursor = Cursors.Default;
            AddProductBtn.IconRightPadding = new Padding(3, 3, 7, 3);
            AddProductBtn.IconSize = 25;
            AddProductBtn.IdleBorderColor = Color.Empty;
            AddProductBtn.IdleBorderRadius = 0;
            AddProductBtn.IdleBorderThickness = 0;
            AddProductBtn.IdleFillColor = Color.Empty;
            AddProductBtn.IdleIconLeftImage = null;
            AddProductBtn.IdleIconRightImage = null;
            AddProductBtn.IndicateFocus = false;
            AddProductBtn.Location = new Point(12, 181);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            AddProductBtn.OnDisabledState.BorderRadius = 1;
            AddProductBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            AddProductBtn.OnDisabledState.BorderThickness = 1;
            AddProductBtn.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            AddProductBtn.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            AddProductBtn.OnDisabledState.IconLeftImage = null;
            AddProductBtn.OnDisabledState.IconRightImage = null;
            AddProductBtn.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            AddProductBtn.onHoverState.BorderRadius = 1;
            AddProductBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            AddProductBtn.onHoverState.BorderThickness = 1;
            AddProductBtn.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            AddProductBtn.onHoverState.ForeColor = Color.White;
            AddProductBtn.onHoverState.IconLeftImage = null;
            AddProductBtn.onHoverState.IconRightImage = null;
            AddProductBtn.OnIdleState.BorderColor = Color.DodgerBlue;
            AddProductBtn.OnIdleState.BorderRadius = 1;
            AddProductBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            AddProductBtn.OnIdleState.BorderThickness = 1;
            AddProductBtn.OnIdleState.FillColor = Color.DodgerBlue;
            AddProductBtn.OnIdleState.ForeColor = Color.White;
            AddProductBtn.OnIdleState.IconLeftImage = null;
            AddProductBtn.OnIdleState.IconRightImage = null;
            AddProductBtn.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            AddProductBtn.OnPressedState.BorderRadius = 1;
            AddProductBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            AddProductBtn.OnPressedState.BorderThickness = 1;
            AddProductBtn.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            AddProductBtn.OnPressedState.ForeColor = Color.White;
            AddProductBtn.OnPressedState.IconLeftImage = null;
            AddProductBtn.OnPressedState.IconRightImage = null;
            AddProductBtn.Size = new Size(120, 30);
            AddProductBtn.TabIndex = 3;
            AddProductBtn.TextAlign = ContentAlignment.MiddleCenter;
            AddProductBtn.TextAlignment = HorizontalAlignment.Center;
            AddProductBtn.TextMarginLeft = 0;
            AddProductBtn.TextPadding = new Padding(0);
            AddProductBtn.UseDefaultRadiusAndThickness = true;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Courier New", 9.75F);
            label2.Location = new Point(146, 36);
            label2.Name = "label2";
            label2.Size = new Size(144, 27);
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
            ProductNametxt.Location = new Point(146, 58);
            ProductNametxt.MaxLength = 20;
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
            ProductNametxt.PlaceholderText = "";
            ProductNametxt.ReadOnly = false;
            ProductNametxt.ScrollBars = ScrollBars.None;
            ProductNametxt.SelectedText = "";
            ProductNametxt.SelectionLength = 0;
            ProductNametxt.SelectionStart = 0;
            ProductNametxt.ShortcutsEnabled = true;
            ProductNametxt.Size = new Size(305, 40);
            ProductNametxt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            ProductNametxt.TabIndex = 5;
            ProductNametxt.TextAlign = HorizontalAlignment.Left;
            ProductNametxt.TextMarginBottom = 0;
            ProductNametxt.TextMarginLeft = 3;
            ProductNametxt.TextMarginTop = 1;
            ProductNametxt.TextPlaceholder = "";
            ProductNametxt.UseSystemPasswordChar = false;
            ProductNametxt.WordWrap = true;
            ProductNametxt.KeyPress += ProductNametxt_KeyPress;
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
            Productpricetxt.Location = new Point(146, 118);
            Productpricetxt.MaxLength = 5;
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
            Productpricetxt.PlaceholderText = "";
            Productpricetxt.ReadOnly = false;
            Productpricetxt.ScrollBars = ScrollBars.None;
            Productpricetxt.SelectedText = "";
            Productpricetxt.SelectionLength = 0;
            Productpricetxt.SelectionStart = 0;
            Productpricetxt.ShortcutsEnabled = true;
            Productpricetxt.Size = new Size(305, 40);
            Productpricetxt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            Productpricetxt.TabIndex = 7;
            Productpricetxt.TextAlign = HorizontalAlignment.Left;
            Productpricetxt.TextMarginBottom = 0;
            Productpricetxt.TextMarginLeft = 3;
            Productpricetxt.TextMarginTop = 1;
            Productpricetxt.TextPlaceholder = "";
            Productpricetxt.UseSystemPasswordChar = false;
            Productpricetxt.WordWrap = true;
            Productpricetxt.KeyPress += Productpricetxt_KeyPress;
            // 
            // label3
            // 
            label3.Font = new Font("Courier New", 9.75F);
            label3.Location = new Point(146, 89);
            label3.Name = "label3";
            label3.Size = new Size(144, 28);
            label3.TabIndex = 6;
            label3.Text = "Product Price :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(bunifuButton2);
            panel2.Controls.Add(ProductModalButton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 280);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 5, 10, 5);
            panel2.Size = new Size(460, 40);
            panel2.TabIndex = 10;
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
            bunifuButton2.ButtonText = "Cancel";
            bunifuButton2.ButtonTextMarginLeft = 0;
            bunifuButton2.ColorContrastOnClick = 45;
            bunifuButton2.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            bunifuButton2.CustomizableEdges = borderEdges2;
            bunifuButton2.DialogResult = DialogResult.None;
            bunifuButton2.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton2.DisabledFillColor = Color.Empty;
            bunifuButton2.DisabledForecolor = Color.Empty;
            bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            bunifuButton2.Font = new Font("Courier New", 9F, FontStyle.Bold);
            bunifuButton2.ForeColor = Color.Black;
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
            bunifuButton2.Location = new Point(257, 5);
            bunifuButton2.Name = "bunifuButton2";
            bunifuButton2.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton2.OnDisabledState.BorderRadius = 1;
            bunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton2.OnDisabledState.BorderThickness = 1;
            bunifuButton2.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            bunifuButton2.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunifuButton2.OnDisabledState.IconLeftImage = null;
            bunifuButton2.OnDisabledState.IconRightImage = null;
            bunifuButton2.onHoverState.BorderColor = Color.Black;
            bunifuButton2.onHoverState.BorderRadius = 1;
            bunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton2.onHoverState.BorderThickness = 1;
            bunifuButton2.onHoverState.FillColor = Color.FromArgb(205, 205, 207);
            bunifuButton2.onHoverState.ForeColor = Color.Black;
            bunifuButton2.onHoverState.IconLeftImage = null;
            bunifuButton2.onHoverState.IconRightImage = null;
            bunifuButton2.OnIdleState.BorderColor = Color.FromArgb(220, 220, 221);
            bunifuButton2.OnIdleState.BorderRadius = 1;
            bunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton2.OnIdleState.BorderThickness = 1;
            bunifuButton2.OnIdleState.FillColor = Color.FromArgb(220, 220, 221);
            bunifuButton2.OnIdleState.ForeColor = Color.Black;
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
            bunifuButton2.Size = new Size(65, 30);
            bunifuButton2.TabIndex = 2;
            bunifuButton2.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton2.TextAlignment = HorizontalAlignment.Center;
            bunifuButton2.TextMarginLeft = 0;
            bunifuButton2.TextPadding = new Padding(0);
            bunifuButton2.UseDefaultRadiusAndThickness = true;
            bunifuButton2.Click += bunifuButton2_Click;
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            ProductModalButton.CustomizableEdges = borderEdges3;
            ProductModalButton.DialogResult = DialogResult.None;
            ProductModalButton.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            ProductModalButton.DisabledFillColor = Color.Empty;
            ProductModalButton.DisabledForecolor = Color.Empty;
            ProductModalButton.Dock = DockStyle.Right;
            ProductModalButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            ProductModalButton.Font = new Font("Courier New", 9F, FontStyle.Bold);
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
            ProductModalButton.Location = new Point(340, 5);
            ProductModalButton.Name = "ProductModalButton";
            ProductModalButton.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            ProductModalButton.OnDisabledState.BorderRadius = 1;
            ProductModalButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            ProductModalButton.OnDisabledState.BorderThickness = 1;
            ProductModalButton.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            ProductModalButton.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            ProductModalButton.OnDisabledState.IconLeftImage = null;
            ProductModalButton.OnDisabledState.IconRightImage = null;
            ProductModalButton.onHoverState.BorderColor = Color.FromArgb(50, 110, 5);
            ProductModalButton.onHoverState.BorderRadius = 1;
            ProductModalButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            ProductModalButton.onHoverState.BorderThickness = 1;
            ProductModalButton.onHoverState.FillColor = Color.FromArgb(50, 110, 5);
            ProductModalButton.onHoverState.ForeColor = Color.White;
            ProductModalButton.onHoverState.IconLeftImage = null;
            ProductModalButton.onHoverState.IconRightImage = null;
            ProductModalButton.OnIdleState.BorderColor = Color.FromArgb(78, 160, 21);
            ProductModalButton.OnIdleState.BorderRadius = 1;
            ProductModalButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            ProductModalButton.OnIdleState.BorderThickness = 1;
            ProductModalButton.OnIdleState.FillColor = Color.FromArgb(78, 160, 21);
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
            // label1
            // 
            label1.Font = new Font("Courier New", 9.75F);
            label1.Location = new Point(147, 150);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 11;
            label1.Text = "Belong to :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductCategories
            // 
            ProductCategories.BackColor = Color.Transparent;
            ProductCategories.BackgroundColor = Color.White;
            ProductCategories.BorderColor = Color.Silver;
            ProductCategories.BorderRadius = 1;
            ProductCategories.Color = Color.Silver;
            ProductCategories.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            ProductCategories.DisabledBackColor = Color.FromArgb(240, 240, 240);
            ProductCategories.DisabledBorderColor = Color.FromArgb(204, 204, 204);
            ProductCategories.DisabledColor = Color.FromArgb(240, 240, 240);
            ProductCategories.DisabledForeColor = Color.FromArgb(109, 109, 109);
            ProductCategories.DisabledIndicatorColor = Color.DarkGray;
            ProductCategories.DrawMode = DrawMode.OwnerDrawFixed;
            ProductCategories.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            ProductCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            ProductCategories.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            ProductCategories.FillDropDown = true;
            ProductCategories.FillIndicator = false;
            ProductCategories.FlatStyle = FlatStyle.Flat;
            ProductCategories.Font = new Font("Segoe UI", 9F);
            ProductCategories.ForeColor = Color.Black;
            ProductCategories.FormattingEnabled = true;
            ProductCategories.Icon = null;
            ProductCategories.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            ProductCategories.IndicatorColor = Color.DarkGray;
            ProductCategories.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            ProductCategories.IndicatorThickness = 2;
            ProductCategories.IsDropdownOpened = false;
            ProductCategories.ItemBackColor = Color.White;
            ProductCategories.ItemBorderColor = Color.White;
            ProductCategories.ItemForeColor = Color.Black;
            ProductCategories.ItemHeight = 26;
            ProductCategories.ItemHighLightColor = Color.DodgerBlue;
            ProductCategories.ItemHighLightForeColor = Color.White;
            ProductCategories.ItemTopMargin = 3;
            ProductCategories.Location = new Point(147, 232);
            ProductCategories.Name = "ProductCategories";
            ProductCategories.Size = new Size(305, 32);
            ProductCategories.TabIndex = 12;
            ProductCategories.Text = null;
            ProductCategories.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            ProductCategories.TextLeftMargin = 5;
            // 
            // label4
            // 
            label4.Font = new Font("Courier New", 9.75F);
            label4.Location = new Point(146, 212);
            label4.Name = "label4";
            label4.Size = new Size(144, 17);
            label4.TabIndex = 13;
            label4.Text = "Categories :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Businessdropdown
            // 
            Businessdropdown.BackColor = Color.Transparent;
            Businessdropdown.BackgroundColor = Color.White;
            Businessdropdown.BorderColor = Color.Silver;
            Businessdropdown.BorderRadius = 1;
            Businessdropdown.Color = Color.Silver;
            Businessdropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            Businessdropdown.DisabledBackColor = Color.FromArgb(240, 240, 240);
            Businessdropdown.DisabledBorderColor = Color.FromArgb(204, 204, 204);
            Businessdropdown.DisabledColor = Color.FromArgb(240, 240, 240);
            Businessdropdown.DisabledForeColor = Color.FromArgb(109, 109, 109);
            Businessdropdown.DisabledIndicatorColor = Color.DarkGray;
            Businessdropdown.DrawMode = DrawMode.OwnerDrawFixed;
            Businessdropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            Businessdropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            Businessdropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            Businessdropdown.FillDropDown = true;
            Businessdropdown.FillIndicator = false;
            Businessdropdown.FlatStyle = FlatStyle.Flat;
            Businessdropdown.Font = new Font("Segoe UI", 9F);
            Businessdropdown.ForeColor = Color.Black;
            Businessdropdown.FormattingEnabled = true;
            Businessdropdown.Icon = null;
            Businessdropdown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            Businessdropdown.IndicatorColor = Color.DarkGray;
            Businessdropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            Businessdropdown.IndicatorThickness = 2;
            Businessdropdown.IsDropdownOpened = false;
            Businessdropdown.ItemBackColor = Color.White;
            Businessdropdown.ItemBorderColor = Color.White;
            Businessdropdown.ItemForeColor = Color.Black;
            Businessdropdown.ItemHeight = 26;
            Businessdropdown.ItemHighLightColor = Color.DodgerBlue;
            Businessdropdown.ItemHighLightForeColor = Color.White;
            Businessdropdown.ItemTopMargin = 3;
            Businessdropdown.Location = new Point(147, 177);
            Businessdropdown.Name = "Businessdropdown";
            Businessdropdown.Size = new Size(305, 32);
            Businessdropdown.TabIndex = 14;
            Businessdropdown.Text = null;
            Businessdropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            Businessdropdown.TextLeftMargin = 5;
            Businessdropdown.SelectedValueChanged += Businessdropdown_SelectedValueChanged;
            // 
            // ProductModalForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(460, 320);
            Controls.Add(Businessdropdown);
            Controls.Add(label4);
            Controls.Add(ProductCategories);
            Controls.Add(panel2);
            Controls.Add(Productpricetxt);
            Controls.Add(ProductNametxt);
            Controls.Add(AddProductBtn);
            Controls.Add(AddProductPic);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ProductModalForm";
            Text = "ProductModal";
            Load += ProductModalForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AddProductPic).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Bunifu.UI.WinForms.BunifuImageButton CloseModal;
        private Label Modaltitle;
        private PictureBox AddProductPic;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AddProductBtn;
        private Label label2;
        private Bunifu.UI.WinForms.BunifuTextBox ProductNametxt;
        private Bunifu.UI.WinForms.BunifuTextBox Productpricetxt;
        private Label label3;
        private Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ProductModalButton;
        private Panel panel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private Label label1;
        private Bunifu.UI.WinForms.BunifuDropdown ProductCategories;
        private Label label4;
        private Bunifu.UI.WinForms.BunifuDropdown Businessdropdown;
    }
}