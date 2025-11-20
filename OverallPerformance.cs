using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigData
{
    public partial class OverallPerformance : Form
    {
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("big Data.mdf") + ";Integrated Security=True;");
        public OverallPerformance()
        {
            InitializeComponent();
        }
   
        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayData();

        }

        private void OverallPerformance_Load(object sender, EventArgs e)
        {
            DisplayData();
            //string query = "SELECT [RegistrationNo] FROM [StudentT]";
            //if (con.State != ConnectionState.Open)
            //{
            //    con.Open();
            //}
            //SqlCommand comm = new SqlCommand(query, con);
            //SqlDataReader de = comm.ExecuteReader();
            //while (de.Read())
            //{
            //    string item = de.GetString(0);
            //    RegC.Items.Add(item);

            //}
            //de.Close();
        }

        private void guna2HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
                    }


        private void DisplayData()
        {
          
           
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string Query = "SELECT s.RegistrationNo, s.Name, c.CourseName, sp.Grade, c.Department FROM StudentT s JOIN Performance sp ON sp.RegistrationNo = s.RegistrationNo JOIN CourseT c ON s.RegistrationNo = c.RegistrationNumber;";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            DataTable da = new DataTable();

            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            //var ds = new DataSet();
            sda.Fill(da);
            PerformanceDGV.DataSource = da;

        }

        private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PerformanceDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
          
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Stud st = new Stud();
            st.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
                    }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Home ho = new Home();
            ho.Show();
            this.Hide();
        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {
          
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {

        }
        private void MaximiBtn_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;

        }

        private void MinimiBTn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Stud st = new Stud();
            st.Show();
            this.Hide();
        }
    }
    
}
