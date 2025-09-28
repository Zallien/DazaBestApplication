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
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            TopNav = new Panel();
            bunifuIconButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            FormControlBox = new Bunifu.UI.WinForms.BunifuFormControlBox();
            CompanyName = new Bunifu.UI.WinForms.BunifuLabel();
            SideNav = new Panel();
            bunifuButton21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            MainContainer = new Panel();
            FormDockandDrag = new Bunifu.UI.WinForms.BunifuFormDock();
            bunifuButton22 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            bunifuButton23 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            bunifuButton24 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            TopNav.SuspendLayout();
            SideNav.SuspendLayout();
            SuspendLayout();
            // 
            // TopNav
            // 
            TopNav.BackColor = Color.FromArgb(33, 33, 33);
            TopNav.Controls.Add(bunifuIconButton1);
            TopNav.Controls.Add(FormControlBox);
            TopNav.Controls.Add(CompanyName);
            TopNav.Dock = DockStyle.Top;
            TopNav.Location = new Point(0, 0);
            TopNav.Name = "TopNav";
            TopNav.Padding = new Padding(10, 0, 0, 0);
            TopNav.Size = new Size(1100, 30);
            TopNav.TabIndex = 2;
            // 
            // bunifuIconButton1
            // 
            bunifuIconButton1.AllowAnimations = true;
            bunifuIconButton1.AllowBorderColorChanges = true;
            bunifuIconButton1.AllowMouseEffects = true;
            bunifuIconButton1.AnimationSpeed = 200;
            bunifuIconButton1.BackColor = Color.Transparent;
            bunifuIconButton1.BackgroundColor = Color.Transparent;
            bunifuIconButton1.BorderColor = Color.Transparent;
            bunifuIconButton1.BorderRadius = 1;
            bunifuIconButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            bunifuIconButton1.BorderThickness = 1;
            bunifuIconButton1.ColorContrastOnClick = 30;
            bunifuIconButton1.ColorContrastOnHover = 30;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            bunifuIconButton1.CustomizableEdges = borderEdges1;
            bunifuIconButton1.DialogResult = DialogResult.None;
            bunifuIconButton1.Dock = DockStyle.Left;
            bunifuIconButton1.Image = Properties.Resources._477622848_2102876326812470_7082635694266922336_n;
            bunifuIconButton1.ImageMargin = new Padding(0);
            bunifuIconButton1.Location = new Point(10, 0);
            bunifuIconButton1.Name = "bunifuIconButton1";
            bunifuIconButton1.RoundBorders = false;
            bunifuIconButton1.ShowBorders = true;
            bunifuIconButton1.Size = new Size(30, 30);
            bunifuIconButton1.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Flat;
            bunifuIconButton1.TabIndex = 1;
            // 
            // FormControlBox
            // 
            FormControlBox.BackColor = Color.White;
            FormControlBox.BunifuFormDrag = null;
            FormControlBox.CloseBoxOptions.BackColor = Color.Transparent;
            FormControlBox.CloseBoxOptions.BorderRadius = 0;
            FormControlBox.CloseBoxOptions.Enabled = true;
            FormControlBox.CloseBoxOptions.EnableDefaultAction = true;
            FormControlBox.CloseBoxOptions.HoverColor = Color.FromArgb(232, 17, 35);
            FormControlBox.CloseBoxOptions.Icon = (Image)resources.GetObject("FormControlBox.CloseBoxOptions.Icon");
            FormControlBox.CloseBoxOptions.IconAlt = null;
            FormControlBox.CloseBoxOptions.IconColor = Color.Black;
            FormControlBox.CloseBoxOptions.IconHoverColor = Color.White;
            FormControlBox.CloseBoxOptions.IconPressedColor = Color.White;
            FormControlBox.CloseBoxOptions.IconSize = new Size(18, 18);
            FormControlBox.CloseBoxOptions.PressedColor = Color.FromArgb(232, 17, 35);
            FormControlBox.Dock = DockStyle.Right;
            FormControlBox.ForeColor = Color.White;
            FormControlBox.HelpBox = false;
            FormControlBox.HelpBoxOptions.BackColor = Color.Transparent;
            FormControlBox.HelpBoxOptions.BorderRadius = 0;
            FormControlBox.HelpBoxOptions.Enabled = true;
            FormControlBox.HelpBoxOptions.EnableDefaultAction = true;
            FormControlBox.HelpBoxOptions.HoverColor = Color.LightGray;
            FormControlBox.HelpBoxOptions.Icon = (Image)resources.GetObject("FormControlBox.HelpBoxOptions.Icon");
            FormControlBox.HelpBoxOptions.IconAlt = null;
            FormControlBox.HelpBoxOptions.IconColor = Color.Black;
            FormControlBox.HelpBoxOptions.IconHoverColor = Color.Black;
            FormControlBox.HelpBoxOptions.IconPressedColor = Color.Black;
            FormControlBox.HelpBoxOptions.IconSize = new Size(22, 22);
            FormControlBox.HelpBoxOptions.PressedColor = Color.Silver;
            FormControlBox.Location = new Point(947, 0);
            FormControlBox.MaximizeBox = true;
            FormControlBox.MaximizeBoxOptions.BackColor = Color.Transparent;
            FormControlBox.MaximizeBoxOptions.BorderRadius = 0;
            FormControlBox.MaximizeBoxOptions.Enabled = true;
            FormControlBox.MaximizeBoxOptions.EnableDefaultAction = true;
            FormControlBox.MaximizeBoxOptions.HoverColor = Color.LightGray;
            FormControlBox.MaximizeBoxOptions.Icon = (Image)resources.GetObject("FormControlBox.MaximizeBoxOptions.Icon");
            FormControlBox.MaximizeBoxOptions.IconAlt = (Image)resources.GetObject("FormControlBox.MaximizeBoxOptions.IconAlt");
            FormControlBox.MaximizeBoxOptions.IconColor = Color.Black;
            FormControlBox.MaximizeBoxOptions.IconHoverColor = Color.Black;
            FormControlBox.MaximizeBoxOptions.IconPressedColor = Color.Black;
            FormControlBox.MaximizeBoxOptions.IconSize = new Size(16, 16);
            FormControlBox.MaximizeBoxOptions.PressedColor = Color.Silver;
            FormControlBox.MinimizeBox = true;
            FormControlBox.MinimizeBoxOptions.BackColor = Color.Transparent;
            FormControlBox.MinimizeBoxOptions.BorderRadius = 0;
            FormControlBox.MinimizeBoxOptions.Enabled = true;
            FormControlBox.MinimizeBoxOptions.EnableDefaultAction = true;
            FormControlBox.MinimizeBoxOptions.HoverColor = Color.LightGray;
            FormControlBox.MinimizeBoxOptions.Icon = (Image)resources.GetObject("FormControlBox.MinimizeBoxOptions.Icon");
            FormControlBox.MinimizeBoxOptions.IconAlt = null;
            FormControlBox.MinimizeBoxOptions.IconColor = Color.Black;
            FormControlBox.MinimizeBoxOptions.IconHoverColor = Color.Black;
            FormControlBox.MinimizeBoxOptions.IconPressedColor = Color.Black;
            FormControlBox.MinimizeBoxOptions.IconSize = new Size(14, 14);
            FormControlBox.MinimizeBoxOptions.PressedColor = Color.Silver;
            FormControlBox.Name = "FormControlBox";
            FormControlBox.ShowDesignBorders = false;
            FormControlBox.Size = new Size(153, 30);
            FormControlBox.TabIndex = 5;
            // 
            // CompanyName
            // 
            CompanyName.AllowParentOverrides = false;
            CompanyName.AutoEllipsis = false;
            CompanyName.AutoSize = false;
            CompanyName.CursorType = Cursors.Default;
            CompanyName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CompanyName.ForeColor = Color.Coral;
            CompanyName.Location = new Point(52, 0);
            CompanyName.Name = "CompanyName";
            CompanyName.RightToLeft = RightToLeft.No;
            CompanyName.Size = new Size(181, 30);
            CompanyName.TabIndex = 1;
            CompanyName.Text = "Daza's Best";
            CompanyName.TextAlignment = ContentAlignment.MiddleLeft;
            CompanyName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // SideNav
            // 
            SideNav.BackColor = Color.FromArgb(33, 33, 33);
            SideNav.Controls.Add(bunifuButton24);
            SideNav.Controls.Add(bunifuButton23);
            SideNav.Controls.Add(bunifuButton22);
            SideNav.Controls.Add(bunifuButton21);
            SideNav.Dock = DockStyle.Left;
            SideNav.Location = new Point(0, 30);
            SideNav.Name = "SideNav";
            SideNav.Padding = new Padding(0, 20, 0, 10);
            SideNav.Size = new Size(200, 670);
            SideNav.TabIndex = 3;
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
            bunifuButton21.BackColor1 = Color.Transparent;
            bunifuButton21.BackgroundImage = (Image)resources.GetObject("bunifuButton21.BackgroundImage");
            bunifuButton21.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton21.ButtonText = "Home";
            bunifuButton21.ButtonTextMarginLeft = 0;
            bunifuButton21.ColorContrastOnClick = 45;
            bunifuButton21.ColorContrastOnHover = 45;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            bunifuButton21.CustomizableEdges = borderEdges5;
            bunifuButton21.DialogResult = DialogResult.None;
            bunifuButton21.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton21.DisabledFillColor = Color.FromArgb(204, 204, 204);
            bunifuButton21.DisabledForecolor = Color.FromArgb(168, 160, 168);
            bunifuButton21.Dock = DockStyle.Top;
            bunifuButton21.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            bunifuButton21.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            bunifuButton21.IdleBorderColor = Color.Transparent;
            bunifuButton21.IdleBorderRadius = 1;
            bunifuButton21.IdleBorderThickness = 1;
            bunifuButton21.IdleFillColor = Color.Transparent;
            bunifuButton21.IdleIconLeftImage = null;
            bunifuButton21.IdleIconRightImage = null;
            bunifuButton21.IndicateFocus = false;
            bunifuButton21.Location = new Point(0, 20);
            bunifuButton21.Name = "bunifuButton21";
            bunifuButton21.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton21.OnDisabledState.BorderRadius = 1;
            bunifuButton21.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton21.OnDisabledState.BorderThickness = 1;
            bunifuButton21.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            bunifuButton21.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunifuButton21.OnDisabledState.IconLeftImage = null;
            bunifuButton21.OnDisabledState.IconRightImage = null;
            bunifuButton21.onHoverState.BorderColor = Color.Transparent;
            bunifuButton21.onHoverState.BorderRadius = 1;
            bunifuButton21.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton21.onHoverState.BorderThickness = 1;
            bunifuButton21.onHoverState.FillColor = Color.FromArgb(245, 124, 0);
            bunifuButton21.onHoverState.ForeColor = Color.Black;
            bunifuButton21.onHoverState.IconLeftImage = null;
            bunifuButton21.onHoverState.IconRightImage = null;
            bunifuButton21.OnIdleState.BorderColor = Color.Transparent;
            bunifuButton21.OnIdleState.BorderRadius = 1;
            bunifuButton21.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton21.OnIdleState.BorderThickness = 1;
            bunifuButton21.OnIdleState.FillColor = Color.Transparent;
            bunifuButton21.OnIdleState.ForeColor = Color.White;
            bunifuButton21.OnIdleState.IconLeftImage = null;
            bunifuButton21.OnIdleState.IconRightImage = null;
            bunifuButton21.OnPressedState.BorderColor = Color.FromArgb(198, 40, 40);
            bunifuButton21.OnPressedState.BorderRadius = 1;
            bunifuButton21.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton21.OnPressedState.BorderThickness = 1;
            bunifuButton21.OnPressedState.FillColor = Color.FromArgb(198, 40, 40);
            bunifuButton21.OnPressedState.ForeColor = Color.White;
            bunifuButton21.OnPressedState.IconLeftImage = null;
            bunifuButton21.OnPressedState.IconRightImage = null;
            bunifuButton21.Size = new Size(200, 40);
            bunifuButton21.TabIndex = 0;
            bunifuButton21.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton21.TextAlignment = HorizontalAlignment.Center;
            bunifuButton21.TextMarginLeft = 0;
            bunifuButton21.TextPadding = new Padding(0);
            bunifuButton21.UseDefaultRadiusAndThickness = true;
            // 
            // MainContainer
            // 
            MainContainer.Dock = DockStyle.Fill;
            MainContainer.Location = new Point(200, 30);
            MainContainer.Name = "MainContainer";
            MainContainer.Size = new Size(900, 670);
            MainContainer.TabIndex = 4;
            // 
            // FormDockandDrag
            // 
            FormDockandDrag.AllowFormDragging = true;
            FormDockandDrag.AllowFormDropShadow = true;
            FormDockandDrag.AllowFormResizing = true;
            FormDockandDrag.AllowHidingBottomRegion = true;
            FormDockandDrag.AllowOpacityChangesWhileDragging = false;
            FormDockandDrag.BorderOptions.BottomBorder.BorderColor = Color.Silver;
            FormDockandDrag.BorderOptions.BottomBorder.BorderThickness = 1;
            FormDockandDrag.BorderOptions.BottomBorder.ShowBorder = true;
            FormDockandDrag.BorderOptions.LeftBorder.BorderColor = Color.Silver;
            FormDockandDrag.BorderOptions.LeftBorder.BorderThickness = 1;
            FormDockandDrag.BorderOptions.LeftBorder.ShowBorder = true;
            FormDockandDrag.BorderOptions.RightBorder.BorderColor = Color.Silver;
            FormDockandDrag.BorderOptions.RightBorder.BorderThickness = 1;
            FormDockandDrag.BorderOptions.RightBorder.ShowBorder = true;
            FormDockandDrag.BorderOptions.TopBorder.BorderColor = Color.Silver;
            FormDockandDrag.BorderOptions.TopBorder.BorderThickness = 1;
            FormDockandDrag.BorderOptions.TopBorder.ShowBorder = true;
            FormDockandDrag.ContainerControl = this;
            FormDockandDrag.DockingIndicatorsColor = Color.FromArgb(202, 215, 233);
            FormDockandDrag.DockingIndicatorsOpacity = 0.5D;
            FormDockandDrag.DockingOptions.DockAll = true;
            FormDockandDrag.DockingOptions.DockBottomLeft = true;
            FormDockandDrag.DockingOptions.DockBottomRight = true;
            FormDockandDrag.DockingOptions.DockFullScreen = true;
            FormDockandDrag.DockingOptions.DockLeft = true;
            FormDockandDrag.DockingOptions.DockRight = true;
            FormDockandDrag.DockingOptions.DockTopLeft = true;
            FormDockandDrag.DockingOptions.DockTopRight = true;
            FormDockandDrag.FormDraggingOpacity = 0.9D;
            FormDockandDrag.ParentForm = this;
            FormDockandDrag.ShowCursorChanges = true;
            FormDockandDrag.ShowDockingIndicators = true;
            FormDockandDrag.TitleBarOptions.AllowFormDragging = true;
            FormDockandDrag.TitleBarOptions.BunifuFormDock = FormDockandDrag;
            FormDockandDrag.TitleBarOptions.DoubleClickToExpandWindow = false;
            FormDockandDrag.TitleBarOptions.TitleBarControl = TopNav;
            FormDockandDrag.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // bunifuButton22
            // 
            bunifuButton22.AllowAnimations = true;
            bunifuButton22.AllowMouseEffects = true;
            bunifuButton22.AllowToggling = false;
            bunifuButton22.AnimationSpeed = 200;
            bunifuButton22.AutoGenerateColors = false;
            bunifuButton22.AutoRoundBorders = false;
            bunifuButton22.AutoSizeLeftIcon = true;
            bunifuButton22.AutoSizeRightIcon = true;
            bunifuButton22.BackColor = Color.Transparent;
            bunifuButton22.BackColor1 = Color.Transparent;
            bunifuButton22.BackgroundImage = (Image)resources.GetObject("bunifuButton22.BackgroundImage");
            bunifuButton22.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton22.ButtonText = "Items";
            bunifuButton22.ButtonTextMarginLeft = 0;
            bunifuButton22.ColorContrastOnClick = 45;
            bunifuButton22.ColorContrastOnHover = 45;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            bunifuButton22.CustomizableEdges = borderEdges4;
            bunifuButton22.DialogResult = DialogResult.None;
            bunifuButton22.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton22.DisabledFillColor = Color.FromArgb(204, 204, 204);
            bunifuButton22.DisabledForecolor = Color.FromArgb(168, 160, 168);
            bunifuButton22.Dock = DockStyle.Top;
            bunifuButton22.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            bunifuButton22.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuButton22.ForeColor = Color.White;
            bunifuButton22.IconLeftAlign = ContentAlignment.MiddleLeft;
            bunifuButton22.IconLeftCursor = Cursors.Default;
            bunifuButton22.IconLeftPadding = new Padding(11, 3, 3, 3);
            bunifuButton22.IconMarginLeft = 11;
            bunifuButton22.IconPadding = 10;
            bunifuButton22.IconRightAlign = ContentAlignment.MiddleRight;
            bunifuButton22.IconRightCursor = Cursors.Default;
            bunifuButton22.IconRightPadding = new Padding(3, 3, 7, 3);
            bunifuButton22.IconSize = 25;
            bunifuButton22.IdleBorderColor = Color.Transparent;
            bunifuButton22.IdleBorderRadius = 1;
            bunifuButton22.IdleBorderThickness = 1;
            bunifuButton22.IdleFillColor = Color.Transparent;
            bunifuButton22.IdleIconLeftImage = null;
            bunifuButton22.IdleIconRightImage = null;
            bunifuButton22.IndicateFocus = false;
            bunifuButton22.Location = new Point(0, 60);
            bunifuButton22.Name = "bunifuButton22";
            bunifuButton22.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton22.OnDisabledState.BorderRadius = 1;
            bunifuButton22.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton22.OnDisabledState.BorderThickness = 1;
            bunifuButton22.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            bunifuButton22.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunifuButton22.OnDisabledState.IconLeftImage = null;
            bunifuButton22.OnDisabledState.IconRightImage = null;
            bunifuButton22.onHoverState.BorderColor = Color.Transparent;
            bunifuButton22.onHoverState.BorderRadius = 1;
            bunifuButton22.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton22.onHoverState.BorderThickness = 1;
            bunifuButton22.onHoverState.FillColor = Color.FromArgb(245, 124, 0);
            bunifuButton22.onHoverState.ForeColor = Color.Black;
            bunifuButton22.onHoverState.IconLeftImage = null;
            bunifuButton22.onHoverState.IconRightImage = null;
            bunifuButton22.OnIdleState.BorderColor = Color.Transparent;
            bunifuButton22.OnIdleState.BorderRadius = 1;
            bunifuButton22.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton22.OnIdleState.BorderThickness = 1;
            bunifuButton22.OnIdleState.FillColor = Color.Transparent;
            bunifuButton22.OnIdleState.ForeColor = Color.White;
            bunifuButton22.OnIdleState.IconLeftImage = null;
            bunifuButton22.OnIdleState.IconRightImage = null;
            bunifuButton22.OnPressedState.BorderColor = Color.FromArgb(198, 40, 40);
            bunifuButton22.OnPressedState.BorderRadius = 1;
            bunifuButton22.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton22.OnPressedState.BorderThickness = 1;
            bunifuButton22.OnPressedState.FillColor = Color.FromArgb(198, 40, 40);
            bunifuButton22.OnPressedState.ForeColor = Color.White;
            bunifuButton22.OnPressedState.IconLeftImage = null;
            bunifuButton22.OnPressedState.IconRightImage = null;
            bunifuButton22.Size = new Size(200, 40);
            bunifuButton22.TabIndex = 1;
            bunifuButton22.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton22.TextAlignment = HorizontalAlignment.Center;
            bunifuButton22.TextMarginLeft = 0;
            bunifuButton22.TextPadding = new Padding(0);
            bunifuButton22.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuButton23
            // 
            bunifuButton23.AllowAnimations = true;
            bunifuButton23.AllowMouseEffects = true;
            bunifuButton23.AllowToggling = false;
            bunifuButton23.AnimationSpeed = 200;
            bunifuButton23.AutoGenerateColors = false;
            bunifuButton23.AutoRoundBorders = false;
            bunifuButton23.AutoSizeLeftIcon = true;
            bunifuButton23.AutoSizeRightIcon = true;
            bunifuButton23.BackColor = Color.Transparent;
            bunifuButton23.BackColor1 = Color.Transparent;
            bunifuButton23.BackgroundImage = (Image)resources.GetObject("bunifuButton23.BackgroundImage");
            bunifuButton23.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton23.ButtonText = "Products";
            bunifuButton23.ButtonTextMarginLeft = 0;
            bunifuButton23.ColorContrastOnClick = 45;
            bunifuButton23.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            bunifuButton23.CustomizableEdges = borderEdges3;
            bunifuButton23.DialogResult = DialogResult.None;
            bunifuButton23.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton23.DisabledFillColor = Color.FromArgb(204, 204, 204);
            bunifuButton23.DisabledForecolor = Color.FromArgb(168, 160, 168);
            bunifuButton23.Dock = DockStyle.Top;
            bunifuButton23.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            bunifuButton23.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuButton23.ForeColor = Color.White;
            bunifuButton23.IconLeftAlign = ContentAlignment.MiddleLeft;
            bunifuButton23.IconLeftCursor = Cursors.Default;
            bunifuButton23.IconLeftPadding = new Padding(11, 3, 3, 3);
            bunifuButton23.IconMarginLeft = 11;
            bunifuButton23.IconPadding = 10;
            bunifuButton23.IconRightAlign = ContentAlignment.MiddleRight;
            bunifuButton23.IconRightCursor = Cursors.Default;
            bunifuButton23.IconRightPadding = new Padding(3, 3, 7, 3);
            bunifuButton23.IconSize = 25;
            bunifuButton23.IdleBorderColor = Color.Transparent;
            bunifuButton23.IdleBorderRadius = 1;
            bunifuButton23.IdleBorderThickness = 1;
            bunifuButton23.IdleFillColor = Color.Transparent;
            bunifuButton23.IdleIconLeftImage = null;
            bunifuButton23.IdleIconRightImage = null;
            bunifuButton23.IndicateFocus = false;
            bunifuButton23.Location = new Point(0, 100);
            bunifuButton23.Name = "bunifuButton23";
            bunifuButton23.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton23.OnDisabledState.BorderRadius = 1;
            bunifuButton23.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton23.OnDisabledState.BorderThickness = 1;
            bunifuButton23.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            bunifuButton23.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunifuButton23.OnDisabledState.IconLeftImage = null;
            bunifuButton23.OnDisabledState.IconRightImage = null;
            bunifuButton23.onHoverState.BorderColor = Color.Transparent;
            bunifuButton23.onHoverState.BorderRadius = 1;
            bunifuButton23.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton23.onHoverState.BorderThickness = 1;
            bunifuButton23.onHoverState.FillColor = Color.FromArgb(245, 124, 0);
            bunifuButton23.onHoverState.ForeColor = Color.Black;
            bunifuButton23.onHoverState.IconLeftImage = null;
            bunifuButton23.onHoverState.IconRightImage = null;
            bunifuButton23.OnIdleState.BorderColor = Color.Transparent;
            bunifuButton23.OnIdleState.BorderRadius = 1;
            bunifuButton23.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton23.OnIdleState.BorderThickness = 1;
            bunifuButton23.OnIdleState.FillColor = Color.Transparent;
            bunifuButton23.OnIdleState.ForeColor = Color.White;
            bunifuButton23.OnIdleState.IconLeftImage = null;
            bunifuButton23.OnIdleState.IconRightImage = null;
            bunifuButton23.OnPressedState.BorderColor = Color.FromArgb(198, 40, 40);
            bunifuButton23.OnPressedState.BorderRadius = 1;
            bunifuButton23.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton23.OnPressedState.BorderThickness = 1;
            bunifuButton23.OnPressedState.FillColor = Color.FromArgb(198, 40, 40);
            bunifuButton23.OnPressedState.ForeColor = Color.White;
            bunifuButton23.OnPressedState.IconLeftImage = null;
            bunifuButton23.OnPressedState.IconRightImage = null;
            bunifuButton23.Size = new Size(200, 40);
            bunifuButton23.TabIndex = 2;
            bunifuButton23.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton23.TextAlignment = HorizontalAlignment.Center;
            bunifuButton23.TextMarginLeft = 0;
            bunifuButton23.TextPadding = new Padding(0);
            bunifuButton23.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuButton24
            // 
            bunifuButton24.AllowAnimations = true;
            bunifuButton24.AllowMouseEffects = true;
            bunifuButton24.AllowToggling = false;
            bunifuButton24.AnimationSpeed = 200;
            bunifuButton24.AutoGenerateColors = false;
            bunifuButton24.AutoRoundBorders = false;
            bunifuButton24.AutoSizeLeftIcon = true;
            bunifuButton24.AutoSizeRightIcon = true;
            bunifuButton24.BackColor = Color.Transparent;
            bunifuButton24.BackColor1 = Color.Transparent;
            bunifuButton24.BackgroundImage = (Image)resources.GetObject("bunifuButton24.BackgroundImage");
            bunifuButton24.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton24.ButtonText = "Reports";
            bunifuButton24.ButtonTextMarginLeft = 0;
            bunifuButton24.ColorContrastOnClick = 45;
            bunifuButton24.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            bunifuButton24.CustomizableEdges = borderEdges2;
            bunifuButton24.DialogResult = DialogResult.None;
            bunifuButton24.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton24.DisabledFillColor = Color.FromArgb(204, 204, 204);
            bunifuButton24.DisabledForecolor = Color.FromArgb(168, 160, 168);
            bunifuButton24.Dock = DockStyle.Top;
            bunifuButton24.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            bunifuButton24.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuButton24.ForeColor = Color.White;
            bunifuButton24.IconLeftAlign = ContentAlignment.MiddleLeft;
            bunifuButton24.IconLeftCursor = Cursors.Default;
            bunifuButton24.IconLeftPadding = new Padding(11, 3, 3, 3);
            bunifuButton24.IconMarginLeft = 11;
            bunifuButton24.IconPadding = 10;
            bunifuButton24.IconRightAlign = ContentAlignment.MiddleRight;
            bunifuButton24.IconRightCursor = Cursors.Default;
            bunifuButton24.IconRightPadding = new Padding(3, 3, 7, 3);
            bunifuButton24.IconSize = 25;
            bunifuButton24.IdleBorderColor = Color.Transparent;
            bunifuButton24.IdleBorderRadius = 1;
            bunifuButton24.IdleBorderThickness = 1;
            bunifuButton24.IdleFillColor = Color.Transparent;
            bunifuButton24.IdleIconLeftImage = null;
            bunifuButton24.IdleIconRightImage = null;
            bunifuButton24.IndicateFocus = false;
            bunifuButton24.Location = new Point(0, 140);
            bunifuButton24.Name = "bunifuButton24";
            bunifuButton24.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            bunifuButton24.OnDisabledState.BorderRadius = 1;
            bunifuButton24.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton24.OnDisabledState.BorderThickness = 1;
            bunifuButton24.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            bunifuButton24.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunifuButton24.OnDisabledState.IconLeftImage = null;
            bunifuButton24.OnDisabledState.IconRightImage = null;
            bunifuButton24.onHoverState.BorderColor = Color.Transparent;
            bunifuButton24.onHoverState.BorderRadius = 1;
            bunifuButton24.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton24.onHoverState.BorderThickness = 1;
            bunifuButton24.onHoverState.FillColor = Color.FromArgb(245, 124, 0);
            bunifuButton24.onHoverState.ForeColor = Color.Black;
            bunifuButton24.onHoverState.IconLeftImage = null;
            bunifuButton24.onHoverState.IconRightImage = null;
            bunifuButton24.OnIdleState.BorderColor = Color.Transparent;
            bunifuButton24.OnIdleState.BorderRadius = 1;
            bunifuButton24.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton24.OnIdleState.BorderThickness = 1;
            bunifuButton24.OnIdleState.FillColor = Color.Transparent;
            bunifuButton24.OnIdleState.ForeColor = Color.White;
            bunifuButton24.OnIdleState.IconLeftImage = null;
            bunifuButton24.OnIdleState.IconRightImage = null;
            bunifuButton24.OnPressedState.BorderColor = Color.FromArgb(198, 40, 40);
            bunifuButton24.OnPressedState.BorderRadius = 1;
            bunifuButton24.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            bunifuButton24.OnPressedState.BorderThickness = 1;
            bunifuButton24.OnPressedState.FillColor = Color.FromArgb(198, 40, 40);
            bunifuButton24.OnPressedState.ForeColor = Color.White;
            bunifuButton24.OnPressedState.IconLeftImage = null;
            bunifuButton24.OnPressedState.IconRightImage = null;
            bunifuButton24.Size = new Size(200, 40);
            bunifuButton24.TabIndex = 3;
            bunifuButton24.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton24.TextAlignment = HorizontalAlignment.Center;
            bunifuButton24.TextMarginLeft = 0;
            bunifuButton24.TextPadding = new Padding(0);
            bunifuButton24.UseDefaultRadiusAndThickness = true;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 700);
            Controls.Add(MainContainer);
            Controls.Add(SideNav);
            Controls.Add(TopNav);
            Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Daza's Best";
            Load += MainPage_Load;
            TopNav.ResumeLayout(false);
            SideNav.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TopNav;
        private Panel SideNav;
        private Panel MainContainer;
        private Bunifu.UI.WinForms.BunifuLabel CompanyName;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton21;
        private Bunifu.UI.WinForms.BunifuFormDock FormDockandDrag;
        private Bunifu.UI.WinForms.BunifuFormControlBox FormControlBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButton1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton24;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton23;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton22;
    }
}
