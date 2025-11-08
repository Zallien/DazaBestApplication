namespace DazaBestApplication.Pages
{
    partial class StockRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockRecord));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
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
            panel5 = new Panel();
            bunifuButton21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            bunifuDatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            bunifuDatePicker2 = new Bunifu.UI.WinForms.BunifuDatePicker();
            bunifuButton22 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            PrintBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            SearchBox = new Bunifu.UI.WinForms.BunifuTextBox();
            panel3 = new Panel();
            AllPurchaseItemDetailsRecordsDatagrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            PurchaseItemNumberCol = new DataGridViewTextBoxColumn();
            DateCol = new DataGridViewTextBoxColumn();
            ItemCol = new DataGridViewTextBoxColumn();
            QuantityCol = new DataGridViewTextBoxColumn();
            TotalCol = new DataGridViewTextBoxColumn();
            TopPanel.SuspendLayout();
            panel2.SuspendLayout();
            Pagination.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AllPurchaseItemDetailsRecordsDatagrid).BeginInit();
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
            label1.Size = new Size(474, 50);
            label1.TabIndex = 0;
            label1.Text = "Stock-In Record";
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
            Pagination.Size = new Size(145, 50);
            Pagination.TabIndex = 10;
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
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(bunifuButton22);
            panel1.Controls.Add(PrintBtn);
            panel1.Controls.Add(SearchBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 0, 10, 0);
            panel1.Size = new Size(900, 79);
            panel1.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.Controls.Add(bunifuButton21);
            panel5.Controls.Add(bunifuLabel1);
            panel5.Controls.Add(bunifuLabel2);
            panel5.Controls.Add(bunifuDatePicker1);
            panel5.Controls.Add(bunifuDatePicker2);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(10, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(461, 79);
            panel5.TabIndex = 19;
            // 
            // bunifuButton21
            // 
            bunifuButton21.AllowAnimations = true;
            bunifuButton21.AllowMouseEffects = true;
            bunifuButton21.AllowToggling = false;
            bunifuButton21.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bunifuButton21.AnimationSpeed = 200;
            bunifuButton21.AutoGenerateColors = false;
            bunifuButton21.AutoRoundBorders = false;
            bunifuButton21.AutoSizeLeftIcon = true;
            bunifuButton21.AutoSizeRightIcon = true;
            bunifuButton21.BackColor = Color.Transparent;
            bunifuButton21.BackColor1 = Color.FromArgb(220, 220, 221);
            bunifuButton21.BackgroundImage = (Image)resources.GetObject("bunifuButton21.BackgroundImage");
            bunifuButton21.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton21.ButtonText = "Reset";
            bunifuButton21.ButtonTextMarginLeft = 0;
            bunifuButton21.ColorContrastOnClick = 45;
            bunifuButton21.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            bunifuButton21.CustomizableEdges = borderEdges1;
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
            bunifuButton21.IdleIconLeftImage = Properties.Resources.gear;
            bunifuButton21.IdleIconRightImage = null;
            bunifuButton21.IndicateFocus = false;
            bunifuButton21.Location = new Point(317, 30);
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
            bunifuButton21.OnIdleState.IconLeftImage = Properties.Resources.gear;
            bunifuButton21.OnIdleState.IconRightImage = null;
            bunifuButton21.OnPressedState.BorderColor = Color.FromArgb(161, 205, 220);
            bunifuButton21.OnPressedState.BorderRadius = 1;
            bunifuButton21.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton21.OnPressedState.BorderThickness = 1;
            bunifuButton21.OnPressedState.FillColor = Color.FromArgb(161, 205, 220);
            bunifuButton21.OnPressedState.ForeColor = Color.Black;
            bunifuButton21.OnPressedState.IconLeftImage = null;
            bunifuButton21.OnPressedState.IconRightImage = null;
            bunifuButton21.Size = new Size(99, 32);
            bunifuButton21.TabIndex = 18;
            bunifuButton21.TextAlign = ContentAlignment.MiddleLeft;
            bunifuButton21.TextAlignment = HorizontalAlignment.Center;
            bunifuButton21.TextMarginLeft = 0;
            bunifuButton21.TextPadding = new Padding(35, 0, 0, 0);
            bunifuButton21.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuLabel1
            // 
            bunifuLabel1.AllowParentOverrides = false;
            bunifuLabel1.AutoEllipsis = false;
            bunifuLabel1.CursorType = Cursors.Default;
            bunifuLabel1.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuLabel1.Location = new Point(7, 5);
            bunifuLabel1.Name = "bunifuLabel1";
            bunifuLabel1.RightToLeft = RightToLeft.No;
            bunifuLabel1.Size = new Size(110, 18);
            bunifuLabel1.TabIndex = 14;
            bunifuLabel1.Text = "Date Range:";
            bunifuLabel1.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            bunifuLabel2.AllowParentOverrides = false;
            bunifuLabel2.AutoEllipsis = false;
            bunifuLabel2.CursorType = Cursors.Default;
            bunifuLabel2.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuLabel2.Location = new Point(165, 33);
            bunifuLabel2.Name = "bunifuLabel2";
            bunifuLabel2.RightToLeft = RightToLeft.No;
            bunifuLabel2.Size = new Size(7, 24);
            bunifuLabel2.TabIndex = 17;
            bunifuLabel2.Text = "-";
            bunifuLabel2.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuDatePicker1
            // 
            bunifuDatePicker1.BackColor = Color.White;
            bunifuDatePicker1.BorderColor = Color.Black;
            bunifuDatePicker1.BorderRadius = 1;
            bunifuDatePicker1.Color = Color.Black;
            bunifuDatePicker1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            bunifuDatePicker1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            bunifuDatePicker1.DisabledColor = Color.Gray;
            bunifuDatePicker1.DisplayWeekNumbers = false;
            bunifuDatePicker1.DPHeight = 0;
            bunifuDatePicker1.DropDownAlign = LeftRightAlignment.Right;
            bunifuDatePicker1.FillDatePicker = false;
            bunifuDatePicker1.Font = new Font("Courier New", 9.75F, FontStyle.Bold);
            bunifuDatePicker1.ForeColor = Color.Black;
            bunifuDatePicker1.Format = DateTimePickerFormat.Custom;
            bunifuDatePicker1.Icon = (Image)resources.GetObject("bunifuDatePicker1.Icon");
            bunifuDatePicker1.IconColor = Color.Gray;
            bunifuDatePicker1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            bunifuDatePicker1.LeftTextMargin = 5;
            bunifuDatePicker1.Location = new Point(30, 30);
            bunifuDatePicker1.MaxDate = new DateTime(2025, 10, 25, 0, 0, 0, 0);
            bunifuDatePicker1.MinimumSize = new Size(0, 32);
            bunifuDatePicker1.Name = "bunifuDatePicker1";
            bunifuDatePicker1.Size = new Size(130, 32);
            bunifuDatePicker1.TabIndex = 15;
            bunifuDatePicker1.Value = new DateTime(2025, 10, 25, 0, 0, 0, 0);
            // 
            // bunifuDatePicker2
            // 
            bunifuDatePicker2.BackColor = Color.White;
            bunifuDatePicker2.BorderColor = Color.Black;
            bunifuDatePicker2.BorderRadius = 1;
            bunifuDatePicker2.CalendarFont = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuDatePicker2.Color = Color.Black;
            bunifuDatePicker2.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            bunifuDatePicker2.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            bunifuDatePicker2.DisabledColor = Color.Gray;
            bunifuDatePicker2.DisplayWeekNumbers = false;
            bunifuDatePicker2.DPHeight = 0;
            bunifuDatePicker2.DropDownAlign = LeftRightAlignment.Right;
            bunifuDatePicker2.FillDatePicker = false;
            bunifuDatePicker2.Font = new Font("Courier New", 9.75F, FontStyle.Bold);
            bunifuDatePicker2.ForeColor = Color.Black;
            bunifuDatePicker2.Format = DateTimePickerFormat.Custom;
            bunifuDatePicker2.Icon = (Image)resources.GetObject("bunifuDatePicker2.Icon");
            bunifuDatePicker2.IconColor = Color.Gray;
            bunifuDatePicker2.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            bunifuDatePicker2.LeftTextMargin = 5;
            bunifuDatePicker2.Location = new Point(178, 30);
            bunifuDatePicker2.MinimumSize = new Size(0, 32);
            bunifuDatePicker2.Name = "bunifuDatePicker2";
            bunifuDatePicker2.Size = new Size(130, 32);
            bunifuDatePicker2.TabIndex = 16;
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
            bunifuButton22.BackColor1 = Color.FromArgb(220, 220, 221);
            bunifuButton22.BackgroundImage = (Image)resources.GetObject("bunifuButton22.BackgroundImage");
            bunifuButton22.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton22.ButtonText = "Reset";
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
            bunifuButton22.Location = new Point(1011, 9);
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
            bunifuButton22.TabIndex = 13;
            bunifuButton22.TextAlign = ContentAlignment.MiddleLeft;
            bunifuButton22.TextAlignment = HorizontalAlignment.Center;
            bunifuButton22.TextMarginLeft = 0;
            bunifuButton22.TextPadding = new Padding(35, 0, 0, 0);
            bunifuButton22.UseDefaultRadiusAndThickness = true;
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            PrintBtn.CustomizableEdges = borderEdges3;
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
            PrintBtn.Location = new Point(487, 28);
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
            PrintBtn.Size = new Size(102, 33);
            PrintBtn.TabIndex = 13;
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
            SearchBox.Location = new Point(595, 28);
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
            SearchBox.Size = new Size(270, 32);
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
            // panel3
            // 
            panel3.Controls.Add(AllPurchaseItemDetailsRecordsDatagrid);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 129);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(35, 10, 35, 10);
            panel3.Size = new Size(900, 483);
            panel3.TabIndex = 8;
            // 
            // AllPurchaseItemDetailsRecordsDatagrid
            // 
            AllPurchaseItemDetailsRecordsDatagrid.AllowCustomTheming = false;
            AllPurchaseItemDetailsRecordsDatagrid.AllowUserToAddRows = false;
            AllPurchaseItemDetailsRecordsDatagrid.AllowUserToDeleteRows = false;
            AllPurchaseItemDetailsRecordsDatagrid.AllowUserToResizeColumns = false;
            AllPurchaseItemDetailsRecordsDatagrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(223, 191, 191);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            AllPurchaseItemDetailsRecordsDatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AllPurchaseItemDetailsRecordsDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllPurchaseItemDetailsRecordsDatagrid.BackgroundColor = Color.White;
            AllPurchaseItemDetailsRecordsDatagrid.BorderStyle = BorderStyle.None;
            AllPurchaseItemDetailsRecordsDatagrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            AllPurchaseItemDetailsRecordsDatagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 0, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AllPurchaseItemDetailsRecordsDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AllPurchaseItemDetailsRecordsDatagrid.ColumnHeadersHeight = 40;
            AllPurchaseItemDetailsRecordsDatagrid.Columns.AddRange(new DataGridViewColumn[] { IdCol, PurchaseItemNumberCol, DateCol, ItemCol, QuantityCol, TotalCol });
            AllPurchaseItemDetailsRecordsDatagrid.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(223, 191, 191);
            AllPurchaseItemDetailsRecordsDatagrid.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            AllPurchaseItemDetailsRecordsDatagrid.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            AllPurchaseItemDetailsRecordsDatagrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(178, 102, 102);
            AllPurchaseItemDetailsRecordsDatagrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.White;
            AllPurchaseItemDetailsRecordsDatagrid.CurrentTheme.BackColor = Color.Maroon;
            AllPurchaseItemDetailsRecordsDatagrid.CurrentTheme.GridColor = Color.FromArgb(216, 178, 178);
            AllPurchaseItemDetailsRecordsDatagrid.CurrentTheme.HeaderStyle.BackColor = Color.Maroon;
            AllPurchaseItemDetailsRecordsDatagrid.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            AllPurchaseItemDetailsRecordsDatagrid.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            AllPurchaseItemDetailsRecordsDatagrid.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(102, 0, 0);
            AllPurchaseItemDetailsRecordsDatagrid.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            AllPurchaseItemDetailsRecordsDatagrid.CurrentTheme.Name = null;
            AllPurchaseItemDetailsRecordsDatagrid.CurrentTheme.RowsStyle.BackColor = Color.FromArgb(229, 204, 204);
            AllPurchaseItemDetailsRecordsDatagrid.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            AllPurchaseItemDetailsRecordsDatagrid.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            AllPurchaseItemDetailsRecordsDatagrid.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(178, 102, 102);
            AllPurchaseItemDetailsRecordsDatagrid.CurrentTheme.RowsStyle.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(229, 204, 204);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(178, 102, 102);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AllPurchaseItemDetailsRecordsDatagrid.DefaultCellStyle = dataGridViewCellStyle3;
            AllPurchaseItemDetailsRecordsDatagrid.Dock = DockStyle.Fill;
            AllPurchaseItemDetailsRecordsDatagrid.EnableHeadersVisualStyles = false;
            AllPurchaseItemDetailsRecordsDatagrid.GridColor = Color.FromArgb(216, 178, 178);
            AllPurchaseItemDetailsRecordsDatagrid.HeaderBackColor = Color.Maroon;
            AllPurchaseItemDetailsRecordsDatagrid.HeaderBgColor = Color.Empty;
            AllPurchaseItemDetailsRecordsDatagrid.HeaderForeColor = Color.White;
            AllPurchaseItemDetailsRecordsDatagrid.Location = new Point(35, 10);
            AllPurchaseItemDetailsRecordsDatagrid.Name = "AllPurchaseItemDetailsRecordsDatagrid";
            AllPurchaseItemDetailsRecordsDatagrid.ReadOnly = true;
            AllPurchaseItemDetailsRecordsDatagrid.RowHeadersVisible = false;
            AllPurchaseItemDetailsRecordsDatagrid.RowTemplate.DefaultCellStyle.Font = new Font("Cambria", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllPurchaseItemDetailsRecordsDatagrid.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            AllPurchaseItemDetailsRecordsDatagrid.RowTemplate.Height = 40;
            AllPurchaseItemDetailsRecordsDatagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllPurchaseItemDetailsRecordsDatagrid.Size = new Size(830, 463);
            AllPurchaseItemDetailsRecordsDatagrid.TabIndex = 2;
            AllPurchaseItemDetailsRecordsDatagrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Maroon;
            // 
            // IdCol
            // 
            IdCol.HeaderText = "DetailsId";
            IdCol.Name = "IdCol";
            IdCol.ReadOnly = true;
            IdCol.Visible = false;
            // 
            // PurchaseItemNumberCol
            // 
            PurchaseItemNumberCol.HeaderText = "Purchase Number";
            PurchaseItemNumberCol.Name = "PurchaseItemNumberCol";
            PurchaseItemNumberCol.ReadOnly = true;
            // 
            // DateCol
            // 
            DateCol.HeaderText = "Date";
            DateCol.Name = "DateCol";
            DateCol.ReadOnly = true;
            // 
            // ItemCol
            // 
            ItemCol.HeaderText = "Item";
            ItemCol.Name = "ItemCol";
            ItemCol.ReadOnly = true;
            // 
            // QuantityCol
            // 
            QuantityCol.HeaderText = "Quantity";
            QuantityCol.Name = "QuantityCol";
            QuantityCol.ReadOnly = true;
            // 
            // TotalCol
            // 
            TotalCol.HeaderText = "Total";
            TotalCol.Name = "TotalCol";
            TotalCol.ReadOnly = true;
            // 
            // StockRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 662);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockRecord";
            Load += StockRecord_Load;
            TopPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            Pagination.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AllPurchaseItemDetailsRecordsDatagrid).EndInit();
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton22;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 PrintBtn;
        private Bunifu.UI.WinForms.BunifuTextBox SearchBox;
        private Panel panel3;
        private Bunifu.UI.WinForms.BunifuDataGridView AllPurchaseItemDetailsRecordsDatagrid;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton21;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker2;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Panel panel5;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn PurchaseItemNumberCol;
        private DataGridViewTextBoxColumn DateCol;
        private DataGridViewTextBoxColumn ItemCol;
        private DataGridViewTextBoxColumn QuantityCol;
        private DataGridViewTextBoxColumn TotalCol;
    }
}