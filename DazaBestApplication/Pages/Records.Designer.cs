namespace DazaBestApplication.Pages
{
    partial class Records
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
            bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            SuspendLayout();
            // 
            // bunifuShadowPanel1
            // 
            bunifuShadowPanel1.BackColor = Color.Transparent;
            bunifuShadowPanel1.BorderColor = Color.WhiteSmoke;
            bunifuShadowPanel1.BorderRadius = 1;
            bunifuShadowPanel1.BorderThickness = 1;
            bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            bunifuShadowPanel1.Location = new Point(443, 80);
            bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            bunifuShadowPanel1.PanelColor = Color.Maroon;
            bunifuShadowPanel1.PanelColor2 = Color.Maroon;
            bunifuShadowPanel1.ShadowColor = Color.DarkGray;
            bunifuShadowPanel1.ShadowDept = 2;
            bunifuShadowPanel1.ShadowDepth = 5;
            bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            bunifuShadowPanel1.ShadowTopLeftVisible = false;
            bunifuShadowPanel1.Size = new Size(202, 117);
            bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            bunifuShadowPanel1.TabIndex = 0;
            // 
            // Records
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 662);
            Controls.Add(bunifuShadowPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Records";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Records";
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
    }
}