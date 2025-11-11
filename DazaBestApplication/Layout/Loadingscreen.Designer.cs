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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CompanyLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)CompanyLogo).BeginInit();
            SuspendLayout();
            // 
            // CompanyLogo
            // 
            CompanyLogo.Image = Properties.Resources.clean;
            CompanyLogo.Location = new Point(186, 38);
            CompanyLogo.Name = "CompanyLogo";
            CompanyLogo.Size = new Size(80, 80);
            CompanyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            CompanyLogo.TabIndex = 0;
            CompanyLogo.TabStop = false;
            // 
            // Loadingscreen
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 250);
            Controls.Add(CompanyLogo);
            Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Loadingscreen";
            Text = "Loadingscreen";
            Load += Loadingscreen_Load;
            ((System.ComponentModel.ISupportInitialize)CompanyLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox CompanyLogo;
    }
}