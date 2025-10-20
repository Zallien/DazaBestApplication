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
            Toppanel = new Panel();
            label1 = new Label();
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
            Toppanel.Size = new Size(500, 30);
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
            // POSPaymentModal
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 300);
            Controls.Add(Toppanel);
            Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "POSPaymentModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "POSPaymentModal";
            Toppanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Toppanel;
        private Label label1;
    }
}