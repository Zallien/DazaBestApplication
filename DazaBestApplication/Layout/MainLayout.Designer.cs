namespace DazaBestApplication
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Topnavbar = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Navbar = new Panel();
            NavbarBtn_Products = new Panel();
            label7 = new Label();
            pictureBox7 = new PictureBox();
            NavbarBtn_Logout = new Panel();
            label6 = new Label();
            pictureBox6 = new PictureBox();
            NavbarBtn_Supplier = new Panel();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            NavbarBtn_Sale = new Panel();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            NavbarBtn_Items = new Panel();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            NavbarBtn_Home = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            MainContainer = new Panel();
            bunifuButton21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            Topnavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Navbar.SuspendLayout();
            NavbarBtn_Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            NavbarBtn_Logout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            NavbarBtn_Supplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            NavbarBtn_Sale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            NavbarBtn_Items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            NavbarBtn_Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Topnavbar
            // 
            Topnavbar.BackColor = Color.FromArgb(249, 168, 37);
            Topnavbar.Controls.Add(label1);
            Topnavbar.Controls.Add(pictureBox1);
            Topnavbar.Dock = DockStyle.Top;
            Topnavbar.Location = new Point(0, 0);
            Topnavbar.Name = "Topnavbar";
            Topnavbar.Padding = new Padding(9, 0, 9, 0);
            Topnavbar.Size = new Size(1100, 38);
            Topnavbar.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(7, 0, 0, 0);
            label1.Size = new Size(244, 38);
            label1.TabIndex = 1;
            label1.Text = "Daza's Best Lechon";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources._477622848_2102876326812470_7082635694266922336_n;
            pictureBox1.Location = new Point(9, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Navbar
            // 
            Navbar.BackColor = Color.FromArgb(251, 192, 45);
            Navbar.Controls.Add(bunifuButton21);
            Navbar.Controls.Add(NavbarBtn_Products);
            Navbar.Controls.Add(NavbarBtn_Logout);
            Navbar.Controls.Add(NavbarBtn_Supplier);
            Navbar.Controls.Add(NavbarBtn_Sale);
            Navbar.Controls.Add(NavbarBtn_Items);
            Navbar.Controls.Add(NavbarBtn_Home);
            Navbar.Dock = DockStyle.Left;
            Navbar.Location = new Point(0, 38);
            Navbar.Name = "Navbar";
            Navbar.Padding = new Padding(10, 20, 10, 10);
            Navbar.Size = new Size(200, 662);
            Navbar.TabIndex = 1;
            // 
            // NavbarBtn_Products
            // 
            NavbarBtn_Products.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NavbarBtn_Products.Controls.Add(label7);
            NavbarBtn_Products.Controls.Add(pictureBox7);
            NavbarBtn_Products.Location = new Point(9, 120);
            NavbarBtn_Products.Name = "NavbarBtn_Products";
            NavbarBtn_Products.Padding = new Padding(3);
            NavbarBtn_Products.Size = new Size(180, 40);
            NavbarBtn_Products.TabIndex = 5;
            NavbarBtn_Products.Tag = "NavBtn";
            NavbarBtn_Products.MouseClick += NavbarBtn_Products_MouseClick;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(43, 3);
            label7.Name = "label7";
            label7.Size = new Size(134, 34);
            label7.TabIndex = 1;
            label7.Text = "Products";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            label7.MouseClick += NavbarBtn_Products_MouseClick;
            // 
            // pictureBox7
            // 
            pictureBox7.Dock = DockStyle.Left;
            pictureBox7.Image = Properties.Resources.inventory;
            pictureBox7.Location = new Point(3, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(40, 34);
            pictureBox7.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            pictureBox7.MouseClick += NavbarBtn_Products_MouseClick;
            // 
            // NavbarBtn_Logout
            // 
            NavbarBtn_Logout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NavbarBtn_Logout.Controls.Add(label6);
            NavbarBtn_Logout.Controls.Add(pictureBox6);
            NavbarBtn_Logout.Location = new Point(9, 609);
            NavbarBtn_Logout.Name = "NavbarBtn_Logout";
            NavbarBtn_Logout.Padding = new Padding(3);
            NavbarBtn_Logout.Size = new Size(180, 40);
            NavbarBtn_Logout.TabIndex = 4;
            NavbarBtn_Logout.Tag = "NavBtn";
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(43, 3);
            label6.Name = "label6";
            label6.Size = new Size(134, 34);
            label6.TabIndex = 1;
            label6.Text = "Logout";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox6
            // 
            pictureBox6.Dock = DockStyle.Left;
            pictureBox6.Image = Properties.Resources.logout;
            pictureBox6.Location = new Point(3, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(40, 34);
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // NavbarBtn_Supplier
            // 
            NavbarBtn_Supplier.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NavbarBtn_Supplier.Controls.Add(label5);
            NavbarBtn_Supplier.Controls.Add(pictureBox5);
            NavbarBtn_Supplier.Location = new Point(10, 270);
            NavbarBtn_Supplier.Name = "NavbarBtn_Supplier";
            NavbarBtn_Supplier.Padding = new Padding(3);
            NavbarBtn_Supplier.Size = new Size(180, 40);
            NavbarBtn_Supplier.TabIndex = 3;
            NavbarBtn_Supplier.Tag = "NavBtn";
            NavbarBtn_Supplier.MouseClick += NavbarBtn_Supplier_MouseClick;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(43, 3);
            label5.Name = "label5";
            label5.Size = new Size(134, 34);
            label5.TabIndex = 1;
            label5.Text = "Supplier";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            label5.MouseClick += NavbarBtn_Supplier_MouseClick;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Left;
            pictureBox5.Image = Properties.Resources.supplier;
            pictureBox5.Location = new Point(3, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 34);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            pictureBox5.MouseClick += NavbarBtn_Supplier_MouseClick;
            // 
            // NavbarBtn_Sale
            // 
            NavbarBtn_Sale.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NavbarBtn_Sale.Controls.Add(label4);
            NavbarBtn_Sale.Controls.Add(pictureBox4);
            NavbarBtn_Sale.Location = new Point(10, 220);
            NavbarBtn_Sale.Name = "NavbarBtn_Sale";
            NavbarBtn_Sale.Padding = new Padding(3);
            NavbarBtn_Sale.Size = new Size(180, 40);
            NavbarBtn_Sale.TabIndex = 2;
            NavbarBtn_Sale.Tag = "NavBtn";
            NavbarBtn_Sale.MouseClick += NavbarBtn_Sale_MouseClick;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 3);
            label4.Name = "label4";
            label4.Size = new Size(134, 34);
            label4.TabIndex = 1;
            label4.Text = "Sale";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            label4.MouseClick += NavbarBtn_Sale_MouseClick;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Left;
            pictureBox4.Image = Properties.Resources.sale;
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            pictureBox4.MouseClick += NavbarBtn_Sale_MouseClick;
            // 
            // NavbarBtn_Items
            // 
            NavbarBtn_Items.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NavbarBtn_Items.Controls.Add(label3);
            NavbarBtn_Items.Controls.Add(pictureBox3);
            NavbarBtn_Items.Location = new Point(10, 170);
            NavbarBtn_Items.Name = "NavbarBtn_Items";
            NavbarBtn_Items.Padding = new Padding(3);
            NavbarBtn_Items.Size = new Size(180, 40);
            NavbarBtn_Items.TabIndex = 1;
            NavbarBtn_Items.Tag = "NavBtn";
            NavbarBtn_Items.MouseClick += NavbarBtn_Items_MouseClick;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 3);
            label3.Name = "label3";
            label3.Size = new Size(134, 34);
            label3.TabIndex = 1;
            label3.Text = "Items";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.MouseClick += NavbarBtn_Items_MouseClick;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Image = Properties.Resources.inventory;
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.MouseClick += NavbarBtn_Items_MouseClick;
            // 
            // NavbarBtn_Home
            // 
            NavbarBtn_Home.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NavbarBtn_Home.Controls.Add(label2);
            NavbarBtn_Home.Controls.Add(pictureBox2);
            NavbarBtn_Home.Location = new Point(10, 70);
            NavbarBtn_Home.Name = "NavbarBtn_Home";
            NavbarBtn_Home.Padding = new Padding(3);
            NavbarBtn_Home.Size = new Size(180, 40);
            NavbarBtn_Home.TabIndex = 0;
            NavbarBtn_Home.Tag = "NavBtn";
            NavbarBtn_Home.MouseClick += NavbarBtn_Home_MouseClick;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 3);
            label2.Name = "label2";
            label2.Size = new Size(134, 34);
            label2.TabIndex = 1;
            label2.Text = "Home";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.MouseClick += NavbarBtn_Home_MouseClick;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.home__1_;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.MouseClick += NavbarBtn_Home_MouseClick;
            // 
            // MainContainer
            // 
            MainContainer.Dock = DockStyle.Fill;
            MainContainer.Location = new Point(200, 38);
            MainContainer.Name = "MainContainer";
            MainContainer.Padding = new Padding(10, 0, 10, 0);
            MainContainer.Size = new Size(900, 662);
            MainContainer.TabIndex = 2;
            // 
            // bunifuButton21
            // 
            bunifuButton21.AllowAnimations = true;
            bunifuButton21.AllowMouseEffects = true;
            bunifuButton21.AllowToggling = false;
            bunifuButton21.AnimationSpeed = 200;
            bunifuButton21.AutoGenerateColors = false;
            bunifuButton21.AutoRoundBorders = false;
            bunifuButton21.AutoSizeLeftIcon = true;
            bunifuButton21.AutoSizeRightIcon = true;
            bunifuButton21.BackColor = Color.Transparent;
            bunifuButton21.BackColor1 = Color.DodgerBlue;
            bunifuButton21.BackgroundImage = (Image)resources.GetObject("bunifuButton21.BackgroundImage");
            bunifuButton21.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton21.ButtonText = "bunifuButton21";
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
            bunifuButton21.Font = new Font("Segoe UI", 9F);
            bunifuButton21.ForeColor = Color.White;
            bunifuButton21.IconLeftAlign = ContentAlignment.MiddleLeft;
            bunifuButton21.IconLeftCursor = Cursors.Default;
            bunifuButton21.IconLeftPadding = new Padding(11, 3, 3, 3);
            bunifuButton21.IconMarginLeft = 11;
            bunifuButton21.IconPadding = 10;
            bunifuButton21.IconRightAlign = ContentAlignment.MiddleRight;
            bunifuButton21.IconRightCursor = Cursors.Default;
            bunifuButton21.IconRightPadding = new Padding(3, 3, 7, 3);
            bunifuButton21.IconSize = 25;
            bunifuButton21.IdleBorderColor = Color.DodgerBlue;
            bunifuButton21.IdleBorderRadius = 1;
            bunifuButton21.IdleBorderThickness = 1;
            bunifuButton21.IdleFillColor = Color.DodgerBlue;
            bunifuButton21.IdleIconLeftImage = null;
            bunifuButton21.IdleIconRightImage = null;
            bunifuButton21.IndicateFocus = false;
            bunifuButton21.Location = new Point(9, 23);
            bunifuButton21.Name = "bunifuButton21";
            bunifuButton21.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton21.OnDisabledState.BorderRadius = 1;
            bunifuButton21.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton21.OnDisabledState.BorderThickness = 1;
            bunifuButton21.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            bunifuButton21.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunifuButton21.OnDisabledState.IconLeftImage = null;
            bunifuButton21.OnDisabledState.IconRightImage = null;
            bunifuButton21.onHoverState.BorderColor = Color.FromArgb(105, 181, 255);
            bunifuButton21.onHoverState.BorderRadius = 1;
            bunifuButton21.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton21.onHoverState.BorderThickness = 1;
            bunifuButton21.onHoverState.FillColor = Color.FromArgb(105, 181, 255);
            bunifuButton21.onHoverState.ForeColor = Color.White;
            bunifuButton21.onHoverState.IconLeftImage = null;
            bunifuButton21.onHoverState.IconRightImage = null;
            bunifuButton21.OnIdleState.BorderColor = Color.DodgerBlue;
            bunifuButton21.OnIdleState.BorderRadius = 1;
            bunifuButton21.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton21.OnIdleState.BorderThickness = 1;
            bunifuButton21.OnIdleState.FillColor = Color.DodgerBlue;
            bunifuButton21.OnIdleState.ForeColor = Color.White;
            bunifuButton21.OnIdleState.IconLeftImage = null;
            bunifuButton21.OnIdleState.IconRightImage = null;
            bunifuButton21.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            bunifuButton21.OnPressedState.BorderRadius = 1;
            bunifuButton21.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton21.OnPressedState.BorderThickness = 1;
            bunifuButton21.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            bunifuButton21.OnPressedState.ForeColor = Color.White;
            bunifuButton21.OnPressedState.IconLeftImage = null;
            bunifuButton21.OnPressedState.IconRightImage = null;
            bunifuButton21.Size = new Size(180, 39);
            bunifuButton21.TabIndex = 6;
            bunifuButton21.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton21.TextAlignment = HorizontalAlignment.Center;
            bunifuButton21.TextMarginLeft = 0;
            bunifuButton21.TextPadding = new Padding(0);
            bunifuButton21.UseDefaultRadiusAndThickness = true;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 700);
            Controls.Add(MainContainer);
            Controls.Add(Navbar);
            Controls.Add(Topnavbar);
            Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Daza's Best";
            Load += MainPage_Load;
            Topnavbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Navbar.ResumeLayout(false);
            NavbarBtn_Products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            NavbarBtn_Logout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            NavbarBtn_Supplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            NavbarBtn_Sale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            NavbarBtn_Items.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            NavbarBtn_Home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Topnavbar;
        private Panel Navbar;
        private Panel MainContainer;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel NavbarBtn_Home;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel NavbarBtn_Items;
        private Label label3;
        private PictureBox pictureBox3;
        private Panel NavbarBtn_Sale;
        private Label label4;
        private PictureBox pictureBox4;
        private Panel NavbarBtn_Supplier;
        private Label label5;
        private PictureBox pictureBox5;
        private Panel NavbarBtn_Logout;
        private Label label6;
        private PictureBox pictureBox6;
        private Panel NavbarBtn_Products;
        private Label label7;
        private PictureBox pictureBox7;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton21;
    }
}
