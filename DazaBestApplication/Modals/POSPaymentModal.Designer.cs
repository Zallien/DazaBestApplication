namespace DazaBestApplication.Modals
{
    partial class POSPaymentModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSPaymentModal));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Toppanel = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Totalvaluetext = new Label();
            bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextBox();
            Changelabel = new Label();
            bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            Toppanel.SuspendLayout();
            SuspendLayout();
            // 
            // Toppanel
            // 
            Toppanel.BackColor = Color.FromArgb(255, 128, 0);
            Toppanel.Controls.Add(label1);
            Toppanel.Dock = DockStyle.Top;
            Toppanel.Location = new Point(0, 0);
            Toppanel.Name = "Toppanel";
            Toppanel.Size = new Size(370, 30);
            Toppanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 0;
            label1.Text = "Payment";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(100, 30);
            label2.TabIndex = 1;
            label2.Text = "Total :";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 80);
            label3.Name = "label3";
            label3.Size = new Size(100, 30);
            label3.TabIndex = 2;
            label3.Text = "Payment :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 110);
            label4.Name = "label4";
            label4.Size = new Size(100, 30);
            label4.TabIndex = 3;
            label4.Text = "Change :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Totalvaluetext
            // 
            Totalvaluetext.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Totalvaluetext.Location = new Point(118, 50);
            Totalvaluetext.Name = "Totalvaluetext";
            Totalvaluetext.Size = new Size(209, 30);
            Totalvaluetext.TabIndex = 4;
            Totalvaluetext.Text = "0.00";
            Totalvaluetext.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bunifuTextBox1
            // 
            bunifuTextBox1.AcceptsReturn = false;
            bunifuTextBox1.AcceptsTab = false;
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
            bunifuTextBox1.Location = new Point(118, 80);
            bunifuTextBox1.MaxLength = 32767;
            bunifuTextBox1.MinimumSize = new Size(1, 1);
            bunifuTextBox1.Modified = false;
            bunifuTextBox1.Multiline = false;
            bunifuTextBox1.Name = "bunifuTextBox1";
            stateProperties9.BorderColor = Color.DodgerBlue;
            stateProperties9.FillColor = Color.Empty;
            stateProperties9.ForeColor = Color.Empty;
            stateProperties9.PlaceholderForeColor = Color.Empty;
            bunifuTextBox1.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties10.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties10.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties10.PlaceholderForeColor = Color.DarkGray;
            bunifuTextBox1.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties11.FillColor = Color.Empty;
            stateProperties11.ForeColor = Color.Empty;
            stateProperties11.PlaceholderForeColor = Color.Empty;
            bunifuTextBox1.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = Color.Silver;
            stateProperties12.FillColor = Color.White;
            stateProperties12.ForeColor = Color.Empty;
            stateProperties12.PlaceholderForeColor = Color.Empty;
            bunifuTextBox1.OnIdleState = stateProperties12;
            bunifuTextBox1.Padding = new Padding(3);
            bunifuTextBox1.PasswordChar = '\0';
            bunifuTextBox1.PlaceholderForeColor = Color.Silver;
            bunifuTextBox1.PlaceholderText = "0.000";
            bunifuTextBox1.ReadOnly = false;
            bunifuTextBox1.ScrollBars = ScrollBars.None;
            bunifuTextBox1.SelectedText = "";
            bunifuTextBox1.SelectionLength = 0;
            bunifuTextBox1.SelectionStart = 0;
            bunifuTextBox1.ShortcutsEnabled = true;
            bunifuTextBox1.Size = new Size(209, 39);
            bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            bunifuTextBox1.TabIndex = 5;
            bunifuTextBox1.TextAlign = HorizontalAlignment.Left;
            bunifuTextBox1.TextMarginBottom = 0;
            bunifuTextBox1.TextMarginLeft = 3;
            bunifuTextBox1.TextMarginTop = 1;
            bunifuTextBox1.TextPlaceholder = "0.000";
            bunifuTextBox1.UseSystemPasswordChar = false;
            bunifuTextBox1.WordWrap = true;
            // 
            // Changelabel
            // 
            Changelabel.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Changelabel.Location = new Point(118, 110);
            Changelabel.Name = "Changelabel";
            Changelabel.Size = new Size(209, 30);
            Changelabel.TabIndex = 6;
            Changelabel.Text = "0.00";
            Changelabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bunifuButton1
            // 
            bunifuButton1.AllowAnimations = true;
            bunifuButton1.AllowMouseEffects = true;
            bunifuButton1.AllowToggling = false;
            bunifuButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bunifuButton1.AnimationSpeed = 200;
            bunifuButton1.AutoGenerateColors = false;
            bunifuButton1.AutoRoundBorders = false;
            bunifuButton1.AutoSizeLeftIcon = true;
            bunifuButton1.AutoSizeRightIcon = true;
            bunifuButton1.BackColor = Color.Transparent;
            bunifuButton1.BackColor1 = Color.FromArgb(51, 122, 183);
            bunifuButton1.BackgroundImage = (Image)resources.GetObject("bunifuButton1.BackgroundImage");
            bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.ButtonText = "Pay";
            bunifuButton1.ButtonTextMarginLeft = 0;
            bunifuButton1.ColorContrastOnClick = 45;
            bunifuButton1.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            bunifuButton1.CustomizableEdges = borderEdges3;
            bunifuButton1.DialogResult = DialogResult.None;
            bunifuButton1.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton1.DisabledFillColor = Color.Empty;
            bunifuButton1.DisabledForecolor = Color.Empty;
            bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            bunifuButton1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuButton1.ForeColor = Color.White;
            bunifuButton1.IconLeft = null;
            bunifuButton1.IconLeftAlign = ContentAlignment.MiddleLeft;
            bunifuButton1.IconLeftCursor = Cursors.Default;
            bunifuButton1.IconLeftPadding = new Padding(11, 3, 3, 3);
            bunifuButton1.IconMarginLeft = 11;
            bunifuButton1.IconPadding = 10;
            bunifuButton1.IconRight = null;
            bunifuButton1.IconRightAlign = ContentAlignment.MiddleRight;
            bunifuButton1.IconRightCursor = Cursors.Default;
            bunifuButton1.IconRightPadding = new Padding(3, 3, 7, 3);
            bunifuButton1.IconSize = 25;
            bunifuButton1.IdleBorderColor = Color.Empty;
            bunifuButton1.IdleBorderRadius = 0;
            bunifuButton1.IdleBorderThickness = 0;
            bunifuButton1.IdleFillColor = Color.Empty;
            bunifuButton1.IdleIconLeftImage = null;
            bunifuButton1.IdleIconRightImage = null;
            bunifuButton1.IndicateFocus = false;
            bunifuButton1.Location = new Point(56, 178);
            bunifuButton1.Name = "bunifuButton1";
            bunifuButton1.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton1.OnDisabledState.BorderRadius = 1;
            bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.OnDisabledState.BorderThickness = 1;
            bunifuButton1.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            bunifuButton1.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunifuButton1.OnDisabledState.IconLeftImage = null;
            bunifuButton1.OnDisabledState.IconRightImage = null;
            bunifuButton1.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            bunifuButton1.onHoverState.BorderRadius = 1;
            bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.onHoverState.BorderThickness = 1;
            bunifuButton1.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            bunifuButton1.onHoverState.ForeColor = Color.White;
            bunifuButton1.onHoverState.IconLeftImage = null;
            bunifuButton1.onHoverState.IconRightImage = null;
            bunifuButton1.OnIdleState.BorderColor = Color.DodgerBlue;
            bunifuButton1.OnIdleState.BorderRadius = 1;
            bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.OnIdleState.BorderThickness = 1;
            bunifuButton1.OnIdleState.FillColor = Color.DodgerBlue;
            bunifuButton1.OnIdleState.ForeColor = Color.White;
            bunifuButton1.OnIdleState.IconLeftImage = null;
            bunifuButton1.OnIdleState.IconRightImage = null;
            bunifuButton1.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            bunifuButton1.OnPressedState.BorderRadius = 1;
            bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.OnPressedState.BorderThickness = 1;
            bunifuButton1.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            bunifuButton1.OnPressedState.ForeColor = Color.White;
            bunifuButton1.OnPressedState.IconLeftImage = null;
            bunifuButton1.OnPressedState.IconRightImage = null;
            bunifuButton1.Size = new Size(302, 30);
            bunifuButton1.TabIndex = 7;
            bunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton1.TextAlignment = HorizontalAlignment.Center;
            bunifuButton1.TextMarginLeft = 0;
            bunifuButton1.TextPadding = new Padding(0);
            bunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuImageButton1
            // 
            bunifuImageButton1.ActiveImage = null;
            bunifuImageButton1.AllowAnimations = true;
            bunifuImageButton1.AllowBuffering = false;
            bunifuImageButton1.AllowToggling = false;
            bunifuImageButton1.AllowZooming = true;
            bunifuImageButton1.AllowZoomingOnFocus = false;
            bunifuImageButton1.BackColor = Color.Transparent;
            bunifuImageButton1.DialogResult = DialogResult.None;
            bunifuImageButton1.ErrorImage = (Image)resources.GetObject("bunifuImageButton1.ErrorImage");
            bunifuImageButton1.FadeWhenInactive = false;
            bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            bunifuImageButton1.Image = Properties.Resources.cancel;
            bunifuImageButton1.ImageActive = null;
            bunifuImageButton1.ImageLocation = null;
            bunifuImageButton1.ImageMargin = 10;
            bunifuImageButton1.ImageSize = new Size(20, 20);
            bunifuImageButton1.ImageZoomSize = new Size(30, 30);
            bunifuImageButton1.InitialImage = (Image)resources.GetObject("bunifuImageButton1.InitialImage");
            bunifuImageButton1.Location = new Point(12, 178);
            bunifuImageButton1.Name = "bunifuImageButton1";
            bunifuImageButton1.Rotation = 0;
            bunifuImageButton1.ShowActiveImage = true;
            bunifuImageButton1.ShowCursorChanges = true;
            bunifuImageButton1.ShowImageBorders = true;
            bunifuImageButton1.ShowSizeMarkers = false;
            bunifuImageButton1.Size = new Size(30, 30);
            bunifuImageButton1.TabIndex = 8;
            bunifuImageButton1.ToolTipText = "";
            bunifuImageButton1.WaitOnLoad = false;
            bunifuImageButton1.Zoom = 10;
            bunifuImageButton1.ZoomSpeed = 10;
            // 
            // POSPaymentModal
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 220);
            Controls.Add(bunifuImageButton1);
            Controls.Add(bunifuButton1);
            Controls.Add(Changelabel);
            Controls.Add(bunifuTextBox1);
            Controls.Add(Totalvaluetext);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Toppanel);
            Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "POSPaymentModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "POSPaymentModal";
            Load += POSPaymentModal_Load;
            Toppanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Toppanel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Totalvaluetext;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        private Label Changelabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
    }
}