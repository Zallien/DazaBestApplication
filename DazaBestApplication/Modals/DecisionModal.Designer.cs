namespace DazaBestApplication.Modals
{
    partial class DecisionModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecisionModal));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            panel1 = new Panel();
            TitleLabel = new Label();
            QuestionLabel = new Label();
            YesButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            NoButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(TitleLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 0, 10, 0);
            panel1.Size = new Size(370, 40);
            panel1.TabIndex = 0;
            // 
            // TitleLabel
            // 
            TitleLabel.Dock = DockStyle.Left;
            TitleLabel.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(10, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(168, 40);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "System";
            TitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // QuestionLabel
            // 
            QuestionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            QuestionLabel.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuestionLabel.Location = new Point(10, 61);
            QuestionLabel.Name = "QuestionLabel";
            QuestionLabel.Size = new Size(348, 64);
            QuestionLabel.TabIndex = 1;
            QuestionLabel.Text = "Do you want to ...";
            QuestionLabel.TextAlign = ContentAlignment.MiddleLeft;
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
            YesButton.ButtonText = "Yes";
            YesButton.ButtonTextMarginLeft = 0;
            YesButton.ColorContrastOnClick = 45;
            YesButton.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            YesButton.CustomizableEdges = borderEdges3;
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
            YesButton.Location = new Point(180, 132);
            YesButton.Name = "YesButton";
            YesButton.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            YesButton.OnDisabledState.BorderRadius = 0;
            YesButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            YesButton.OnDisabledState.BorderThickness = 0;
            YesButton.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            YesButton.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            YesButton.OnDisabledState.IconLeftImage = null;
            YesButton.OnDisabledState.IconRightImage = null;
            YesButton.onHoverState.BorderColor = Color.FromArgb(255, 128, 0);
            YesButton.onHoverState.BorderRadius = 0;
            YesButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            YesButton.onHoverState.BorderThickness = 0;
            YesButton.onHoverState.FillColor = Color.FromArgb(255, 128, 0);
            YesButton.onHoverState.ForeColor = Color.White;
            YesButton.onHoverState.IconLeftImage = null;
            YesButton.onHoverState.IconRightImage = null;
            YesButton.OnIdleState.BorderColor = Color.FromArgb(255, 128, 0);
            YesButton.OnIdleState.BorderRadius = 0;
            YesButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            YesButton.OnIdleState.BorderThickness = 0;
            YesButton.OnIdleState.FillColor = Color.FromArgb(192, 64, 0);
            YesButton.OnIdleState.ForeColor = Color.White;
            YesButton.OnIdleState.IconLeftImage = null;
            YesButton.OnIdleState.IconRightImage = null;
            YesButton.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            YesButton.OnPressedState.BorderRadius = 0;
            YesButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            YesButton.OnPressedState.BorderThickness = 0;
            YesButton.OnPressedState.FillColor = Color.FromArgb(255, 192, 128);
            YesButton.OnPressedState.ForeColor = Color.White;
            YesButton.OnPressedState.IconLeftImage = null;
            YesButton.OnPressedState.IconRightImage = null;
            YesButton.Size = new Size(86, 26);
            YesButton.TabIndex = 2;
            YesButton.TextAlign = ContentAlignment.MiddleCenter;
            YesButton.TextAlignment = HorizontalAlignment.Center;
            YesButton.TextMarginLeft = 0;
            YesButton.TextPadding = new Padding(0);
            YesButton.UseDefaultRadiusAndThickness = true;
            // 
            // NoButton
            // 
            NoButton.AllowAnimations = true;
            NoButton.AllowMouseEffects = true;
            NoButton.AllowToggling = false;
            NoButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NoButton.AnimationSpeed = 200;
            NoButton.AutoGenerateColors = false;
            NoButton.AutoRoundBorders = false;
            NoButton.AutoSizeLeftIcon = true;
            NoButton.AutoSizeRightIcon = true;
            NoButton.BackColor = Color.Transparent;
            NoButton.BackColor1 = Color.FromArgb(51, 122, 183);
            NoButton.BackgroundImage = (Image)resources.GetObject("NoButton.BackgroundImage");
            NoButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            NoButton.ButtonText = "No";
            NoButton.ButtonTextMarginLeft = 0;
            NoButton.ColorContrastOnClick = 45;
            NoButton.ColorContrastOnHover = 45;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            NoButton.CustomizableEdges = borderEdges4;
            NoButton.DialogResult = DialogResult.None;
            NoButton.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            NoButton.DisabledFillColor = Color.Empty;
            NoButton.DisabledForecolor = Color.Empty;
            NoButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            NoButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NoButton.ForeColor = Color.White;
            NoButton.IconLeft = null;
            NoButton.IconLeftAlign = ContentAlignment.MiddleLeft;
            NoButton.IconLeftCursor = Cursors.Default;
            NoButton.IconLeftPadding = new Padding(11, 3, 3, 3);
            NoButton.IconMarginLeft = 11;
            NoButton.IconPadding = 10;
            NoButton.IconRight = null;
            NoButton.IconRightAlign = ContentAlignment.MiddleRight;
            NoButton.IconRightCursor = Cursors.Default;
            NoButton.IconRightPadding = new Padding(3, 3, 7, 3);
            NoButton.IconSize = 25;
            NoButton.IdleBorderColor = Color.Empty;
            NoButton.IdleBorderRadius = 0;
            NoButton.IdleBorderThickness = 0;
            NoButton.IdleFillColor = Color.Empty;
            NoButton.IdleIconLeftImage = null;
            NoButton.IdleIconRightImage = null;
            NoButton.IndicateFocus = false;
            NoButton.Location = new Point(272, 132);
            NoButton.Name = "NoButton";
            NoButton.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            NoButton.OnDisabledState.BorderRadius = 0;
            NoButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            NoButton.OnDisabledState.BorderThickness = 0;
            NoButton.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            NoButton.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            NoButton.OnDisabledState.IconLeftImage = null;
            NoButton.OnDisabledState.IconRightImage = null;
            NoButton.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
            NoButton.onHoverState.BorderRadius = 0;
            NoButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            NoButton.onHoverState.BorderThickness = 0;
            NoButton.onHoverState.FillColor = Color.FromArgb(192, 0, 0);
            NoButton.onHoverState.ForeColor = Color.White;
            NoButton.onHoverState.IconLeftImage = null;
            NoButton.onHoverState.IconRightImage = null;
            NoButton.OnIdleState.BorderColor = Color.Red;
            NoButton.OnIdleState.BorderRadius = 0;
            NoButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            NoButton.OnIdleState.BorderThickness = 0;
            NoButton.OnIdleState.FillColor = Color.Red;
            NoButton.OnIdleState.ForeColor = Color.White;
            NoButton.OnIdleState.IconLeftImage = null;
            NoButton.OnIdleState.IconRightImage = null;
            NoButton.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            NoButton.OnPressedState.BorderRadius = 0;
            NoButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            NoButton.OnPressedState.BorderThickness = 0;
            NoButton.OnPressedState.FillColor = Color.FromArgb(255, 128, 128);
            NoButton.OnPressedState.ForeColor = Color.White;
            NoButton.OnPressedState.IconLeftImage = null;
            NoButton.OnPressedState.IconRightImage = null;
            NoButton.Size = new Size(86, 26);
            NoButton.TabIndex = 3;
            NoButton.TextAlign = ContentAlignment.MiddleCenter;
            NoButton.TextAlignment = HorizontalAlignment.Center;
            NoButton.TextMarginLeft = 0;
            NoButton.TextPadding = new Padding(0);
            NoButton.UseDefaultRadiusAndThickness = true;
            // 
            // DecisionModal
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 170);
            Controls.Add(NoButton);
            Controls.Add(YesButton);
            Controls.Add(QuestionLabel);
            Controls.Add(panel1);
            Font = new Font("Cambria", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DecisionModal";
            Text = "DecisionModal";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label TitleLabel;
        private Label QuestionLabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton YesButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton NoButton;
    }
}