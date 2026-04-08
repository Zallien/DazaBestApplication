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
            submitbutton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
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
            CloseModal.Click += CloseModal_Click;
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
            // submitbutton
            // 
            submitbutton.AllowAnimations = true;
            submitbutton.AllowMouseEffects = true;
            submitbutton.AllowToggling = false;
            submitbutton.AnimationSpeed = 200;
            submitbutton.AutoGenerateColors = false;
            submitbutton.AutoRoundBorders = false;
            submitbutton.AutoSizeLeftIcon = true;
            submitbutton.AutoSizeRightIcon = true;
            submitbutton.BackColor = Color.Transparent;
            submitbutton.BackColor1 = Color.FromArgb(51, 122, 183);
            submitbutton.BackgroundImage = (Image)resources.GetObject("submitbutton.BackgroundImage");
            submitbutton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            submitbutton.ButtonText = "Add Category";
            submitbutton.ButtonTextMarginLeft = 0;
            submitbutton.ColorContrastOnClick = 45;
            submitbutton.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            submitbutton.CustomizableEdges = borderEdges1;
            submitbutton.DialogResult = DialogResult.None;
            submitbutton.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            submitbutton.DisabledFillColor = Color.Empty;
            submitbutton.DisabledForecolor = Color.Empty;
            submitbutton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            submitbutton.Font = new Font("Segoe UI", 9F);
            submitbutton.ForeColor = Color.White;
            submitbutton.IconLeft = null;
            submitbutton.IconLeftAlign = ContentAlignment.MiddleLeft;
            submitbutton.IconLeftCursor = Cursors.Default;
            submitbutton.IconLeftPadding = new Padding(11, 3, 3, 3);
            submitbutton.IconMarginLeft = 11;
            submitbutton.IconPadding = 10;
            submitbutton.IconRight = null;
            submitbutton.IconRightAlign = ContentAlignment.MiddleRight;
            submitbutton.IconRightCursor = Cursors.Default;
            submitbutton.IconRightPadding = new Padding(3, 3, 7, 3);
            submitbutton.IconSize = 25;
            submitbutton.IdleBorderColor = Color.Empty;
            submitbutton.IdleBorderRadius = 0;
            submitbutton.IdleBorderThickness = 0;
            submitbutton.IdleFillColor = Color.Empty;
            submitbutton.IdleIconLeftImage = null;
            submitbutton.IdleIconRightImage = null;
            submitbutton.IndicateFocus = false;
            submitbutton.Location = new Point(235, 153);
            submitbutton.Name = "submitbutton";
            submitbutton.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            submitbutton.OnDisabledState.BorderRadius = 1;
            submitbutton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            submitbutton.OnDisabledState.BorderThickness = 1;
            submitbutton.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            submitbutton.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            submitbutton.OnDisabledState.IconLeftImage = null;
            submitbutton.OnDisabledState.IconRightImage = null;
            submitbutton.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            submitbutton.onHoverState.BorderRadius = 1;
            submitbutton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            submitbutton.onHoverState.BorderThickness = 1;
            submitbutton.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
            submitbutton.onHoverState.ForeColor = Color.White;
            submitbutton.onHoverState.IconLeftImage = null;
            submitbutton.onHoverState.IconRightImage = null;
            submitbutton.OnIdleState.BorderColor = Color.DodgerBlue;
            submitbutton.OnIdleState.BorderRadius = 1;
            submitbutton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            submitbutton.OnIdleState.BorderThickness = 1;
            submitbutton.OnIdleState.FillColor = Color.DodgerBlue;
            submitbutton.OnIdleState.ForeColor = Color.White;
            submitbutton.OnIdleState.IconLeftImage = null;
            submitbutton.OnIdleState.IconRightImage = null;
            submitbutton.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            submitbutton.OnPressedState.BorderRadius = 1;
            submitbutton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            submitbutton.OnPressedState.BorderThickness = 1;
            submitbutton.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            submitbutton.OnPressedState.ForeColor = Color.White;
            submitbutton.OnPressedState.IconLeftImage = null;
            submitbutton.OnPressedState.IconRightImage = null;
            submitbutton.Size = new Size(150, 32);
            submitbutton.TabIndex = 5;
            submitbutton.TextAlign = ContentAlignment.MiddleCenter;
            submitbutton.TextAlignment = HorizontalAlignment.Center;
            submitbutton.TextMarginLeft = 0;
            submitbutton.TextPadding = new Padding(0);
            submitbutton.UseDefaultRadiusAndThickness = true;
            submitbutton.Click += bunifuButton1_Click;
            // 
            // BusinessModalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 197);
            Controls.Add(submitbutton);
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton submitbutton;
    }
}