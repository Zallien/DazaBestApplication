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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            TopPanel = new Panel();
            label1 = new Label();
            MainContainer = new Panel();
            PurchaseReportBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            SearchBox = new Bunifu.UI.WinForms.BunifuTextBox();
            AdjustItemBTN = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            AllPurchaseDatagridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            ReferenceNoCol = new DataGridViewTextBoxColumn();
            PurchaseDateCol = new DataGridViewTextBoxColumn();
            AdjustedByCol = new DataGridViewTextBoxColumn();
            Pagination = new Panel();
            PaginationLabel = new Label();
            PaginationPREV = new Bunifu.UI.WinForms.BunifuImageButton();
            PaginationNext = new Bunifu.UI.WinForms.BunifuImageButton();
            TopPanel.SuspendLayout();
            MainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AllPurchaseDatagridView).BeginInit();
            Pagination.SuspendLayout();
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
            TopPanel.TabIndex = 4;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
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
            MainContainer.Controls.Add(PurchaseReportBtn);
            MainContainer.Controls.Add(SearchBox);
            MainContainer.Controls.Add(AdjustItemBTN);
            MainContainer.Controls.Add(AllPurchaseDatagridView);
            MainContainer.Controls.Add(Pagination);
            MainContainer.Dock = DockStyle.Fill;
            MainContainer.Location = new Point(0, 50);
            MainContainer.Name = "MainContainer";
            MainContainer.Padding = new Padding(0, 10, 0, 0);
            MainContainer.Size = new Size(900, 612);
            MainContainer.TabIndex = 5;
            // 
            // PurchaseReportBtn
            // 
            PurchaseReportBtn.AllowAnimations = true;
            PurchaseReportBtn.AllowMouseEffects = true;
            PurchaseReportBtn.AllowToggling = false;
            PurchaseReportBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PurchaseReportBtn.AnimationSpeed = 200;
            PurchaseReportBtn.AutoGenerateColors = false;
            PurchaseReportBtn.AutoRoundBorders = false;
            PurchaseReportBtn.AutoSizeLeftIcon = true;
            PurchaseReportBtn.AutoSizeRightIcon = true;
            PurchaseReportBtn.BackColor = Color.Transparent;
            PurchaseReportBtn.BackColor1 = Color.FromArgb(220, 220, 221);
            PurchaseReportBtn.BackgroundImage = (Image)resources.GetObject("PurchaseReportBtn.BackgroundImage");
            PurchaseReportBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            PurchaseReportBtn.ButtonText = "Print";
            PurchaseReportBtn.ButtonTextMarginLeft = 0;
            PurchaseReportBtn.ColorContrastOnClick = 45;
            PurchaseReportBtn.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            PurchaseReportBtn.CustomizableEdges = borderEdges1;
            PurchaseReportBtn.DialogResult = DialogResult.None;
            PurchaseReportBtn.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            PurchaseReportBtn.DisabledFillColor = Color.FromArgb(204, 204, 204);
            PurchaseReportBtn.DisabledForecolor = Color.FromArgb(168, 160, 168);
            PurchaseReportBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            PurchaseReportBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PurchaseReportBtn.ForeColor = Color.Black;
            PurchaseReportBtn.IconLeftAlign = ContentAlignment.MiddleLeft;
            PurchaseReportBtn.IconLeftCursor = Cursors.Default;
            PurchaseReportBtn.IconLeftPadding = new Padding(11, 3, 3, 3);
            PurchaseReportBtn.IconMarginLeft = 11;
            PurchaseReportBtn.IconPadding = 10;
            PurchaseReportBtn.IconRightAlign = ContentAlignment.MiddleRight;
            PurchaseReportBtn.IconRightCursor = Cursors.Default;
            PurchaseReportBtn.IconRightPadding = new Padding(3, 3, 7, 3);
            PurchaseReportBtn.IconSize = 25;
            PurchaseReportBtn.IdleBorderColor = Color.FromArgb(220, 220, 221);
            PurchaseReportBtn.IdleBorderRadius = 1;
            PurchaseReportBtn.IdleBorderThickness = 1;
            PurchaseReportBtn.IdleFillColor = Color.FromArgb(220, 220, 221);
            PurchaseReportBtn.IdleIconLeftImage = Properties.Resources.printer__1_;
            PurchaseReportBtn.IdleIconRightImage = null;
            PurchaseReportBtn.IndicateFocus = false;
            PurchaseReportBtn.Location = new Point(452, 14);
            PurchaseReportBtn.Name = "PurchaseReportBtn";
            PurchaseReportBtn.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            PurchaseReportBtn.OnDisabledState.BorderRadius = 1;
            PurchaseReportBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            PurchaseReportBtn.OnDisabledState.BorderThickness = 1;
            PurchaseReportBtn.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            PurchaseReportBtn.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            PurchaseReportBtn.OnDisabledState.IconLeftImage = null;
            PurchaseReportBtn.OnDisabledState.IconRightImage = null;
            PurchaseReportBtn.onHoverState.BorderColor = Color.Black;
            PurchaseReportBtn.onHoverState.BorderRadius = 1;
            PurchaseReportBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            PurchaseReportBtn.onHoverState.BorderThickness = 1;
            PurchaseReportBtn.onHoverState.FillColor = Color.FromArgb(205, 205, 207);
            PurchaseReportBtn.onHoverState.ForeColor = Color.Black;
            PurchaseReportBtn.onHoverState.IconLeftImage = null;
            PurchaseReportBtn.onHoverState.IconRightImage = null;
            PurchaseReportBtn.OnIdleState.BorderColor = Color.FromArgb(220, 220, 221);
            PurchaseReportBtn.OnIdleState.BorderRadius = 1;
            PurchaseReportBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            PurchaseReportBtn.OnIdleState.BorderThickness = 1;
            PurchaseReportBtn.OnIdleState.FillColor = Color.FromArgb(220, 220, 221);
            PurchaseReportBtn.OnIdleState.ForeColor = Color.Black;
            PurchaseReportBtn.OnIdleState.IconLeftImage = Properties.Resources.printer__1_;
            PurchaseReportBtn.OnIdleState.IconRightImage = null;
            PurchaseReportBtn.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            PurchaseReportBtn.OnPressedState.BorderRadius = 1;
            PurchaseReportBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            PurchaseReportBtn.OnPressedState.BorderThickness = 1;
            PurchaseReportBtn.OnPressedState.FillColor = Color.FromArgb(192, 64, 0);
            PurchaseReportBtn.OnPressedState.ForeColor = Color.White;
            PurchaseReportBtn.OnPressedState.IconLeftImage = null;
            PurchaseReportBtn.OnPressedState.IconRightImage = null;
            PurchaseReportBtn.Size = new Size(150, 40);
            PurchaseReportBtn.TabIndex = 13;
            PurchaseReportBtn.TextAlign = ContentAlignment.MiddleLeft;
            PurchaseReportBtn.TextAlignment = HorizontalAlignment.Center;
            PurchaseReportBtn.TextMarginLeft = 0;
            PurchaseReportBtn.TextPadding = new Padding(35, 0, 0, 0);
            PurchaseReportBtn.UseDefaultRadiusAndThickness = true;
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
            SearchBox.Location = new Point(608, 14);
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
            SearchBox.Size = new Size(280, 39);
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            AdjustItemBTN.CustomizableEdges = borderEdges2;
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
            // AllPurchaseDatagridView
            // 
            AllPurchaseDatagridView.AllowCustomTheming = false;
            AllPurchaseDatagridView.AllowUserToAddRows = false;
            AllPurchaseDatagridView.AllowUserToDeleteRows = false;
            AllPurchaseDatagridView.AllowUserToResizeColumns = false;
            AllPurchaseDatagridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(223, 191, 191);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            AllPurchaseDatagridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AllPurchaseDatagridView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AllPurchaseDatagridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllPurchaseDatagridView.BackgroundColor = Color.White;
            AllPurchaseDatagridView.BorderStyle = BorderStyle.None;
            AllPurchaseDatagridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            AllPurchaseDatagridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 0, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AllPurchaseDatagridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AllPurchaseDatagridView.ColumnHeadersHeight = 40;
            AllPurchaseDatagridView.Columns.AddRange(new DataGridViewColumn[] { IdCol, ReferenceNoCol, PurchaseDateCol, AdjustedByCol });
            AllPurchaseDatagridView.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(223, 191, 191);
            AllPurchaseDatagridView.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            AllPurchaseDatagridView.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            AllPurchaseDatagridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(178, 102, 102);
            AllPurchaseDatagridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.White;
            AllPurchaseDatagridView.CurrentTheme.BackColor = Color.Maroon;
            AllPurchaseDatagridView.CurrentTheme.GridColor = Color.FromArgb(216, 178, 178);
            AllPurchaseDatagridView.CurrentTheme.HeaderStyle.BackColor = Color.Maroon;
            AllPurchaseDatagridView.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            AllPurchaseDatagridView.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            AllPurchaseDatagridView.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(102, 0, 0);
            AllPurchaseDatagridView.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            AllPurchaseDatagridView.CurrentTheme.Name = null;
            AllPurchaseDatagridView.CurrentTheme.RowsStyle.BackColor = Color.FromArgb(229, 204, 204);
            AllPurchaseDatagridView.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            AllPurchaseDatagridView.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            AllPurchaseDatagridView.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(178, 102, 102);
            AllPurchaseDatagridView.CurrentTheme.RowsStyle.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(229, 204, 204);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(178, 102, 102);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AllPurchaseDatagridView.DefaultCellStyle = dataGridViewCellStyle3;
            AllPurchaseDatagridView.EnableHeadersVisualStyles = false;
            AllPurchaseDatagridView.GridColor = Color.FromArgb(216, 178, 178);
            AllPurchaseDatagridView.HeaderBackColor = Color.Maroon;
            AllPurchaseDatagridView.HeaderBgColor = Color.Empty;
            AllPurchaseDatagridView.HeaderForeColor = Color.White;
            AllPurchaseDatagridView.Location = new Point(10, 68);
            AllPurchaseDatagridView.Name = "AllPurchaseDatagridView";
            AllPurchaseDatagridView.ReadOnly = true;
            AllPurchaseDatagridView.RowHeadersVisible = false;
            AllPurchaseDatagridView.RowTemplate.Height = 40;
            AllPurchaseDatagridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllPurchaseDatagridView.Size = new Size(878, 464);
            AllPurchaseDatagridView.TabIndex = 10;
            AllPurchaseDatagridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Maroon;
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
            // PurchaseDateCol
            // 
            PurchaseDateCol.FillWeight = 35F;
            PurchaseDateCol.HeaderText = "Date";
            PurchaseDateCol.Name = "PurchaseDateCol";
            PurchaseDateCol.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)AllPurchaseDatagridView).EndInit();
            Pagination.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Label label1;
        private Panel MainContainer;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 PurchaseReportBtn;
        private Bunifu.UI.WinForms.BunifuTextBox SearchBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 AdjustItemBTN;
        private Bunifu.UI.WinForms.BunifuDataGridView AllPurchaseDatagridView;
        private Panel Pagination;
        private Label PaginationLabel;
        private Bunifu.UI.WinForms.BunifuImageButton PaginationPREV;
        private Bunifu.UI.WinForms.BunifuImageButton PaginationNext;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn ReferenceNoCol;
        private DataGridViewTextBoxColumn PurchaseDateCol;
        private DataGridViewTextBoxColumn AdjustedByCol;
    }
}