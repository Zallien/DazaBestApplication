namespace DazaBestApplication.Pages
{
    partial class ItemInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemInventory));
            TopPanel = new Panel();
            MainContainer = new Panel();
            ItemsDatagrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            ItemCodeCol = new DataGridViewTextBoxColumn();
            ItemNameCol = new DataGridViewTextBoxColumn();
            StocksCol = new DataGridViewTextBoxColumn();
            StatusCol = new DataGridViewTextBoxColumn();
            PriceCol = new DataGridViewTextBoxColumn();
            bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            TopPanel.SuspendLayout();
            MainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemsDatagrid).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.Controls.Add(bunifuLabel1);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(900, 50);
            TopPanel.TabIndex = 0;
            // 
            // MainContainer
            // 
            MainContainer.Controls.Add(ItemsDatagrid);
            MainContainer.Dock = DockStyle.Fill;
            MainContainer.Location = new Point(0, 50);
            MainContainer.Name = "MainContainer";
            MainContainer.Size = new Size(900, 612);
            MainContainer.TabIndex = 1;
            MainContainer.Paint += MainContainer_Paint;
            // 
            // ItemsDatagrid
            // 
            ItemsDatagrid.AllowCustomTheming = false;
            ItemsDatagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 232, 191);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            ItemsDatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ItemsDatagrid.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ItemsDatagrid.BackgroundColor = Color.White;
            ItemsDatagrid.BorderStyle = BorderStyle.None;
            ItemsDatagrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ItemsDatagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Orange;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(204, 132, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ItemsDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ItemsDatagrid.ColumnHeadersHeight = 40;
            ItemsDatagrid.Columns.AddRange(new DataGridViewColumn[] { IdCol, ItemCodeCol, ItemNameCol, StocksCol, StatusCol, PriceCol });
            ItemsDatagrid.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(255, 232, 191);
            ItemsDatagrid.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            ItemsDatagrid.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            ItemsDatagrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(255, 201, 102);
            ItemsDatagrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            ItemsDatagrid.CurrentTheme.BackColor = Color.Orange;
            ItemsDatagrid.CurrentTheme.GridColor = Color.FromArgb(255, 226, 173);
            ItemsDatagrid.CurrentTheme.HeaderStyle.BackColor = Color.Orange;
            ItemsDatagrid.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            ItemsDatagrid.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            ItemsDatagrid.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(204, 132, 0);
            ItemsDatagrid.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            ItemsDatagrid.CurrentTheme.Name = null;
            ItemsDatagrid.CurrentTheme.RowsStyle.BackColor = Color.FromArgb(255, 237, 204);
            ItemsDatagrid.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            ItemsDatagrid.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            ItemsDatagrid.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(255, 201, 102);
            ItemsDatagrid.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 237, 204);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 201, 102);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ItemsDatagrid.DefaultCellStyle = dataGridViewCellStyle3;
            ItemsDatagrid.EnableHeadersVisualStyles = false;
            ItemsDatagrid.GridColor = Color.FromArgb(255, 226, 173);
            ItemsDatagrid.HeaderBackColor = Color.Orange;
            ItemsDatagrid.HeaderBgColor = Color.Empty;
            ItemsDatagrid.HeaderForeColor = Color.White;
            ItemsDatagrid.Location = new Point(5, 143);
            ItemsDatagrid.Name = "ItemsDatagrid";
            ItemsDatagrid.ReadOnly = true;
            ItemsDatagrid.RowHeadersVisible = false;
            ItemsDatagrid.RowTemplate.Height = 40;
            ItemsDatagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ItemsDatagrid.Size = new Size(890, 422);
            ItemsDatagrid.TabIndex = 0;
            ItemsDatagrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Orange;
            // 
            // IdCol
            // 
            IdCol.HeaderText = "ItemID";
            IdCol.Name = "IdCol";
            IdCol.ReadOnly = true;
            IdCol.Visible = false;
            // 
            // ItemCodeCol
            // 
            ItemCodeCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ItemCodeCol.FillWeight = 20F;
            ItemCodeCol.HeaderText = "Item Code";
            ItemCodeCol.Name = "ItemCodeCol";
            ItemCodeCol.ReadOnly = true;
            ItemCodeCol.Width = 110;
            // 
            // ItemNameCol
            // 
            ItemNameCol.HeaderText = "Item Name";
            ItemNameCol.Name = "ItemNameCol";
            ItemNameCol.ReadOnly = true;
            // 
            // StocksCol
            // 
            StocksCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            StocksCol.FillWeight = 20F;
            StocksCol.HeaderText = "Stocks";
            StocksCol.Name = "StocksCol";
            StocksCol.ReadOnly = true;
            StocksCol.Width = 81;
            // 
            // StatusCol
            // 
            StatusCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            StatusCol.FillWeight = 13F;
            StatusCol.HeaderText = "Status";
            StatusCol.Name = "StatusCol";
            StatusCol.ReadOnly = true;
            StatusCol.Width = 78;
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
            // bunifuLabel1
            // 
            bunifuLabel1.AllowParentOverrides = false;
            bunifuLabel1.AutoEllipsis = false;
            bunifuLabel1.AutoSize = false;
            bunifuLabel1.CursorType = Cursors.Default;
            bunifuLabel1.Dock = DockStyle.Left;
            bunifuLabel1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuLabel1.Location = new Point(0, 0);
            bunifuLabel1.Name = "bunifuLabel1";
            bunifuLabel1.Padding = new Padding(10, 0, 0, 0);
            bunifuLabel1.RightToLeft = RightToLeft.No;
            bunifuLabel1.Size = new Size(219, 50);
            bunifuLabel1.TabIndex = 0;
            bunifuLabel1.Text = "Inventory";
            bunifuLabel1.TextAlignment = ContentAlignment.MiddleLeft;
            bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ItemInventory
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 662);
            Controls.Add(MainContainer);
            Controls.Add(TopPanel);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ItemInventory";
            Text = "ItemInventory";
            Load += ItemInventory_Load;
            TopPanel.ResumeLayout(false);
            MainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ItemsDatagrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Panel MainContainer;
        private Bunifu.UI.WinForms.BunifuDataGridView ItemsDatagrid;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn ItemCodeCol;
        private DataGridViewTextBoxColumn ItemNameCol;
        private DataGridViewTextBoxColumn StocksCol;
        private DataGridViewTextBoxColumn StatusCol;
        private DataGridViewTextBoxColumn PriceCol;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}