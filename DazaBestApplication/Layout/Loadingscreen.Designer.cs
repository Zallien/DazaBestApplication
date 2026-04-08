namespace DazaBestApplication.Layout
{
    partial class Loadingscreen
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
            if (disposing)
            {
                loadingTimer?.Stop();
                loadingTimer?.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loadingscreen));
            loadingprogressbar = new Bunifu.UI.WinForms.BunifuProgressBar();
            SuspendLayout();
            // 
            // loadingprogressbar
            // 
            loadingprogressbar.AllowAnimations = false;
            loadingprogressbar.Animation = 0;
            loadingprogressbar.AnimationSpeed = 220;
            loadingprogressbar.AnimationStep = 10;
            loadingprogressbar.BackColor = Color.FromArgb(250, 205, 118);
            loadingprogressbar.BackgroundImage = (Image)resources.GetObject("loadingprogressbar.BackgroundImage");
            loadingprogressbar.BorderColor = Color.Red;
            loadingprogressbar.BorderRadius = 9;
            loadingprogressbar.BorderThickness = 1;
            loadingprogressbar.Location = new Point(93, 237);
            loadingprogressbar.Maximum = 100;
            loadingprogressbar.MaximumValue = 100;
            loadingprogressbar.Minimum = 0;
            loadingprogressbar.MinimumValue = 0;
            loadingprogressbar.Name = "loadingprogressbar";
            loadingprogressbar.Orientation = Orientation.Horizontal;
            loadingprogressbar.ProgressBackColor = Color.FromArgb(250, 205, 118);
            loadingprogressbar.ProgressColorLeft = Color.Red;
            loadingprogressbar.ProgressColorRight = Color.White;
            loadingprogressbar.Size = new Size(315, 10);
            loadingprogressbar.TabIndex = 0;
            loadingprogressbar.Value = 10;
            loadingprogressbar.ValueByTransition = 10;
            // 
            // Loadingscreen
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.loadingscreen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(500, 270);
            Controls.Add(loadingprogressbar);
            Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Loadingscreen";
            Text = "Loadingscreen";
            Load += Loadingscreen_Load;
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.UI.WinForms.BunifuProgressBar loadingprogressbar;
    }
}