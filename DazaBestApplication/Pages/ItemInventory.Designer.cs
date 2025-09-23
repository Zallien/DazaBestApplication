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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            ItemList = new DataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            CodeCol = new DataGridViewTextBoxColumn();
            ItemNameCol = new DataGridViewTextBoxColumn();
            StockCol = new DataGridViewTextBoxColumn();
            StatusCol = new DataGridViewTextBoxColumn();
            PriceCol = new DataGridViewTextBoxColumn();
            Topnav = new Panel();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            Datanav = new Panel();
            DelBtn = new Panel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            AddItemBtn = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ItemPageMainContainer = new Panel();
            ((System.ComponentModel.ISupportInitialize)ItemList).BeginInit();
            Topnav.SuspendLayout();
            Datanav.SuspendLayout();
            DelBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            AddItemBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ItemPageMainContainer.SuspendLayout();
            SuspendLayout();
            // 
            // ItemList
            // 
            ItemList.AllowUserToAddRows = false;
            ItemList.AllowUserToDeleteRows = false;
            ItemList.AllowUserToResizeColumns = false;
            ItemList.AllowUserToResizeRows = false;
            ItemList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ItemList.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(251, 192, 45);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ItemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ItemList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemList.Columns.AddRange(new DataGridViewColumn[] { IdCol, CodeCol, ItemNameCol, StockCol, StatusCol, PriceCol });
            ItemList.Dock = DockStyle.Fill;
            ItemList.GridColor = Color.White;
            ItemList.Location = new Point(0, 0);
            ItemList.MultiSelect = false;
            ItemList.Name = "ItemList";
            ItemList.ReadOnly = true;
            ItemList.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ItemList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            ItemList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ItemList.Size = new Size(900, 551);
            ItemList.TabIndex = 0;
            // 
            // IdCol
            // 
            dataGridViewCellStyle2.BackColor = Color.FromArgb(251, 192, 45);
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IdCol.DefaultCellStyle = dataGridViewCellStyle2;
            IdCol.HeaderText = "ID";
            IdCol.Name = "IdCol";
            IdCol.ReadOnly = true;
            IdCol.Visible = false;
            // 
            // CodeCol
            // 
            CodeCol.FillWeight = 25F;
            CodeCol.HeaderText = "Item Code";
            CodeCol.Name = "CodeCol";
            CodeCol.ReadOnly = true;
            // 
            // ItemNameCol
            // 
            ItemNameCol.HeaderText = "Item Name";
            ItemNameCol.Name = "ItemNameCol";
            ItemNameCol.ReadOnly = true;
            // 
            // StockCol
            // 
            StockCol.FillWeight = 15F;
            StockCol.HeaderText = "Stocks";
            StockCol.Name = "StockCol";
            StockCol.ReadOnly = true;
            // 
            // StatusCol
            // 
            StatusCol.FillWeight = 18F;
            StatusCol.HeaderText = "Status";
            StatusCol.Name = "StatusCol";
            StatusCol.ReadOnly = true;
            // 
            // PriceCol
            // 
            PriceCol.FillWeight = 18F;
            PriceCol.HeaderText = "Price";
            PriceCol.Name = "PriceCol";
            PriceCol.ReadOnly = true;
            // 
            // Topnav
            // 
            Topnav.Controls.Add(label1);
            Topnav.Controls.Add(label2);
            Topnav.Controls.Add(textBox1);
            Topnav.Dock = DockStyle.Top;
            Topnav.Location = new Point(0, 0);
            Topnav.Name = "Topnav";
            Topnav.Size = new Size(900, 40);
            Topnav.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 40);
            label1.TabIndex = 0;
            label1.Text = "Item Inventory";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(604, 6);
            label2.Name = "label2";
            label2.Size = new Size(116, 26);
            label2.TabIndex = 1;
            label2.Text = "Search :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(720, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 26);
            textBox1.TabIndex = 0;
            // 
            // Datanav
            // 
            Datanav.Controls.Add(DelBtn);
            Datanav.Controls.Add(AddItemBtn);
            Datanav.Dock = DockStyle.Top;
            Datanav.Location = new Point(0, 40);
            Datanav.Name = "Datanav";
            Datanav.Size = new Size(900, 71);
            Datanav.TabIndex = 2;
            // 
            // DelBtn
            // 
            DelBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DelBtn.BackColor = Color.White;
            DelBtn.BorderStyle = BorderStyle.FixedSingle;
            DelBtn.Controls.Add(label4);
            DelBtn.Controls.Add(pictureBox2);
            DelBtn.Location = new Point(751, 34);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(145, 30);
            DelBtn.TabIndex = 1;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(30, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(2);
            label4.Size = new Size(113, 28);
            label4.TabIndex = 1;
            label4.Text = "Delete";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.delete16px;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // AddItemBtn
            // 
            AddItemBtn.BackColor = Color.FromArgb(251, 192, 45);
            AddItemBtn.BorderStyle = BorderStyle.FixedSingle;
            AddItemBtn.Controls.Add(label3);
            AddItemBtn.Controls.Add(pictureBox1);
            AddItemBtn.Location = new Point(0, 34);
            AddItemBtn.Name = "AddItemBtn";
            AddItemBtn.Size = new Size(145, 30);
            AddItemBtn.TabIndex = 0;
            AddItemBtn.Click += AdddItem;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(30, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(2);
            label3.Size = new Size(113, 28);
            label3.TabIndex = 1;
            label3.Text = "Add Item";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Click += AdddItem;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.add16px;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += AdddItem;
            // 
            // ItemPageMainContainer
            // 
            ItemPageMainContainer.Controls.Add(ItemList);
            ItemPageMainContainer.Dock = DockStyle.Fill;
            ItemPageMainContainer.Location = new Point(0, 111);
            ItemPageMainContainer.Name = "ItemPageMainContainer";
            ItemPageMainContainer.Size = new Size(900, 551);
            ItemPageMainContainer.TabIndex = 3;
            // 
            // ItemInventory
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 662);
            Controls.Add(ItemPageMainContainer);
            Controls.Add(Datanav);
            Controls.Add(Topnav);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ItemInventory";
            Text = "ItemInventory";
            Load += ItemInventory_Load;
            ((System.ComponentModel.ISupportInitialize)ItemList).EndInit();
            Topnav.ResumeLayout(false);
            Topnav.PerformLayout();
            Datanav.ResumeLayout(false);
            DelBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            AddItemBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ItemPageMainContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ItemList;
        private Panel Topnav;
        private Panel Datanav;
        private Label label1;
        private Panel ItemPageMainContainer;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn CodeCol;
        private DataGridViewTextBoxColumn ItemNameCol;
        private DataGridViewTextBoxColumn StockCol;
        private DataGridViewTextBoxColumn StatusCol;
        private DataGridViewTextBoxColumn PriceCol;
        private Label label2;
        private TextBox textBox1;
        private Panel AddItemBtn;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel DelBtn;
        private Label label4;
        private PictureBox pictureBox2;
    }
}