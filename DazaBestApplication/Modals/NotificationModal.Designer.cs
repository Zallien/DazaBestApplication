namespace DazaBestApplication.Modals
{
    partial class NotificationModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationModal));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            panel1 = new Panel();
            TitleLabel = new Label();
            detailslabel = new Label();
            YesButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(TitleLabel);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 0, 10, 0);
            panel1.Size = new Size(360, 40);
            panel1.TabIndex = 1;
            // 
            // TitleLabel
            // 
            TitleLabel.Dock = DockStyle.Fill;
            TitleLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(10, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(340, 40);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "System";
            TitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // detailslabel
            // 
            detailslabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            detailslabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            detailslabel.Location = new Point(6, 61);
            detailslabel.Name = "detailslabel";
            detailslabel.Size = new Size(348, 84);
            detailslabel.TabIndex = 2;
            detailslabel.Text = "Do you want to ...";
            detailslabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // YesButton
            // 
            YesButton.AllowAnimations = true;
            YesButton.AllowMouseEffects = true;
            YesButton.AllowToggling = false;
            YesButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            YesButton.AnimationSpeed = 200;
            YesButton.AutoGenerateColors = false;
            YesButton.AutoRoundBorders = false;
            YesButton.AutoSizeLeftIcon = true;
            YesButton.AutoSizeRightIcon = true;
            YesButton.BackColor = Color.Transparent;
            YesButton.BackColor1 = Color.FromArgb(51, 122, 183);
            YesButton.BackgroundImage = (Image)resources.GetObject("YesButton.BackgroundImage");
            YesButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            YesButton.ButtonText = "Ok";
            YesButton.ButtonTextMarginLeft = 0;
            YesButton.ColorContrastOnClick = 45;
            YesButton.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            YesButton.CustomizableEdges = borderEdges1;
            YesButton.DialogResult = DialogResult.None;
            YesButton.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            YesButton.DisabledFillColor = Color.Empty;
            YesButton.DisabledForecolor = Color.Empty;
            YesButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            YesButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YesButton.ForeColor = Color.White;
            YesButton.IconLeft = null;
            YesButton.IconLeftAlign = ContentAlignment.MiddleLeft;
            YesButton.IconLeftCursor = Cursors.Default;
            YesButton.IconLeftPadding = new Padding(11, 3, 3, 3);
            YesButton.IconMarginLeft = 11;
            YesButton.IconPadding = 10;
            YesButton.IconRight = null;
            YesButton.IconRightAlign = ContentAlignment.MiddleRight;
            YesButton.IconRightCursor = Cursors.Default;
            YesButton.IconRightPadding = new Padding(3, 3, 7, 3);
            YesButton.IconSize = 25;
            YesButton.IdleBorderColor = Color.Empty;
            YesButton.IdleBorderRadius = 0;
            YesButton.IdleBorderThickness = 0;
            YesButton.IdleFillColor = Color.Empty;
            YesButton.IdleIconLeftImage = null;
            YesButton.IdleIconRightImage = null;
            YesButton.IndicateFocus = false;
            YesButton.Location = new Point(268, 149);
            YesButton.Name = "YesButton";
            YesButton.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            YesButton.OnDisabledState.BorderRadius = 0;
            YesButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            YesButton.OnDisabledState.BorderThickness = 0;
            YesButton.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            YesButton.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            YesButton.OnDisabledState.IconLeftImage = null;
            YesButton.OnDisabledState.IconRightImage = null;
            YesButton.onHoverState.BorderColor = Color.FromArgb(50, 110, 5);
            YesButton.onHoverState.BorderRadius = 0;
            YesButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            YesButton.onHoverState.BorderThickness = 0;
            YesButton.onHoverState.FillColor = Color.FromArgb(50, 110, 5);
            YesButton.onHoverState.ForeColor = Color.White;
            YesButton.onHoverState.IconLeftImage = null;
            YesButton.onHoverState.IconRightImage = null;
            YesButton.OnIdleState.BorderColor = Color.FromArgb(78, 160, 21);
            YesButton.OnIdleState.BorderRadius = 0;
            YesButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            YesButton.OnIdleState.BorderThickness = 0;
            YesButton.OnIdleState.FillColor = Color.FromArgb(78, 160, 21);
            YesButton.OnIdleState.ForeColor = Color.White;
            YesButton.OnIdleState.IconLeftImage = null;
            YesButton.OnIdleState.IconRightImage = null;
            YesButton.OnPressedState.BorderColor = Color.FromArgb(50, 110, 5);
            YesButton.OnPressedState.BorderRadius = 0;
            YesButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            YesButton.OnPressedState.BorderThickness = 0;
            YesButton.OnPressedState.FillColor = Color.FromArgb(50, 110, 5);
            YesButton.OnPressedState.ForeColor = Color.White;
            YesButton.OnPressedState.IconLeftImage = null;
            YesButton.OnPressedState.IconRightImage = null;
            YesButton.Size = new Size(86, 26);
            YesButton.TabIndex = 3;
            YesButton.TextAlign = ContentAlignment.MiddleCenter;
            YesButton.TextAlignment = HorizontalAlignment.Center;
            YesButton.TextMarginLeft = 0;
            YesButton.TextPadding = new Padding(0);
            YesButton.UseDefaultRadiusAndThickness = true;
            YesButton.Click += YesButton_Click;
            // 
            // NotificationModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 187);
            Controls.Add(YesButton);
            Controls.Add(detailslabel);
            Controls.Add(panel1);
            Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NotificationModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NotificationModal";
            Load += NotificationModal_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label TitleLabel;
        private Label detailslabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton YesButton;
    }
}