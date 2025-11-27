namespace DazaBestApplication.Pages
{
    partial class BusinessFormPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessFormPage));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            TopPanel = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            MainContainer = new Panel();
            EditBTN = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            RemoveBTN = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            Pagination = new Panel();
            PaginationLabel = new Label();
            PaginationPREV = new Bunifu.UI.WinForms.BunifuImageButton();
            PaginationNext = new Bunifu.UI.WinForms.BunifuImageButton();
            AllBusinessDatagrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            BusinessNameCol = new DataGridViewTextBoxColumn();
            DateCreatedCol = new DataGridViewTextBoxColumn();
            AddBusinessBTN = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            Menustrip = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            TopPanel.SuspendLayout();
            MainContainer.SuspendLayout();
            Pagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AllBusinessDatagrid).BeginInit();
            Menustrip.SuspendLayout();
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
            TopPanel.Size = new Size(900, 50);
            TopPanel.TabIndex = 3;
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
            // label1
            // 
            label1.Font = new Font("Courier New", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 0);
            label1.Name = "label1";
            label1.Size = new Size(394, 50);
            label1.TabIndex = 0;
            label1.Text = "Business";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainContainer
            // 
            MainContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainContainer.Controls.Add(EditBTN);
            MainContainer.Controls.Add(RemoveBTN);
            MainContainer.Controls.Add(Pagination);
            MainContainer.Controls.Add(AllBusinessDatagrid);
            MainContainer.Controls.Add(AddBusinessBTN);
            MainContainer.Location = new Point(0, 56);
            MainContainer.Name = "MainContainer";
            MainContainer.Size = new Size(900, 494);
            MainContainer.TabIndex = 4;
            // 
            // EditBTN
            // 
            EditBTN.AllowAnimations = true;
            EditBTN.AllowMouseEffects = true;
            EditBTN.AllowToggling = false;
            EditBTN.AnimationSpeed = 200;
            EditBTN.AutoGenerateColors = false;
            EditBTN.AutoRoundBorders = false;
            EditBTN.AutoSizeLeftIcon = true;
            EditBTN.AutoSizeRightIcon = true;
            EditBTN.BackColor = Color.Transparent;
            EditBTN.BackColor1 = Color.FromArgb(220, 220, 221);
            EditBTN.BackgroundImage = (Image)resources.GetObject("EditBTN.BackgroundImage");
            EditBTN.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            EditBTN.ButtonText = "Edit";
            EditBTN.ButtonTextMarginLeft = 0;
            EditBTN.ColorContrastOnClick = 45;
            EditBTN.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            EditBTN.CustomizableEdges = borderEdges1;
            EditBTN.DialogResult = DialogResult.None;
            EditBTN.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            EditBTN.DisabledFillColor = Color.FromArgb(204, 204, 204);
            EditBTN.DisabledForecolor = Color.FromArgb(168, 160, 168);
            EditBTN.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            EditBTN.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditBTN.ForeColor = Color.Black;
            EditBTN.IconLeftAlign = ContentAlignment.MiddleLeft;
            EditBTN.IconLeftCursor = Cursors.Default;
            EditBTN.IconLeftPadding = new Padding(11, 3, 3, 3);
            EditBTN.IconMarginLeft = 11;
            EditBTN.IconPadding = 10;
            EditBTN.IconRightAlign = ContentAlignment.MiddleRight;
            EditBTN.IconRightCursor = Cursors.Default;
            EditBTN.IconRightPadding = new Padding(3, 3, 7, 3);
            EditBTN.IconSize = 25;
            EditBTN.IdleBorderColor = Color.FromArgb(220, 220, 221);
            EditBTN.IdleBorderRadius = 1;
            EditBTN.IdleBorderThickness = 1;
            EditBTN.IdleFillColor = Color.FromArgb(220, 220, 221);
            EditBTN.IdleIconLeftImage = Properties.Resources.trashcan;
            EditBTN.IdleIconRightImage = null;
            EditBTN.IndicateFocus = false;
            EditBTN.Location = new Point(296, 3);
            EditBTN.Name = "EditBTN";
            EditBTN.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            EditBTN.OnDisabledState.BorderRadius = 1;
            EditBTN.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            EditBTN.OnDisabledState.BorderThickness = 1;
            EditBTN.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            EditBTN.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            EditBTN.OnDisabledState.IconLeftImage = null;
            EditBTN.OnDisabledState.IconRightImage = null;
            EditBTN.onHoverState.BorderColor = Color.Black;
            EditBTN.onHoverState.BorderRadius = 1;
            EditBTN.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            EditBTN.onHoverState.BorderThickness = 1;
            EditBTN.onHoverState.FillColor = Color.FromArgb(205, 205, 207);
            EditBTN.onHoverState.ForeColor = Color.Black;
            EditBTN.onHoverState.IconLeftImage = null;
            EditBTN.onHoverState.IconRightImage = null;
            EditBTN.OnIdleState.BorderColor = Color.FromArgb(220, 220, 221);
            EditBTN.OnIdleState.BorderRadius = 1;
            EditBTN.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            EditBTN.OnIdleState.BorderThickness = 1;
            EditBTN.OnIdleState.FillColor = Color.FromArgb(220, 220, 221);
            EditBTN.OnIdleState.ForeColor = Color.Black;
            EditBTN.OnIdleState.IconLeftImage = Properties.Resources.trashcan;
            EditBTN.OnIdleState.IconRightImage = null;
            EditBTN.OnPressedState.BorderColor = Color.FromArgb(161, 205, 220);
            EditBTN.OnPressedState.BorderRadius = 1;
            EditBTN.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            EditBTN.OnPressedState.BorderThickness = 1;
            EditBTN.OnPressedState.FillColor = Color.FromArgb(161, 205, 220);
            EditBTN.OnPressedState.ForeColor = Color.Black;
            EditBTN.OnPressedState.IconLeftImage = null;
            EditBTN.OnPressedState.IconRightImage = null;
            EditBTN.Size = new Size(120, 32);
            EditBTN.TabIndex = 14;
            EditBTN.TextAlign = ContentAlignment.MiddleLeft;
            EditBTN.TextAlignment = HorizontalAlignment.Center;
            EditBTN.TextMarginLeft = 0;
            EditBTN.TextPadding = new Padding(35, 0, 0, 0);
            EditBTN.UseDefaultRadiusAndThickness = true;
            // 
            // RemoveBTN
            // 
            RemoveBTN.AllowAnimations = true;
            RemoveBTN.AllowMouseEffects = true;
            RemoveBTN.AllowToggling = false;
            RemoveBTN.AnimationSpeed = 200;
            RemoveBTN.AutoGenerateColors = false;
            RemoveBTN.AutoRoundBorders = false;
            RemoveBTN.AutoSizeLeftIcon = true;
            RemoveBTN.AutoSizeRightIcon = true;
            RemoveBTN.BackColor = Color.Transparent;
            RemoveBTN.BackColor1 = Color.FromArgb(220, 220, 221);
            RemoveBTN.BackgroundImage = (Image)resources.GetObject("RemoveBTN.BackgroundImage");
            RemoveBTN.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            RemoveBTN.ButtonText = "Remove";
            RemoveBTN.ButtonTextMarginLeft = 0;
            RemoveBTN.ColorContrastOnClick = 45;
            RemoveBTN.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            RemoveBTN.CustomizableEdges = borderEdges2;
            RemoveBTN.DialogResult = DialogResult.None;
            RemoveBTN.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            RemoveBTN.DisabledFillColor = Color.FromArgb(204, 204, 204);
            RemoveBTN.DisabledForecolor = Color.FromArgb(168, 160, 168);
            RemoveBTN.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            RemoveBTN.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RemoveBTN.ForeColor = Color.Black;
            RemoveBTN.IconLeftAlign = ContentAlignment.MiddleLeft;
            RemoveBTN.IconLeftCursor = Cursors.Default;
            RemoveBTN.IconLeftPadding = new Padding(11, 3, 3, 3);
            RemoveBTN.IconMarginLeft = 11;
            RemoveBTN.IconPadding = 10;
            RemoveBTN.IconRightAlign = ContentAlignment.MiddleRight;
            RemoveBTN.IconRightCursor = Cursors.Default;
            RemoveBTN.IconRightPadding = new Padding(3, 3, 7, 3);
            RemoveBTN.IconSize = 25;
            RemoveBTN.IdleBorderColor = Color.FromArgb(220, 220, 221);
            RemoveBTN.IdleBorderRadius = 1;
            RemoveBTN.IdleBorderThickness = 1;
            RemoveBTN.IdleFillColor = Color.FromArgb(220, 220, 221);
            RemoveBTN.IdleIconLeftImage = Properties.Resources.trashcan;
            RemoveBTN.IdleIconRightImage = null;
            RemoveBTN.IndicateFocus = false;
            RemoveBTN.Location = new Point(170, 3);
            RemoveBTN.Name = "RemoveBTN";
            RemoveBTN.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            RemoveBTN.OnDisabledState.BorderRadius = 1;
            RemoveBTN.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            RemoveBTN.OnDisabledState.BorderThickness = 1;
            RemoveBTN.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            RemoveBTN.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            RemoveBTN.OnDisabledState.IconLeftImage = null;
            RemoveBTN.OnDisabledState.IconRightImage = null;
            RemoveBTN.onHoverState.BorderColor = Color.Black;
            RemoveBTN.onHoverState.BorderRadius = 1;
            RemoveBTN.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            RemoveBTN.onHoverState.BorderThickness = 1;
            RemoveBTN.onHoverState.FillColor = Color.FromArgb(205, 205, 207);
            RemoveBTN.onHoverState.ForeColor = Color.Black;
            RemoveBTN.onHoverState.IconLeftImage = null;
            RemoveBTN.onHoverState.IconRightImage = null;
            RemoveBTN.OnIdleState.BorderColor = Color.FromArgb(220, 220, 221);
            RemoveBTN.OnIdleState.BorderRadius = 1;
            RemoveBTN.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            RemoveBTN.OnIdleState.BorderThickness = 1;
            RemoveBTN.OnIdleState.FillColor = Color.FromArgb(220, 220, 221);
            RemoveBTN.OnIdleState.ForeColor = Color.Black;
            RemoveBTN.OnIdleState.IconLeftImage = Properties.Resources.trashcan;
            RemoveBTN.OnIdleState.IconRightImage = null;
            RemoveBTN.OnPressedState.BorderColor = Color.FromArgb(161, 205, 220);
            RemoveBTN.OnPressedState.BorderRadius = 1;
            RemoveBTN.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            RemoveBTN.OnPressedState.BorderThickness = 1;
            RemoveBTN.OnPressedState.FillColor = Color.FromArgb(161, 205, 220);
            RemoveBTN.OnPressedState.ForeColor = Color.Black;
            RemoveBTN.OnPressedState.IconLeftImage = null;
            RemoveBTN.OnPressedState.IconRightImage = null;
            RemoveBTN.Size = new Size(120, 32);
            RemoveBTN.TabIndex = 13;
            RemoveBTN.TextAlign = ContentAlignment.MiddleLeft;
            RemoveBTN.TextAlignment = HorizontalAlignment.Center;
            RemoveBTN.TextMarginLeft = 0;
            RemoveBTN.TextPadding = new Padding(35, 0, 0, 0);
            RemoveBTN.UseDefaultRadiusAndThickness = true;
            RemoveBTN.Click += RemoveBTN_Click;
            // 
            // Pagination
            // 
            Pagination.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Pagination.Controls.Add(PaginationLabel);
            Pagination.Controls.Add(PaginationPREV);
            Pagination.Controls.Add(PaginationNext);
            Pagination.Location = new Point(12, 441);
            Pagination.Name = "Pagination";
            Pagination.Size = new Size(196, 50);
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
            // 
            // AllBusinessDatagrid
            // 
            AllBusinessDatagrid.AllowCustomTheming = false;
            AllBusinessDatagrid.AllowUserToAddRows = false;
            AllBusinessDatagrid.AllowUserToDeleteRows = false;
            AllBusinessDatagrid.AllowUserToResizeColumns = false;
            AllBusinessDatagrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(223, 191, 191);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            AllBusinessDatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AllBusinessDatagrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AllBusinessDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllBusinessDatagrid.BackgroundColor = Color.White;
            AllBusinessDatagrid.BorderStyle = BorderStyle.None;
            AllBusinessDatagrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            AllBusinessDatagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 0, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AllBusinessDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AllBusinessDatagrid.ColumnHeadersHeight = 40;
            AllBusinessDatagrid.Columns.AddRange(new DataGridViewColumn[] { IdCol, BusinessNameCol, DateCreatedCol });
            AllBusinessDatagrid.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(223, 191, 191);
            AllBusinessDatagrid.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            AllBusinessDatagrid.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            AllBusinessDatagrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(178, 102, 102);
            AllBusinessDatagrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.White;
            AllBusinessDatagrid.CurrentTheme.BackColor = Color.Maroon;
            AllBusinessDatagrid.CurrentTheme.GridColor = Color.FromArgb(216, 178, 178);
            AllBusinessDatagrid.CurrentTheme.HeaderStyle.BackColor = Color.Maroon;
            AllBusinessDatagrid.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            AllBusinessDatagrid.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            AllBusinessDatagrid.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(102, 0, 0);
            AllBusinessDatagrid.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            AllBusinessDatagrid.CurrentTheme.Name = null;
            AllBusinessDatagrid.CurrentTheme.RowsStyle.BackColor = Color.FromArgb(229, 204, 204);
            AllBusinessDatagrid.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            AllBusinessDatagrid.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            AllBusinessDatagrid.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(178, 102, 102);
            AllBusinessDatagrid.CurrentTheme.RowsStyle.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(229, 204, 204);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(178, 102, 102);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AllBusinessDatagrid.DefaultCellStyle = dataGridViewCellStyle3;
            AllBusinessDatagrid.EnableHeadersVisualStyles = false;
            AllBusinessDatagrid.GridColor = Color.FromArgb(216, 178, 178);
            AllBusinessDatagrid.HeaderBackColor = Color.Maroon;
            AllBusinessDatagrid.HeaderBgColor = Color.Empty;
            AllBusinessDatagrid.HeaderForeColor = Color.White;
            AllBusinessDatagrid.Location = new Point(10, 41);
            AllBusinessDatagrid.Name = "AllBusinessDatagrid";
            AllBusinessDatagrid.ReadOnly = true;
            AllBusinessDatagrid.RowHeadersVisible = false;
            AllBusinessDatagrid.RowTemplate.Height = 40;
            AllBusinessDatagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllBusinessDatagrid.Size = new Size(880, 394);
            AllBusinessDatagrid.TabIndex = 3;
            AllBusinessDatagrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Maroon;
            AllBusinessDatagrid.MouseClick += AllBusinessDatagrid_MouseClick;
            // 
            // IdCol
            // 
            IdCol.HeaderText = "BusinessId";
            IdCol.Name = "IdCol";
            IdCol.ReadOnly = true;
            IdCol.Visible = false;
            // 
            // BusinessNameCol
            // 
            BusinessNameCol.HeaderText = "Business";
            BusinessNameCol.Name = "BusinessNameCol";
            BusinessNameCol.ReadOnly = true;
            // 
            // DateCreatedCol
            // 
            DateCreatedCol.FillWeight = 30F;
            DateCreatedCol.HeaderText = "Created";
            DateCreatedCol.Name = "DateCreatedCol";
            DateCreatedCol.ReadOnly = true;
            // 
            // AddBusinessBTN
            // 
            AddBusinessBTN.AllowAnimations = true;
            AddBusinessBTN.AllowMouseEffects = true;
            AddBusinessBTN.AllowToggling = false;
            AddBusinessBTN.AnimationSpeed = 200;
            AddBusinessBTN.AutoGenerateColors = false;
            AddBusinessBTN.AutoRoundBorders = false;
            AddBusinessBTN.AutoSizeLeftIcon = true;
            AddBusinessBTN.AutoSizeRightIcon = true;
            AddBusinessBTN.BackColor = Color.Transparent;
            AddBusinessBTN.BackColor1 = Color.FromArgb(78, 160, 21);
            AddBusinessBTN.BackgroundImage = (Image)resources.GetObject("AddBusinessBTN.BackgroundImage");
            AddBusinessBTN.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddBusinessBTN.ButtonText = "Add Business";
            AddBusinessBTN.ButtonTextMarginLeft = 0;
            AddBusinessBTN.ColorContrastOnClick = 45;
            AddBusinessBTN.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            AddBusinessBTN.CustomizableEdges = borderEdges3;
            AddBusinessBTN.DialogResult = DialogResult.None;
            AddBusinessBTN.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            AddBusinessBTN.DisabledFillColor = Color.FromArgb(204, 204, 204);
            AddBusinessBTN.DisabledForecolor = Color.FromArgb(168, 160, 168);
            AddBusinessBTN.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            AddBusinessBTN.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBusinessBTN.ForeColor = Color.White;
            AddBusinessBTN.IconLeftAlign = ContentAlignment.MiddleLeft;
            AddBusinessBTN.IconLeftCursor = Cursors.Default;
            AddBusinessBTN.IconLeftPadding = new Padding(11, 3, 3, 3);
            AddBusinessBTN.IconMarginLeft = 11;
            AddBusinessBTN.IconPadding = 10;
            AddBusinessBTN.IconRightAlign = ContentAlignment.MiddleRight;
            AddBusinessBTN.IconRightCursor = Cursors.Default;
            AddBusinessBTN.IconRightPadding = new Padding(3, 3, 7, 3);
            AddBusinessBTN.IconSize = 25;
            AddBusinessBTN.IdleBorderColor = Color.FromArgb(78, 160, 21);
            AddBusinessBTN.IdleBorderRadius = 1;
            AddBusinessBTN.IdleBorderThickness = 1;
            AddBusinessBTN.IdleFillColor = Color.FromArgb(78, 160, 21);
            AddBusinessBTN.IdleIconLeftImage = Properties.Resources.plus__1_;
            AddBusinessBTN.IdleIconRightImage = null;
            AddBusinessBTN.IndicateFocus = false;
            AddBusinessBTN.Location = new Point(10, 3);
            AddBusinessBTN.Name = "AddBusinessBTN";
            AddBusinessBTN.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            AddBusinessBTN.OnDisabledState.BorderRadius = 1;
            AddBusinessBTN.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddBusinessBTN.OnDisabledState.BorderThickness = 1;
            AddBusinessBTN.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            AddBusinessBTN.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            AddBusinessBTN.OnDisabledState.IconLeftImage = null;
            AddBusinessBTN.OnDisabledState.IconRightImage = null;
            AddBusinessBTN.onHoverState.BorderColor = Color.FromArgb(50, 110, 5);
            AddBusinessBTN.onHoverState.BorderRadius = 1;
            AddBusinessBTN.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddBusinessBTN.onHoverState.BorderThickness = 1;
            AddBusinessBTN.onHoverState.FillColor = Color.FromArgb(50, 110, 5);
            AddBusinessBTN.onHoverState.ForeColor = Color.White;
            AddBusinessBTN.onHoverState.IconLeftImage = null;
            AddBusinessBTN.onHoverState.IconRightImage = null;
            AddBusinessBTN.OnIdleState.BorderColor = Color.FromArgb(78, 160, 21);
            AddBusinessBTN.OnIdleState.BorderRadius = 1;
            AddBusinessBTN.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddBusinessBTN.OnIdleState.BorderThickness = 1;
            AddBusinessBTN.OnIdleState.FillColor = Color.FromArgb(78, 160, 21);
            AddBusinessBTN.OnIdleState.ForeColor = Color.White;
            AddBusinessBTN.OnIdleState.IconLeftImage = Properties.Resources.plus__1_;
            AddBusinessBTN.OnIdleState.IconRightImage = null;
            AddBusinessBTN.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            AddBusinessBTN.OnPressedState.BorderRadius = 1;
            AddBusinessBTN.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddBusinessBTN.OnPressedState.BorderThickness = 1;
            AddBusinessBTN.OnPressedState.FillColor = Color.FromArgb(192, 64, 0);
            AddBusinessBTN.OnPressedState.ForeColor = Color.White;
            AddBusinessBTN.OnPressedState.IconLeftImage = null;
            AddBusinessBTN.OnPressedState.IconRightImage = null;
            AddBusinessBTN.Size = new Size(154, 32);
            AddBusinessBTN.TabIndex = 2;
            AddBusinessBTN.TextAlign = ContentAlignment.MiddleLeft;
            AddBusinessBTN.TextAlignment = HorizontalAlignment.Center;
            AddBusinessBTN.TextMarginLeft = 0;
            AddBusinessBTN.TextPadding = new Padding(35, 0, 0, 0);
            AddBusinessBTN.UseDefaultRadiusAndThickness = true;
            AddBusinessBTN.Click += AddBusinessBTN_Click;
            // 
            // Menustrip
            // 
            Menustrip.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            Menustrip.Name = "Menustrip";
            Menustrip.Size = new Size(123, 26);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(122, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // BusinessFormPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 550);
            Controls.Add(MainContainer);
            Controls.Add(TopPanel);
            Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BusinessFormPage";
            Text = "BusinessFormPage";
            Load += BusinessFormPage_Load;
            TopPanel.ResumeLayout(false);
            MainContainer.ResumeLayout(false);
            Pagination.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AllBusinessDatagrid).EndInit();
            Menustrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel TopPanel;
        private Panel panel4;
        private Label label1;
        private Panel MainContainer;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 AddBusinessBTN;
        private Bunifu.UI.WinForms.BunifuDataGridView AllBusinessDatagrid;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn BusinessNameCol;
        private DataGridViewTextBoxColumn DateCreatedCol;
        private Panel Pagination;
        private Label PaginationLabel;
        private Bunifu.UI.WinForms.BunifuImageButton PaginationPREV;
        private Bunifu.UI.WinForms.BunifuImageButton PaginationNext;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 EditBTN;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 RemoveBTN;
        private ContextMenuStrip Menustrip;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}