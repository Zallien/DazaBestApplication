namespace DazaBestApplication.Pages
{
    partial class SalesRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesRecord));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            TopPanel = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            RecordFilter = new Bunifu.UI.WinForms.BunifuDropdown();
            PrintBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            SearchBox = new Bunifu.UI.WinForms.BunifuTextBox();
            bunifuButton22 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            fromdatetxt = new Bunifu.UI.WinForms.BunifuDatePicker();
            todatetxt = new Bunifu.UI.WinForms.BunifuDatePicker();
            bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            panel2 = new Panel();
            Pagination = new Panel();
            PaginationLabel = new Label();
            PaginationPREV = new Bunifu.UI.WinForms.BunifuImageButton();
            PaginationNext = new Bunifu.UI.WinForms.BunifuImageButton();
            panel3 = new Panel();
            daterangepanel = new Bunifu.UI.WinForms.BunifuShadowPanel();
            panel6 = new Panel();
            bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            label2 = new Label();
            AllsaleDatagrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            PurchaseNumberCol = new DataGridViewTextBoxColumn();
            ProductNameCol = new DataGridViewTextBoxColumn();
            DateCol = new DataGridViewTextBoxColumn();
            CashierCol = new DataGridViewTextBoxColumn();
            TopPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            Pagination.SuspendLayout();
            panel3.SuspendLayout();
            daterangepanel.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AllsaleDatagrid).BeginInit();
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
            TopPanel.TabIndex = 2;
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
            label1.Size = new Size(372, 50);
            label1.TabIndex = 0;
            label1.Text = "Sales Record";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(PrintBtn);
            panel1.Controls.Add(SearchBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 0, 10, 0);
            panel1.Size = new Size(900, 76);
            panel1.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(bunifuButton2);
            panel5.Controls.Add(RecordFilter);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(10, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(500, 76);
            panel5.TabIndex = 9;
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
            bunifuButton2.ButtonText = "Change Date";
            bunifuButton2.ButtonTextMarginLeft = 0;
            bunifuButton2.ColorContrastOnClick = 45;
            bunifuButton2.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            bunifuButton2.CustomizableEdges = borderEdges1;
            bunifuButton2.DialogResult = DialogResult.None;
            bunifuButton2.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton2.DisabledFillColor = Color.Empty;
            bunifuButton2.DisabledForecolor = Color.Empty;
            bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            bunifuButton2.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            bunifuButton2.Location = new Point(358, 28);
            bunifuButton2.Name = "bunifuButton2";
            bunifuButton2.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton2.OnDisabledState.BorderRadius = 1;
            bunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton2.OnDisabledState.BorderThickness = 1;
            bunifuButton2.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            bunifuButton2.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunifuButton2.OnDisabledState.IconLeftImage = null;
            bunifuButton2.OnDisabledState.IconRightImage = null;
            bunifuButton2.onHoverState.BorderColor = Color.Maroon;
            bunifuButton2.onHoverState.BorderRadius = 1;
            bunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton2.onHoverState.BorderThickness = 1;
            bunifuButton2.onHoverState.FillColor = Color.Transparent;
            bunifuButton2.onHoverState.ForeColor = Color.Maroon;
            bunifuButton2.onHoverState.IconLeftImage = null;
            bunifuButton2.onHoverState.IconRightImage = null;
            bunifuButton2.OnIdleState.BorderColor = Color.Maroon;
            bunifuButton2.OnIdleState.BorderRadius = 1;
            bunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton2.OnIdleState.BorderThickness = 1;
            bunifuButton2.OnIdleState.FillColor = Color.Transparent;
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
            bunifuButton2.Size = new Size(103, 31);
            bunifuButton2.TabIndex = 1;
            bunifuButton2.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton2.TextAlignment = HorizontalAlignment.Center;
            bunifuButton2.TextMarginLeft = 0;
            bunifuButton2.TextPadding = new Padding(0);
            bunifuButton2.UseDefaultRadiusAndThickness = true;
            bunifuButton2.Click += bunifuButton2_Click;
            // 
            // RecordFilter
            // 
            RecordFilter.BackColor = Color.Transparent;
            RecordFilter.BackgroundColor = Color.White;
            RecordFilter.BorderColor = Color.Silver;
            RecordFilter.BorderRadius = 1;
            RecordFilter.Color = Color.Silver;
            RecordFilter.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            RecordFilter.DisabledBackColor = Color.FromArgb(240, 240, 240);
            RecordFilter.DisabledBorderColor = Color.FromArgb(204, 204, 204);
            RecordFilter.DisabledColor = Color.FromArgb(240, 240, 240);
            RecordFilter.DisabledForeColor = Color.FromArgb(109, 109, 109);
            RecordFilter.DisabledIndicatorColor = Color.DarkGray;
            RecordFilter.DrawMode = DrawMode.OwnerDrawFixed;
            RecordFilter.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            RecordFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            RecordFilter.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            RecordFilter.FillDropDown = true;
            RecordFilter.FillIndicator = false;
            RecordFilter.FlatStyle = FlatStyle.Flat;
            RecordFilter.Font = new Font("Segoe UI", 9F);
            RecordFilter.ForeColor = Color.Black;
            RecordFilter.FormattingEnabled = true;
            RecordFilter.Icon = null;
            RecordFilter.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            RecordFilter.IndicatorColor = Color.DarkGray;
            RecordFilter.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            RecordFilter.IndicatorThickness = 2;
            RecordFilter.IsDropdownOpened = false;
            RecordFilter.ItemBackColor = Color.White;
            RecordFilter.ItemBorderColor = Color.White;
            RecordFilter.ItemForeColor = Color.Black;
            RecordFilter.ItemHeight = 26;
            RecordFilter.ItemHighLightColor = Color.DodgerBlue;
            RecordFilter.ItemHighLightForeColor = Color.White;
            RecordFilter.ItemTopMargin = 3;
            RecordFilter.Location = new Point(25, 27);
            RecordFilter.Name = "RecordFilter";
            RecordFilter.Size = new Size(327, 32);
            RecordFilter.TabIndex = 0;
            RecordFilter.Text = null;
            RecordFilter.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            RecordFilter.TextLeftMargin = 5;
            RecordFilter.SelectedValueChanged += RecordFilter_SelectedValueChanged;
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            PrintBtn.CustomizableEdges = borderEdges2;
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
            PrintBtn.Location = new Point(512, 27);
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
            PrintBtn.TabIndex = 7;
            PrintBtn.TextAlign = ContentAlignment.MiddleLeft;
            PrintBtn.TextAlignment = HorizontalAlignment.Center;
            PrintBtn.TextMarginLeft = 0;
            PrintBtn.TextPadding = new Padding(35, 0, 0, 0);
            PrintBtn.UseDefaultRadiusAndThickness = true;
            PrintBtn.Click += bunifuButton22_Click;
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
            SearchBox.Location = new Point(620, 28);
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
            SearchBox.PlaceholderText = "Search by Trans No";
            SearchBox.ReadOnly = false;
            SearchBox.ScrollBars = ScrollBars.None;
            SearchBox.SelectedText = "";
            SearchBox.SelectionLength = 0;
            SearchBox.SelectionStart = 0;
            SearchBox.ShortcutsEnabled = true;
            SearchBox.Size = new Size(280, 39);
            SearchBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            SearchBox.TabIndex = 6;
            SearchBox.TextAlign = HorizontalAlignment.Left;
            SearchBox.TextMarginBottom = 0;
            SearchBox.TextMarginLeft = 3;
            SearchBox.TextMarginTop = 1;
            SearchBox.TextPlaceholder = "Search by Trans No";
            SearchBox.UseSystemPasswordChar = false;
            SearchBox.WordWrap = true;
            SearchBox.TextChange += SearchBox_TextChange;
            // 
            // bunifuButton22
            // 
            bunifuButton22.AllowAnimations = true;
            bunifuButton22.AllowMouseEffects = true;
            bunifuButton22.AllowToggling = false;
            bunifuButton22.AnimationSpeed = 200;
            bunifuButton22.AutoGenerateColors = false;
            bunifuButton22.AutoRoundBorders = false;
            bunifuButton22.AutoSizeLeftIcon = true;
            bunifuButton22.AutoSizeRightIcon = true;
            bunifuButton22.BackColor = Color.Transparent;
            bunifuButton22.BackColor1 = Color.FromArgb(220, 220, 221);
            bunifuButton22.BackgroundImage = (Image)resources.GetObject("bunifuButton22.BackgroundImage");
            bunifuButton22.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton22.ButtonText = "Reset";
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
            bunifuButton22.ForeColor = Color.Black;
            bunifuButton22.IconLeftAlign = ContentAlignment.MiddleLeft;
            bunifuButton22.IconLeftCursor = Cursors.Default;
            bunifuButton22.IconLeftPadding = new Padding(11, 3, 3, 3);
            bunifuButton22.IconMarginLeft = 11;
            bunifuButton22.IconPadding = 10;
            bunifuButton22.IconRightAlign = ContentAlignment.MiddleRight;
            bunifuButton22.IconRightCursor = Cursors.Default;
            bunifuButton22.IconRightPadding = new Padding(3, 3, 7, 3);
            bunifuButton22.IconSize = 25;
            bunifuButton22.IdleBorderColor = Color.FromArgb(220, 220, 221);
            bunifuButton22.IdleBorderRadius = 1;
            bunifuButton22.IdleBorderThickness = 1;
            bunifuButton22.IdleFillColor = Color.FromArgb(220, 220, 221);
            bunifuButton22.IdleIconLeftImage = Properties.Resources.gear;
            bunifuButton22.IdleIconRightImage = null;
            bunifuButton22.IndicateFocus = false;
            bunifuButton22.Location = new Point(306, 36);
            bunifuButton22.Name = "bunifuButton22";
            bunifuButton22.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton22.OnDisabledState.BorderRadius = 1;
            bunifuButton22.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton22.OnDisabledState.BorderThickness = 1;
            bunifuButton22.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            bunifuButton22.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunifuButton22.OnDisabledState.IconLeftImage = null;
            bunifuButton22.OnDisabledState.IconRightImage = null;
            bunifuButton22.onHoverState.BorderColor = Color.Black;
            bunifuButton22.onHoverState.BorderRadius = 1;
            bunifuButton22.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton22.onHoverState.BorderThickness = 1;
            bunifuButton22.onHoverState.FillColor = Color.FromArgb(205, 205, 207);
            bunifuButton22.onHoverState.ForeColor = Color.Black;
            bunifuButton22.onHoverState.IconLeftImage = null;
            bunifuButton22.onHoverState.IconRightImage = null;
            bunifuButton22.OnIdleState.BorderColor = Color.FromArgb(220, 220, 221);
            bunifuButton22.OnIdleState.BorderRadius = 1;
            bunifuButton22.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton22.OnIdleState.BorderThickness = 1;
            bunifuButton22.OnIdleState.FillColor = Color.FromArgb(220, 220, 221);
            bunifuButton22.OnIdleState.ForeColor = Color.Black;
            bunifuButton22.OnIdleState.IconLeftImage = Properties.Resources.gear;
            bunifuButton22.OnIdleState.IconRightImage = null;
            bunifuButton22.OnPressedState.BorderColor = Color.FromArgb(161, 205, 220);
            bunifuButton22.OnPressedState.BorderRadius = 1;
            bunifuButton22.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton22.OnPressedState.BorderThickness = 1;
            bunifuButton22.OnPressedState.FillColor = Color.FromArgb(161, 205, 220);
            bunifuButton22.OnPressedState.ForeColor = Color.Black;
            bunifuButton22.OnPressedState.IconLeftImage = null;
            bunifuButton22.OnPressedState.IconRightImage = null;
            bunifuButton22.Size = new Size(99, 32);
            bunifuButton22.TabIndex = 8;
            bunifuButton22.TextAlign = ContentAlignment.MiddleLeft;
            bunifuButton22.TextAlignment = HorizontalAlignment.Center;
            bunifuButton22.TextMarginLeft = 0;
            bunifuButton22.TextPadding = new Padding(35, 0, 0, 0);
            bunifuButton22.UseDefaultRadiusAndThickness = true;
            bunifuButton22.Click += bunifuButton22_Click_1;
            // 
            // fromdatetxt
            // 
            fromdatetxt.BackColor = Color.White;
            fromdatetxt.BorderColor = Color.Black;
            fromdatetxt.BorderRadius = 1;
            fromdatetxt.Color = Color.Black;
            fromdatetxt.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            fromdatetxt.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            fromdatetxt.DisabledColor = Color.Gray;
            fromdatetxt.DisplayWeekNumbers = false;
            fromdatetxt.DPHeight = 0;
            fromdatetxt.DropDownAlign = LeftRightAlignment.Right;
            fromdatetxt.FillDatePicker = false;
            fromdatetxt.Font = new Font("Courier New", 9.75F, FontStyle.Bold);
            fromdatetxt.ForeColor = Color.Black;
            fromdatetxt.Format = DateTimePickerFormat.Custom;
            fromdatetxt.Icon = (Image)resources.GetObject("fromdatetxt.Icon");
            fromdatetxt.IconColor = Color.Gray;
            fromdatetxt.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            fromdatetxt.LeftTextMargin = 5;
            fromdatetxt.Location = new Point(22, 36);
            fromdatetxt.MaxDate = new DateTime(2025, 10, 25, 0, 0, 0, 0);
            fromdatetxt.MinimumSize = new Size(0, 32);
            fromdatetxt.Name = "fromdatetxt";
            fromdatetxt.Size = new Size(130, 32);
            fromdatetxt.TabIndex = 1;
            fromdatetxt.Value = new DateTime(2025, 10, 25, 0, 0, 0, 0);
            fromdatetxt.ValueChanged += todatetxt_ValueChanged;
            // 
            // todatetxt
            // 
            todatetxt.BackColor = Color.White;
            todatetxt.BorderColor = Color.Black;
            todatetxt.BorderRadius = 1;
            todatetxt.CalendarFont = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            todatetxt.Color = Color.Black;
            todatetxt.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            todatetxt.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            todatetxt.DisabledColor = Color.Gray;
            todatetxt.DisplayWeekNumbers = false;
            todatetxt.DPHeight = 0;
            todatetxt.DropDownAlign = LeftRightAlignment.Right;
            todatetxt.FillDatePicker = false;
            todatetxt.Font = new Font("Courier New", 9.75F, FontStyle.Bold);
            todatetxt.ForeColor = Color.Black;
            todatetxt.Format = DateTimePickerFormat.Custom;
            todatetxt.Icon = (Image)resources.GetObject("todatetxt.Icon");
            todatetxt.IconColor = Color.Gray;
            todatetxt.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            todatetxt.LeftTextMargin = 5;
            todatetxt.Location = new Point(170, 36);
            todatetxt.MinimumSize = new Size(0, 32);
            todatetxt.Name = "todatetxt";
            todatetxt.Size = new Size(130, 32);
            todatetxt.TabIndex = 2;
            todatetxt.ValueChanged += fromdatetxt_ValueChanged;
            // 
            // bunifuLabel2
            // 
            bunifuLabel2.AllowParentOverrides = false;
            bunifuLabel2.AutoEllipsis = false;
            bunifuLabel2.CursorType = Cursors.Default;
            bunifuLabel2.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuLabel2.Location = new Point(155, 39);
            bunifuLabel2.Name = "bunifuLabel2";
            bunifuLabel2.RightToLeft = RightToLeft.No;
            bunifuLabel2.Size = new Size(7, 24);
            bunifuLabel2.TabIndex = 3;
            bunifuLabel2.Text = "-";
            bunifuLabel2.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel2
            // 
            panel2.Controls.Add(Pagination);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 612);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10, 0, 10, 0);
            panel2.Size = new Size(900, 50);
            panel2.TabIndex = 4;
            // 
            // Pagination
            // 
            Pagination.Controls.Add(PaginationLabel);
            Pagination.Controls.Add(PaginationPREV);
            Pagination.Controls.Add(PaginationNext);
            Pagination.Dock = DockStyle.Left;
            Pagination.Location = new Point(10, 0);
            Pagination.Name = "Pagination";
            Pagination.Size = new Size(210, 50);
            Pagination.TabIndex = 10;
            // 
            // PaginationLabel
            // 
            PaginationLabel.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaginationLabel.Location = new Point(52, 7);
            PaginationLabel.Name = "PaginationLabel";
            PaginationLabel.Size = new Size(98, 40);
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
            PaginationNext.Location = new Point(156, 7);
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
            // panel3
            // 
            panel3.Controls.Add(daterangepanel);
            panel3.Controls.Add(AllsaleDatagrid);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 126);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(35, 10, 35, 10);
            panel3.Size = new Size(900, 486);
            panel3.TabIndex = 5;
            // 
            // daterangepanel
            // 
            daterangepanel.BackColor = Color.Transparent;
            daterangepanel.BorderColor = Color.WhiteSmoke;
            daterangepanel.BorderRadius = 1;
            daterangepanel.BorderThickness = 1;
            daterangepanel.Controls.Add(bunifuButton22);
            daterangepanel.Controls.Add(panel6);
            daterangepanel.Controls.Add(todatetxt);
            daterangepanel.Controls.Add(fromdatetxt);
            daterangepanel.Controls.Add(bunifuLabel2);
            daterangepanel.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            daterangepanel.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            daterangepanel.Location = new Point(210, 40);
            daterangepanel.Name = "daterangepanel";
            daterangepanel.PanelColor = Color.WhiteSmoke;
            daterangepanel.PanelColor2 = Color.WhiteSmoke;
            daterangepanel.ShadowColor = Color.DarkGray;
            daterangepanel.ShadowDept = 2;
            daterangepanel.ShadowDepth = 5;
            daterangepanel.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            daterangepanel.ShadowTopLeftVisible = false;
            daterangepanel.Size = new Size(421, 86);
            daterangepanel.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            daterangepanel.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Maroon;
            panel6.Controls.Add(bunifuImageButton1);
            panel6.Controls.Add(label2);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(10, 0, 5, 0);
            panel6.Size = new Size(421, 30);
            panel6.TabIndex = 2;
            // 
            // bunifuImageButton1
            // 
            bunifuImageButton1.ActiveImage = null;
            bunifuImageButton1.AllowAnimations = true;
            bunifuImageButton1.AllowBuffering = false;
            bunifuImageButton1.AllowToggling = false;
            bunifuImageButton1.AllowZooming = true;
            bunifuImageButton1.AllowZoomingOnFocus = false;
            bunifuImageButton1.BackColor = Color.Transparent;
            bunifuImageButton1.DialogResult = DialogResult.None;
            bunifuImageButton1.Dock = DockStyle.Right;
            bunifuImageButton1.ErrorImage = (Image)resources.GetObject("bunifuImageButton1.ErrorImage");
            bunifuImageButton1.FadeWhenInactive = false;
            bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            bunifuImageButton1.Image = Properties.Resources.close;
            bunifuImageButton1.ImageActive = null;
            bunifuImageButton1.ImageLocation = null;
            bunifuImageButton1.ImageMargin = 8;
            bunifuImageButton1.ImageSize = new Size(22, 22);
            bunifuImageButton1.ImageZoomSize = new Size(30, 30);
            bunifuImageButton1.InitialImage = (Image)resources.GetObject("bunifuImageButton1.InitialImage");
            bunifuImageButton1.Location = new Point(386, 0);
            bunifuImageButton1.Name = "bunifuImageButton1";
            bunifuImageButton1.Rotation = 0;
            bunifuImageButton1.ShowActiveImage = true;
            bunifuImageButton1.ShowCursorChanges = true;
            bunifuImageButton1.ShowImageBorders = true;
            bunifuImageButton1.ShowSizeMarkers = false;
            bunifuImageButton1.Size = new Size(30, 30);
            bunifuImageButton1.TabIndex = 3;
            bunifuImageButton1.ToolTipText = "";
            bunifuImageButton1.WaitOnLoad = false;
            bunifuImageButton1.Zoom = 8;
            bunifuImageButton1.ZoomSpeed = 10;
            bunifuImageButton1.Click += bunifuImageButton1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Maroon;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 0);
            label2.Name = "label2";
            label2.Size = new Size(367, 30);
            label2.TabIndex = 1;
            label2.Text = "Date Range";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AllsaleDatagrid
            // 
            AllsaleDatagrid.AllowCustomTheming = false;
            AllsaleDatagrid.AllowUserToAddRows = false;
            AllsaleDatagrid.AllowUserToDeleteRows = false;
            AllsaleDatagrid.AllowUserToResizeColumns = false;
            AllsaleDatagrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(223, 191, 191);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            AllsaleDatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AllsaleDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllsaleDatagrid.BackgroundColor = Color.White;
            AllsaleDatagrid.BorderStyle = BorderStyle.None;
            AllsaleDatagrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            AllsaleDatagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 0, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AllsaleDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AllsaleDatagrid.ColumnHeadersHeight = 40;
            AllsaleDatagrid.Columns.AddRange(new DataGridViewColumn[] { IdCol, PurchaseNumberCol, ProductNameCol, DateCol, CashierCol });
            AllsaleDatagrid.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(223, 191, 191);
            AllsaleDatagrid.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            AllsaleDatagrid.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            AllsaleDatagrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(178, 102, 102);
            AllsaleDatagrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.White;
            AllsaleDatagrid.CurrentTheme.BackColor = Color.Maroon;
            AllsaleDatagrid.CurrentTheme.GridColor = Color.FromArgb(216, 178, 178);
            AllsaleDatagrid.CurrentTheme.HeaderStyle.BackColor = Color.Maroon;
            AllsaleDatagrid.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            AllsaleDatagrid.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            AllsaleDatagrid.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(102, 0, 0);
            AllsaleDatagrid.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            AllsaleDatagrid.CurrentTheme.Name = null;
            AllsaleDatagrid.CurrentTheme.RowsStyle.BackColor = Color.FromArgb(229, 204, 204);
            AllsaleDatagrid.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            AllsaleDatagrid.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            AllsaleDatagrid.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(178, 102, 102);
            AllsaleDatagrid.CurrentTheme.RowsStyle.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(229, 204, 204);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(178, 102, 102);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AllsaleDatagrid.DefaultCellStyle = dataGridViewCellStyle3;
            AllsaleDatagrid.Dock = DockStyle.Fill;
            AllsaleDatagrid.EnableHeadersVisualStyles = false;
            AllsaleDatagrid.GridColor = Color.FromArgb(216, 178, 178);
            AllsaleDatagrid.HeaderBackColor = Color.Maroon;
            AllsaleDatagrid.HeaderBgColor = Color.Empty;
            AllsaleDatagrid.HeaderForeColor = Color.White;
            AllsaleDatagrid.Location = new Point(35, 10);
            AllsaleDatagrid.Name = "AllsaleDatagrid";
            AllsaleDatagrid.ReadOnly = true;
            AllsaleDatagrid.RowHeadersVisible = false;
            AllsaleDatagrid.RowTemplate.DefaultCellStyle.Font = new Font("Cambria", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllsaleDatagrid.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            AllsaleDatagrid.RowTemplate.Height = 40;
            AllsaleDatagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllsaleDatagrid.Size = new Size(830, 466);
            AllsaleDatagrid.TabIndex = 2;
            AllsaleDatagrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Maroon;
            AllsaleDatagrid.CellContentClick += AllsaleDatagrid_CellContentClick;
            // 
            // IdCol
            // 
            IdCol.HeaderText = "DetailsId";
            IdCol.Name = "IdCol";
            IdCol.ReadOnly = true;
            IdCol.Visible = false;
            // 
            // PurchaseNumberCol
            // 
            PurchaseNumberCol.HeaderText = "PurchaseNumber";
            PurchaseNumberCol.Name = "PurchaseNumberCol";
            PurchaseNumberCol.ReadOnly = true;
            // 
            // ProductNameCol
            // 
            ProductNameCol.HeaderText = "Product";
            ProductNameCol.Name = "ProductNameCol";
            ProductNameCol.ReadOnly = true;
            // 
            // DateCol
            // 
            DateCol.HeaderText = "Date";
            DateCol.Name = "DateCol";
            DateCol.ReadOnly = true;
            // 
            // CashierCol
            // 
            CashierCol.HeaderText = "Cashier";
            CashierCol.Name = "CashierCol";
            CashierCol.ReadOnly = true;
            // 
            // SalesRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 662);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SalesRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalesRecord";
            Load += SalesRecord_Load;
            TopPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            Pagination.ResumeLayout(false);
            panel3.ResumeLayout(false);
            daterangepanel.ResumeLayout(false);
            daterangepanel.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AllsaleDatagrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel Pagination;
        private Label PaginationLabel;
        private Bunifu.UI.WinForms.BunifuImageButton PaginationPREV;
        private Bunifu.UI.WinForms.BunifuImageButton PaginationNext;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuDatePicker todatetxt;
        private Bunifu.UI.WinForms.BunifuDatePicker fromdatetxt;
        private Bunifu.UI.WinForms.BunifuDataGridView AllsaleDatagrid;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 PrintBtn;
        private Bunifu.UI.WinForms.BunifuTextBox SearchBox;
        private Panel panel4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton22;
        private Panel panel5;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn PurchaseNumberCol;
        private DataGridViewTextBoxColumn ProductNameCol;
        private DataGridViewTextBoxColumn DateCol;
        private DataGridViewTextBoxColumn CashierCol;
        private Bunifu.UI.WinForms.BunifuShadowPanel daterangepanel;
        private Panel panel6;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Label label2;
        private Bunifu.UI.WinForms.BunifuDropdown RecordFilter;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
    }
}