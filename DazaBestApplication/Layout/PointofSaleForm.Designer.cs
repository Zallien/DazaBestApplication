namespace DazaBestApplication.Layout
{
    partial class PointofSaleForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointofSaleForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Bottomnavbar = new Panel();
            Sidebar = new Panel();
            label1 = new Label();
            label2 = new Label();
            ProductOrdersDatagrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            Searchbox = new Bunifu.UI.WinForms.BunifuTextBox();
            MainDisplay = new FlowLayoutPanel();
            ProductIdCol = new DataGridViewTextBoxColumn();
            ProductNameCol = new DataGridViewTextBoxColumn();
            QuantityCol = new DataGridViewTextBoxColumn();
            PriceCol = new DataGridViewTextBoxColumn();
            Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductOrdersDatagrid).BeginInit();
            SuspendLayout();
            // 
            // Bottomnavbar
            // 
            Bottomnavbar.Dock = DockStyle.Bottom;
            Bottomnavbar.Location = new Point(0, 580);
            Bottomnavbar.Name = "Bottomnavbar";
            Bottomnavbar.Size = new Size(1020, 70);
            Bottomnavbar.TabIndex = 0;
            // 
            // Sidebar
            // 
            Sidebar.Controls.Add(label1);
            Sidebar.Controls.Add(label2);
            Sidebar.Controls.Add(ProductOrdersDatagrid);
            Sidebar.Controls.Add(Searchbox);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.Location = new Point(0, 0);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(300, 580);
            Sidebar.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(67, 19);
            label1.TabIndex = 4;
            label1.Text = "Search :";
            // 
            // label2
            // 
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 3;
            label2.Text = "Orders :";
            // 
            // ProductOrdersDatagrid
            // 
            ProductOrdersDatagrid.AllowCustomTheming = false;
            ProductOrdersDatagrid.AllowUserToAddRows = false;
            ProductOrdersDatagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            ProductOrdersDatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ProductOrdersDatagrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductOrdersDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductOrdersDatagrid.BackgroundColor = Color.White;
            ProductOrdersDatagrid.BorderStyle = BorderStyle.None;
            ProductOrdersDatagrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ProductOrdersDatagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ProductOrdersDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ProductOrdersDatagrid.ColumnHeadersHeight = 40;
            ProductOrdersDatagrid.Columns.AddRange(new DataGridViewColumn[] { ProductIdCol, ProductNameCol, QuantityCol, PriceCol });
            ProductOrdersDatagrid.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            ProductOrdersDatagrid.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            ProductOrdersDatagrid.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            ProductOrdersDatagrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            ProductOrdersDatagrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            ProductOrdersDatagrid.CurrentTheme.BackColor = Color.White;
            ProductOrdersDatagrid.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            ProductOrdersDatagrid.CurrentTheme.HeaderStyle.BackColor = Color.DodgerBlue;
            ProductOrdersDatagrid.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            ProductOrdersDatagrid.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            ProductOrdersDatagrid.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            ProductOrdersDatagrid.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            ProductOrdersDatagrid.CurrentTheme.Name = null;
            ProductOrdersDatagrid.CurrentTheme.RowsStyle.BackColor = Color.White;
            ProductOrdersDatagrid.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            ProductOrdersDatagrid.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            ProductOrdersDatagrid.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            ProductOrdersDatagrid.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            ProductOrdersDatagrid.DefaultCellStyle = dataGridViewCellStyle4;
            ProductOrdersDatagrid.EnableHeadersVisualStyles = false;
            ProductOrdersDatagrid.GridColor = Color.FromArgb(221, 238, 255);
            ProductOrdersDatagrid.HeaderBackColor = Color.DodgerBlue;
            ProductOrdersDatagrid.HeaderBgColor = Color.Empty;
            ProductOrdersDatagrid.HeaderForeColor = Color.White;
            ProductOrdersDatagrid.Location = new Point(10, 117);
            ProductOrdersDatagrid.Name = "ProductOrdersDatagrid";
            ProductOrdersDatagrid.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new Font("Cambria", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            ProductOrdersDatagrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            ProductOrdersDatagrid.RowTemplate.Height = 40;
            ProductOrdersDatagrid.ScrollBars = ScrollBars.Vertical;
            ProductOrdersDatagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductOrdersDatagrid.Size = new Size(282, 146);
            ProductOrdersDatagrid.TabIndex = 2;
            ProductOrdersDatagrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Searchbox
            // 
            Searchbox.AcceptsReturn = false;
            Searchbox.AcceptsTab = false;
            Searchbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Searchbox.AnimationSpeed = 200;
            Searchbox.AutoCompleteMode = AutoCompleteMode.None;
            Searchbox.AutoCompleteSource = AutoCompleteSource.None;
            Searchbox.AutoSizeHeight = true;
            Searchbox.BackColor = Color.Transparent;
            Searchbox.BackgroundImage = (Image)resources.GetObject("Searchbox.BackgroundImage");
            Searchbox.BorderColorActive = Color.DodgerBlue;
            Searchbox.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            Searchbox.BorderColorHover = Color.FromArgb(105, 181, 255);
            Searchbox.BorderColorIdle = Color.Silver;
            Searchbox.BorderRadius = 1;
            Searchbox.BorderThickness = 1;
            Searchbox.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            Searchbox.CharacterCasing = CharacterCasing.Normal;
            Searchbox.DefaultFont = new Font("Segoe UI", 9.25F);
            Searchbox.DefaultText = "";
            Searchbox.FillColor = Color.White;
            Searchbox.HideSelection = true;
            Searchbox.IconLeft = null;
            Searchbox.IconLeftCursor = Cursors.IBeam;
            Searchbox.IconPadding = 10;
            Searchbox.IconRight = null;
            Searchbox.IconRightCursor = Cursors.IBeam;
            Searchbox.Location = new Point(10, 42);
            Searchbox.MaxLength = 32767;
            Searchbox.MinimumSize = new Size(1, 1);
            Searchbox.Modified = false;
            Searchbox.Multiline = false;
            Searchbox.Name = "Searchbox";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            Searchbox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            Searchbox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            Searchbox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.Empty;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            Searchbox.OnIdleState = stateProperties4;
            Searchbox.Padding = new Padding(3);
            Searchbox.PasswordChar = '\0';
            Searchbox.PlaceholderForeColor = Color.Silver;
            Searchbox.PlaceholderText = "Search...";
            Searchbox.ReadOnly = false;
            Searchbox.ScrollBars = ScrollBars.None;
            Searchbox.SelectedText = "";
            Searchbox.SelectionLength = 0;
            Searchbox.SelectionStart = 0;
            Searchbox.ShortcutsEnabled = true;
            Searchbox.Size = new Size(282, 39);
            Searchbox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            Searchbox.TabIndex = 0;
            Searchbox.TextAlign = HorizontalAlignment.Left;
            Searchbox.TextMarginBottom = 0;
            Searchbox.TextMarginLeft = 3;
            Searchbox.TextMarginTop = 1;
            Searchbox.TextPlaceholder = "Search...";
            Searchbox.UseSystemPasswordChar = false;
            Searchbox.WordWrap = true;
            // 
            // MainDisplay
            // 
            MainDisplay.AutoScroll = true;
            MainDisplay.Dock = DockStyle.Fill;
            MainDisplay.Location = new Point(300, 0);
            MainDisplay.Name = "MainDisplay";
            MainDisplay.Size = new Size(720, 580);
            MainDisplay.TabIndex = 2;
            // 
            // ProductIdCol
            // 
            ProductIdCol.HeaderText = "id";
            ProductIdCol.Name = "ProductIdCol";
            ProductIdCol.Visible = false;
            // 
            // ProductNameCol
            // 
            dataGridViewCellStyle3.Font = new Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductNameCol.DefaultCellStyle = dataGridViewCellStyle3;
            ProductNameCol.FillWeight = 60F;
            ProductNameCol.HeaderText = "Product";
            ProductNameCol.Name = "ProductNameCol";
            ProductNameCol.ReadOnly = true;
            // 
            // QuantityCol
            // 
            QuantityCol.FillWeight = 15F;
            QuantityCol.HeaderText = "Qty";
            QuantityCol.Name = "QuantityCol";
            // 
            // PriceCol
            // 
            PriceCol.FillWeight = 25F;
            PriceCol.HeaderText = "Price";
            PriceCol.Name = "PriceCol";
            // 
            // PointofSaleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 650);
            Controls.Add(MainDisplay);
            Controls.Add(Sidebar);
            Controls.Add(Bottomnavbar);
            Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PointofSaleForm";
            Text = "PointofSaleForm";
            Load += PointofSaleForm_Load;
            Sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductOrdersDatagrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Bottomnavbar;
        private Panel Sidebar;
        private FlowLayoutPanel MainDisplay;
        private Bunifu.UI.WinForms.BunifuTextBox Searchbox;
        private Bunifu.UI.WinForms.BunifuDataGridView ProductOrdersDatagrid;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn ProductIdCol;
        private DataGridViewTextBoxColumn ProductNameCol;
        private DataGridViewTextBoxColumn QuantityCol;
        private DataGridViewTextBoxColumn PriceCol;
    }
}