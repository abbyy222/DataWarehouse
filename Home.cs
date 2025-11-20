using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BigData
{
    public partial class Home : Form
    {
        private Timer imageChangeTimer = new Timer();

        private Timer fadeTimer = new Timer();

        private int imageIndex = 0;
        private float currentOpacity = 0;
        private string[] imagePaths;
        //{
        //   @"C:\Users\TOSHIBA\Downloads\istockphoto-866501982-612x612.jpg", @"C:\Users\TOSHIBA\Downloads\istockphoto-624745074-612x612.jpg",

        //   @"C:\Users\TOSHIBA\Downloads\istockphoto-1130500593-612x612.jpg", @"C:\Users\TOSHIBA\Downloads\images (11).jpeg", @"C:\Users\TOSHIBA\Downloads\images (10).jpeg"
        //};
        private string[] GetImagePaths()
        {
            string ImageDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MyImages");
            var jpgFiles = Directory.GetFiles(ImageDirectory, "*jpg");
            var pngFiles = Directory.GetFiles(ImageDirectory, "*png");
            return
            jpgFiles.Concat(pngFiles).ToArray();
        }
        public Home()
        {
            InitializeComponent();
            imagePaths = GetImagePaths();
            gunaPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            imageChangeTimer.Interval = 7000;
            imageChangeTimer.Tick += ImageChangeTimer_Tick;
                fadeTimer.Interval = 50;
            fadeTimer.Tick += FadeTimer_Tick;

            if(imagePaths.Length>0)
            {
                gunaPictureBox1.Image = new Bitmap(imagePaths[imageIndex]);
                imageChangeTimer.Start();

            }
        }
        private void ImageChangeTimer_Tick(object sender, EventArgs e)
        {
            imageIndex = (imageIndex + 1) % imagePaths.Length;
            gunaPictureBox1.Image = new Bitmap(imagePaths[imageIndex]);
            currentOpacity = 0;
            fadeTimer.Start();

        }
        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            currentOpacity += 0.05f;
            if(currentOpacity >= 1.0f)
            {
                currentOpacity = 1.0f;
                fadeTimer.Stop();
            }
            gunaPictureBox1.BackColor = Color.FromArgb((int)(currentOpacity * 255), 0, 0, 0);
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
                   }

        private void gunaGradientButton5_Click(object sender, EventArgs e)
        {
            Chapl ch = new Chapl();
            ch.Show();
            this.Hide();
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void StudentBtn_Click(object sender, EventArgs e)
        {
            OverallPerformance ov = new OverallPerformance();
            ov.Show();
            this.Hide();
        }

        private void FinanceBtn_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Location = new Point(70, 50);
            this.Controls.Add(info);
            info.BringToFront();
        }

        private void gunaGradientButton2_Click_1(object sender, EventArgs e)
        {
            Sports sp = new Sports();
            sp.Show();
        }

        private void Staff_Click(object sender, EventArgs e)
        {
            StaffD sta = new StaffD();
            sta.Show();
        }

        private void HostelBtn_Click(object sender, EventArgs e)
        {
            Hostel ho = new Hostel();
            ho.Show();
            
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            ReportGenerator report = new ReportGenerator();
            report.GeneratePDFReport();
        }
    }
}
