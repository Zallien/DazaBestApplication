namespace DazaBestApplication.Modals
{
    partial class BusinessModalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessModalForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            panel1 = new Panel();
            panel3 = new Panel();
            CloseModal = new Bunifu.UI.WinForms.BunifuImageButton();
            modaltitletext = new Label();
            BusinessTypeTxt = new Bunifu.UI.WinForms.BunifuTextBox();
            label1 = new Label();
            bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(CloseModal);
            panel1.Controls.Add(modaltitletext);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 40);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Maroon;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(395, 5);
            panel3.TabIndex = 3;
            // 
            // CloseModal
            // 
            CloseModal.ActiveImage = null;
            CloseModal.AllowAnimations = true;
            CloseModal.AllowBuffering = false;
            CloseModal.AllowToggling = false;
            CloseModal.AllowZooming = true;
            CloseModal.AllowZoomingOnFocus = false;
            CloseModal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseModal.BackColor = Color.Transparent;
            CloseModal.DialogResult = DialogResult.None;
            CloseModal.ErrorImage = (Image)resources.GetObject("CloseModal.ErrorImage");
            CloseModal.FadeWhenInactive = false;
            CloseModal.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            CloseModal.Image = Properties.Resources.close;
            CloseModal.ImageActive = null;
            CloseModal.ImageLocation = null;
            CloseModal.ImageMargin = 23;
            CloseModal.ImageSize = new Size(7, 7);
            CloseModal.ImageZoomSize = new Size(30, 30);
            CloseModal.InitialImage = (Image)resources.GetObject("CloseModal.InitialImage");
            CloseModal.Location = new Point(362, 3);
            CloseModal.Name = "CloseModal";
            CloseModal.Rotation = 0;
            CloseModal.ShowActiveImage = true;
            CloseModal.ShowCursorChanges = true;
            CloseModal.ShowImageBorders = true;
            CloseModal.ShowSizeMarkers = false;
            CloseModal.Size = new Size(30, 30);
            CloseModal.TabIndex = 1;
            CloseModal.ToolTipText = "";
            CloseModal.WaitOnLoad = false;
            CloseModal.Zoom = 23;
            CloseModal.ZoomSpeed = 10;
            // 
            // modaltitletext
            // 
            modaltitletext.BackColor = Color.Transparent;
            modaltitletext.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modaltitletext.Location = new Point(10, 0);
            modaltitletext.Name = "modaltitletext";
            modaltitletext.Size = new Size(198, 33);
            modaltitletext.TabIndex = 0;
            modaltitletext.Text = "Add Business";
            modaltitletext.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BusinessTypeTxt
            // 
            BusinessTypeTxt.AcceptsReturn = false;
            BusinessTypeTxt.AcceptsTab = false;
            BusinessTypeTxt.AnimationSpeed = 200;
            BusinessTypeTxt.AutoCompleteMode = AutoCompleteMode.None;
            BusinessTypeTxt.AutoCompleteSource = AutoCompleteSource.None;
            BusinessTypeTxt.AutoSizeHeight = true;
            BusinessTypeTxt.BackColor = Color.Transparent;
            BusinessTypeTxt.BackgroundImage = (Image)resources.GetObject("BusinessTypeTxt.BackgroundImage");
            BusinessTypeTxt.BorderColorActive = Color.DodgerBlue;
            BusinessTypeTxt.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            BusinessTypeTxt.BorderColorHover = Color.FromArgb(105, 181, 255);
            BusinessTypeTxt.BorderColorIdle = Color.Silver;
            BusinessTypeTxt.BorderRadius = 1;
            BusinessTypeTxt.BorderThickness = 1;
            BusinessTypeTxt.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            BusinessTypeTxt.CharacterCasing = CharacterCasing.Normal;
            BusinessTypeTxt.DefaultFont = new Font("Segoe UI", 9.25F);
            BusinessTypeTxt.DefaultText = "";
            BusinessTypeTxt.FillColor = Color.White;
            BusinessTypeTxt.HideSelection = true;
            BusinessTypeTxt.IconLeft = null;
            BusinessTypeTxt.IconLeftCursor = Cursors.IBeam;
            BusinessTypeTxt.IconPadding = 10;
            BusinessTypeTxt.IconRight = null;
            BusinessTypeTxt.IconRightCursor = Cursors.IBeam;
            BusinessTypeTxt.Location = new Point(181, 58);
            BusinessTypeTxt.MaxLength = 32767;
            BusinessTypeTxt.MinimumSize = new Size(1, 1);
            BusinessTypeTxt.Modified = false;
            BusinessTypeTxt.Multiline = false;
            BusinessTypeTxt.Name = "BusinessTypeTxt";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            BusinessTypeTxt.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            BusinessTypeTxt.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            BusinessTypeTxt.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.Empty;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            BusinessTypeTxt.OnIdleState = stateProperties4;
            BusinessTypeTxt.Padding = new Padding(3);
            BusinessTypeTxt.PasswordChar = '\0';
            BusinessTypeTxt.PlaceholderForeColor = Color.Silver;
            BusinessTypeTxt.PlaceholderText = "Enter text";
            BusinessTypeTxt.ReadOnly = false;
            BusinessTypeTxt.ScrollBars = ScrollBars.None;
            BusinessTypeTxt.SelectedText = "";
            BusinessTypeTxt.SelectionLength = 0;
            BusinessTypeTxt.SelectionStart = 0;
            BusinessTypeTxt.ShortcutsEnabled = true;
            BusinessTypeTxt.Size = new Size(204, 39);
            BusinessTypeTxt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            BusinessTypeTxt.TabIndex = 3;
            BusinessTypeTxt.TextAlign = HorizontalAlignment.Left;
            BusinessTypeTxt.TextMarginBottom = 0;
            BusinessTypeTxt.TextMarginLeft = 3;
            BusinessTypeTxt.TextMarginTop = 1;
            BusinessTypeTxt.TextPlaceholder = "Enter text";
            BusinessTypeTxt.UseSystemPasswordChar = false;
            BusinessTypeTxt.WordWrap = true;
            // 
            // label1
            // 
            label1.Font = new Font("Courier New", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 58);
            label1.Name = "label1";
            label1.Size = new Size(165, 30);
            label1.TabIndex = 4;
            label1.Text = "Business Name: ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bunifuButton1
            // 
            bunifuButton1.AllowAnimations = true;
            bunifuButton1.AllowMouseEffects = true;
            bunifuButton1.AllowToggling = false;
            bunifuButton1.AnimationSpeed = 200;
            bunifuButton1.AutoGenerateColors = false;
            bunifuButton1.AutoRoundBorders = false;
            bunifuButton1.AutoSizeLeftIcon = true;
            bunifuButton1.AutoSizeRightIcon = true;
            bunifuButton1.BackColor = Color.Transparent;
            bunifuButton1.BackColor1 = Color.FromArgb(51, 122, 183);
            bunifuButton1.BackgroundImage = (Image)resources.GetObject("bunifuButton1.BackgroundImage");
            bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuButton1.ButtonText = "Add Category";
            bunifuButton1.ButtonTextMarginLeft = 0;
            bunifuButton1.ColorContrastOnClick = 45;
            bunifuButton1.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            bunifuButton1.CustomizableEdges = borderEdges1;
            bunifuButton1.DialogResult = DialogResult.None;
            bunifuButton1.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton1.DisabledFillColor = Color.Empty;
            bunifuButton1.DisabledForecolor = Color.Empty;
            bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            bunifuButton1.Font = new Font("Segoe UI", 9F);
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
            bunifuButton1.Location = new Point(235, 153);
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
            bunifuButton1.Size = new Size(150, 32);
            bunifuButton1.TabIndex = 5;
            bunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton1.TextAlignment = HorizontalAlignment.Center;
            bunifuButton1.TextMarginLeft = 0;
            bunifuButton1.TextPadding = new Padding(0);
            bunifuButton1.UseDefaultRadiusAndThickness = true;
            bunifuButton1.Click += bunifuButton1_Click;
            // 
            // BusinessModalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 197);
            Controls.Add(bunifuButton1);
            Controls.Add(label1);
            Controls.Add(BusinessTypeTxt);
            Controls.Add(panel1);
            Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BusinessModalForm";
            Text = "BusinessModalForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Bunifu.UI.WinForms.BunifuImageButton CloseModal;
        private Label modaltitletext;
        private Bunifu.UI.WinForms.BunifuTextBox BusinessTypeTxt;
        private Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
    }
}