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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointofSaleForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bottomnavbar = new Panel();
            Sidebar = new Panel();
            MainDisplay = new FlowLayoutPanel();
            bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextBox();
            label1 = new Label();
            Sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // Bottomnavbar
            // 
            Bottomnavbar.Dock = DockStyle.Bottom;
            Bottomnavbar.Location = new Point(0, 430);
            Bottomnavbar.Name = "Bottomnavbar";
            Bottomnavbar.Size = new Size(900, 70);
            Bottomnavbar.TabIndex = 0;
            // 
            // Sidebar
            // 
            Sidebar.Controls.Add(label1);
            Sidebar.Controls.Add(bunifuTextBox1);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.Location = new Point(0, 0);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(250, 430);
            Sidebar.TabIndex = 1;
            // 
            // MainDisplay
            // 
            MainDisplay.AutoScroll = true;
            MainDisplay.Dock = DockStyle.Fill;
            MainDisplay.Location = new Point(250, 0);
            MainDisplay.Name = "MainDisplay";
            MainDisplay.Size = new Size(650, 430);
            MainDisplay.TabIndex = 2;
            // 
            // bunifuTextBox1
            // 
            bunifuTextBox1.AcceptsReturn = false;
            bunifuTextBox1.AcceptsTab = false;
            bunifuTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bunifuTextBox1.AnimationSpeed = 200;
            bunifuTextBox1.AutoCompleteMode = AutoCompleteMode.None;
            bunifuTextBox1.AutoCompleteSource = AutoCompleteSource.None;
            bunifuTextBox1.AutoSizeHeight = true;
            bunifuTextBox1.BackColor = Color.Transparent;
            bunifuTextBox1.BackgroundImage = (Image)resources.GetObject("bunifuTextBox1.BackgroundImage");
            bunifuTextBox1.BorderColorActive = Color.DodgerBlue;
            bunifuTextBox1.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            bunifuTextBox1.BorderColorHover = Color.FromArgb(105, 181, 255);
            bunifuTextBox1.BorderColorIdle = Color.Silver;
            bunifuTextBox1.BorderRadius = 1;
            bunifuTextBox1.BorderThickness = 1;
            bunifuTextBox1.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            bunifuTextBox1.CharacterCasing = CharacterCasing.Normal;
            bunifuTextBox1.DefaultFont = new Font("Segoe UI", 9.25F);
            bunifuTextBox1.DefaultText = "";
            bunifuTextBox1.FillColor = Color.White;
            bunifuTextBox1.HideSelection = true;
            bunifuTextBox1.IconLeft = null;
            bunifuTextBox1.IconLeftCursor = Cursors.IBeam;
            bunifuTextBox1.IconPadding = 10;
            bunifuTextBox1.IconRight = null;
            bunifuTextBox1.IconRightCursor = Cursors.IBeam;
            bunifuTextBox1.Location = new Point(10, 42);
            bunifuTextBox1.MaxLength = 32767;
            bunifuTextBox1.MinimumSize = new Size(1, 1);
            bunifuTextBox1.Modified = false;
            bunifuTextBox1.Multiline = false;
            bunifuTextBox1.Name = "bunifuTextBox1";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            bunifuTextBox1.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            bunifuTextBox1.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            bunifuTextBox1.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.Empty;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            bunifuTextBox1.OnIdleState = stateProperties4;
            bunifuTextBox1.Padding = new Padding(3);
            bunifuTextBox1.PasswordChar = '\0';
            bunifuTextBox1.PlaceholderForeColor = Color.Silver;
            bunifuTextBox1.PlaceholderText = "Enter text";
            bunifuTextBox1.ReadOnly = false;
            bunifuTextBox1.ScrollBars = ScrollBars.None;
            bunifuTextBox1.SelectedText = "";
            bunifuTextBox1.SelectionLength = 0;
            bunifuTextBox1.SelectionStart = 0;
            bunifuTextBox1.ShortcutsEnabled = true;
            bunifuTextBox1.Size = new Size(232, 32);
            bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            bunifuTextBox1.TabIndex = 0;
            bunifuTextBox1.TextAlign = HorizontalAlignment.Left;
            bunifuTextBox1.TextMarginBottom = 0;
            bunifuTextBox1.TextMarginLeft = 3;
            bunifuTextBox1.TextMarginTop = 1;
            bunifuTextBox1.TextPlaceholder = "Enter text";
            bunifuTextBox1.UseSystemPasswordChar = false;
            bunifuTextBox1.WordWrap = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(67, 19);
            label1.TabIndex = 1;
            label1.Text = "Search :";
            // 
            // PointofSaleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 500);
            Controls.Add(MainDisplay);
            Controls.Add(Sidebar);
            Controls.Add(Bottomnavbar);
            Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PointofSaleForm";
            Text = "PointofSaleForm";
            Load += PointofSaleForm_Load;
            Sidebar.ResumeLayout(false);
            Sidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Bottomnavbar;
        private Panel Sidebar;
        private FlowLayoutPanel MainDisplay;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        private Label label1;
    }
}