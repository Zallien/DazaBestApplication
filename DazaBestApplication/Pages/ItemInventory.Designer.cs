namespace DazaBestApplication.Pages
{
    partial class ItemInventory
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemInventory));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            TopPanel = new Panel();
            label1 = new Label();
            MainContainer = new Panel();
            Pagination = new Panel();
            PaginationLabel = new Label();
            PaginationPREV = new Bunifu.UI.WinForms.BunifuImageButton();
            PaginationNext = new Bunifu.UI.WinForms.BunifuImageButton();
            panel1 = new Panel();
            AddItemButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            bunifuButton22 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            SearchBoxTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            AllItemsDatagrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            RowCol = new DataGridViewTextBoxColumn();
            ItemCodeCol = new DataGridViewTextBoxColumn();
            ItemNameCol = new DataGridViewTextBoxColumn();
            StocksCol = new DataGridViewTextBoxColumn();
            PriceCol = new DataGridViewTextBoxColumn();
            MenustripforItems = new ContextMenuStrip(components);
            edittoolstrip = new ToolStripMenuItem();
            sep1 = new ToolStripSeparator();
            deletetoolstrip = new ToolStripMenuItem();
            TopPanel.SuspendLayout();
            MainContainer.SuspendLayout();
            Pagination.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AllItemsDatagrid).BeginInit();
            MenustripforItems.SuspendLayout();
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
            TopPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 0);
            label1.Name = "label1";
            label1.Size = new Size(245, 50);
            label1.TabIndex = 0;
            label1.Text = "Inventory";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainContainer
            // 
            MainContainer.Controls.Add(Pagination);
            MainContainer.Controls.Add(panel1);
            MainContainer.Controls.Add(AllItemsDatagrid);
            MainContainer.Dock = DockStyle.Fill;
            MainContainer.Location = new Point(0, 50);
            MainContainer.Name = "MainContainer";
            MainContainer.Padding = new Padding(0, 10, 0, 0);
            MainContainer.Size = new Size(900, 612);
            MainContainer.TabIndex = 1;
            // 
            // Pagination
            // 
            Pagination.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Pagination.Controls.Add(PaginationLabel);
            Pagination.Controls.Add(PaginationPREV);
            Pagination.Controls.Add(PaginationNext);
            Pagination.Location = new Point(10, 559);
            Pagination.Name = "Pagination";
            Pagination.Size = new Size(145, 50);
            Pagination.TabIndex = 8;
            // 
            // PaginationLabel
            // 
            PaginationLabel.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaginationLabel.Location = new Point(52, 7);
            PaginationLabel.Name = "PaginationLabel";
            PaginationLabel.Size = new Size(40, 40);
            PaginationLabel.TabIndex = 7;
            PaginationLabel.Text = "0";
            PaginationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PaginationPREV
            // 
            PaginationPREV.ActiveImage = null;
            PaginationPREV.AllowAnimations = true;
            PaginationPREV.AllowBuffering = false;
            PaginationPREV.AllowToggling = false;
            PaginationPREV.AllowZooming = true;
            PaginationPREV.AllowZoomingOnFocus = false;
            PaginationPREV.BackColor = Color.Transparent;
            PaginationPREV.DialogResult = DialogResult.None;
            PaginationPREV.ErrorImage = (Image)resources.GetObject("PaginationPREV.ErrorImage");
            PaginationPREV.FadeWhenInactive = false;
            PaginationPREV.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            PaginationPREV.Image = Properties.Resources.prev;
            PaginationPREV.ImageActive = null;
            PaginationPREV.ImageLocation = null;
            PaginationPREV.ImageMargin = 20;
            PaginationPREV.ImageSize = new Size(20, 20);
            PaginationPREV.ImageZoomSize = new Size(40, 40);
            PaginationPREV.InitialImage = (Image)resources.GetObject("PaginationPREV.InitialImage");
            PaginationPREV.Location = new Point(6, 7);
            PaginationPREV.Name = "PaginationPREV";
            PaginationPREV.Rotation = 0;
            PaginationPREV.ShowActiveImage = true;
            PaginationPREV.ShowCursorChanges = true;
            PaginationPREV.ShowImageBorders = true;
            PaginationPREV.ShowSizeMarkers = false;
            PaginationPREV.Size = new Size(40, 40);
            PaginationPREV.TabIndex = 5;
            PaginationPREV.ToolTipText = "";
            PaginationPREV.WaitOnLoad = false;
            PaginationPREV.Zoom = 20;
            PaginationPREV.ZoomSpeed = 10;
            PaginationPREV.Click += PaginationPREV_Click;
            // 
            // PaginationNext
            // 
            PaginationNext.ActiveImage = null;
            PaginationNext.AllowAnimations = true;
            PaginationNext.AllowBuffering = false;
            PaginationNext.AllowToggling = false;
            PaginationNext.AllowZooming = true;
            PaginationNext.AllowZoomingOnFocus = false;
            PaginationNext.BackColor = Color.Transparent;
            PaginationNext.DialogResult = DialogResult.None;
            PaginationNext.ErrorImage = (Image)resources.GetObject("PaginationNext.ErrorImage");
            PaginationNext.FadeWhenInactive = false;
            PaginationNext.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            PaginationNext.Image = Properties.Resources.right;
            PaginationNext.ImageActive = null;
            PaginationNext.ImageLocation = null;
            PaginationNext.ImageMargin = 20;
            PaginationNext.ImageSize = new Size(20, 20);
            PaginationNext.ImageZoomSize = new Size(40, 40);
            PaginationNext.InitialImage = (Image)resources.GetObject("PaginationNext.InitialImage");
            PaginationNext.Location = new Point(98, 7);
            PaginationNext.Name = "PaginationNext";
            PaginationNext.Rotation = 0;
            PaginationNext.ShowActiveImage = true;
            PaginationNext.ShowCursorChanges = true;
            PaginationNext.ShowImageBorders = true;
            PaginationNext.ShowSizeMarkers = false;
            PaginationNext.Size = new Size(40, 40);
            PaginationNext.TabIndex = 6;
            PaginationNext.ToolTipText = "";
            PaginationNext.WaitOnLoad = false;
            PaginationNext.Zoom = 20;
            PaginationNext.ZoomSpeed = 10;
            PaginationNext.Click += PaginationNext_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(AddItemButton);
            panel1.Controls.Add(bunifuButton22);
            panel1.Controls.Add(SearchBoxTextBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5, 0, 5, 0);
            panel1.Size = new Size(900, 130);
            panel1.TabIndex = 4;
            // 
            // AddItemButton
            // 
            AddItemButton.AllowAnimations = true;
            AddItemButton.AllowMouseEffects = true;
            AddItemButton.AllowToggling = false;
            AddItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddItemButton.AnimationSpeed = 200;
            AddItemButton.AutoGenerateColors = false;
            AddItemButton.AutoRoundBorders = false;
            AddItemButton.AutoSizeLeftIcon = true;
            AddItemButton.AutoSizeRightIcon = true;
            AddItemButton.BackColor = Color.Transparent;
            AddItemButton.BackColor1 = Color.Orange;
            AddItemButton.BackgroundImage = (Image)resources.GetObject("AddItemButton.BackgroundImage");
            AddItemButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddItemButton.ButtonText = "Add Item";
            AddItemButton.ButtonTextMarginLeft = 0;
            AddItemButton.ColorContrastOnClick = 45;
            AddItemButton.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            AddItemButton.CustomizableEdges = borderEdges1;
            AddItemButton.DialogResult = DialogResult.None;
            AddItemButton.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            AddItemButton.DisabledFillColor = Color.FromArgb(204, 204, 204);
            AddItemButton.DisabledForecolor = Color.FromArgb(168, 160, 168);
            AddItemButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            AddItemButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddItemButton.ForeColor = Color.White;
            AddItemButton.IconLeftAlign = ContentAlignment.MiddleLeft;
            AddItemButton.IconLeftCursor = Cursors.Default;
            AddItemButton.IconLeftPadding = new Padding(11, 3, 3, 3);
            AddItemButton.IconMarginLeft = 11;
            AddItemButton.IconPadding = 10;
            AddItemButton.IconRightAlign = ContentAlignment.MiddleRight;
            AddItemButton.IconRightCursor = Cursors.Default;
            AddItemButton.IconRightPadding = new Padding(3, 3, 7, 3);
            AddItemButton.IconSize = 25;
            AddItemButton.IdleBorderColor = Color.FromArgb(192, 64, 0);
            AddItemButton.IdleBorderRadius = 1;
            AddItemButton.IdleBorderThickness = 1;
            AddItemButton.IdleFillColor = Color.Orange;
            AddItemButton.IdleIconLeftImage = null;
            AddItemButton.IdleIconRightImage = null;
            AddItemButton.IndicateFocus = false;
            AddItemButton.Location = new Point(5, 87);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            AddItemButton.OnDisabledState.BorderRadius = 1;
            AddItemButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddItemButton.OnDisabledState.BorderThickness = 1;
            AddItemButton.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            AddItemButton.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            AddItemButton.OnDisabledState.IconLeftImage = null;
            AddItemButton.OnDisabledState.IconRightImage = null;
            AddItemButton.onHoverState.BorderColor = Color.FromArgb(105, 181, 255);
            AddItemButton.onHoverState.BorderRadius = 1;
            AddItemButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddItemButton.onHoverState.BorderThickness = 1;
            AddItemButton.onHoverState.FillColor = Color.FromArgb(255, 128, 0);
            AddItemButton.onHoverState.ForeColor = Color.White;
            AddItemButton.onHoverState.IconLeftImage = null;
            AddItemButton.onHoverState.IconRightImage = null;
            AddItemButton.OnIdleState.BorderColor = Color.FromArgb(192, 64, 0);
            AddItemButton.OnIdleState.BorderRadius = 1;
            AddItemButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddItemButton.OnIdleState.BorderThickness = 1;
            AddItemButton.OnIdleState.FillColor = Color.Orange;
            AddItemButton.OnIdleState.ForeColor = Color.White;
            AddItemButton.OnIdleState.IconLeftImage = null;
            AddItemButton.OnIdleState.IconRightImage = null;
            AddItemButton.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            AddItemButton.OnPressedState.BorderRadius = 1;
            AddItemButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddItemButton.OnPressedState.BorderThickness = 1;
            AddItemButton.OnPressedState.FillColor = Color.FromArgb(192, 64, 0);
            AddItemButton.OnPressedState.ForeColor = Color.White;
            AddItemButton.OnPressedState.IconLeftImage = null;
            AddItemButton.OnPressedState.IconRightImage = null;
            AddItemButton.Size = new Size(150, 40);
            AddItemButton.TabIndex = 1;
            AddItemButton.TextAlign = ContentAlignment.MiddleCenter;
            AddItemButton.TextAlignment = HorizontalAlignment.Center;
            AddItemButton.TextMarginLeft = 0;
            AddItemButton.TextPadding = new Padding(0);
            AddItemButton.UseDefaultRadiusAndThickness = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // bunifuButton22
            // 
            bunifuButton22.AllowAnimations = true;
            bunifuButton22.AllowMouseEffects = true;
            bunifuButton22.AllowToggling = false;
            bunifuButton22.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bunifuButton22.AnimationSpeed = 200;
            bunifuButton22.AutoGenerateColors = false;
            bunifuButton22.AutoRoundBorders = false;
            bunifuButton22.AutoSizeLeftIcon = true;
            bunifuButton22.AutoSizeRightIcon = true;
            bunifuButton22.BackColor = Color.Transparent;
            bunifuButton22.BackColor1 = Color.Orange;
            bunifuButton22.BackgroundImage = (Image)resources.GetObject("bunifuButton22.BackgroundImage");
            bunifuButton22.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton22.ButtonText = "Report";
            bunifuButton22.ButtonTextMarginLeft = 0;
            bunifuButton22.ColorContrastOnClick = 45;
            bunifuButton22.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            bunifuButton22.CustomizableEdges = borderEdges2;
            bunifuButton22.DialogResult = DialogResult.None;
            bunifuButton22.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton22.DisabledFillColor = Color.FromArgb(204, 204, 204);
            bunifuButton22.DisabledForecolor = Color.FromArgb(168, 160, 168);
            bunifuButton22.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            bunifuButton22.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuButton22.ForeColor = Color.White;
            bunifuButton22.IconLeftAlign = ContentAlignment.MiddleLeft;
            bunifuButton22.IconLeftCursor = Cursors.Default;
            bunifuButton22.IconLeftPadding = new Padding(11, 3, 3, 3);
            bunifuButton22.IconMarginLeft = 11;
            bunifuButton22.IconPadding = 10;
            bunifuButton22.IconRightAlign = ContentAlignment.MiddleRight;
            bunifuButton22.IconRightCursor = Cursors.Default;
            bunifuButton22.IconRightPadding = new Padding(3, 3, 7, 3);
            bunifuButton22.IconSize = 25;
            bunifuButton22.IdleBorderColor = Color.FromArgb(192, 64, 0);
            bunifuButton22.IdleBorderRadius = 1;
            bunifuButton22.IdleBorderThickness = 1;
            bunifuButton22.IdleFillColor = Color.Orange;
            bunifuButton22.IdleIconLeftImage = null;
            bunifuButton22.IdleIconRightImage = null;
            bunifuButton22.IndicateFocus = false;
            bunifuButton22.Location = new Point(459, 87);
            bunifuButton22.Name = "bunifuButton22";
            bunifuButton22.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton22.OnDisabledState.BorderRadius = 1;
            bunifuButton22.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton22.OnDisabledState.BorderThickness = 1;
            bunifuButton22.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            bunifuButton22.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunifuButton22.OnDisabledState.IconLeftImage = null;
            bunifuButton22.OnDisabledState.IconRightImage = null;
            bunifuButton22.onHoverState.BorderColor = Color.FromArgb(105, 181, 255);
            bunifuButton22.onHoverState.BorderRadius = 1;
            bunifuButton22.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton22.onHoverState.BorderThickness = 1;
            bunifuButton22.onHoverState.FillColor = Color.FromArgb(255, 128, 0);
            bunifuButton22.onHoverState.ForeColor = Color.White;
            bunifuButton22.onHoverState.IconLeftImage = null;
            bunifuButton22.onHoverState.IconRightImage = null;
            bunifuButton22.OnIdleState.BorderColor = Color.FromArgb(192, 64, 0);
            bunifuButton22.OnIdleState.BorderRadius = 1;
            bunifuButton22.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton22.OnIdleState.BorderThickness = 1;
            bunifuButton22.OnIdleState.FillColor = Color.Orange;
            bunifuButton22.OnIdleState.ForeColor = Color.White;
            bunifuButton22.OnIdleState.IconLeftImage = null;
            bunifuButton22.OnIdleState.IconRightImage = null;
            bunifuButton22.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            bunifuButton22.OnPressedState.BorderRadius = 1;
            bunifuButton22.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton22.OnPressedState.BorderThickness = 1;
            bunifuButton22.OnPressedState.FillColor = Color.FromArgb(192, 64, 0);
            bunifuButton22.OnPressedState.ForeColor = Color.White;
            bunifuButton22.OnPressedState.IconLeftImage = null;
            bunifuButton22.OnPressedState.IconRightImage = null;
            bunifuButton22.Size = new Size(150, 40);
            bunifuButton22.TabIndex = 3;
            bunifuButton22.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton22.TextAlignment = HorizontalAlignment.Center;
            bunifuButton22.TextMarginLeft = 0;
            bunifuButton22.TextPadding = new Padding(0);
            bunifuButton22.UseDefaultRadiusAndThickness = true;
            // 
            // SearchBoxTextBox
            // 
            SearchBoxTextBox.AcceptsReturn = false;
            SearchBoxTextBox.AcceptsTab = false;
            SearchBoxTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SearchBoxTextBox.AnimationSpeed = 200;
            SearchBoxTextBox.AutoCompleteMode = AutoCompleteMode.None;
            SearchBoxTextBox.AutoCompleteSource = AutoCompleteSource.None;
            SearchBoxTextBox.AutoSizeHeight = true;
            SearchBoxTextBox.BackColor = Color.White;
            SearchBoxTextBox.BackgroundImage = (Image)resources.GetObject("SearchBoxTextBox.BackgroundImage");
            SearchBoxTextBox.BorderColorActive = Color.DodgerBlue;
            SearchBoxTextBox.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            SearchBoxTextBox.BorderColorHover = Color.FromArgb(105, 181, 255);
            SearchBoxTextBox.BorderColorIdle = Color.Silver;
            SearchBoxTextBox.BorderRadius = 1;
            SearchBoxTextBox.BorderThickness = 1;
            SearchBoxTextBox.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            SearchBoxTextBox.CharacterCasing = CharacterCasing.Normal;
            SearchBoxTextBox.DefaultFont = new Font("Segoe UI", 9.25F);
            SearchBoxTextBox.DefaultText = "";
            SearchBoxTextBox.FillColor = Color.White;
            SearchBoxTextBox.HideSelection = true;
            SearchBoxTextBox.IconLeft = null;
            SearchBoxTextBox.IconLeftCursor = Cursors.IBeam;
            SearchBoxTextBox.IconPadding = 10;
            SearchBoxTextBox.IconRight = null;
            SearchBoxTextBox.IconRightCursor = Cursors.IBeam;
            SearchBoxTextBox.Location = new Point(615, 87);
            SearchBoxTextBox.MaxLength = 32767;
            SearchBoxTextBox.MinimumSize = new Size(1, 1);
            SearchBoxTextBox.Modified = false;
            SearchBoxTextBox.Multiline = false;
            SearchBoxTextBox.Name = "SearchBoxTextBox";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            SearchBoxTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            SearchBoxTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            SearchBoxTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.Empty;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            SearchBoxTextBox.OnIdleState = stateProperties4;
            SearchBoxTextBox.Padding = new Padding(3);
            SearchBoxTextBox.PasswordChar = '\0';
            SearchBoxTextBox.PlaceholderForeColor = Color.Silver;
            SearchBoxTextBox.PlaceholderText = "Search";
            SearchBoxTextBox.ReadOnly = false;
            SearchBoxTextBox.ScrollBars = ScrollBars.None;
            SearchBoxTextBox.SelectedText = "";
            SearchBoxTextBox.SelectionLength = 0;
            SearchBoxTextBox.SelectionStart = 0;
            SearchBoxTextBox.ShortcutsEnabled = true;
            SearchBoxTextBox.Size = new Size(280, 39);
            SearchBoxTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            SearchBoxTextBox.TabIndex = 2;
            SearchBoxTextBox.TextAlign = HorizontalAlignment.Left;
            SearchBoxTextBox.TextMarginBottom = 0;
            SearchBoxTextBox.TextMarginLeft = 3;
            SearchBoxTextBox.TextMarginTop = 1;
            SearchBoxTextBox.TextPlaceholder = "Search";
            SearchBoxTextBox.UseSystemPasswordChar = false;
            SearchBoxTextBox.WordWrap = true;
            SearchBoxTextBox.TextChange += SearchBox;
            // 
            // AllItemsDatagrid
            // 
            AllItemsDatagrid.AllowCustomTheming = false;
            AllItemsDatagrid.AllowUserToAddRows = false;
            AllItemsDatagrid.AllowUserToDeleteRows = false;
            AllItemsDatagrid.AllowUserToResizeColumns = false;
            AllItemsDatagrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 232, 191);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            AllItemsDatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AllItemsDatagrid.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AllItemsDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllItemsDatagrid.BackgroundColor = Color.White;
            AllItemsDatagrid.BorderStyle = BorderStyle.None;
            AllItemsDatagrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            AllItemsDatagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Orange;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(204, 132, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AllItemsDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AllItemsDatagrid.ColumnHeadersHeight = 40;
            AllItemsDatagrid.Columns.AddRange(new DataGridViewColumn[] { IdCol, RowCol, ItemCodeCol, ItemNameCol, StocksCol, PriceCol });
            AllItemsDatagrid.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(255, 232, 191);
            AllItemsDatagrid.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            AllItemsDatagrid.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            AllItemsDatagrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(255, 201, 102);
            AllItemsDatagrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            AllItemsDatagrid.CurrentTheme.BackColor = Color.Orange;
            AllItemsDatagrid.CurrentTheme.GridColor = Color.FromArgb(255, 226, 173);
            AllItemsDatagrid.CurrentTheme.HeaderStyle.BackColor = Color.Orange;
            AllItemsDatagrid.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            AllItemsDatagrid.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            AllItemsDatagrid.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(204, 132, 0);
            AllItemsDatagrid.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            AllItemsDatagrid.CurrentTheme.Name = null;
            AllItemsDatagrid.CurrentTheme.RowsStyle.BackColor = Color.FromArgb(255, 237, 204);
            AllItemsDatagrid.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            AllItemsDatagrid.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            AllItemsDatagrid.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(255, 201, 102);
            AllItemsDatagrid.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 237, 204);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 201, 102);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AllItemsDatagrid.DefaultCellStyle = dataGridViewCellStyle3;
            AllItemsDatagrid.EnableHeadersVisualStyles = false;
            AllItemsDatagrid.GridColor = Color.FromArgb(255, 226, 173);
            AllItemsDatagrid.HeaderBackColor = Color.Orange;
            AllItemsDatagrid.HeaderBgColor = Color.Empty;
            AllItemsDatagrid.HeaderForeColor = Color.White;
            AllItemsDatagrid.Location = new Point(5, 155);
            AllItemsDatagrid.Name = "AllItemsDatagrid";
            AllItemsDatagrid.ReadOnly = true;
            AllItemsDatagrid.RowHeadersVisible = false;
            AllItemsDatagrid.RowTemplate.Height = 40;
            AllItemsDatagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllItemsDatagrid.Size = new Size(890, 398);
            AllItemsDatagrid.TabIndex = 0;
            AllItemsDatagrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Orange;
            AllItemsDatagrid.KeyDown += AllItemsDatagrid_KeyDown;
            AllItemsDatagrid.MouseClick += AllItemsDatagrid_MouseClick;
            // 
            // IdCol
            // 
            IdCol.HeaderText = "ItemID";
            IdCol.Name = "IdCol";
            IdCol.ReadOnly = true;
            IdCol.Visible = false;
            // 
            // RowCol
            // 
            RowCol.FillWeight = 15F;
            RowCol.HeaderText = "No";
            RowCol.Name = "RowCol";
            RowCol.ReadOnly = true;
            // 
            // ItemCodeCol
            // 
            ItemCodeCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ItemCodeCol.FillWeight = 20F;
            ItemCodeCol.HeaderText = "Item Code";
            ItemCodeCol.Name = "ItemCodeCol";
            ItemCodeCol.ReadOnly = true;
            ItemCodeCol.Width = 110;
            // 
            // ItemNameCol
            // 
            ItemNameCol.HeaderText = "Item Name";
            ItemNameCol.Name = "ItemNameCol";
            ItemNameCol.ReadOnly = true;
            // 
            // StocksCol
            // 
            StocksCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            StocksCol.FillWeight = 20F;
            StocksCol.HeaderText = "Stocks";
            StocksCol.Name = "StocksCol";
            StocksCol.ReadOnly = true;
            StocksCol.Width = 81;
            // 
            // PriceCol
            // 
            PriceCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            PriceCol.FillWeight = 13F;
            PriceCol.HeaderText = "Price";
            PriceCol.Name = "PriceCol";
            PriceCol.ReadOnly = true;
            PriceCol.Width = 69;
            // 
            // MenustripforItems
            // 
            MenustripforItems.BackColor = Color.White;
            MenustripforItems.Items.AddRange(new ToolStripItem[] { edittoolstrip, sep1, deletetoolstrip });
            MenustripforItems.Name = "MenustripforItems";
            MenustripforItems.Size = new Size(121, 54);
            MenustripforItems.Text = "Actions";
            // 
            // edittoolstrip
            // 
            edittoolstrip.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edittoolstrip.Name = "edittoolstrip";
            edittoolstrip.Size = new Size(120, 22);
            edittoolstrip.Text = "Edit";
            edittoolstrip.ToolTipText = "Edit the Selected Item";
            // 
            // sep1
            // 
            sep1.Name = "sep1";
            sep1.Size = new Size(117, 6);
            // 
            // deletetoolstrip
            // 
            deletetoolstrip.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletetoolstrip.Name = "deletetoolstrip";
            deletetoolstrip.Size = new Size(120, 22);
            deletetoolstrip.Text = "Delete";
            deletetoolstrip.ToolTipText = "Delete the Selected Item";
            // 
            // ItemInventory
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 662);
            Controls.Add(MainContainer);
            Controls.Add(TopPanel);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ItemInventory";
            Text = "ItemInventory";
            Load += ItemInventory_Load;
            TopPanel.ResumeLayout(false);
            MainContainer.ResumeLayout(false);
            Pagination.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AllItemsDatagrid).EndInit();
            MenustripforItems.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Panel MainContainer;
        private Bunifu.UI.WinForms.BunifuDataGridView AllItemsDatagrid;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 AddItemButton;
        private Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton22;
        private Bunifu.UI.WinForms.BunifuTextBox SearchBoxTextBox;
        private Panel panel1;
        private ContextMenuStrip MenustripforItems;
        private ToolStripMenuItem edittoolstrip;
        private ToolStripSeparator sep1;
        private ToolStripMenuItem deletetoolstrip;
        private Label PaginationLabel;
        private Bunifu.UI.WinForms.BunifuImageButton PaginationNext;
        private Bunifu.UI.WinForms.BunifuImageButton PaginationPREV;
        private Panel Pagination;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn RowCol;
        private DataGridViewTextBoxColumn ItemCodeCol;
        private DataGridViewTextBoxColumn ItemNameCol;
        private DataGridViewTextBoxColumn StocksCol;
        private DataGridViewTextBoxColumn PriceCol;
    }
}