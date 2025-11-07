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
            RemoveButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            EditButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            AddAccountBTN = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            panel3 = new Panel();
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
            AllAccountsDatagridView.Click += AddAccountBTN_Click;
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
            panel4.Controls.Add(RemoveButton);
            panel4.Controls.Add(EditButton);
            panel4.Controls.Add(AddAccountBTN);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(10, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(519, 60);
            panel4.TabIndex = 15;
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            RemoveButton.CustomizableEdges = borderEdges1;
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
            RemoveButton.Location = new Point(146, 15);
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
            EditButton.Location = new Point(292, 15);
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
            // AddAccountBTN
            // 
            AddAccountBTN.AllowAnimations = true;
            AddAccountBTN.AllowMouseEffects = true;
            AddAccountBTN.AllowToggling = false;
            AddAccountBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddAccountBTN.AnimationSpeed = 200;
            AddAccountBTN.AutoGenerateColors = false;
            AddAccountBTN.AutoRoundBorders = false;
            AddAccountBTN.AutoSizeLeftIcon = true;
            AddAccountBTN.AutoSizeRightIcon = true;
            AddAccountBTN.BackColor = Color.Transparent;
            AddAccountBTN.BackColor1 = Color.FromArgb(78, 160, 21);
            AddAccountBTN.BackgroundImage = (Image)resources.GetObject("AddAccountBTN.BackgroundImage");
            AddAccountBTN.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddAccountBTN.ButtonText = "New Account";
            AddAccountBTN.ButtonTextMarginLeft = 0;
            AddAccountBTN.ColorContrastOnClick = 45;
            AddAccountBTN.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            AddAccountBTN.CustomizableEdges = borderEdges3;
            AddAccountBTN.DialogResult = DialogResult.None;
            AddAccountBTN.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            AddAccountBTN.DisabledFillColor = Color.FromArgb(204, 204, 204);
            AddAccountBTN.DisabledForecolor = Color.FromArgb(168, 160, 168);
            AddAccountBTN.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            AddAccountBTN.Font = new Font("Courier New", 11.25F, FontStyle.Bold);
            AddAccountBTN.ForeColor = Color.White;
            AddAccountBTN.IconLeftAlign = ContentAlignment.MiddleLeft;
            AddAccountBTN.IconLeftCursor = Cursors.Default;
            AddAccountBTN.IconLeftPadding = new Padding(11, 3, 3, 3);
            AddAccountBTN.IconMarginLeft = 11;
            AddAccountBTN.IconPadding = 10;
            AddAccountBTN.IconRightAlign = ContentAlignment.MiddleRight;
            AddAccountBTN.IconRightCursor = Cursors.Default;
            AddAccountBTN.IconRightPadding = new Padding(3, 3, 7, 3);
            AddAccountBTN.IconSize = 25;
            AddAccountBTN.IdleBorderColor = Color.FromArgb(78, 160, 21);
            AddAccountBTN.IdleBorderRadius = 1;
            AddAccountBTN.IdleBorderThickness = 1;
            AddAccountBTN.IdleFillColor = Color.FromArgb(78, 160, 21);
            AddAccountBTN.IdleIconLeftImage = Properties.Resources.plus__1_;
            AddAccountBTN.IdleIconRightImage = null;
            AddAccountBTN.IndicateFocus = false;
            AddAccountBTN.Location = new Point(0, 15);
            AddAccountBTN.Name = "AddAccountBTN";
            AddAccountBTN.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            AddAccountBTN.OnDisabledState.BorderRadius = 1;
            AddAccountBTN.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddAccountBTN.OnDisabledState.BorderThickness = 1;
            AddAccountBTN.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            AddAccountBTN.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            AddAccountBTN.OnDisabledState.IconLeftImage = null;
            AddAccountBTN.OnDisabledState.IconRightImage = null;
            AddAccountBTN.onHoverState.BorderColor = Color.FromArgb(50, 110, 5);
            AddAccountBTN.onHoverState.BorderRadius = 1;
            AddAccountBTN.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddAccountBTN.onHoverState.BorderThickness = 1;
            AddAccountBTN.onHoverState.FillColor = Color.FromArgb(50, 110, 5);
            AddAccountBTN.onHoverState.ForeColor = Color.White;
            AddAccountBTN.onHoverState.IconLeftImage = null;
            AddAccountBTN.onHoverState.IconRightImage = null;
            AddAccountBTN.OnIdleState.BorderColor = Color.FromArgb(78, 160, 21);
            AddAccountBTN.OnIdleState.BorderRadius = 1;
            AddAccountBTN.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddAccountBTN.OnIdleState.BorderThickness = 1;
            AddAccountBTN.OnIdleState.FillColor = Color.FromArgb(78, 160, 21);
            AddAccountBTN.OnIdleState.ForeColor = Color.White;
            AddAccountBTN.OnIdleState.IconLeftImage = Properties.Resources.plus__1_;
            AddAccountBTN.OnIdleState.IconRightImage = null;
            AddAccountBTN.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            AddAccountBTN.OnPressedState.BorderRadius = 1;
            AddAccountBTN.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            AddAccountBTN.OnPressedState.BorderThickness = 1;
            AddAccountBTN.OnPressedState.FillColor = Color.FromArgb(192, 64, 0);
            AddAccountBTN.OnPressedState.ForeColor = Color.White;
            AddAccountBTN.OnPressedState.IconLeftImage = null;
            AddAccountBTN.OnPressedState.IconRightImage = null;
            AddAccountBTN.Size = new Size(140, 34);
            AddAccountBTN.TabIndex = 17;
            AddAccountBTN.TextAlign = ContentAlignment.MiddleLeft;
            AddAccountBTN.TextAlignment = HorizontalAlignment.Center;
            AddAccountBTN.TextMarginLeft = 0;
            AddAccountBTN.TextPadding = new Padding(35, 0, 0, 0);
            AddAccountBTN.UseDefaultRadiusAndThickness = true;
            AddAccountBTN.Click += AddAccountBTN_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(SearchBox);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(529, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(361, 60);
            panel3.TabIndex = 14;
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
            SearchBox.Location = new Point(6, 10);
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
            SearchBox.PlaceholderText = "Search by Name";
            SearchBox.ReadOnly = false;
            SearchBox.ScrollBars = ScrollBars.None;
            SearchBox.SelectedText = "";
            SearchBox.SelectionLength = 0;
            SearchBox.SelectionStart = 0;
            SearchBox.ShortcutsEnabled = true;
            SearchBox.Size = new Size(349, 39);
            SearchBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            SearchBox.TabIndex = 13;
            SearchBox.TextAlign = HorizontalAlignment.Left;
            SearchBox.TextMarginBottom = 0;
            SearchBox.TextMarginLeft = 3;
            SearchBox.TextMarginTop = 1;
            SearchBox.TextPlaceholder = "Search by Name";
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
            Load += accountPage_Load;
            TopPanel.ResumeLayout(false);
            MainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AllAccountsDatagridView).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 AddAccountBTN;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 RemoveButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 EditButton;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridViewTextBoxColumn UsernameCol;
    }
}