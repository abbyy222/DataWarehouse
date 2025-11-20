using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BigData
{
    public partial class Stud : Form
    {
        private Timer imageChangeTimer = new Timer();

        private Timer fadeTimer = new Timer();

        private int imageIndex = 0;
        private float currentOpacity = 0;
        private string[] imagePaths;
        [DllImport("dwmapi.dll")]
        private static extern int DwmEnableBlurBehindWindow(IntPtr hWnd, ref DWM_BLURBEHIND blurBehind);

        [StructLayout(LayoutKind.Sequential)]
        public struct DWM_BLURBEHIND
        {
            public uint dwFlags;
            public bool fEnable;
            public IntPtr hRgnBlur;
            public bool fTransitionOnMaximized;
        }
        private const uint DWM_BB_ENABLE = 0x00000001;
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
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("big Data.mdf") + ";Integrated Security=True;");

        
      
        public Stud()
        {

            InitializeComponent();
            
            imagePaths = GetImagePaths();
            gunaPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            imageChangeTimer.Interval = 7000;
            imageChangeTimer.Tick += ImageChangeTimer_Tick;
            fadeTimer.Interval = 50;
            fadeTimer.Tick += FadeTimer_Tick;

            if (imagePaths.Length > 0)
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
            if (currentOpacity >= 1.0f)
            {
                currentOpacity = 1.0f;
                fadeTimer.Stop();
            }
            gunaPictureBox1.BackColor = Color.FromArgb((int)(currentOpacity * 255), 0, 0, 0);
        }
        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel6_Click(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {


        }

        private void gunaLineTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Stud_Load(object sender, EventArgs e)
        {
            //Ena/*bleBlur(panel1);*/
        }
        public void EnableBlur(Panel panel)
        {
            DWM_BLURBEHIND blur = new DWM_BLURBEHIND();
            blur.dwFlags = DWM_BB_ENABLE;
            blur.fEnable = true;
            blur.hRgnBlur = IntPtr.Zero;

            DwmEnableBlurBehindWindow(panel.Handle, ref blur);
        }
        private void gunaGradientCircleButton1_Click(object sender, EventArgs e)
        {
            string ScholarshipVal = "";
            if(YesC.Checked)
            {
                ScholarshipVal = "Yes";

            }
            else if(NoC.Checked)
            {
                ScholarshipVal = "No";
            }
            if (con.State != ConnectionState.Open)
            {
                con.Open();

            }

            string checkQuery = " SELECT RegistrationNo FROM StudentT WHERE RegistrationNo = @RI ";
            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
            checkCmd.Parameters.AddWithValue("@RI", MatricT.Text);
            SqlDataReader dr = checkCmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                MessageBox.Show("Registration Number already exist");
                return;

            }
            dr.Close();




            SqlTransaction transaction = con.BeginTransaction();
            try
            {
                SqlCommand co = new SqlCommand("Insert into StudentT(RegistrationNo, Name, Address, Gender, Age, Scholarship,  Date)Values(@RA, @NA, @AD, @GE, @AG, @SC, @DA)", con, transaction);

                co.Parameters.AddWithValue("RA", MatricT.Text);
                co.Parameters.AddWithValue("@NA", NameT.Text);
                co.Parameters.AddWithValue("@AD", AddressT.Text);
                co.Parameters.AddWithValue("@GE", GenderC.SelectedItem.ToString());
                co.Parameters.AddWithValue("@AG", AgeT.Text);
                co.Parameters.AddWithValue("@SC", ScholarshipVal);
                co.Parameters.AddWithValue("@DA", DateTime.Now.Date);
                co.ExecuteNonQuery();


                SqlCommand com = new SqlCommand("Insert into CourseT(CourseName, RegistrationNumber, Department)Values(@CN, @RN, @DP)", con, transaction);
                com.Parameters.AddWithValue("CN", NameC.SelectedItem.ToString());
                com.Parameters.AddWithValue("RN", MatricT.Text);
                com.Parameters.AddWithValue("DP", DeptC.SelectedItem.ToString());
                com.ExecuteNonQuery();

                SqlCommand cu = new SqlCommand("Insert into Performance(RegistrationNo, Grade)Values(@RG, @GR)", con, transaction);
                cu.Parameters.AddWithValue("RG", MatricT.Text);
                cu.Parameters.AddWithValue("@GR", GradeT.Text);
                cu.ExecuteNonQuery();

                transaction.Commit();
                MessageBox.Show("You have Sucessfully Added a Data To Your Data Warehouse Lets redirect you to view your record");
                OverallPerformance Ov = new OverallPerformance();
                Ov.Show();
                this.Hide();


            }
            catch (Exception Ex)
            {
                transaction.Rollback();
                MessageBox.Show("An error occured" + Ex.Message);
            }




        }

        private void gunaGradientPanel1_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaLabel7_Click(object sender, EventArgs e)
        {

        }

        private void NameT_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void MatricT_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel9_Click(object sender, EventArgs e)
        {

        }

        private void DeptC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //panel1.BackColor = Color.FromArgb(100, 0,0,0);
            //EnableBlur(panel1);
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
