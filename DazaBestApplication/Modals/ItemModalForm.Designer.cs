namespace DazaBestApplication.Modals
{
    partial class ItemModalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemModalForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            panel1 = new Panel();
            CloseModal = new Bunifu.UI.WinForms.BunifuImageButton();
            label1 = new Label();
            panel2 = new Panel();
            AddItemButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ItemNametxt = new Bunifu.UI.WinForms.BunifuTextBox();
            ItemPricetxt = new Bunifu.UI.WinForms.BunifuTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 192, 45);
            panel1.Controls.Add(CloseModal);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 40);
            panel1.TabIndex = 0;
            // 
            // CloseModal
            // 
            CloseModal.ActiveImage = null;
            CloseModal.AllowAnimations = true;
            CloseModal.AllowBuffering = false;
            CloseModal.AllowToggling = false;
            CloseModal.AllowZooming = true;
            CloseModal.AllowZoomingOnFocus = false;
            CloseModal.BackColor = Color.Transparent;
            CloseModal.DialogResult = DialogResult.None;
            CloseModal.Dock = DockStyle.Right;
            CloseModal.ErrorImage = (Image)resources.GetObject("CloseModal.ErrorImage");
            CloseModal.FadeWhenInactive = false;
            CloseModal.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            CloseModal.Image = Properties.Resources.logout;
            CloseModal.ImageActive = null;
            CloseModal.ImageLocation = null;
            CloseModal.ImageMargin = 20;
            CloseModal.ImageSize = new Size(20, 20);
            CloseModal.ImageZoomSize = new Size(40, 40);
            CloseModal.InitialImage = (Image)resources.GetObject("CloseModal.InitialImage");
            CloseModal.Location = new Point(380, 0);
            CloseModal.Name = "CloseModal";
            CloseModal.Rotation = 0;
            CloseModal.ShowActiveImage = true;
            CloseModal.ShowCursorChanges = true;
            CloseModal.ShowImageBorders = true;
            CloseModal.ShowSizeMarkers = false;
            CloseModal.Size = new Size(40, 40);
            CloseModal.TabIndex = 1;
            CloseModal.ToolTipText = "";
            CloseModal.WaitOnLoad = false;
            CloseModal.Zoom = 20;
            CloseModal.ZoomSpeed = 10;
            CloseModal.Click += CloseModal_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(154, 40);
            label1.TabIndex = 0;
            label1.Text = "Add Item";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(AddItemButton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 225);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10, 2, 10, 2);
            panel2.Size = new Size(420, 35);
            panel2.TabIndex = 1;
            // 
            // AddItemButton
            // 
            AddItemButton.AllowAnimations = true;
            AddItemButton.AllowMouseEffects = true;
            AddItemButton.AllowToggling = false;
            AddItemButton.AnimationSpeed = 200;
            AddItemButton.AutoGenerateColors = false;
            AddItemButton.AutoRoundBorders = false;
            AddItemButton.AutoSizeLeftIcon = true;
            AddItemButton.AutoSizeRightIcon = true;
            AddItemButton.BackColor = Color.Transparent;
            AddItemButton.BackColor1 = Color.FromArgb(51, 122, 183);
            AddItemButton.BackgroundImage = (Image)resources.GetObject("AddItemButton.BackgroundImage");
            AddItemButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            AddItemButton.ButtonText = "Add Item";
            AddItemButton.ButtonTextMarginLeft = 0;
            AddItemButton.ColorContrastOnClick = 45;
            AddItemButton.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            AddItemButton.CustomizableEdges = borderEdges1;
            AddItemButton.DialogResult = DialogResult.None;
            AddItemButton.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            AddItemButton.DisabledFillColor = Color.Empty;
            AddItemButton.DisabledForecolor = Color.Empty;
            AddItemButton.Dock = DockStyle.Right;
            AddItemButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            AddItemButton.Font = new Font("Segoe UI", 9F);
            AddItemButton.ForeColor = Color.White;
            AddItemButton.IconLeft = null;
            AddItemButton.IconLeftAlign = ContentAlignment.MiddleLeft;
            AddItemButton.IconLeftCursor = Cursors.Default;
            AddItemButton.IconLeftPadding = new Padding(11, 3, 3, 3);
            AddItemButton.IconMarginLeft = 11;
            AddItemButton.IconPadding = 10;
            AddItemButton.IconRight = null;
            AddItemButton.IconRightAlign = ContentAlignment.MiddleRight;
            AddItemButton.IconRightCursor = Cursors.Default;
            AddItemButton.IconRightPadding = new Padding(3, 3, 7, 3);
            AddItemButton.IconSize = 25;
            AddItemButton.IdleBorderColor = Color.Empty;
            AddItemButton.IdleBorderRadius = 0;
            AddItemButton.IdleBorderThickness = 0;
            AddItemButton.IdleFillColor = Color.Empty;
            AddItemButton.IdleIconLeftImage = null;
            AddItemButton.IdleIconRightImage = null;
            AddItemButton.IndicateFocus = false;
            AddItemButton.Location = new Point(300, 2);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            AddItemButton.OnDisabledState.BorderRadius = 1;
            AddItemButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            AddItemButton.OnDisabledState.BorderThickness = 1;
            AddItemButton.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            AddItemButton.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            AddItemButton.OnDisabledState.IconLeftImage = null;
            AddItemButton.OnDisabledState.IconRightImage = null;
            AddItemButton.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            AddItemButton.onHoverState.BorderRadius = 1;
            AddItemButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            AddItemButton.onHoverState.BorderThickness = 1;
            AddItemButton.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            AddItemButton.onHoverState.ForeColor = Color.White;
            AddItemButton.onHoverState.IconLeftImage = null;
            AddItemButton.onHoverState.IconRightImage = null;
            AddItemButton.OnIdleState.BorderColor = Color.DodgerBlue;
            AddItemButton.OnIdleState.BorderRadius = 1;
            AddItemButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            AddItemButton.OnIdleState.BorderThickness = 1;
            AddItemButton.OnIdleState.FillColor = Color.DodgerBlue;
            AddItemButton.OnIdleState.ForeColor = Color.White;
            AddItemButton.OnIdleState.IconLeftImage = null;
            AddItemButton.OnIdleState.IconRightImage = null;
            AddItemButton.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            AddItemButton.OnPressedState.BorderRadius = 1;
            AddItemButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            AddItemButton.OnPressedState.BorderThickness = 1;
            AddItemButton.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            AddItemButton.OnPressedState.ForeColor = Color.White;
            AddItemButton.OnPressedState.IconLeftImage = null;
            AddItemButton.OnPressedState.IconRightImage = null;
            AddItemButton.Size = new Size(110, 31);
            AddItemButton.TabIndex = 0;
            AddItemButton.TextAlign = ContentAlignment.MiddleCenter;
            AddItemButton.TextAlignment = HorizontalAlignment.Center;
            AddItemButton.TextMarginLeft = 0;
            AddItemButton.TextPadding = new Padding(0);
            AddItemButton.UseDefaultRadiusAndThickness = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(12, 160);
            button2.Name = "button2";
            button2.Size = new Size(100, 33);
            button2.TabIndex = 3;
            button2.Text = "Insert Image";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(127, 52);
            label2.Name = "label2";
            label2.Size = new Size(113, 30);
            label2.TabIndex = 4;
            label2.Text = "Item Name: ";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(127, 85);
            label3.Name = "label3";
            label3.Size = new Size(113, 30);
            label3.TabIndex = 5;
            label3.Text = "Item Price :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(127, 121);
            label4.Name = "label4";
            label4.Size = new Size(113, 30);
            label4.TabIndex = 8;
            label4.Text = "Date Created :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(248, 121);
            label5.Name = "label5";
            label5.Size = new Size(162, 30);
            label5.TabIndex = 9;
            label5.Text = "09/20/2025";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ItemNametxt
            // 
            ItemNametxt.AcceptsReturn = false;
            ItemNametxt.AcceptsTab = false;
            ItemNametxt.AnimationSpeed = 200;
            ItemNametxt.AutoCompleteMode = AutoCompleteMode.None;
            ItemNametxt.AutoCompleteSource = AutoCompleteSource.None;
            ItemNametxt.AutoSizeHeight = true;
            ItemNametxt.BackColor = Color.Transparent;
            ItemNametxt.BackgroundImage = (Image)resources.GetObject("ItemNametxt.BackgroundImage");
            ItemNametxt.BorderColorActive = Color.DodgerBlue;
            ItemNametxt.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            ItemNametxt.BorderColorHover = Color.FromArgb(105, 181, 255);
            ItemNametxt.BorderColorIdle = Color.Silver;
            ItemNametxt.BorderRadius = 1;
            ItemNametxt.BorderThickness = 1;
            ItemNametxt.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            ItemNametxt.CharacterCasing = CharacterCasing.Normal;
            ItemNametxt.DefaultFont = new Font("Segoe UI", 9.25F);
            ItemNametxt.DefaultText = "";
            ItemNametxt.FillColor = Color.White;
            ItemNametxt.HideSelection = true;
            ItemNametxt.IconLeft = null;
            ItemNametxt.IconLeftCursor = Cursors.IBeam;
            ItemNametxt.IconPadding = 10;
            ItemNametxt.IconRight = null;
            ItemNametxt.IconRightCursor = Cursors.IBeam;
            ItemNametxt.Location = new Point(248, 52);
            ItemNametxt.MaxLength = 32767;
            ItemNametxt.MinimumSize = new Size(1, 1);
            ItemNametxt.Modified = false;
            ItemNametxt.Multiline = false;
            ItemNametxt.Name = "ItemNametxt";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            ItemNametxt.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            ItemNametxt.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            ItemNametxt.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.Empty;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            ItemNametxt.OnIdleState = stateProperties4;
            ItemNametxt.Padding = new Padding(3);
            ItemNametxt.PasswordChar = '\0';
            ItemNametxt.PlaceholderForeColor = Color.Silver;
            ItemNametxt.PlaceholderText = "Item name";
            ItemNametxt.ReadOnly = false;
            ItemNametxt.ScrollBars = ScrollBars.None;
            ItemNametxt.SelectedText = "";
            ItemNametxt.SelectionLength = 0;
            ItemNametxt.SelectionStart = 0;
            ItemNametxt.ShortcutsEnabled = true;
            ItemNametxt.Size = new Size(162, 39);
            ItemNametxt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            ItemNametxt.TabIndex = 10;
            ItemNametxt.TextAlign = HorizontalAlignment.Left;
            ItemNametxt.TextMarginBottom = 0;
            ItemNametxt.TextMarginLeft = 3;
            ItemNametxt.TextMarginTop = 1;
            ItemNametxt.TextPlaceholder = "Item name";
            ItemNametxt.UseSystemPasswordChar = false;
            ItemNametxt.WordWrap = true;
            // 
            // ItemPricetxt
            // 
            ItemPricetxt.AcceptsReturn = false;
            ItemPricetxt.AcceptsTab = false;
            ItemPricetxt.AnimationSpeed = 200;
            ItemPricetxt.AutoCompleteMode = AutoCompleteMode.None;
            ItemPricetxt.AutoCompleteSource = AutoCompleteSource.None;
            ItemPricetxt.AutoSizeHeight = true;
            ItemPricetxt.BackColor = Color.Transparent;
            ItemPricetxt.BackgroundImage = (Image)resources.GetObject("ItemPricetxt.BackgroundImage");
            ItemPricetxt.BorderColorActive = Color.DodgerBlue;
            ItemPricetxt.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            ItemPricetxt.BorderColorHover = Color.FromArgb(105, 181, 255);
            ItemPricetxt.BorderColorIdle = Color.Silver;
            ItemPricetxt.BorderRadius = 1;
            ItemPricetxt.BorderThickness = 1;
            ItemPricetxt.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            ItemPricetxt.CharacterCasing = CharacterCasing.Normal;
            ItemPricetxt.DefaultFont = new Font("Segoe UI", 9.25F);
            ItemPricetxt.DefaultText = "";
            ItemPricetxt.FillColor = Color.White;
            ItemPricetxt.HideSelection = true;
            ItemPricetxt.IconLeft = null;
            ItemPricetxt.IconLeftCursor = Cursors.IBeam;
            ItemPricetxt.IconPadding = 10;
            ItemPricetxt.IconRight = null;
            ItemPricetxt.IconRightCursor = Cursors.IBeam;
            ItemPricetxt.Location = new Point(248, 85);
            ItemPricetxt.MaxLength = 32767;
            ItemPricetxt.MinimumSize = new Size(1, 1);
            ItemPricetxt.Modified = false;
            ItemPricetxt.Multiline = false;
            ItemPricetxt.Name = "ItemPricetxt";
            stateProperties5.BorderColor = Color.DodgerBlue;
            stateProperties5.FillColor = Color.Empty;
            stateProperties5.ForeColor = Color.Empty;
            stateProperties5.PlaceholderForeColor = Color.Empty;
            ItemPricetxt.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties6.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties6.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties6.PlaceholderForeColor = Color.DarkGray;
            ItemPricetxt.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties7.FillColor = Color.Empty;
            stateProperties7.ForeColor = Color.Empty;
            stateProperties7.PlaceholderForeColor = Color.Empty;
            ItemPricetxt.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = Color.Silver;
            stateProperties8.FillColor = Color.White;
            stateProperties8.ForeColor = Color.Empty;
            stateProperties8.PlaceholderForeColor = Color.Empty;
            ItemPricetxt.OnIdleState = stateProperties8;
            ItemPricetxt.Padding = new Padding(3);
            ItemPricetxt.PasswordChar = '\0';
            ItemPricetxt.PlaceholderForeColor = Color.Silver;
            ItemPricetxt.PlaceholderText = "Item Price";
            ItemPricetxt.ReadOnly = false;
            ItemPricetxt.ScrollBars = ScrollBars.None;
            ItemPricetxt.SelectedText = "";
            ItemPricetxt.SelectionLength = 0;
            ItemPricetxt.SelectionStart = 0;
            ItemPricetxt.ShortcutsEnabled = true;
            ItemPricetxt.Size = new Size(162, 39);
            ItemPricetxt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            ItemPricetxt.TabIndex = 11;
            ItemPricetxt.TextAlign = HorizontalAlignment.Left;
            ItemPricetxt.TextMarginBottom = 0;
            ItemPricetxt.TextMarginLeft = 3;
            ItemPricetxt.TextMarginTop = 1;
            ItemPricetxt.TextPlaceholder = "Item Price";
            ItemPricetxt.UseSystemPasswordChar = false;
            ItemPricetxt.WordWrap = true;
            // 
            // ItemModalForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 260);
            Controls.Add(ItemPricetxt);
            Controls.Add(ItemNametxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ItemModalForm";
            Load += AddItemModal_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Bunifu.UI.WinForms.BunifuTextBox ItemNametxt;
        private Bunifu.UI.WinForms.BunifuTextBox ItemPricetxt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AddItemButton;
        private Bunifu.UI.WinForms.BunifuImageButton CloseModal;
    }
}