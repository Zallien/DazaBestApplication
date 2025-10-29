namespace DazaBestApplication.Pages
{
    partial class accountPage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accountPage));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            TopPanel = new Panel();
            label1 = new Label();
            MainContainer = new Panel();
            AllAccountsDatagridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            NameCol = new DataGridViewTextBoxColumn();
            UsernameCol = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel4 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            EditButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            RemoveButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            AddProductBTN = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            panel3 = new Panel();
            bunifuButton22 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            SearchBox = new Bunifu.UI.WinForms.BunifuTextBox();
            panel2 = new Panel();
            Pagination = new Panel();
            PaginationLabel = new Label();
            PaginationPREV = new Bunifu.UI.WinForms.BunifuImageButton();
            PaginationNext = new Bunifu.UI.WinForms.BunifuImageButton();
            TopPanel.SuspendLayout();
            MainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AllAccountsDatagridView).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
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
            label1.Text = "Accounts";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainContainer
            // 
            MainContainer.Controls.Add(AllAccountsDatagridView);
            MainContainer.Controls.Add(panel1);
            MainContainer.Controls.Add(panel2);
            MainContainer.Dock = DockStyle.Fill;
            MainContainer.Location = new Point(0, 50);
            MainContainer.Name = "MainContainer";
            MainContainer.Padding = new Padding(0, 10, 0, 0);
            MainContainer.Size = new Size(900, 612);
            MainContainer.TabIndex = 5;
            // 
            // AllAccountsDatagridView
            // 
            AllAccountsDatagridView.AllowCustomTheming = false;
            AllAccountsDatagridView.AllowUserToAddRows = false;
            AllAccountsDatagridView.AllowUserToDeleteRows = false;
            AllAccountsDatagridView.AllowUserToResizeColumns = false;
            AllAccountsDatagridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(223, 191, 191);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            AllAccountsDatagridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AllAccountsDatagridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllAccountsDatagridView.BackgroundColor = Color.White;
            AllAccountsDatagridView.BorderStyle = BorderStyle.None;
            AllAccountsDatagridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            AllAccountsDatagridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 0, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AllAccountsDatagridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AllAccountsDatagridView.ColumnHeadersHeight = 40;
            AllAccountsDatagridView.Columns.AddRange(new DataGridViewColumn[] { IdCol, NameCol, UsernameCol });
            AllAccountsDatagridView.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(223, 191, 191);
            AllAccountsDatagridView.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            AllAccountsDatagridView.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            AllAccountsDatagridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(178, 102, 102);
            AllAccountsDatagridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.White;
            AllAccountsDatagridView.CurrentTheme.BackColor = Color.Maroon;
            AllAccountsDatagridView.CurrentTheme.GridColor = Color.FromArgb(216, 178, 178);
            AllAccountsDatagridView.CurrentTheme.HeaderStyle.BackColor = Color.Maroon;
            AllAccountsDatagridView.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            AllAccountsDatagridView.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            AllAccountsDatagridView.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(102, 0, 0);
            AllAccountsDatagridView.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            AllAccountsDatagridView.CurrentTheme.Name = null;
            AllAccountsDatagridView.CurrentTheme.RowsStyle.BackColor = Color.FromArgb(229, 204, 204);
            AllAccountsDatagridView.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            AllAccountsDatagridView.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            AllAccountsDatagridView.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(178, 102, 102);
            AllAccountsDatagridView.CurrentTheme.RowsStyle.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(229, 204, 204);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(178, 102, 102);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AllAccountsDatagridView.DefaultCellStyle = dataGridViewCellStyle3;
            AllAccountsDatagridView.Dock = DockStyle.Fill;
            AllAccountsDatagridView.EnableHeadersVisualStyles = false;
            AllAccountsDatagridView.GridColor = Color.FromArgb(216, 178, 178);
            AllAccountsDatagridView.HeaderBackColor = Color.Maroon;
            AllAccountsDatagridView.HeaderBgColor = Color.Empty;
            AllAccountsDatagridView.HeaderForeColor = Color.White;
            AllAccountsDatagridView.Location = new Point(0, 70);
            AllAccountsDatagridView.Name = "AllAccountsDatagridView";
            AllAccountsDatagridView.ReadOnly = true;
            AllAccountsDatagridView.RowHeadersVisible = false;
            AllAccountsDatagridView.RowTemplate.Height = 40;
            AllAccountsDatagridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllAccountsDatagridView.Size = new Size(900, 492);
            AllAccountsDatagridView.TabIndex = 11;
            AllAccountsDatagridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Maroon;
            // 
            // IdCol
            // 
            IdCol.HeaderText = "ID";
            IdCol.Name = "IdCol";
            IdCol.ReadOnly = true;
            IdCol.Visible = false;
            // 
            // NameCol
            // 
            NameCol.HeaderText = "Name";
            NameCol.Name = "NameCol";
            NameCol.ReadOnly = true;
            // 
            // UsernameCol
            // 
            UsernameCol.HeaderText = "Username";
            UsernameCol.Name = "UsernameCol";
            UsernameCol.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 0, 10, 0);
            panel1.Size = new Size(900, 60);
            panel1.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(10, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(519, 60);
            panel4.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.4117641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.4117641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.4117641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.7647057F));
            tableLayoutPanel1.Controls.Add(EditButton, 2, 0);
            tableLayoutPanel1.Controls.Add(RemoveButton, 1, 0);
            tableLayoutPanel1.Controls.Add(AddProductBTN, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(519, 60);
            tableLayoutPanel1.TabIndex = 0;
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
            EditButton.Font = new Font("Courier New", 11.25F, FontStyle.Bold);
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
            EditButton.Location = new Point(305, 13);
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
            EditButton.Size = new Size(140, 34);
            EditButton.TabIndex = 19;
            EditButton.TextAlign = ContentAlignment.MiddleLeft;
            EditButton.TextAlignment = HorizontalAlignment.Center;
            EditButton.TextMarginLeft = 0;
            EditButton.TextPadding = new Padding(35, 0, 0, 0);
            EditButton.UseDefaultRadiusAndThickness = true;
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
            RemoveButton.Font = new Font("Courier New", 11.25F, FontStyle.Bold);
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
            RemoveButton.Location = new Point(159, 13);
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
            RemoveButton.Size = new Size(140, 34);
            RemoveButton.TabIndex = 18;
            RemoveButton.TextAlign = ContentAlignment.MiddleLeft;
            RemoveButton.TextAlignment = HorizontalAlignment.Center;
            RemoveButton.TextMarginLeft = 0;
            RemoveButton.TextPadding = new Padding(35, 0, 0, 0);
            RemoveButton.UseDefaultRadiusAndThickness = true;
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
            AddProductBTN.ButtonText = "New Account";
            AddProductBTN.ButtonTextMarginLeft = 0;
            AddProductBTN.ColorContrastOnClick = 45;
            AddProductBTN.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            AddProductBTN.CustomizableEdges = borderEdges3;
            AddProductBTN.DialogResult = DialogResult.None;
            AddProductBTN.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            AddProductBTN.DisabledFillColor = Color.FromArgb(204, 204, 204);
            AddProductBTN.DisabledForecolor = Color.FromArgb(168, 160, 168);
            AddProductBTN.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            AddProductBTN.Font = new Font("Courier New", 11.25F, FontStyle.Bold);
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
            AddProductBTN.Location = new Point(13, 13);
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
            AddProductBTN.Size = new Size(140, 34);
            AddProductBTN.TabIndex = 17;
            AddProductBTN.TextAlign = ContentAlignment.MiddleLeft;
            AddProductBTN.TextAlignment = HorizontalAlignment.Center;
            AddProductBTN.TextMarginLeft = 0;
            AddProductBTN.TextPadding = new Padding(35, 0, 0, 0);
            AddProductBTN.UseDefaultRadiusAndThickness = true;
            AddProductBTN.Click += AddProductBTN_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(bunifuButton22);
            panel3.Controls.Add(SearchBox);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(529, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(361, 60);
            panel3.TabIndex = 14;
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
            bunifuButton22.ButtonText = "Print";
            bunifuButton22.ButtonTextMarginLeft = 0;
            bunifuButton22.ColorContrastOnClick = 45;
            bunifuButton22.ColorContrastOnHover = 45;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            bunifuButton22.CustomizableEdges = borderEdges4;
            bunifuButton22.DialogResult = DialogResult.None;
            bunifuButton22.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton22.DisabledFillColor = Color.FromArgb(204, 204, 204);
            bunifuButton22.DisabledForecolor = Color.FromArgb(168, 160, 168);
            bunifuButton22.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            bunifuButton22.Font = new Font("Courier New", 11.25F, FontStyle.Bold);
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
            bunifuButton22.IdleIconLeftImage = Properties.Resources.printer__1_;
            bunifuButton22.IdleIconRightImage = null;
            bunifuButton22.IndicateFocus = false;
            bunifuButton22.Location = new Point(8, 10);
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
            bunifuButton22.OnIdleState.IconLeftImage = Properties.Resources.printer__1_;
            bunifuButton22.OnIdleState.IconRightImage = null;
            bunifuButton22.OnPressedState.BorderColor = Color.FromArgb(161, 205, 220);
            bunifuButton22.OnPressedState.BorderRadius = 1;
            bunifuButton22.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton22.OnPressedState.BorderThickness = 1;
            bunifuButton22.OnPressedState.FillColor = Color.FromArgb(161, 205, 220);
            bunifuButton22.OnPressedState.ForeColor = Color.Black;
            bunifuButton22.OnPressedState.IconLeftImage = null;
            bunifuButton22.OnPressedState.IconRightImage = null;
            bunifuButton22.Size = new Size(98, 40);
            bunifuButton22.TabIndex = 14;
            bunifuButton22.TextAlign = ContentAlignment.MiddleLeft;
            bunifuButton22.TextAlignment = HorizontalAlignment.Center;
            bunifuButton22.TextMarginLeft = 0;
            bunifuButton22.TextPadding = new Padding(35, 0, 0, 0);
            bunifuButton22.UseDefaultRadiusAndThickness = true;
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
            SearchBox.Location = new Point(112, 10);
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
            SearchBox.Size = new Size(243, 39);
            SearchBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            SearchBox.TabIndex = 13;
            SearchBox.TextAlign = HorizontalAlignment.Left;
            SearchBox.TextMarginBottom = 0;
            SearchBox.TextMarginLeft = 3;
            SearchBox.TextMarginTop = 1;
            SearchBox.TextPlaceholder = "Search by Purchase No";
            SearchBox.UseSystemPasswordChar = false;
            SearchBox.WordWrap = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(Pagination);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 562);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10, 0, 10, 0);
            panel2.Size = new Size(900, 50);
            panel2.TabIndex = 7;
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
            // accountPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 662);
            Controls.Add(MainContainer);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "accountPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "accountPage";
            TopPanel.ResumeLayout(false);
            MainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AllAccountsDatagridView).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            Pagination.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Label label1;
        private Panel MainContainer;
        private Panel panel2;
        private Panel Pagination;
        private Label PaginationLabel;
        private Bunifu.UI.WinForms.BunifuImageButton PaginationPREV;
        private Bunifu.UI.WinForms.BunifuImageButton PaginationNext;
        private Panel panel1;
        private Bunifu.UI.WinForms.BunifuDataGridView AllAccountsDatagridView;
        private Panel panel3;
        private Bunifu.UI.WinForms.BunifuTextBox SearchBox;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton22;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 AddProductBTN;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 RemoveButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 EditButton;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridViewTextBoxColumn UsernameCol;
    }
}