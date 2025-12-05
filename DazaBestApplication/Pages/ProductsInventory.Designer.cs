namespace DazaBestApplication.Pages
{
    partial class ProductsInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsInventory));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            TopPanel = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            MainContainer = new Panel();
            bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            productperpagetxt = new TextBox();
            label4 = new Label();
            businesscategorypicked = new Bunifu.UI.WinForms.BunifuDropdown();
            bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            label3 = new Label();
            label2 = new Label();
            filterbutton = new Bunifu.UI.WinForms.BunifuImageButton();
            EditButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            RemoveButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            Pagination = new Panel();
            PaginationLabel = new Label();
            PaginationPREV = new Bunifu.UI.WinForms.BunifuImageButton();
            PaginationNext = new Bunifu.UI.WinForms.BunifuImageButton();
            SearchBox = new Bunifu.UI.WinForms.BunifuTextBox();
            AddProductBTN = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            AllProductDatagridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            AvailabilityCol = new DataGridViewImageColumn();
            ProductCodeCol = new DataGridViewTextBoxColumn();
            ProductNameCol = new DataGridViewTextBoxColumn();
            PriceCol = new DataGridViewTextBoxColumn();
            ActionCol = new DataGridViewButtonColumn();
            ProductMenuStrip = new ContextMenuStrip(components);
            Edittoolstrip = new ToolStripMenuItem();
            sep1 = new ToolStripSeparator();
            Deletetoolstrip = new ToolStripMenuItem();
            TopPanel.SuspendLayout();
            MainContainer.SuspendLayout();
            bunifuShadowPanel1.SuspendLayout();
            Pagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AllProductDatagridView).BeginInit();
            ProductMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.White;
            TopPanel.Controls.Add(panel4);
            TopPanel.Controls.Add(label1);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Padding = new Padding(10, 0, 10, 0);
            TopPanel.Size = new Size(950, 50);
            TopPanel.TabIndex = 1;
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
            label1.Size = new Size(372, 50);
            label1.TabIndex = 0;
            label1.Text = "Products List";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainContainer
            // 
            MainContainer.Controls.Add(bunifuShadowPanel1);
            MainContainer.Controls.Add(filterbutton);
            MainContainer.Controls.Add(EditButton);
            MainContainer.Controls.Add(RemoveButton);
            MainContainer.Controls.Add(Pagination);
            MainContainer.Controls.Add(SearchBox);
            MainContainer.Controls.Add(AddProductBTN);
            MainContainer.Controls.Add(AllProductDatagridView);
            MainContainer.Dock = DockStyle.Bottom;
            MainContainer.Location = new Point(0, 68);
            MainContainer.Name = "MainContainer";
            MainContainer.Padding = new Padding(0, 10, 0, 0);
            MainContainer.Size = new Size(950, 612);
            MainContainer.TabIndex = 2;
            // 
            // bunifuShadowPanel1
            // 
            bunifuShadowPanel1.BackColor = Color.Transparent;
            bunifuShadowPanel1.BorderColor = Color.WhiteSmoke;
            bunifuShadowPanel1.BorderRadius = 1;
            bunifuShadowPanel1.BorderThickness = 1;
            bunifuShadowPanel1.Controls.Add(productperpagetxt);
            bunifuShadowPanel1.Controls.Add(label4);
            bunifuShadowPanel1.Controls.Add(businesscategorypicked);
            bunifuShadowPanel1.Controls.Add(bunifuButton1);
            bunifuShadowPanel1.Controls.Add(label3);
            bunifuShadowPanel1.Controls.Add(label2);
            bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            bunifuShadowPanel1.Location = new Point(695, 66);
            bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            bunifuShadowPanel1.Padding = new Padding(15, 10, 10, 10);
            bunifuShadowPanel1.PanelColor = Color.WhiteSmoke;
            bunifuShadowPanel1.PanelColor2 = Color.WhiteSmoke;
            bunifuShadowPanel1.ShadowColor = Color.DarkGray;
            bunifuShadowPanel1.ShadowDept = 2;
            bunifuShadowPanel1.ShadowDepth = 5;
            bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            bunifuShadowPanel1.ShadowTopLeftVisible = false;
            bunifuShadowPanel1.Size = new Size(220, 205);
            bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            bunifuShadowPanel1.TabIndex = 13;
            bunifuShadowPanel1.Visible = false;
            // 
            // productperpagetxt
            // 
            productperpagetxt.Dock = DockStyle.Top;
            productperpagetxt.Font = new Font("Courier New", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productperpagetxt.Location = new Point(15, 111);
            productperpagetxt.Name = "productperpagetxt";
            productperpagetxt.Size = new Size(195, 24);
            productperpagetxt.TabIndex = 4;
            productperpagetxt.KeyPress += productperpagetxt_KeyPress;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Courier New", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 88);
            label4.Name = "label4";
            label4.Size = new Size(195, 23);
            label4.TabIndex = 3;
            label4.Text = "Per Page :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // businesscategorypicked
            // 
            businesscategorypicked.BackColor = Color.Transparent;
            businesscategorypicked.BackgroundColor = Color.White;
            businesscategorypicked.BorderColor = Color.Silver;
            businesscategorypicked.BorderRadius = 1;
            businesscategorypicked.Color = Color.Silver;
            businesscategorypicked.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            businesscategorypicked.DisabledBackColor = Color.FromArgb(240, 240, 240);
            businesscategorypicked.DisabledBorderColor = Color.FromArgb(204, 204, 204);
            businesscategorypicked.DisabledColor = Color.FromArgb(240, 240, 240);
            businesscategorypicked.DisabledForeColor = Color.FromArgb(109, 109, 109);
            businesscategorypicked.DisabledIndicatorColor = Color.DarkGray;
            businesscategorypicked.Dock = DockStyle.Top;
            businesscategorypicked.DrawMode = DrawMode.OwnerDrawFixed;
            businesscategorypicked.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            businesscategorypicked.DropDownStyle = ComboBoxStyle.DropDownList;
            businesscategorypicked.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            businesscategorypicked.FillDropDown = true;
            businesscategorypicked.FillIndicator = false;
            businesscategorypicked.FlatStyle = FlatStyle.Flat;
            businesscategorypicked.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            businesscategorypicked.ForeColor = Color.Black;
            businesscategorypicked.FormattingEnabled = true;
            businesscategorypicked.Icon = null;
            businesscategorypicked.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            businesscategorypicked.IndicatorColor = Color.DarkGray;
            businesscategorypicked.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            businesscategorypicked.IndicatorThickness = 2;
            businesscategorypicked.IsDropdownOpened = false;
            businesscategorypicked.ItemBackColor = Color.White;
            businesscategorypicked.ItemBorderColor = Color.White;
            businesscategorypicked.ItemForeColor = Color.Black;
            businesscategorypicked.ItemHeight = 26;
            businesscategorypicked.ItemHighLightColor = Color.DodgerBlue;
            businesscategorypicked.ItemHighLightForeColor = Color.White;
            businesscategorypicked.ItemTopMargin = 3;
            businesscategorypicked.Location = new Point(15, 56);
            businesscategorypicked.Name = "businesscategorypicked";
            businesscategorypicked.Size = new Size(195, 32);
            businesscategorypicked.TabIndex = 2;
            businesscategorypicked.Text = null;
            businesscategorypicked.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            businesscategorypicked.TextLeftMargin = 5;
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
            bunifuButton1.Location = new Point(65, 167);
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
            bunifuButton1.Size = new Size(105, 25);
            bunifuButton1.TabIndex = 2;
            bunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton1.TextAlignment = HorizontalAlignment.Center;
            bunifuButton1.TextMarginLeft = 0;
            bunifuButton1.TextPadding = new Padding(0);
            bunifuButton1.UseDefaultRadiusAndThickness = true;
            bunifuButton1.Click += bunifuButton1_Click;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Courier New", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 33);
            label3.Name = "label3";
            label3.Size = new Size(195, 23);
            label3.TabIndex = 1;
            label3.Text = "Business :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
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
            filterbutton.Location = new Point(904, 15);
            filterbutton.Name = "filterbutton";
            filterbutton.Rotation = 0;
            filterbutton.ShowActiveImage = true;
            filterbutton.ShowCursorChanges = true;
            filterbutton.ShowImageBorders = true;
            filterbutton.ShowSizeMarkers = false;
            filterbutton.Size = new Size(39, 39);
            filterbutton.TabIndex = 12;
            filterbutton.ToolTipText = "";
            filterbutton.WaitOnLoad = false;
            filterbutton.Zoom = 10;
            filterbutton.ZoomSpeed = 10;
            filterbutton.Click += filterbutton_Click;
            // 
            // EditButton
            // 
            EditButton.AllowAnimations = true;
            EditButton.AllowMouseEffects = true;
            EditButton.AllowToggling = false;
            EditButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EditButton.AnimationSpeed = 200;
            EditButton.AutoGenerateColors = false;
            EditButton.AutoRoundBorders = false;
            EditButton.AutoSizeLeftIcon = true;
            EditButton.AutoSizeRightIcon = true;
            EditButton.BackColor = Color.Transparent;
            EditButton.BackColor1 = Color.FromArgb(220, 220, 221);
            EditButton.BackgroundImage = (Image)resources.GetObject("EditButton.BackgroundImage");
            EditButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            EditButton.ButtonText = "Edit";
            EditButton.ButtonTextMarginLeft = 0;
            EditButton.ColorContrastOnClick = 45;
            EditButton.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            EditButton.CustomizableEdges = borderEdges2;
            EditButton.DialogResult = DialogResult.None;
            EditButton.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            EditButton.DisabledFillColor = Color.FromArgb(204, 204, 204);
            EditButton.DisabledForecolor = Color.FromArgb(168, 160, 168);
            EditButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            EditButton.Font = new Font("Courier New", 12F, FontStyle.Bold);
            EditButton.ForeColor = Color.Black;
            EditButton.IconLeftAlign = ContentAlignment.MiddleLeft;
            EditButton.IconLeftCursor = Cursors.Default;
            EditButton.IconLeftPadding = new Padding(11, 3, 3, 3);
            EditButton.IconMarginLeft = 11;
            EditButton.IconPadding = 10;
            EditButton.IconRightAlign = ContentAlignment.MiddleRight;
            EditButton.IconRightCursor = Cursors.Default;
            EditButton.IconRightPadding = new Padding(3, 3, 7, 3);
            EditButton.IconSize = 25;
            EditButton.IdleBorderColor = Color.FromArgb(220, 220, 221);
            EditButton.IdleBorderRadius = 1;
            EditButton.IdleBorderThickness = 1;
            EditButton.IdleFillColor = Color.FromArgb(220, 220, 221);
            EditButton.IdleIconLeftImage = Properties.Resources.compose;
            EditButton.IdleIconRightImage = null;
            EditButton.IndicateFocus = false;
            EditButton.Location = new Point(353, 15);
            EditButton.Name = "EditButton";
            EditButton.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            EditButton.OnDisabledState.BorderRadius = 1;
            EditButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            EditButton.OnDisabledState.BorderThickness = 1;
            EditButton.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            EditButton.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            EditButton.OnDisabledState.IconLeftImage = null;
            EditButton.OnDisabledState.IconRightImage = null;
            EditButton.onHoverState.BorderColor = Color.Black;
            EditButton.onHoverState.BorderRadius = 1;
            EditButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            EditButton.onHoverState.BorderThickness = 1;
            EditButton.onHoverState.FillColor = Color.FromArgb(205, 205, 207);
            EditButton.onHoverState.ForeColor = Color.Black;
            EditButton.onHoverState.IconLeftImage = null;
            EditButton.onHoverState.IconRightImage = null;
            EditButton.OnIdleState.BorderColor = Color.FromArgb(220, 220, 221);
            EditButton.OnIdleState.BorderRadius = 1;
            EditButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            EditButton.OnIdleState.BorderThickness = 1;
            EditButton.OnIdleState.FillColor = Color.FromArgb(220, 220, 221);
            EditButton.OnIdleState.ForeColor = Color.Black;
            EditButton.OnIdleState.IconLeftImage = Properties.Resources.compose;
            EditButton.OnIdleState.IconRightImage = null;
            EditButton.OnPressedState.BorderColor = Color.FromArgb(161, 205, 220);
            EditButton.OnPressedState.BorderRadius = 1;
            EditButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            EditButton.OnPressedState.BorderThickness = 1;
            EditButton.OnPressedState.FillColor = Color.FromArgb(161, 205, 220);
            EditButton.OnPressedState.ForeColor = Color.Black;
            EditButton.OnPressedState.IconLeftImage = null;
            EditButton.OnPressedState.IconRightImage = null;
            EditButton.Size = new Size(160, 40);
            EditButton.TabIndex = 11;
            EditButton.TextAlign = ContentAlignment.MiddleLeft;
            EditButton.TextAlignment = HorizontalAlignment.Center;
            EditButton.TextMarginLeft = 0;
            EditButton.TextPadding = new Padding(35, 0, 0, 0);
            EditButton.UseDefaultRadiusAndThickness = true;
            EditButton.Click += EditButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.AllowAnimations = true;
            RemoveButton.AllowMouseEffects = true;
            RemoveButton.AllowToggling = false;
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveButton.AnimationSpeed = 200;
            RemoveButton.AutoGenerateColors = false;
            RemoveButton.AutoRoundBorders = false;
            RemoveButton.AutoSizeLeftIcon = true;
            RemoveButton.AutoSizeRightIcon = true;
            RemoveButton.BackColor = Color.Transparent;
            RemoveButton.BackColor1 = Color.FromArgb(220, 220, 221);
            RemoveButton.BackgroundImage = (Image)resources.GetObject("RemoveButton.BackgroundImage");
            RemoveButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            RemoveButton.ButtonText = "Remove";
            RemoveButton.ButtonTextMarginLeft = 0;
            RemoveButton.ColorContrastOnClick = 45;
            RemoveButton.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            RemoveButton.CustomizableEdges = borderEdges3;
            RemoveButton.DialogResult = DialogResult.None;
            RemoveButton.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            RemoveButton.DisabledFillColor = Color.FromArgb(204, 204, 204);
            RemoveButton.DisabledForecolor = Color.FromArgb(168, 160, 168);
            RemoveButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            RemoveButton.Font = new Font("Courier New", 12F, FontStyle.Bold);
            RemoveButton.ForeColor = Color.Black;
            RemoveButton.IconLeftAlign = ContentAlignment.MiddleLeft;
            RemoveButton.IconLeftCursor = Cursors.Default;
            RemoveButton.IconLeftPadding = new Padding(11, 3, 3, 3);
            RemoveButton.IconMarginLeft = 11;
            RemoveButton.IconPadding = 10;
            RemoveButton.IconRightAlign = ContentAlignment.MiddleRight;
            RemoveButton.IconRightCursor = Cursors.Default;
            RemoveButton.IconRightPadding = new Padding(3, 3, 7, 3);
            RemoveButton.IconSize = 25;
            RemoveButton.IdleBorderColor = Color.FromArgb(220, 220, 221);
            RemoveButton.IdleBorderRadius = 1;
            RemoveButton.IdleBorderThickness = 1;
            RemoveButton.IdleFillColor = Color.FromArgb(220, 220, 221);
            RemoveButton.IdleIconLeftImage = Properties.Resources.trashcan;
            RemoveButton.IdleIconRightImage = null;
            RemoveButton.IndicateFocus = false;
            RemoveButton.Location = new Point(173, 15);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            RemoveButton.OnDisabledState.BorderRadius = 1;
            RemoveButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            RemoveButton.OnDisabledState.BorderThickness = 1;
            RemoveButton.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            RemoveButton.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            RemoveButton.OnDisabledState.IconLeftImage = null;
            RemoveButton.OnDisabledState.IconRightImage = null;
            RemoveButton.onHoverState.BorderColor = Color.Black;
            RemoveButton.onHoverState.BorderRadius = 1;
            RemoveButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            RemoveButton.onHoverState.BorderThickness = 1;
            RemoveButton.onHoverState.FillColor = Color.FromArgb(205, 205, 207);
            RemoveButton.onHoverState.ForeColor = Color.Black;
            RemoveButton.onHoverState.IconLeftImage = null;
            RemoveButton.onHoverState.IconRightImage = null;
            RemoveButton.OnIdleState.BorderColor = Color.FromArgb(220, 220, 221);
            RemoveButton.OnIdleState.BorderRadius = 1;
            RemoveButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            RemoveButton.OnIdleState.BorderThickness = 1;
            RemoveButton.OnIdleState.FillColor = Color.FromArgb(220, 220, 221);
            RemoveButton.OnIdleState.ForeColor = Color.Black;
            RemoveButton.OnIdleState.IconLeftImage = Properties.Resources.trashcan;
            RemoveButton.OnIdleState.IconRightImage = null;
            RemoveButton.OnPressedState.BorderColor = Color.FromArgb(161, 205, 220);
            RemoveButton.OnPressedState.BorderRadius = 1;
            RemoveButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            RemoveButton.OnPressedState.BorderThickness = 1;
            RemoveButton.OnPressedState.FillColor = Color.FromArgb(161, 205, 220);
            RemoveButton.OnPressedState.ForeColor = Color.Black;
            RemoveButton.OnPressedState.IconLeftImage = null;
            RemoveButton.OnPressedState.IconRightImage = null;
            RemoveButton.Size = new Size(165, 40);
            RemoveButton.TabIndex = 10;
            RemoveButton.TextAlign = ContentAlignment.MiddleLeft;
            RemoveButton.TextAlignment = HorizontalAlignment.Center;
            RemoveButton.TextMarginLeft = 0;
            RemoveButton.TextPadding = new Padding(35, 0, 0, 0);
            RemoveButton.UseDefaultRadiusAndThickness = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // Pagination
            // 
            Pagination.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Pagination.Controls.Add(PaginationLabel);
            Pagination.Controls.Add(PaginationPREV);
            Pagination.Controls.Add(PaginationNext);
            Pagination.Location = new Point(5, 553);
            Pagination.Name = "Pagination";
            Pagination.Size = new Size(194, 50);
            Pagination.TabIndex = 9;
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
            // SearchBox
            // 
            SearchBox.AcceptsReturn = false;
            SearchBox.AcceptsTab = false;
            SearchBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SearchBox.AnimationSpeed = 200;
            SearchBox.AutoCompleteMode = AutoCompleteMode.None;
            SearchBox.AutoCompleteSource = AutoCompleteSource.None;
            SearchBox.AutoSizeHeight = true;
            SearchBox.BackColor = Color.White;
            SearchBox.BackgroundImage = (Image)resources.GetObject("SearchBox.BackgroundImage");
            SearchBox.BorderColorActive = Color.DodgerBlue;
            SearchBox.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            SearchBox.BorderColorHover = Color.FromArgb(105, 181, 255);
            SearchBox.BorderColorIdle = Color.Silver;
            SearchBox.BorderRadius = 1;
            SearchBox.BorderThickness = 1;
            SearchBox.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            SearchBox.CharacterCasing = CharacterCasing.Normal;
            SearchBox.DefaultFont = new Font("Segoe UI", 9.25F);
            SearchBox.DefaultText = "";
            SearchBox.FillColor = Color.White;
            SearchBox.HideSelection = true;
            SearchBox.IconLeft = Properties.Resources.magnifying_glass;
            SearchBox.IconLeftCursor = Cursors.IBeam;
            SearchBox.IconPadding = 10;
            SearchBox.IconRight = null;
            SearchBox.IconRightCursor = Cursors.IBeam;
            SearchBox.Location = new Point(560, 15);
            SearchBox.MaxLength = 32767;
            SearchBox.MinimumSize = new Size(1, 1);
            SearchBox.Modified = false;
            SearchBox.Multiline = false;
            SearchBox.Name = "SearchBox";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            SearchBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            SearchBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            SearchBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.Empty;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            SearchBox.OnIdleState = stateProperties4;
            SearchBox.Padding = new Padding(35, 3, 3, 3);
            SearchBox.PasswordChar = '\0';
            SearchBox.PlaceholderForeColor = Color.Silver;
            SearchBox.PlaceholderText = "Search by Product Code or Name";
            SearchBox.ReadOnly = false;
            SearchBox.ScrollBars = ScrollBars.None;
            SearchBox.SelectedText = "";
            SearchBox.SelectionLength = 0;
            SearchBox.SelectionStart = 0;
            SearchBox.ShortcutsEnabled = true;
            SearchBox.Size = new Size(340, 39);
            SearchBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            SearchBox.TabIndex = 4;
            SearchBox.TextAlign = HorizontalAlignment.Left;
            SearchBox.TextMarginBottom = 0;
            SearchBox.TextMarginLeft = 3;
            SearchBox.TextMarginTop = 1;
            SearchBox.TextPlaceholder = "Search by Product Code or Name";
            SearchBox.UseSystemPasswordChar = false;
            SearchBox.WordWrap = true;
            SearchBox.TextChange += SearchBox_TextChange;
            // 
            // AddProductBTN
            // 
            AddProductBTN.AllowAnimations = true;
            AddProductBTN.AllowMouseEffects = true;
            AddProductBTN.AllowToggling = false;
            AddProductBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddProductBTN.AnimationSpeed = 200;
            AddProductBTN.AutoGenerateColors = false;
            AddProductBTN.AutoRoundBorders = false;
            AddProductBTN.AutoSizeLeftIcon = true;
            AddProductBTN.AutoSizeRightIcon = true;
            AddProductBTN.BackColor = Color.Transparent;
            AddProductBTN.BackColor1 = Color.FromArgb(78, 160, 21);
            AddProductBTN.BackgroundImage = (Image)resources.GetObject("AddProductBTN.BackgroundImage");
            AddProductBTN.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddProductBTN.ButtonText = "Add Product";
            AddProductBTN.ButtonTextMarginLeft = 0;
            AddProductBTN.ColorContrastOnClick = 45;
            AddProductBTN.ColorContrastOnHover = 45;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            AddProductBTN.CustomizableEdges = borderEdges4;
            AddProductBTN.DialogResult = DialogResult.None;
            AddProductBTN.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            AddProductBTN.DisabledFillColor = Color.FromArgb(204, 204, 204);
            AddProductBTN.DisabledForecolor = Color.FromArgb(168, 160, 168);
            AddProductBTN.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            AddProductBTN.Font = new Font("Courier New", 12F, FontStyle.Bold);
            AddProductBTN.ForeColor = Color.White;
            AddProductBTN.IconLeftAlign = ContentAlignment.MiddleLeft;
            AddProductBTN.IconLeftCursor = Cursors.Default;
            AddProductBTN.IconLeftPadding = new Padding(11, 3, 3, 3);
            AddProductBTN.IconMarginLeft = 11;
            AddProductBTN.IconPadding = 10;
            AddProductBTN.IconRightAlign = ContentAlignment.MiddleRight;
            AddProductBTN.IconRightCursor = Cursors.Default;
            AddProductBTN.IconRightPadding = new Padding(3, 3, 7, 3);
            AddProductBTN.IconSize = 25;
            AddProductBTN.IdleBorderColor = Color.FromArgb(78, 160, 21);
            AddProductBTN.IdleBorderRadius = 1;
            AddProductBTN.IdleBorderThickness = 1;
            AddProductBTN.IdleFillColor = Color.FromArgb(78, 160, 21);
            AddProductBTN.IdleIconLeftImage = Properties.Resources.plus__1_;
            AddProductBTN.IdleIconRightImage = null;
            AddProductBTN.IndicateFocus = false;
            AddProductBTN.Location = new Point(7, 15);
            AddProductBTN.Name = "AddProductBTN";
            AddProductBTN.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            AddProductBTN.OnDisabledState.BorderRadius = 1;
            AddProductBTN.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddProductBTN.OnDisabledState.BorderThickness = 1;
            AddProductBTN.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            AddProductBTN.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            AddProductBTN.OnDisabledState.IconLeftImage = null;
            AddProductBTN.OnDisabledState.IconRightImage = null;
            AddProductBTN.onHoverState.BorderColor = Color.FromArgb(50, 110, 5);
            AddProductBTN.onHoverState.BorderRadius = 1;
            AddProductBTN.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddProductBTN.onHoverState.BorderThickness = 1;
            AddProductBTN.onHoverState.FillColor = Color.FromArgb(50, 110, 5);
            AddProductBTN.onHoverState.ForeColor = Color.White;
            AddProductBTN.onHoverState.IconLeftImage = null;
            AddProductBTN.onHoverState.IconRightImage = null;
            AddProductBTN.OnIdleState.BorderColor = Color.FromArgb(78, 160, 21);
            AddProductBTN.OnIdleState.BorderRadius = 1;
            AddProductBTN.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddProductBTN.OnIdleState.BorderThickness = 1;
            AddProductBTN.OnIdleState.FillColor = Color.FromArgb(78, 160, 21);
            AddProductBTN.OnIdleState.ForeColor = Color.White;
            AddProductBTN.OnIdleState.IconLeftImage = Properties.Resources.plus__1_;
            AddProductBTN.OnIdleState.IconRightImage = null;
            AddProductBTN.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            AddProductBTN.OnPressedState.BorderRadius = 1;
            AddProductBTN.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddProductBTN.OnPressedState.BorderThickness = 1;
            AddProductBTN.OnPressedState.FillColor = Color.FromArgb(192, 64, 0);
            AddProductBTN.OnPressedState.ForeColor = Color.White;
            AddProductBTN.OnPressedState.IconLeftImage = null;
            AddProductBTN.OnPressedState.IconRightImage = null;
            AddProductBTN.Size = new Size(160, 40);
            AddProductBTN.TabIndex = 2;
            AddProductBTN.TextAlign = ContentAlignment.MiddleLeft;
            AddProductBTN.TextAlignment = HorizontalAlignment.Center;
            AddProductBTN.TextMarginLeft = 0;
            AddProductBTN.TextPadding = new Padding(35, 0, 0, 0);
            AddProductBTN.UseDefaultRadiusAndThickness = true;
            AddProductBTN.Click += AddProductBTN_Click;
            // 
            // AllProductDatagridView
            // 
            AllProductDatagridView.AllowCustomTheming = false;
            AllProductDatagridView.AllowUserToAddRows = false;
            AllProductDatagridView.AllowUserToDeleteRows = false;
            AllProductDatagridView.AllowUserToResizeColumns = false;
            AllProductDatagridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(223, 191, 191);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            AllProductDatagridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AllProductDatagridView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AllProductDatagridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllProductDatagridView.BackgroundColor = Color.White;
            AllProductDatagridView.BorderStyle = BorderStyle.None;
            AllProductDatagridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            AllProductDatagridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 0, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AllProductDatagridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AllProductDatagridView.ColumnHeadersHeight = 40;
            AllProductDatagridView.Columns.AddRange(new DataGridViewColumn[] { IdCol, AvailabilityCol, ProductCodeCol, ProductNameCol, PriceCol, ActionCol });
            AllProductDatagridView.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(223, 191, 191);
            AllProductDatagridView.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            AllProductDatagridView.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            AllProductDatagridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(178, 102, 102);
            AllProductDatagridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.White;
            AllProductDatagridView.CurrentTheme.BackColor = Color.Maroon;
            AllProductDatagridView.CurrentTheme.GridColor = Color.FromArgb(216, 178, 178);
            AllProductDatagridView.CurrentTheme.HeaderStyle.BackColor = Color.Maroon;
            AllProductDatagridView.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            AllProductDatagridView.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            AllProductDatagridView.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(102, 0, 0);
            AllProductDatagridView.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            AllProductDatagridView.CurrentTheme.Name = null;
            AllProductDatagridView.CurrentTheme.RowsStyle.BackColor = Color.FromArgb(229, 204, 204);
            AllProductDatagridView.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            AllProductDatagridView.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            AllProductDatagridView.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(178, 102, 102);
            AllProductDatagridView.CurrentTheme.RowsStyle.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(229, 204, 204);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(178, 102, 102);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            AllProductDatagridView.DefaultCellStyle = dataGridViewCellStyle5;
            AllProductDatagridView.EnableHeadersVisualStyles = false;
            AllProductDatagridView.GridColor = Color.FromArgb(216, 178, 178);
            AllProductDatagridView.HeaderBackColor = Color.Maroon;
            AllProductDatagridView.HeaderBgColor = Color.Empty;
            AllProductDatagridView.HeaderForeColor = Color.White;
            AllProductDatagridView.Location = new Point(5, 65);
            AllProductDatagridView.Name = "AllProductDatagridView";
            AllProductDatagridView.ReadOnly = true;
            AllProductDatagridView.RowHeadersVisible = false;
            AllProductDatagridView.RowTemplate.DefaultCellStyle.Font = new Font("Cambria", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllProductDatagridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            AllProductDatagridView.RowTemplate.Height = 40;
            AllProductDatagridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllProductDatagridView.Size = new Size(940, 481);
            AllProductDatagridView.TabIndex = 1;
            AllProductDatagridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Maroon;
            AllProductDatagridView.CellContentClick += AllProductDatagridView_CellContentClick;
            AllProductDatagridView.CellFormatting += AllProductDatagridView_CellFormatting;
            AllProductDatagridView.MouseClick += AllItemsDatagrid_MouseClick;
            // 
            // IdCol
            // 
            IdCol.FillWeight = 5F;
            IdCol.HeaderText = "ItemID";
            IdCol.Name = "IdCol";
            IdCol.ReadOnly = true;
            IdCol.Visible = false;
            // 
            // AvailabilityCol
            // 
            AvailabilityCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.NullValue = resources.GetObject("dataGridViewCellStyle3.NullValue");
            dataGridViewCellStyle3.Padding = new Padding(3, 5, 3, 5);
            AvailabilityCol.DefaultCellStyle = dataGridViewCellStyle3;
            AvailabilityCol.FillWeight = 40F;
            AvailabilityCol.HeaderText = "";
            AvailabilityCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            AvailabilityCol.Name = "AvailabilityCol";
            AvailabilityCol.ReadOnly = true;
            AvailabilityCol.Resizable = DataGridViewTriState.True;
            AvailabilityCol.SortMode = DataGridViewColumnSortMode.Automatic;
            AvailabilityCol.Width = 40;
            // 
            // ProductCodeCol
            // 
            ProductCodeCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ProductCodeCol.FillWeight = 25F;
            ProductCodeCol.HeaderText = "Code";
            ProductCodeCol.Name = "ProductCodeCol";
            ProductCodeCol.ReadOnly = true;
            ProductCodeCol.Width = 72;
            // 
            // ProductNameCol
            // 
            ProductNameCol.FillWeight = 14.6522036F;
            ProductNameCol.HeaderText = "Product Name";
            ProductNameCol.Name = "ProductNameCol";
            ProductNameCol.ReadOnly = true;
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
            // ActionCol
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(64, 64, 64);
            ActionCol.DefaultCellStyle = dataGridViewCellStyle4;
            ActionCol.FillWeight = 2.63739681F;
            ActionCol.FlatStyle = FlatStyle.Flat;
            ActionCol.HeaderText = "Status";
            ActionCol.Name = "ActionCol";
            ActionCol.ReadOnly = true;
            ActionCol.Text = "Change Status";
            ActionCol.UseColumnTextForButtonValue = true;
            // 
            // ProductMenuStrip
            // 
            ProductMenuStrip.Items.AddRange(new ToolStripItem[] { Edittoolstrip, sep1, Deletetoolstrip });
            ProductMenuStrip.Name = "ProductMenuStrip";
            ProductMenuStrip.Size = new Size(150, 54);
            // 
            // Edittoolstrip
            // 
            Edittoolstrip.Name = "Edittoolstrip";
            Edittoolstrip.Size = new Size(149, 22);
            Edittoolstrip.Text = "Edit";
            Edittoolstrip.Click += Edittoolstrip_Click;
            // 
            // sep1
            // 
            sep1.Name = "sep1";
            sep1.Size = new Size(146, 6);
            // 
            // Deletetoolstrip
            // 
            Deletetoolstrip.Name = "Deletetoolstrip";
            Deletetoolstrip.Size = new Size(149, 22);
            Deletetoolstrip.Text = "Remove Items";
            // 
            // ProductsInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 680);
            Controls.Add(MainContainer);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductsInventory";
            Text = "Products";
            Load += ProductsInventory_Load;
            TopPanel.ResumeLayout(false);
            MainContainer.ResumeLayout(false);
            bunifuShadowPanel1.ResumeLayout(false);
            bunifuShadowPanel1.PerformLayout();
            Pagination.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AllProductDatagridView).EndInit();
            ProductMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Label label1;
        private Panel MainContainer;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 AddProductBTN;
        private Bunifu.UI.WinForms.BunifuDataGridView AllProductDatagridView;
        private Bunifu.UI.WinForms.BunifuTextBox SearchBox;
        private Panel Pagination;
        private Label PaginationLabel;
        private Bunifu.UI.WinForms.BunifuImageButton PaginationPREV;
        private Bunifu.UI.WinForms.BunifuImageButton PaginationNext;
        private ContextMenuStrip ProductMenuStrip;
        private ToolStripMenuItem Edittoolstrip;
        private ToolStripSeparator sep1;
        private ToolStripMenuItem Deletetoolstrip;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 EditButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 RemoveButton;
        private Panel panel4;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewImageColumn AvailabilityCol;
        private DataGridViewTextBoxColumn ProductCodeCol;
        private DataGridViewTextBoxColumn ProductNameCol;
        private DataGridViewTextBoxColumn PriceCol;
        private DataGridViewButtonColumn ActionCol;
        private Bunifu.UI.WinForms.BunifuImageButton filterbutton;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.UI.WinForms.BunifuDropdown businesscategorypicked;
        private Label label3;
        private Label label2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Label label4;
        private TextBox productperpagetxt;
    }
}