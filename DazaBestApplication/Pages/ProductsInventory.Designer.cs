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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
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
            label1 = new Label();
            MainContainer = new Panel();
            EditButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            RemoveButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            bunifuButton22 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
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
            QuantityCol = new DataGridViewTextBoxColumn();
            PriceCol = new DataGridViewTextBoxColumn();
            ActionCol = new DataGridViewButtonColumn();
            ProductMenuStrip = new ContextMenuStrip(components);
            Edittoolstrip = new ToolStripMenuItem();
            sep1 = new ToolStripSeparator();
            Deletetoolstrip = new ToolStripMenuItem();
            TopPanel.SuspendLayout();
            MainContainer.SuspendLayout();
            Pagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AllProductDatagridView).BeginInit();
            ProductMenuStrip.SuspendLayout();
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
            label1.Size = new Size(191, 50);
            label1.TabIndex = 0;
            label1.Text = "Products";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainContainer
            // 
            MainContainer.Controls.Add(EditButton);
            MainContainer.Controls.Add(RemoveButton);
            MainContainer.Controls.Add(bunifuButton22);
            MainContainer.Controls.Add(Pagination);
            MainContainer.Controls.Add(SearchBox);
            MainContainer.Controls.Add(AddProductBTN);
            MainContainer.Controls.Add(AllProductDatagridView);
            MainContainer.Dock = DockStyle.Fill;
            MainContainer.Location = new Point(0, 50);
            MainContainer.Name = "MainContainer";
            MainContainer.Padding = new Padding(0, 10, 0, 0);
            MainContainer.Size = new Size(900, 612);
            MainContainer.TabIndex = 2;
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
            EditButton.BackColor1 = Color.Maroon;
            EditButton.BackgroundImage = (Image)resources.GetObject("EditButton.BackgroundImage");
            EditButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            EditButton.ButtonText = "Edit Product";
            EditButton.ButtonTextMarginLeft = 0;
            EditButton.ColorContrastOnClick = 45;
            EditButton.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            EditButton.CustomizableEdges = borderEdges1;
            EditButton.DialogResult = DialogResult.None;
            EditButton.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            EditButton.DisabledFillColor = Color.FromArgb(204, 204, 204);
            EditButton.DisabledForecolor = Color.FromArgb(168, 160, 168);
            EditButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            EditButton.Font = new Font("Courier New", 12F, FontStyle.Bold);
            EditButton.ForeColor = Color.White;
            EditButton.IconLeftAlign = ContentAlignment.MiddleLeft;
            EditButton.IconLeftCursor = Cursors.Default;
            EditButton.IconLeftPadding = new Padding(11, 3, 3, 3);
            EditButton.IconMarginLeft = 11;
            EditButton.IconPadding = 10;
            EditButton.IconRightAlign = ContentAlignment.MiddleRight;
            EditButton.IconRightCursor = Cursors.Default;
            EditButton.IconRightPadding = new Padding(3, 3, 7, 3);
            EditButton.IconSize = 25;
            EditButton.IdleBorderColor = Color.Maroon;
            EditButton.IdleBorderRadius = 1;
            EditButton.IdleBorderThickness = 1;
            EditButton.IdleFillColor = Color.Maroon;
            EditButton.IdleIconLeftImage = null;
            EditButton.IdleIconRightImage = null;
            EditButton.IndicateFocus = false;
            EditButton.Location = new Point(318, 20);
            EditButton.Name = "EditButton";
            EditButton.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            EditButton.OnDisabledState.BorderRadius = 1;
            EditButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            EditButton.OnDisabledState.BorderThickness = 1;
            EditButton.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            EditButton.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            EditButton.OnDisabledState.IconLeftImage = null;
            EditButton.OnDisabledState.IconRightImage = null;
            EditButton.onHoverState.BorderColor = Color.FromArgb(105, 181, 255);
            EditButton.onHoverState.BorderRadius = 1;
            EditButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            EditButton.onHoverState.BorderThickness = 1;
            EditButton.onHoverState.FillColor = Color.FromArgb(255, 128, 0);
            EditButton.onHoverState.ForeColor = Color.White;
            EditButton.onHoverState.IconLeftImage = null;
            EditButton.onHoverState.IconRightImage = null;
            EditButton.OnIdleState.BorderColor = Color.Maroon;
            EditButton.OnIdleState.BorderRadius = 1;
            EditButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            EditButton.OnIdleState.BorderThickness = 1;
            EditButton.OnIdleState.FillColor = Color.Maroon;
            EditButton.OnIdleState.ForeColor = Color.White;
            EditButton.OnIdleState.IconLeftImage = null;
            EditButton.OnIdleState.IconRightImage = null;
            EditButton.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            EditButton.OnPressedState.BorderRadius = 1;
            EditButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            EditButton.OnPressedState.BorderThickness = 1;
            EditButton.OnPressedState.FillColor = Color.FromArgb(192, 64, 0);
            EditButton.OnPressedState.ForeColor = Color.White;
            EditButton.OnPressedState.IconLeftImage = null;
            EditButton.OnPressedState.IconRightImage = null;
            EditButton.Size = new Size(154, 40);
            EditButton.TabIndex = 11;
            EditButton.TextAlign = ContentAlignment.MiddleCenter;
            EditButton.TextAlignment = HorizontalAlignment.Center;
            EditButton.TextMarginLeft = 0;
            EditButton.TextPadding = new Padding(0);
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
            RemoveButton.BackColor1 = Color.Maroon;
            RemoveButton.BackgroundImage = (Image)resources.GetObject("RemoveButton.BackgroundImage");
            RemoveButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            RemoveButton.ButtonText = "Remove Product";
            RemoveButton.ButtonTextMarginLeft = 0;
            RemoveButton.ColorContrastOnClick = 45;
            RemoveButton.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            RemoveButton.CustomizableEdges = borderEdges2;
            RemoveButton.DialogResult = DialogResult.None;
            RemoveButton.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            RemoveButton.DisabledFillColor = Color.FromArgb(204, 204, 204);
            RemoveButton.DisabledForecolor = Color.FromArgb(168, 160, 168);
            RemoveButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            RemoveButton.Font = new Font("Courier New", 12F, FontStyle.Bold);
            RemoveButton.ForeColor = Color.White;
            RemoveButton.IconLeftAlign = ContentAlignment.MiddleLeft;
            RemoveButton.IconLeftCursor = Cursors.Default;
            RemoveButton.IconLeftPadding = new Padding(11, 3, 3, 3);
            RemoveButton.IconMarginLeft = 11;
            RemoveButton.IconPadding = 10;
            RemoveButton.IconRightAlign = ContentAlignment.MiddleRight;
            RemoveButton.IconRightCursor = Cursors.Default;
            RemoveButton.IconRightPadding = new Padding(3, 3, 7, 3);
            RemoveButton.IconSize = 25;
            RemoveButton.IdleBorderColor = Color.Maroon;
            RemoveButton.IdleBorderRadius = 1;
            RemoveButton.IdleBorderThickness = 1;
            RemoveButton.IdleFillColor = Color.Maroon;
            RemoveButton.IdleIconLeftImage = null;
            RemoveButton.IdleIconRightImage = null;
            RemoveButton.IndicateFocus = false;
            RemoveButton.Location = new Point(163, 20);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            RemoveButton.OnDisabledState.BorderRadius = 1;
            RemoveButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            RemoveButton.OnDisabledState.BorderThickness = 1;
            RemoveButton.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            RemoveButton.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            RemoveButton.OnDisabledState.IconLeftImage = null;
            RemoveButton.OnDisabledState.IconRightImage = null;
            RemoveButton.onHoverState.BorderColor = Color.FromArgb(105, 181, 255);
            RemoveButton.onHoverState.BorderRadius = 1;
            RemoveButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            RemoveButton.onHoverState.BorderThickness = 1;
            RemoveButton.onHoverState.FillColor = Color.FromArgb(255, 128, 0);
            RemoveButton.onHoverState.ForeColor = Color.White;
            RemoveButton.onHoverState.IconLeftImage = null;
            RemoveButton.onHoverState.IconRightImage = null;
            RemoveButton.OnIdleState.BorderColor = Color.Maroon;
            RemoveButton.OnIdleState.BorderRadius = 1;
            RemoveButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            RemoveButton.OnIdleState.BorderThickness = 1;
            RemoveButton.OnIdleState.FillColor = Color.Maroon;
            RemoveButton.OnIdleState.ForeColor = Color.White;
            RemoveButton.OnIdleState.IconLeftImage = null;
            RemoveButton.OnIdleState.IconRightImage = null;
            RemoveButton.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            RemoveButton.OnPressedState.BorderRadius = 1;
            RemoveButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            RemoveButton.OnPressedState.BorderThickness = 1;
            RemoveButton.OnPressedState.FillColor = Color.FromArgb(192, 64, 0);
            RemoveButton.OnPressedState.ForeColor = Color.White;
            RemoveButton.OnPressedState.IconLeftImage = null;
            RemoveButton.OnPressedState.IconRightImage = null;
            RemoveButton.Size = new Size(154, 40);
            RemoveButton.TabIndex = 10;
            RemoveButton.TextAlign = ContentAlignment.MiddleCenter;
            RemoveButton.TextAlignment = HorizontalAlignment.Center;
            RemoveButton.TextMarginLeft = 0;
            RemoveButton.TextPadding = new Padding(0);
            RemoveButton.UseDefaultRadiusAndThickness = true;
            RemoveButton.Click += RemoveButton_Click;
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
            bunifuButton22.BackColor1 = Color.Maroon;
            bunifuButton22.BackgroundImage = (Image)resources.GetObject("bunifuButton22.BackgroundImage");
            bunifuButton22.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton22.ButtonText = "Report";
            bunifuButton22.ButtonTextMarginLeft = 0;
            bunifuButton22.ColorContrastOnClick = 45;
            bunifuButton22.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            bunifuButton22.CustomizableEdges = borderEdges3;
            bunifuButton22.DialogResult = DialogResult.None;
            bunifuButton22.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton22.DisabledFillColor = Color.FromArgb(204, 204, 204);
            bunifuButton22.DisabledForecolor = Color.FromArgb(168, 160, 168);
            bunifuButton22.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            bunifuButton22.Font = new Font("Courier New", 12F, FontStyle.Bold);
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
            bunifuButton22.IdleBorderColor = Color.Maroon;
            bunifuButton22.IdleBorderRadius = 1;
            bunifuButton22.IdleBorderThickness = 1;
            bunifuButton22.IdleFillColor = Color.Maroon;
            bunifuButton22.IdleIconLeftImage = null;
            bunifuButton22.IdleIconRightImage = null;
            bunifuButton22.IndicateFocus = false;
            bunifuButton22.Location = new Point(473, 20);
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
            bunifuButton22.OnIdleState.BorderColor = Color.Maroon;
            bunifuButton22.OnIdleState.BorderRadius = 1;
            bunifuButton22.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton22.OnIdleState.BorderThickness = 1;
            bunifuButton22.OnIdleState.FillColor = Color.Maroon;
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
            bunifuButton22.Size = new Size(136, 40);
            bunifuButton22.TabIndex = 5;
            bunifuButton22.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton22.TextAlignment = HorizontalAlignment.Center;
            bunifuButton22.TextMarginLeft = 0;
            bunifuButton22.TextPadding = new Padding(0);
            bunifuButton22.UseDefaultRadiusAndThickness = true;
            // 
            // Pagination
            // 
            Pagination.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Pagination.Controls.Add(PaginationLabel);
            Pagination.Controls.Add(PaginationPREV);
            Pagination.Controls.Add(PaginationNext);
            Pagination.Location = new Point(5, 553);
            Pagination.Name = "Pagination";
            Pagination.Size = new Size(145, 50);
            Pagination.TabIndex = 9;
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
            SearchBox.IconLeft = null;
            SearchBox.IconLeftCursor = Cursors.IBeam;
            SearchBox.IconPadding = 10;
            SearchBox.IconRight = null;
            SearchBox.IconRightCursor = Cursors.IBeam;
            SearchBox.Location = new Point(615, 20);
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
            SearchBox.Padding = new Padding(3);
            SearchBox.PasswordChar = '\0';
            SearchBox.PlaceholderForeColor = Color.Silver;
            SearchBox.PlaceholderText = "Search";
            SearchBox.ReadOnly = false;
            SearchBox.ScrollBars = ScrollBars.None;
            SearchBox.SelectedText = "";
            SearchBox.SelectionLength = 0;
            SearchBox.SelectionStart = 0;
            SearchBox.ShortcutsEnabled = true;
            SearchBox.Size = new Size(280, 39);
            SearchBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            SearchBox.TabIndex = 4;
            SearchBox.TextAlign = HorizontalAlignment.Left;
            SearchBox.TextMarginBottom = 0;
            SearchBox.TextMarginLeft = 3;
            SearchBox.TextMarginTop = 1;
            SearchBox.TextPlaceholder = "Search";
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
            AddProductBTN.BackColor1 = Color.Maroon;
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
            AddProductBTN.IdleBorderColor = Color.Maroon;
            AddProductBTN.IdleBorderRadius = 1;
            AddProductBTN.IdleBorderThickness = 1;
            AddProductBTN.IdleFillColor = Color.Maroon;
            AddProductBTN.IdleIconLeftImage = null;
            AddProductBTN.IdleIconRightImage = null;
            AddProductBTN.IndicateFocus = false;
            AddProductBTN.Location = new Point(7, 20);
            AddProductBTN.Name = "AddProductBTN";
            AddProductBTN.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            AddProductBTN.OnDisabledState.BorderRadius = 1;
            AddProductBTN.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddProductBTN.OnDisabledState.BorderThickness = 1;
            AddProductBTN.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            AddProductBTN.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            AddProductBTN.OnDisabledState.IconLeftImage = null;
            AddProductBTN.OnDisabledState.IconRightImage = null;
            AddProductBTN.onHoverState.BorderColor = Color.FromArgb(105, 181, 255);
            AddProductBTN.onHoverState.BorderRadius = 1;
            AddProductBTN.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddProductBTN.onHoverState.BorderThickness = 1;
            AddProductBTN.onHoverState.FillColor = Color.FromArgb(255, 128, 0);
            AddProductBTN.onHoverState.ForeColor = Color.White;
            AddProductBTN.onHoverState.IconLeftImage = null;
            AddProductBTN.onHoverState.IconRightImage = null;
            AddProductBTN.OnIdleState.BorderColor = Color.Maroon;
            AddProductBTN.OnIdleState.BorderRadius = 1;
            AddProductBTN.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddProductBTN.OnIdleState.BorderThickness = 1;
            AddProductBTN.OnIdleState.FillColor = Color.Maroon;
            AddProductBTN.OnIdleState.ForeColor = Color.White;
            AddProductBTN.OnIdleState.IconLeftImage = null;
            AddProductBTN.OnIdleState.IconRightImage = null;
            AddProductBTN.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            AddProductBTN.OnPressedState.BorderRadius = 1;
            AddProductBTN.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddProductBTN.OnPressedState.BorderThickness = 1;
            AddProductBTN.OnPressedState.FillColor = Color.FromArgb(192, 64, 0);
            AddProductBTN.OnPressedState.ForeColor = Color.White;
            AddProductBTN.OnPressedState.IconLeftImage = null;
            AddProductBTN.OnPressedState.IconRightImage = null;
            AddProductBTN.Size = new Size(154, 40);
            AddProductBTN.TabIndex = 2;
            AddProductBTN.TextAlign = ContentAlignment.MiddleCenter;
            AddProductBTN.TextAlignment = HorizontalAlignment.Center;
            AddProductBTN.TextMarginLeft = 0;
            AddProductBTN.TextPadding = new Padding(0);
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
            AllProductDatagridView.Columns.AddRange(new DataGridViewColumn[] { IdCol, AvailabilityCol, ProductCodeCol, ProductNameCol, QuantityCol, PriceCol, ActionCol });
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
            AllProductDatagridView.Location = new Point(5, 66);
            AllProductDatagridView.Name = "AllProductDatagridView";
            AllProductDatagridView.ReadOnly = true;
            AllProductDatagridView.RowHeadersVisible = false;
            AllProductDatagridView.RowTemplate.Height = 40;
            AllProductDatagridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllProductDatagridView.Size = new Size(890, 481);
            AllProductDatagridView.TabIndex = 1;
            AllProductDatagridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Maroon;
            AllProductDatagridView.CellContentClick += AllProductDatagridView_CellContentClick;
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
            // QuantityCol
            // 
            QuantityCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            QuantityCol.FillWeight = 20F;
            QuantityCol.HeaderText = "Qty.";
            QuantityCol.Name = "QuantityCol";
            QuantityCol.ReadOnly = true;
            QuantityCol.Width = 62;
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
            dataGridViewCellStyle4.Padding = new Padding(5, 2, 5, 2);
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
            ClientSize = new Size(900, 662);
            Controls.Add(MainContainer);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductsInventory";
            Text = "Products";
            Load += ProductsInventory_Load;
            TopPanel.ResumeLayout(false);
            MainContainer.ResumeLayout(false);
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton22;
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
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewImageColumn AvailabilityCol;
        private DataGridViewTextBoxColumn ProductCodeCol;
        private DataGridViewTextBoxColumn ProductNameCol;
        private DataGridViewTextBoxColumn QuantityCol;
        private DataGridViewTextBoxColumn PriceCol;
        private DataGridViewButtonColumn ActionCol;
    }
}