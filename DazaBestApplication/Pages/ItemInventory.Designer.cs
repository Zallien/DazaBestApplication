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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            TopPanel = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            MainContainer = new Panel();
            bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            productperpagetxt = new TextBox();
            label4 = new Label();
            bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            label2 = new Label();
            filterbutton = new Bunifu.UI.WinForms.BunifuImageButton();
            bunifuButton23 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            bunifuButton21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            AddItemButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            Pagination = new Panel();
            PaginationLabel = new Label();
            PaginationPREV = new Bunifu.UI.WinForms.BunifuImageButton();
            PaginationNext = new Bunifu.UI.WinForms.BunifuImageButton();
            SearchBoxTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            AllItemsDatagrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            MenustripforItems = new ContextMenuStrip(components);
            edittoolstrip = new ToolStripMenuItem();
            sep1 = new ToolStripSeparator();
            deletetoolstrip = new ToolStripMenuItem();
            IdCol = new DataGridViewTextBoxColumn();
            RowCol = new DataGridViewTextBoxColumn();
            ItemCodeCol = new DataGridViewTextBoxColumn();
            ItemNameCol = new DataGridViewTextBoxColumn();
            StocksCol = new DataGridViewTextBoxColumn();
            PriceCol = new DataGridViewTextBoxColumn();
            ThresholdCol = new DataGridViewTextBoxColumn();
            UnitCol = new DataGridViewTextBoxColumn();
            TopPanel.SuspendLayout();
            MainContainer.SuspendLayout();
            bunifuShadowPanel1.SuspendLayout();
            Pagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AllItemsDatagrid).BeginInit();
            MenustripforItems.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.Controls.Add(panel4);
            TopPanel.Controls.Add(label1);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Padding = new Padding(10, 0, 10, 0);
            TopPanel.Size = new Size(950, 50);
            TopPanel.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Maroon;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(10, 45);
            panel4.Name = "panel4";
            panel4.Size = new Size(930, 5);
            panel4.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Courier New", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 0);
            label1.Name = "label1";
            label1.Size = new Size(245, 50);
            label1.TabIndex = 0;
            label1.Text = "Inventory";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainContainer
            // 
            MainContainer.Controls.Add(bunifuShadowPanel1);
            MainContainer.Controls.Add(filterbutton);
            MainContainer.Controls.Add(bunifuButton23);
            MainContainer.Controls.Add(bunifuButton21);
            MainContainer.Controls.Add(AddItemButton);
            MainContainer.Controls.Add(Pagination);
            MainContainer.Controls.Add(SearchBoxTextBox);
            MainContainer.Controls.Add(AllItemsDatagrid);
            MainContainer.Dock = DockStyle.Bottom;
            MainContainer.Location = new Point(0, 68);
            MainContainer.Name = "MainContainer";
            MainContainer.Padding = new Padding(0, 10, 0, 0);
            MainContainer.Size = new Size(950, 612);
            MainContainer.TabIndex = 1;
            // 
            // bunifuShadowPanel1
            // 
            bunifuShadowPanel1.BackColor = Color.Transparent;
            bunifuShadowPanel1.BorderColor = Color.WhiteSmoke;
            bunifuShadowPanel1.BorderRadius = 1;
            bunifuShadowPanel1.BorderThickness = 1;
            bunifuShadowPanel1.Controls.Add(productperpagetxt);
            bunifuShadowPanel1.Controls.Add(label4);
            bunifuShadowPanel1.Controls.Add(bunifuButton1);
            bunifuShadowPanel1.Controls.Add(label2);
            bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            bunifuShadowPanel1.Location = new Point(725, 60);
            bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            bunifuShadowPanel1.Padding = new Padding(15, 10, 10, 10);
            bunifuShadowPanel1.PanelColor = Color.WhiteSmoke;
            bunifuShadowPanel1.PanelColor2 = Color.WhiteSmoke;
            bunifuShadowPanel1.ShadowColor = Color.DarkGray;
            bunifuShadowPanel1.ShadowDept = 2;
            bunifuShadowPanel1.ShadowDepth = 5;
            bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            bunifuShadowPanel1.ShadowTopLeftVisible = false;
            bunifuShadowPanel1.Size = new Size(220, 128);
            bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            bunifuShadowPanel1.TabIndex = 15;
            bunifuShadowPanel1.Visible = false;
            // 
            // productperpagetxt
            // 
            productperpagetxt.Dock = DockStyle.Top;
            productperpagetxt.Font = new Font("Courier New", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productperpagetxt.Location = new Point(15, 56);
            productperpagetxt.Name = "productperpagetxt";
            productperpagetxt.Size = new Size(195, 24);
            productperpagetxt.TabIndex = 4;
            productperpagetxt.KeyPress += productperpagetxt_KeyPress;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Courier New", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 33);
            label4.Name = "label4";
            label4.Size = new Size(195, 23);
            label4.TabIndex = 3;
            label4.Text = "Per Page :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bunifuButton1
            // 
            bunifuButton1.AllowAnimations = true;
            bunifuButton1.AllowMouseEffects = true;
            bunifuButton1.AllowToggling = false;
            bunifuButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bunifuButton1.AnimationSpeed = 200;
            bunifuButton1.AutoGenerateColors = false;
            bunifuButton1.AutoRoundBorders = false;
            bunifuButton1.AutoSizeLeftIcon = true;
            bunifuButton1.AutoSizeRightIcon = true;
            bunifuButton1.BackColor = Color.Transparent;
            bunifuButton1.BackColor1 = Color.FromArgb(51, 122, 183);
            bunifuButton1.BackgroundImage = (Image)resources.GetObject("bunifuButton1.BackgroundImage");
            bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.ButtonText = "Save";
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
            bunifuButton1.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            bunifuButton1.Location = new Point(61, 90);
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
            bunifuButton1.Size = new Size(103, 25);
            bunifuButton1.TabIndex = 2;
            bunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton1.TextAlignment = HorizontalAlignment.Center;
            bunifuButton1.TextMarginLeft = 0;
            bunifuButton1.TextPadding = new Padding(0);
            bunifuButton1.UseDefaultRadiusAndThickness = true;
            bunifuButton1.Click += bunifuButton1_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 10);
            label2.Name = "label2";
            label2.Size = new Size(195, 23);
            label2.TabIndex = 0;
            label2.Text = "Filter";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // filterbutton
            // 
            filterbutton.ActiveImage = null;
            filterbutton.AllowAnimations = true;
            filterbutton.AllowBuffering = false;
            filterbutton.AllowToggling = false;
            filterbutton.AllowZooming = true;
            filterbutton.AllowZoomingOnFocus = false;
            filterbutton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            filterbutton.BackColor = Color.Transparent;
            filterbutton.DialogResult = DialogResult.None;
            filterbutton.ErrorImage = (Image)resources.GetObject("filterbutton.ErrorImage");
            filterbutton.FadeWhenInactive = false;
            filterbutton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            filterbutton.Image = Properties.Resources.filter;
            filterbutton.ImageActive = null;
            filterbutton.ImageLocation = null;
            filterbutton.ImageMargin = 10;
            filterbutton.ImageSize = new Size(29, 29);
            filterbutton.ImageZoomSize = new Size(39, 39);
            filterbutton.InitialImage = (Image)resources.GetObject("filterbutton.InitialImage");
            filterbutton.Location = new Point(906, 15);
            filterbutton.Name = "filterbutton";
            filterbutton.Rotation = 0;
            filterbutton.ShowActiveImage = true;
            filterbutton.ShowCursorChanges = true;
            filterbutton.ShowImageBorders = true;
            filterbutton.ShowSizeMarkers = false;
            filterbutton.Size = new Size(39, 39);
            filterbutton.TabIndex = 14;
            filterbutton.ToolTipText = "";
            filterbutton.WaitOnLoad = false;
            filterbutton.Zoom = 10;
            filterbutton.ZoomSpeed = 10;
            filterbutton.Click += filterbutton_Click;
            // 
            // bunifuButton23
            // 
            bunifuButton23.AllowAnimations = true;
            bunifuButton23.AllowMouseEffects = true;
            bunifuButton23.AllowToggling = false;
            bunifuButton23.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bunifuButton23.AnimationSpeed = 200;
            bunifuButton23.AutoGenerateColors = false;
            bunifuButton23.AutoRoundBorders = false;
            bunifuButton23.AutoSizeLeftIcon = true;
            bunifuButton23.AutoSizeRightIcon = true;
            bunifuButton23.BackColor = Color.Transparent;
            bunifuButton23.BackColor1 = Color.FromArgb(220, 220, 221);
            bunifuButton23.BackgroundImage = (Image)resources.GetObject("bunifuButton23.BackgroundImage");
            bunifuButton23.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton23.ButtonText = "Edit Item";
            bunifuButton23.ButtonTextMarginLeft = 0;
            bunifuButton23.ColorContrastOnClick = 45;
            bunifuButton23.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            bunifuButton23.CustomizableEdges = borderEdges2;
            bunifuButton23.DialogResult = DialogResult.None;
            bunifuButton23.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton23.DisabledFillColor = Color.FromArgb(204, 204, 204);
            bunifuButton23.DisabledForecolor = Color.FromArgb(168, 160, 168);
            bunifuButton23.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            bunifuButton23.Font = new Font("Courier New", 12F, FontStyle.Bold);
            bunifuButton23.ForeColor = Color.Black;
            bunifuButton23.IconLeftAlign = ContentAlignment.MiddleLeft;
            bunifuButton23.IconLeftCursor = Cursors.Default;
            bunifuButton23.IconLeftPadding = new Padding(11, 3, 3, 3);
            bunifuButton23.IconMarginLeft = 11;
            bunifuButton23.IconPadding = 10;
            bunifuButton23.IconRightAlign = ContentAlignment.MiddleRight;
            bunifuButton23.IconRightCursor = Cursors.Default;
            bunifuButton23.IconRightPadding = new Padding(3, 3, 7, 3);
            bunifuButton23.IconSize = 25;
            bunifuButton23.IdleBorderColor = Color.FromArgb(220, 220, 221);
            bunifuButton23.IdleBorderRadius = 1;
            bunifuButton23.IdleBorderThickness = 1;
            bunifuButton23.IdleFillColor = Color.FromArgb(220, 220, 221);
            bunifuButton23.IdleIconLeftImage = Properties.Resources.compose;
            bunifuButton23.IdleIconRightImage = null;
            bunifuButton23.IndicateFocus = false;
            bunifuButton23.Location = new Point(329, 15);
            bunifuButton23.Name = "bunifuButton23";
            bunifuButton23.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton23.OnDisabledState.BorderRadius = 1;
            bunifuButton23.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton23.OnDisabledState.BorderThickness = 1;
            bunifuButton23.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            bunifuButton23.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunifuButton23.OnDisabledState.IconLeftImage = null;
            bunifuButton23.OnDisabledState.IconRightImage = null;
            bunifuButton23.onHoverState.BorderColor = Color.Black;
            bunifuButton23.onHoverState.BorderRadius = 1;
            bunifuButton23.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton23.onHoverState.BorderThickness = 1;
            bunifuButton23.onHoverState.FillColor = Color.FromArgb(205, 205, 207);
            bunifuButton23.onHoverState.ForeColor = Color.Black;
            bunifuButton23.onHoverState.IconLeftImage = null;
            bunifuButton23.onHoverState.IconRightImage = null;
            bunifuButton23.OnIdleState.BorderColor = Color.FromArgb(220, 220, 221);
            bunifuButton23.OnIdleState.BorderRadius = 1;
            bunifuButton23.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton23.OnIdleState.BorderThickness = 1;
            bunifuButton23.OnIdleState.FillColor = Color.FromArgb(220, 220, 221);
            bunifuButton23.OnIdleState.ForeColor = Color.Black;
            bunifuButton23.OnIdleState.IconLeftImage = Properties.Resources.compose;
            bunifuButton23.OnIdleState.IconRightImage = null;
            bunifuButton23.OnPressedState.BorderColor = Color.FromArgb(161, 205, 220);
            bunifuButton23.OnPressedState.BorderRadius = 1;
            bunifuButton23.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton23.OnPressedState.BorderThickness = 1;
            bunifuButton23.OnPressedState.FillColor = Color.FromArgb(161, 205, 220);
            bunifuButton23.OnPressedState.ForeColor = Color.Black;
            bunifuButton23.OnPressedState.IconLeftImage = null;
            bunifuButton23.OnPressedState.IconRightImage = null;
            bunifuButton23.Size = new Size(154, 40);
            bunifuButton23.TabIndex = 13;
            bunifuButton23.TextAlign = ContentAlignment.MiddleLeft;
            bunifuButton23.TextAlignment = HorizontalAlignment.Center;
            bunifuButton23.TextMarginLeft = 0;
            bunifuButton23.TextPadding = new Padding(35, 0, 0, 0);
            bunifuButton23.UseDefaultRadiusAndThickness = true;
            bunifuButton23.Click += bunifuButton23_Click;
            // 
            // bunifuButton21
            // 
            bunifuButton21.AllowAnimations = true;
            bunifuButton21.AllowMouseEffects = true;
            bunifuButton21.AllowToggling = false;
            bunifuButton21.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bunifuButton21.AnimationSpeed = 200;
            bunifuButton21.AutoGenerateColors = false;
            bunifuButton21.AutoRoundBorders = false;
            bunifuButton21.AutoSizeLeftIcon = true;
            bunifuButton21.AutoSizeRightIcon = true;
            bunifuButton21.BackColor = Color.Transparent;
            bunifuButton21.BackColor1 = Color.FromArgb(220, 220, 221);
            bunifuButton21.BackgroundImage = (Image)resources.GetObject("bunifuButton21.BackgroundImage");
            bunifuButton21.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton21.ButtonText = "Remove Item";
            bunifuButton21.ButtonTextMarginLeft = 0;
            bunifuButton21.ColorContrastOnClick = 45;
            bunifuButton21.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            bunifuButton21.CustomizableEdges = borderEdges3;
            bunifuButton21.DialogResult = DialogResult.None;
            bunifuButton21.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton21.DisabledFillColor = Color.FromArgb(204, 204, 204);
            bunifuButton21.DisabledForecolor = Color.FromArgb(168, 160, 168);
            bunifuButton21.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            bunifuButton21.Font = new Font("Courier New", 12F, FontStyle.Bold);
            bunifuButton21.ForeColor = Color.Black;
            bunifuButton21.IconLeftAlign = ContentAlignment.MiddleLeft;
            bunifuButton21.IconLeftCursor = Cursors.Default;
            bunifuButton21.IconLeftPadding = new Padding(11, 3, 3, 3);
            bunifuButton21.IconMarginLeft = 11;
            bunifuButton21.IconPadding = 10;
            bunifuButton21.IconRightAlign = ContentAlignment.MiddleRight;
            bunifuButton21.IconRightCursor = Cursors.Default;
            bunifuButton21.IconRightPadding = new Padding(3, 3, 7, 3);
            bunifuButton21.IconSize = 25;
            bunifuButton21.IdleBorderColor = Color.FromArgb(220, 220, 221);
            bunifuButton21.IdleBorderRadius = 1;
            bunifuButton21.IdleBorderThickness = 1;
            bunifuButton21.IdleFillColor = Color.FromArgb(220, 220, 221);
            bunifuButton21.IdleIconLeftImage = Properties.Resources.trashcan;
            bunifuButton21.IdleIconRightImage = null;
            bunifuButton21.IndicateFocus = false;
            bunifuButton21.Location = new Point(166, 15);
            bunifuButton21.Name = "bunifuButton21";
            bunifuButton21.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton21.OnDisabledState.BorderRadius = 1;
            bunifuButton21.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton21.OnDisabledState.BorderThickness = 1;
            bunifuButton21.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            bunifuButton21.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunifuButton21.OnDisabledState.IconLeftImage = null;
            bunifuButton21.OnDisabledState.IconRightImage = null;
            bunifuButton21.onHoverState.BorderColor = Color.Black;
            bunifuButton21.onHoverState.BorderRadius = 1;
            bunifuButton21.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton21.onHoverState.BorderThickness = 1;
            bunifuButton21.onHoverState.FillColor = Color.FromArgb(205, 205, 207);
            bunifuButton21.onHoverState.ForeColor = Color.Black;
            bunifuButton21.onHoverState.IconLeftImage = null;
            bunifuButton21.onHoverState.IconRightImage = null;
            bunifuButton21.OnIdleState.BorderColor = Color.FromArgb(220, 220, 221);
            bunifuButton21.OnIdleState.BorderRadius = 1;
            bunifuButton21.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton21.OnIdleState.BorderThickness = 1;
            bunifuButton21.OnIdleState.FillColor = Color.FromArgb(220, 220, 221);
            bunifuButton21.OnIdleState.ForeColor = Color.Black;
            bunifuButton21.OnIdleState.IconLeftImage = Properties.Resources.trashcan;
            bunifuButton21.OnIdleState.IconRightImage = null;
            bunifuButton21.OnPressedState.BorderColor = Color.FromArgb(161, 205, 220);
            bunifuButton21.OnPressedState.BorderRadius = 1;
            bunifuButton21.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton21.OnPressedState.BorderThickness = 1;
            bunifuButton21.OnPressedState.FillColor = Color.FromArgb(161, 205, 220);
            bunifuButton21.OnPressedState.ForeColor = Color.Black;
            bunifuButton21.OnPressedState.IconLeftImage = null;
            bunifuButton21.OnPressedState.IconRightImage = null;
            bunifuButton21.Size = new Size(154, 40);
            bunifuButton21.TabIndex = 12;
            bunifuButton21.TextAlign = ContentAlignment.MiddleLeft;
            bunifuButton21.TextAlignment = HorizontalAlignment.Center;
            bunifuButton21.TextMarginLeft = 0;
            bunifuButton21.TextPadding = new Padding(35, 0, 0, 0);
            bunifuButton21.UseDefaultRadiusAndThickness = true;
            bunifuButton21.Click += bunifuButton21_Click;
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
            AddItemButton.BackColor1 = Color.FromArgb(78, 160, 21);
            AddItemButton.BackgroundImage = (Image)resources.GetObject("AddItemButton.BackgroundImage");
            AddItemButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddItemButton.ButtonText = "Add Item";
            AddItemButton.ButtonTextMarginLeft = 0;
            AddItemButton.ColorContrastOnClick = 45;
            AddItemButton.ColorContrastOnHover = 45;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            AddItemButton.CustomizableEdges = borderEdges4;
            AddItemButton.DialogResult = DialogResult.None;
            AddItemButton.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            AddItemButton.DisabledFillColor = Color.FromArgb(204, 204, 204);
            AddItemButton.DisabledForecolor = Color.FromArgb(168, 160, 168);
            AddItemButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            AddItemButton.Font = new Font("Courier New", 12F, FontStyle.Bold);
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
            AddItemButton.IdleBorderColor = Color.FromArgb(78, 160, 21);
            AddItemButton.IdleBorderRadius = 1;
            AddItemButton.IdleBorderThickness = 1;
            AddItemButton.IdleFillColor = Color.FromArgb(78, 160, 21);
            AddItemButton.IdleIconLeftImage = Properties.Resources.plus__1_;
            AddItemButton.IdleIconRightImage = null;
            AddItemButton.IndicateFocus = false;
            AddItemButton.Location = new Point(3, 15);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            AddItemButton.OnDisabledState.BorderRadius = 1;
            AddItemButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddItemButton.OnDisabledState.BorderThickness = 1;
            AddItemButton.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            AddItemButton.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            AddItemButton.OnDisabledState.IconLeftImage = null;
            AddItemButton.OnDisabledState.IconRightImage = null;
            AddItemButton.onHoverState.BorderColor = Color.FromArgb(50, 110, 5);
            AddItemButton.onHoverState.BorderRadius = 1;
            AddItemButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddItemButton.onHoverState.BorderThickness = 1;
            AddItemButton.onHoverState.FillColor = Color.FromArgb(50, 110, 5);
            AddItemButton.onHoverState.ForeColor = Color.White;
            AddItemButton.onHoverState.IconLeftImage = null;
            AddItemButton.onHoverState.IconRightImage = null;
            AddItemButton.OnIdleState.BorderColor = Color.FromArgb(78, 160, 21);
            AddItemButton.OnIdleState.BorderRadius = 1;
            AddItemButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddItemButton.OnIdleState.BorderThickness = 1;
            AddItemButton.OnIdleState.FillColor = Color.FromArgb(78, 160, 21);
            AddItemButton.OnIdleState.ForeColor = Color.White;
            AddItemButton.OnIdleState.IconLeftImage = Properties.Resources.plus__1_;
            AddItemButton.OnIdleState.IconRightImage = null;
            AddItemButton.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            AddItemButton.OnPressedState.BorderRadius = 1;
            AddItemButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddItemButton.OnPressedState.BorderThickness = 1;
            AddItemButton.OnPressedState.FillColor = Color.FromArgb(192, 64, 0);
            AddItemButton.OnPressedState.ForeColor = Color.White;
            AddItemButton.OnPressedState.IconLeftImage = null;
            AddItemButton.OnPressedState.IconRightImage = null;
            AddItemButton.Size = new Size(154, 40);
            AddItemButton.TabIndex = 1;
            AddItemButton.TextAlign = ContentAlignment.MiddleLeft;
            AddItemButton.TextAlignment = HorizontalAlignment.Center;
            AddItemButton.TextMarginLeft = 0;
            AddItemButton.TextPadding = new Padding(35, 0, 0, 0);
            AddItemButton.UseDefaultRadiusAndThickness = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // Pagination
            // 
            Pagination.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Pagination.Controls.Add(PaginationLabel);
            Pagination.Controls.Add(PaginationPREV);
            Pagination.Controls.Add(PaginationNext);
            Pagination.Location = new Point(10, 559);
            Pagination.Name = "Pagination";
            Pagination.Size = new Size(196, 50);
            Pagination.TabIndex = 8;
            // 
            // PaginationLabel
            // 
            PaginationLabel.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaginationLabel.Location = new Point(52, 7);
            PaginationLabel.Name = "PaginationLabel";
            PaginationLabel.Size = new Size(95, 40);
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
            PaginationNext.Location = new Point(153, 7);
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
            SearchBoxTextBox.DefaultFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBoxTextBox.DefaultText = "";
            SearchBoxTextBox.FillColor = Color.White;
            SearchBoxTextBox.HideSelection = true;
            SearchBoxTextBox.IconLeft = Properties.Resources.magnifying_glass;
            SearchBoxTextBox.IconLeftCursor = Cursors.IBeam;
            SearchBoxTextBox.IconPadding = 10;
            SearchBoxTextBox.IconRight = null;
            SearchBoxTextBox.IconRightCursor = Cursors.IBeam;
            SearchBoxTextBox.Location = new Point(560, 15);
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
            SearchBoxTextBox.PlaceholderText = "Search by Item Code or Name";
            SearchBoxTextBox.ReadOnly = false;
            SearchBoxTextBox.ScrollBars = ScrollBars.None;
            SearchBoxTextBox.SelectedText = "";
            SearchBoxTextBox.SelectionLength = 0;
            SearchBoxTextBox.SelectionStart = 0;
            SearchBoxTextBox.ShortcutsEnabled = true;
            SearchBoxTextBox.Size = new Size(340, 38);
            SearchBoxTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            SearchBoxTextBox.TabIndex = 2;
            SearchBoxTextBox.TextAlign = HorizontalAlignment.Left;
            SearchBoxTextBox.TextMarginBottom = 0;
            SearchBoxTextBox.TextMarginLeft = 5;
            SearchBoxTextBox.TextMarginTop = 1;
            SearchBoxTextBox.TextPlaceholder = "Search by Item Code or Name";
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
            dataGridViewCellStyle1.BackColor = Color.FromArgb(223, 191, 191);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            AllItemsDatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AllItemsDatagrid.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AllItemsDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllItemsDatagrid.BackgroundColor = Color.White;
            AllItemsDatagrid.BorderStyle = BorderStyle.None;
            AllItemsDatagrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            AllItemsDatagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 0, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AllItemsDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AllItemsDatagrid.ColumnHeadersHeight = 40;
            AllItemsDatagrid.Columns.AddRange(new DataGridViewColumn[] { IdCol, RowCol, ItemCodeCol, ItemNameCol, StocksCol, PriceCol, ThresholdCol, UnitCol });
            AllItemsDatagrid.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(223, 191, 191);
            AllItemsDatagrid.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            AllItemsDatagrid.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            AllItemsDatagrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(178, 102, 102);
            AllItemsDatagrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.White;
            AllItemsDatagrid.CurrentTheme.BackColor = Color.Maroon;
            AllItemsDatagrid.CurrentTheme.GridColor = Color.FromArgb(216, 178, 178);
            AllItemsDatagrid.CurrentTheme.HeaderStyle.BackColor = Color.Maroon;
            AllItemsDatagrid.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            AllItemsDatagrid.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            AllItemsDatagrid.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(102, 0, 0);
            AllItemsDatagrid.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            AllItemsDatagrid.CurrentTheme.Name = null;
            AllItemsDatagrid.CurrentTheme.RowsStyle.BackColor = Color.FromArgb(229, 204, 204);
            AllItemsDatagrid.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            AllItemsDatagrid.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            AllItemsDatagrid.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(178, 102, 102);
            AllItemsDatagrid.CurrentTheme.RowsStyle.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(229, 204, 204);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(178, 102, 102);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AllItemsDatagrid.DefaultCellStyle = dataGridViewCellStyle3;
            AllItemsDatagrid.EnableHeadersVisualStyles = false;
            AllItemsDatagrid.GridColor = Color.FromArgb(216, 178, 178);
            AllItemsDatagrid.HeaderBackColor = Color.Maroon;
            AllItemsDatagrid.HeaderBgColor = Color.Empty;
            AllItemsDatagrid.HeaderForeColor = Color.White;
            AllItemsDatagrid.Location = new Point(5, 65);
            AllItemsDatagrid.Name = "AllItemsDatagrid";
            AllItemsDatagrid.ReadOnly = true;
            AllItemsDatagrid.RowHeadersVisible = false;
            AllItemsDatagrid.RowTemplate.Height = 40;
            AllItemsDatagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllItemsDatagrid.Size = new Size(940, 484);
            AllItemsDatagrid.TabIndex = 0;
            AllItemsDatagrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Maroon;
            AllItemsDatagrid.CellFormatting += AllItemsDatagrid_CellFormatting;
            AllItemsDatagrid.KeyDown += AllItemsDatagrid_KeyDown;
            AllItemsDatagrid.MouseClick += AllItemsDatagrid_MouseClick;
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
            RowCol.Visible = false;
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
            // ThresholdCol
            // 
            ThresholdCol.HeaderText = "Threshold";
            ThresholdCol.Name = "ThresholdCol";
            ThresholdCol.ReadOnly = true;
            ThresholdCol.Resizable = DataGridViewTriState.False;
            ThresholdCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            ThresholdCol.Visible = false;
            // 
            // UnitCol
            // 
            UnitCol.HeaderText = "Unit";
            UnitCol.Name = "UnitCol";
            UnitCol.ReadOnly = true;
            UnitCol.Visible = false;
            // 
            // ItemInventory
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 680);
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
            bunifuShadowPanel1.ResumeLayout(false);
            bunifuShadowPanel1.PerformLayout();
            Pagination.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AllItemsDatagrid).EndInit();
            MenustripforItems.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Panel MainContainer;
        private Bunifu.UI.WinForms.BunifuDataGridView AllItemsDatagrid;
        private Label label1;
        private ContextMenuStrip MenustripforItems;
        private ToolStripMenuItem edittoolstrip;
        private ToolStripSeparator sep1;
        private ToolStripMenuItem deletetoolstrip;
        private Label PaginationLabel;
        private Bunifu.UI.WinForms.BunifuImageButton PaginationNext;
        private Bunifu.UI.WinForms.BunifuImageButton PaginationPREV;
        private Panel Pagination;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 AddItemButton;
        private Bunifu.UI.WinForms.BunifuTextBox SearchBoxTextBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton23;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton21;
        private Panel panel4;
        private Bunifu.UI.WinForms.BunifuImageButton filterbutton;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private TextBox productperpagetxt;
        private Label label4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Label label2;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn RowCol;
        private DataGridViewTextBoxColumn ItemCodeCol;
        private DataGridViewTextBoxColumn ItemNameCol;
        private DataGridViewTextBoxColumn StocksCol;
        private DataGridViewTextBoxColumn PriceCol;
        private DataGridViewTextBoxColumn ThresholdCol;
        private DataGridViewTextBoxColumn UnitCol;
    }
}