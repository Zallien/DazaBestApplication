namespace DazaBestApplication.Pages
{
    partial class ItemAdjustment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemAdjustment));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            TopPanel = new Panel();
            label1 = new Label();
            MainContainer = new Panel();
            SearchBox = new Bunifu.UI.WinForms.BunifuTextBox();
            AdjustItemBTN = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            AllAdjustmentItemsDatagrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            ReferenceNoCol = new DataGridViewTextBoxColumn();
            OperatedDateCol = new DataGridViewTextBoxColumn();
            AdjustedByCol = new DataGridViewTextBoxColumn();
            Pagination = new Panel();
            PaginationLabel = new Label();
            PaginationPREV = new Bunifu.UI.WinForms.BunifuImageButton();
            PaginationNext = new Bunifu.UI.WinForms.BunifuImageButton();
            panel4 = new Panel();
            TopPanel.SuspendLayout();
            MainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AllAdjustmentItemsDatagrid).BeginInit();
            Pagination.SuspendLayout();
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
            TopPanel.Size = new Size(900, 50);
            TopPanel.TabIndex = 4;
            // 
            // label1
            // 
            label1.Font = new Font("Courier New", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 0);
            label1.Name = "label1";
            label1.Size = new Size(413, 50);
            label1.TabIndex = 0;
            label1.Text = "Item Adjustment";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainContainer
            // 
            MainContainer.Controls.Add(SearchBox);
            MainContainer.Controls.Add(AdjustItemBTN);
            MainContainer.Controls.Add(AllAdjustmentItemsDatagrid);
            MainContainer.Controls.Add(Pagination);
            MainContainer.Dock = DockStyle.Fill;
            MainContainer.Location = new Point(0, 50);
            MainContainer.Name = "MainContainer";
            MainContainer.Padding = new Padding(0, 10, 0, 0);
            MainContainer.Size = new Size(900, 612);
            MainContainer.TabIndex = 5;
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
            SearchBox.Location = new Point(394, 14);
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
            SearchBox.PlaceholderText = "Search by Purchase No";
            SearchBox.ReadOnly = false;
            SearchBox.ScrollBars = ScrollBars.None;
            SearchBox.SelectedText = "";
            SearchBox.SelectionLength = 0;
            SearchBox.SelectionStart = 0;
            SearchBox.ShortcutsEnabled = true;
            SearchBox.Size = new Size(494, 39);
            SearchBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            SearchBox.TabIndex = 12;
            SearchBox.TextAlign = HorizontalAlignment.Left;
            SearchBox.TextMarginBottom = 0;
            SearchBox.TextMarginLeft = 3;
            SearchBox.TextMarginTop = 1;
            SearchBox.TextPlaceholder = "Search by Purchase No";
            SearchBox.UseSystemPasswordChar = false;
            SearchBox.WordWrap = true;
            // 
            // AdjustItemBTN
            // 
            AdjustItemBTN.AllowAnimations = true;
            AdjustItemBTN.AllowMouseEffects = true;
            AdjustItemBTN.AllowToggling = false;
            AdjustItemBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AdjustItemBTN.AnimationSpeed = 200;
            AdjustItemBTN.AutoGenerateColors = false;
            AdjustItemBTN.AutoRoundBorders = false;
            AdjustItemBTN.AutoSizeLeftIcon = true;
            AdjustItemBTN.AutoSizeRightIcon = true;
            AdjustItemBTN.BackColor = Color.Transparent;
            AdjustItemBTN.BackColor1 = Color.FromArgb(78, 160, 21);
            AdjustItemBTN.BackgroundImage = (Image)resources.GetObject("AdjustItemBTN.BackgroundImage");
            AdjustItemBTN.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AdjustItemBTN.ButtonText = "Adjust New Item";
            AdjustItemBTN.ButtonTextMarginLeft = 0;
            AdjustItemBTN.ColorContrastOnClick = 45;
            AdjustItemBTN.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            AdjustItemBTN.CustomizableEdges = borderEdges1;
            AdjustItemBTN.DialogResult = DialogResult.None;
            AdjustItemBTN.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            AdjustItemBTN.DisabledFillColor = Color.FromArgb(204, 204, 204);
            AdjustItemBTN.DisabledForecolor = Color.FromArgb(168, 160, 168);
            AdjustItemBTN.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            AdjustItemBTN.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdjustItemBTN.ForeColor = Color.White;
            AdjustItemBTN.IconLeftAlign = ContentAlignment.MiddleLeft;
            AdjustItemBTN.IconLeftCursor = Cursors.Default;
            AdjustItemBTN.IconLeftPadding = new Padding(11, 3, 3, 3);
            AdjustItemBTN.IconMarginLeft = 11;
            AdjustItemBTN.IconPadding = 10;
            AdjustItemBTN.IconRightAlign = ContentAlignment.MiddleRight;
            AdjustItemBTN.IconRightCursor = Cursors.Default;
            AdjustItemBTN.IconRightPadding = new Padding(3, 3, 7, 3);
            AdjustItemBTN.IconSize = 25;
            AdjustItemBTN.IdleBorderColor = Color.FromArgb(78, 160, 21);
            AdjustItemBTN.IdleBorderRadius = 1;
            AdjustItemBTN.IdleBorderThickness = 1;
            AdjustItemBTN.IdleFillColor = Color.FromArgb(78, 160, 21);
            AdjustItemBTN.IdleIconLeftImage = Properties.Resources.plus__1_;
            AdjustItemBTN.IdleIconRightImage = null;
            AdjustItemBTN.IndicateFocus = false;
            AdjustItemBTN.Location = new Point(11, 13);
            AdjustItemBTN.Name = "AdjustItemBTN";
            AdjustItemBTN.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            AdjustItemBTN.OnDisabledState.BorderRadius = 1;
            AdjustItemBTN.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AdjustItemBTN.OnDisabledState.BorderThickness = 1;
            AdjustItemBTN.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            AdjustItemBTN.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            AdjustItemBTN.OnDisabledState.IconLeftImage = null;
            AdjustItemBTN.OnDisabledState.IconRightImage = null;
            AdjustItemBTN.onHoverState.BorderColor = Color.FromArgb(50, 110, 5);
            AdjustItemBTN.onHoverState.BorderRadius = 1;
            AdjustItemBTN.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AdjustItemBTN.onHoverState.BorderThickness = 1;
            AdjustItemBTN.onHoverState.FillColor = Color.FromArgb(50, 110, 5);
            AdjustItemBTN.onHoverState.ForeColor = Color.White;
            AdjustItemBTN.onHoverState.IconLeftImage = Properties.Resources.plus__1_;
            AdjustItemBTN.onHoverState.IconRightImage = null;
            AdjustItemBTN.OnIdleState.BorderColor = Color.FromArgb(78, 160, 21);
            AdjustItemBTN.OnIdleState.BorderRadius = 1;
            AdjustItemBTN.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AdjustItemBTN.OnIdleState.BorderThickness = 1;
            AdjustItemBTN.OnIdleState.FillColor = Color.FromArgb(78, 160, 21);
            AdjustItemBTN.OnIdleState.ForeColor = Color.White;
            AdjustItemBTN.OnIdleState.IconLeftImage = Properties.Resources.plus__1_;
            AdjustItemBTN.OnIdleState.IconRightImage = null;
            AdjustItemBTN.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            AdjustItemBTN.OnPressedState.BorderRadius = 1;
            AdjustItemBTN.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AdjustItemBTN.OnPressedState.BorderThickness = 1;
            AdjustItemBTN.OnPressedState.FillColor = Color.FromArgb(192, 64, 0);
            AdjustItemBTN.OnPressedState.ForeColor = Color.White;
            AdjustItemBTN.OnPressedState.IconLeftImage = null;
            AdjustItemBTN.OnPressedState.IconRightImage = null;
            AdjustItemBTN.Size = new Size(161, 40);
            AdjustItemBTN.TabIndex = 11;
            AdjustItemBTN.TextAlign = ContentAlignment.MiddleLeft;
            AdjustItemBTN.TextAlignment = HorizontalAlignment.Center;
            AdjustItemBTN.TextMarginLeft = 0;
            AdjustItemBTN.TextPadding = new Padding(35, 0, 0, 0);
            AdjustItemBTN.UseDefaultRadiusAndThickness = true;
            AdjustItemBTN.Click += AdjustItemBTN_Click;
            // 
            // AllAdjustmentItemsDatagrid
            // 
            AllAdjustmentItemsDatagrid.AllowCustomTheming = false;
            AllAdjustmentItemsDatagrid.AllowUserToAddRows = false;
            AllAdjustmentItemsDatagrid.AllowUserToDeleteRows = false;
            AllAdjustmentItemsDatagrid.AllowUserToResizeColumns = false;
            AllAdjustmentItemsDatagrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(223, 191, 191);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            AllAdjustmentItemsDatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AllAdjustmentItemsDatagrid.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AllAdjustmentItemsDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllAdjustmentItemsDatagrid.BackgroundColor = Color.White;
            AllAdjustmentItemsDatagrid.BorderStyle = BorderStyle.None;
            AllAdjustmentItemsDatagrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            AllAdjustmentItemsDatagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 0, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AllAdjustmentItemsDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AllAdjustmentItemsDatagrid.ColumnHeadersHeight = 40;
            AllAdjustmentItemsDatagrid.Columns.AddRange(new DataGridViewColumn[] { IdCol, ReferenceNoCol, OperatedDateCol, AdjustedByCol });
            AllAdjustmentItemsDatagrid.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(223, 191, 191);
            AllAdjustmentItemsDatagrid.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            AllAdjustmentItemsDatagrid.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            AllAdjustmentItemsDatagrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(178, 102, 102);
            AllAdjustmentItemsDatagrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.White;
            AllAdjustmentItemsDatagrid.CurrentTheme.BackColor = Color.Maroon;
            AllAdjustmentItemsDatagrid.CurrentTheme.GridColor = Color.FromArgb(216, 178, 178);
            AllAdjustmentItemsDatagrid.CurrentTheme.HeaderStyle.BackColor = Color.Maroon;
            AllAdjustmentItemsDatagrid.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            AllAdjustmentItemsDatagrid.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            AllAdjustmentItemsDatagrid.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(102, 0, 0);
            AllAdjustmentItemsDatagrid.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            AllAdjustmentItemsDatagrid.CurrentTheme.Name = null;
            AllAdjustmentItemsDatagrid.CurrentTheme.RowsStyle.BackColor = Color.FromArgb(229, 204, 204);
            AllAdjustmentItemsDatagrid.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            AllAdjustmentItemsDatagrid.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            AllAdjustmentItemsDatagrid.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(178, 102, 102);
            AllAdjustmentItemsDatagrid.CurrentTheme.RowsStyle.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(229, 204, 204);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(178, 102, 102);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AllAdjustmentItemsDatagrid.DefaultCellStyle = dataGridViewCellStyle3;
            AllAdjustmentItemsDatagrid.EnableHeadersVisualStyles = false;
            AllAdjustmentItemsDatagrid.GridColor = Color.FromArgb(216, 178, 178);
            AllAdjustmentItemsDatagrid.HeaderBackColor = Color.Maroon;
            AllAdjustmentItemsDatagrid.HeaderBgColor = Color.Empty;
            AllAdjustmentItemsDatagrid.HeaderForeColor = Color.White;
            AllAdjustmentItemsDatagrid.Location = new Point(10, 68);
            AllAdjustmentItemsDatagrid.Name = "AllAdjustmentItemsDatagrid";
            AllAdjustmentItemsDatagrid.ReadOnly = true;
            AllAdjustmentItemsDatagrid.RowHeadersVisible = false;
            AllAdjustmentItemsDatagrid.RowTemplate.Height = 40;
            AllAdjustmentItemsDatagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllAdjustmentItemsDatagrid.Size = new Size(878, 464);
            AllAdjustmentItemsDatagrid.TabIndex = 10;
            AllAdjustmentItemsDatagrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Maroon;
            AllAdjustmentItemsDatagrid.CellDoubleClick += AllAdjustmentItemsDatagrid_CellDoubleClick;
            AllAdjustmentItemsDatagrid.EditingControlShowing += AllAdjustmentItemsDatagrid_EditingControlShowing;
            // 
            // IdCol
            // 
            IdCol.HeaderText = "PurchaseId";
            IdCol.Name = "IdCol";
            IdCol.ReadOnly = true;
            IdCol.Visible = false;
            // 
            // ReferenceNoCol
            // 
            ReferenceNoCol.FillWeight = 40F;
            ReferenceNoCol.HeaderText = "Reference No";
            ReferenceNoCol.Name = "ReferenceNoCol";
            ReferenceNoCol.ReadOnly = true;
            // 
            // OperatedDateCol
            // 
            OperatedDateCol.FillWeight = 35F;
            OperatedDateCol.HeaderText = "Date";
            OperatedDateCol.Name = "OperatedDateCol";
            OperatedDateCol.ReadOnly = true;
            // 
            // AdjustedByCol
            // 
            AdjustedByCol.FillWeight = 25F;
            AdjustedByCol.HeaderText = "Adjusted By";
            AdjustedByCol.Name = "AdjustedByCol";
            AdjustedByCol.ReadOnly = true;
            // 
            // Pagination
            // 
            Pagination.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Pagination.Controls.Add(PaginationLabel);
            Pagination.Controls.Add(PaginationPREV);
            Pagination.Controls.Add(PaginationNext);
            Pagination.Location = new Point(11, 548);
            Pagination.Name = "Pagination";
            Pagination.Size = new Size(145, 50);
            Pagination.TabIndex = 14;
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
            // 
            // panel4
            // 
            panel4.BackColor = Color.Maroon;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(10, 45);
            panel4.Name = "panel4";
            panel4.Size = new Size(880, 5);
            panel4.TabIndex = 2;
            // 
            // ItemAdjustment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 662);
            Controls.Add(MainContainer);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ItemAdjustment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ItemAdjustment";
            Load += ItemAdjustment_Load;
            TopPanel.ResumeLayout(false);
            MainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AllAdjustmentItemsDatagrid).EndInit();
            Pagination.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Label label1;
        private Panel MainContainer;
        private Bunifu.UI.WinForms.BunifuTextBox SearchBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 AdjustItemBTN;
        private Bunifu.UI.WinForms.BunifuDataGridView AllAdjustmentItemsDatagrid;
        private Panel Pagination;
        private Label PaginationLabel;
        private Bunifu.UI.WinForms.BunifuImageButton PaginationPREV;
        private Bunifu.UI.WinForms.BunifuImageButton PaginationNext;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn ReferenceNoCol;
        private DataGridViewTextBoxColumn OperatedDateCol;
        private DataGridViewTextBoxColumn AdjustedByCol;
        private Panel panel4;
    }
}