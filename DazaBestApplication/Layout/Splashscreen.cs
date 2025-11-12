using DazaBestApplication.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DazaBestApplication.Layout
{
    public partial class Splashscreen : Form
    {
        private List<Image> frames = new();
        private int frameIndex = 0;
        private System.Windows.Forms.Timer gifTimer;


        public Splashscreen()
        {
            InitializeComponent();
        }
        private void Splashscreen_Load(object sender, EventArgs e)
        {
            LoadGifFrames();

            pictureBox1.Image = frames[0];

            gifTimer = new System.Windows.Forms.Timer();
            gifTimer.Interval = 25;
            gifTimer.Tick += GifTimer_Tick;
            gifTimer.Start();
        }


        #region Play GIF Smooth Without Flash
        private void GifTimer_Tick(object sender, EventArgs e)
        {
            frameIndex++;

            if (frameIndex >= frames.Count)
            {
                
                gifTimer.Stop();
                frameIndex = frames.Count - 1;
                pictureBox1.Image = frames[frameIndex];

                OnGifFinished();
                return;
            }

            pictureBox1.Image = frames[frameIndex];
        }
        private void LoadGifFrames()
        {
            Image gif = Properties.Resources.Splashscreenv2loop1;
            FrameDimension dim = new FrameDimension(gif.FrameDimensionsList[0]);
            int count = gif.GetFrameCount(dim);

            for (int i = 0; i < count; i++)
            {
                gif.SelectActiveFrame(dim, i);
                frames.Add(new Bitmap(gif)); 
            }
        }
        private void OnGifFinished()
        {
            Task.Delay(500).Wait();
            this.Hide();
            Log_in log_In = new Log_in();
            log_In.Show();
        }
        #endregion


    }
}
