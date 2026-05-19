namespace DazaBestApplication.Pages
{
    partial class InventoryRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryRecord));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
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
            panel2 = new Panel();
            Pagination = new Panel();
            PaginationLabel = new Label();
            PaginationPREV = new Bunifu.UI.WinForms.BunifuImageButton();
            PaginationNext = new Bunifu.UI.WinForms.BunifuImageButton();
            panel1 = new Panel();
            PrintBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            SearchBox = new Bunifu.UI.WinForms.BunifuTextBox();
            panel3 = new Panel();
            AllItemDatagrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            ItemNameCol = new DataGridViewTextBoxColumn();
            ItemCodeCol = new DataGridViewTextBoxColumn();
            DateCol = new DataGridViewTextBoxColumn();
            UnitCol = new DataGridViewTextBoxColumn();
            StockCol = new DataGridViewTextBoxColumn();
            ItemPriceCol = new DataGridViewTextBoxColumn();
            TopPanel.SuspendLayout();
            panel2.SuspendLayout();
            Pagination.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AllItemDatagrid).BeginInit();
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
            // panel4
            // 
            panel4.BackColor = Color.Maroon;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(10, 45);
            panel4.Name = "panel4";
            panel4.Size = new Size(880, 5);
            panel4.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Courier New", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 0);
            label1.Name = "label1";
            label1.Size = new Size(602, 50);
            label1.TabIndex = 0;
            label1.Text = "Inventory Status Record";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(Pagination);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 612);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10, 0, 10, 0);
            panel2.Size = new Size(900, 50);
            panel2.TabIndex = 6;
            // 
            // Pagination
            // 
            Pagination.Controls.Add(PaginationLabel);
            Pagination.Controls.Add(PaginationPREV);
            Pagination.Controls.Add(PaginationNext);
            Pagination.Dock = DockStyle.Left;
            Pagination.Location = new Point(10, 0);
            Pagination.Name = "Pagination";
            Pagination.Size = new Size(196, 50);
            Pagination.TabIndex = 10;
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
            // panel1
            // 
            panel1.Controls.Add(PrintBtn);
            panel1.Controls.Add(SearchBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 0, 10, 0);
            panel1.Size = new Size(900, 61);
            panel1.TabIndex = 7;
            // 
            // PrintBtn
            // 
            PrintBtn.AllowAnimations = true;
            PrintBtn.AllowMouseEffects = true;
            PrintBtn.AllowToggling = false;
            PrintBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PrintBtn.AnimationSpeed = 200;
            PrintBtn.AutoGenerateColors = false;
            PrintBtn.AutoRoundBorders = false;
            PrintBtn.AutoSizeLeftIcon = true;
            PrintBtn.AutoSizeRightIcon = true;
            PrintBtn.BackColor = Color.Transparent;
            PrintBtn.BackColor1 = Color.FromArgb(220, 220, 221);
            PrintBtn.BackgroundImage = (Image)resources.GetObject("PrintBtn.BackgroundImage");
            PrintBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            PrintBtn.ButtonText = "Print";
            PrintBtn.ButtonTextMarginLeft = 0;
            PrintBtn.ColorContrastOnClick = 45;
            PrintBtn.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            PrintBtn.CustomizableEdges = borderEdges1;
            PrintBtn.DialogResult = DialogResult.None;
            PrintBtn.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            PrintBtn.DisabledFillColor = Color.FromArgb(204, 204, 204);
            PrintBtn.DisabledForecolor = Color.FromArgb(168, 160, 168);
            PrintBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            PrintBtn.Font = new Font("Courier New", 12F, FontStyle.Bold);
            PrintBtn.ForeColor = Color.Black;
            PrintBtn.IconLeftAlign = ContentAlignment.MiddleLeft;
            PrintBtn.IconLeftCursor = Cursors.Default;
            PrintBtn.IconLeftPadding = new Padding(11, 3, 3, 3);
            PrintBtn.IconMarginLeft = 11;
            PrintBtn.IconPadding = 10;
            PrintBtn.IconRightAlign = ContentAlignment.MiddleRight;
            PrintBtn.IconRightCursor = Cursors.Default;
            PrintBtn.IconRightPadding = new Padding(3, 3, 7, 3);
            PrintBtn.IconSize = 25;
            PrintBtn.IdleBorderColor = Color.FromArgb(220, 220, 221);
            PrintBtn.IdleBorderRadius = 1;
            PrintBtn.IdleBorderThickness = 1;
            PrintBtn.IdleFillColor = Color.FromArgb(220, 220, 221);
            PrintBtn.IdleIconLeftImage = Properties.Resources.printer__1_;
            PrintBtn.IdleIconRightImage = null;
            PrintBtn.IndicateFocus = false;
            PrintBtn.Location = new Point(512, 11);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            PrintBtn.OnDisabledState.BorderRadius = 1;
            PrintBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            PrintBtn.OnDisabledState.BorderThickness = 1;
            PrintBtn.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            PrintBtn.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            PrintBtn.OnDisabledState.IconLeftImage = null;
            PrintBtn.OnDisabledState.IconRightImage = null;
            PrintBtn.onHoverState.BorderColor = Color.Black;
            PrintBtn.onHoverState.BorderRadius = 1;
            PrintBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            PrintBtn.onHoverState.BorderThickness = 1;
            PrintBtn.onHoverState.FillColor = Color.FromArgb(205, 205, 207);
            PrintBtn.onHoverState.ForeColor = Color.Black;
            PrintBtn.onHoverState.IconLeftImage = null;
            PrintBtn.onHoverState.IconRightImage = null;
            PrintBtn.OnIdleState.BorderColor = Color.FromArgb(220, 220, 221);
            PrintBtn.OnIdleState.BorderRadius = 1;
            PrintBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            PrintBtn.OnIdleState.BorderThickness = 1;
            PrintBtn.OnIdleState.FillColor = Color.FromArgb(220, 220, 221);
            PrintBtn.OnIdleState.ForeColor = Color.Black;
            PrintBtn.OnIdleState.IconLeftImage = Properties.Resources.printer__1_;
            PrintBtn.OnIdleState.IconRightImage = null;
            PrintBtn.OnPressedState.BorderColor = Color.FromArgb(161, 205, 220);
            PrintBtn.OnPressedState.BorderRadius = 1;
            PrintBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            PrintBtn.OnPressedState.BorderThickness = 1;
            PrintBtn.OnPressedState.FillColor = Color.FromArgb(161, 205, 220);
            PrintBtn.OnPressedState.ForeColor = Color.Black;
            PrintBtn.OnPressedState.IconLeftImage = null;
            PrintBtn.OnPressedState.IconRightImage = null;
            PrintBtn.Size = new Size(102, 40);
            PrintBtn.TabIndex = 19;
            PrintBtn.TextAlign = ContentAlignment.MiddleLeft;
            PrintBtn.TextAlignment = HorizontalAlignment.Center;
            PrintBtn.TextMarginLeft = 0;
            PrintBtn.TextPadding = new Padding(35, 0, 0, 0);
            PrintBtn.UseDefaultRadiusAndThickness = true;
            PrintBtn.Click += PrintBtn_Click;
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
            SearchBox.Location = new Point(620, 12);
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
            SearchBox.PlaceholderText = "Search by Item Name or Code\r\n";
            SearchBox.ReadOnly = false;
            SearchBox.ScrollBars = ScrollBars.None;
            SearchBox.SelectedText = "";
            SearchBox.SelectionLength = 0;
            SearchBox.SelectionStart = 0;
            SearchBox.ShortcutsEnabled = true;
            SearchBox.Size = new Size(270, 39);
            SearchBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            SearchBox.TabIndex = 17;
            SearchBox.TextAlign = HorizontalAlignment.Left;
            SearchBox.TextMarginBottom = 0;
            SearchBox.TextMarginLeft = 3;
            SearchBox.TextMarginTop = 1;
            SearchBox.TextPlaceholder = "Search by Item Name or Code\r\n";
            SearchBox.UseSystemPasswordChar = false;
            SearchBox.WordWrap = true;
            SearchBox.TextChange += SearchBox_TextChange;
            // 
            // panel3
            // 
            panel3.Controls.Add(AllItemDatagrid);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 111);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(35, 10, 35, 10);
            panel3.Size = new Size(900, 501);
            panel3.TabIndex = 8;
            // 
            // AllItemDatagrid
            // 
            AllItemDatagrid.AllowCustomTheming = false;
            AllItemDatagrid.AllowUserToAddRows = false;
            AllItemDatagrid.AllowUserToDeleteRows = false;
            AllItemDatagrid.AllowUserToResizeColumns = false;
            AllItemDatagrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(223, 191, 191);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            AllItemDatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AllItemDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllItemDatagrid.BackgroundColor = Color.White;
            AllItemDatagrid.BorderStyle = BorderStyle.None;
            AllItemDatagrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            AllItemDatagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 0, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AllItemDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AllItemDatagrid.ColumnHeadersHeight = 40;
            AllItemDatagrid.Columns.AddRange(new DataGridViewColumn[] { IdCol, ItemNameCol, ItemCodeCol, DateCol, UnitCol, StockCol, ItemPriceCol });
            AllItemDatagrid.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(223, 191, 191);
            AllItemDatagrid.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            AllItemDatagrid.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            AllItemDatagrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(178, 102, 102);
            AllItemDatagrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.White;
            AllItemDatagrid.CurrentTheme.BackColor = Color.Maroon;
            AllItemDatagrid.CurrentTheme.GridColor = Color.FromArgb(216, 178, 178);
            AllItemDatagrid.CurrentTheme.HeaderStyle.BackColor = Color.Maroon;
            AllItemDatagrid.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            AllItemDatagrid.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            AllItemDatagrid.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(102, 0, 0);
            AllItemDatagrid.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            AllItemDatagrid.CurrentTheme.Name = null;
            AllItemDatagrid.CurrentTheme.RowsStyle.BackColor = Color.FromArgb(229, 204, 204);
            AllItemDatagrid.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            AllItemDatagrid.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            AllItemDatagrid.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(178, 102, 102);
            AllItemDatagrid.CurrentTheme.RowsStyle.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(229, 204, 204);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(178, 102, 102);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AllItemDatagrid.DefaultCellStyle = dataGridViewCellStyle3;
            AllItemDatagrid.Dock = DockStyle.Fill;
            AllItemDatagrid.EnableHeadersVisualStyles = false;
            AllItemDatagrid.GridColor = Color.FromArgb(216, 178, 178);
            AllItemDatagrid.HeaderBackColor = Color.Maroon;
            AllItemDatagrid.HeaderBgColor = Color.Empty;
            AllItemDatagrid.HeaderForeColor = Color.White;
            AllItemDatagrid.Location = new Point(35, 10);
            AllItemDatagrid.Name = "AllItemDatagrid";
            AllItemDatagrid.ReadOnly = true;
            AllItemDatagrid.RowHeadersVisible = false;
            AllItemDatagrid.RowTemplate.DefaultCellStyle.Font = new Font("Cambria", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllItemDatagrid.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            AllItemDatagrid.RowTemplate.Height = 40;
            AllItemDatagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllItemDatagrid.Size = new Size(830, 481);
            AllItemDatagrid.TabIndex = 2;
            AllItemDatagrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Maroon;
            // 
            // IdCol
            // 
            IdCol.HeaderText = "Id";
            IdCol.Name = "IdCol";
            IdCol.ReadOnly = true;
            IdCol.Visible = false;
            // 
            // ItemNameCol
            // 
            ItemNameCol.HeaderText = "Item";
            ItemNameCol.Name = "ItemNameCol";
            ItemNameCol.ReadOnly = true;
            // 
            // ItemCodeCol
            // 
            ItemCodeCol.HeaderText = "ItemCode";
            ItemCodeCol.Name = "ItemCodeCol";
            ItemCodeCol.ReadOnly = true;
            // 
            // DateCol
            // 
            DateCol.HeaderText = "Date";
            DateCol.Name = "DateCol";
            DateCol.ReadOnly = true;
            DateCol.Visible = false;
            // 
            // UnitCol
            // 
            UnitCol.HeaderText = "Unit";
            UnitCol.Name = "UnitCol";
            UnitCol.ReadOnly = true;
            // 
            // StockCol
            // 
            StockCol.HeaderText = "Stocks";
            StockCol.Name = "StockCol";
            StockCol.ReadOnly = true;
            // 
            // ItemPriceCol
            // 
            ItemPriceCol.HeaderText = "Price";
            ItemPriceCol.Name = "ItemPriceCol";
            ItemPriceCol.ReadOnly = true;
            // 
            // InventoryRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 662);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InventoryRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InventoryRecord";
            Load += InventoryRecord_Load;
            TopPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            Pagination.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AllItemDatagrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Panel panel4;
        private Label label1;
        private Panel panel2;
        private Panel Pagination;
        private Label PaginationLabel;
        private Bunifu.UI.WinForms.BunifuImageButton PaginationPREV;
        private Bunifu.UI.WinForms.BunifuImageButton PaginationNext;
        private Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 PrintBtn;
        private Bunifu.UI.WinForms.BunifuTextBox SearchBox;
        private Panel panel3;
        private Bunifu.UI.WinForms.BunifuDataGridView AllItemDatagrid;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn ItemNameCol;
        private DataGridViewTextBoxColumn ItemCodeCol;
        private DataGridViewTextBoxColumn DateCol;
        private DataGridViewTextBoxColumn UnitCol;
        private DataGridViewTextBoxColumn StockCol;
        private DataGridViewTextBoxColumn ItemPriceCol;
    }
}