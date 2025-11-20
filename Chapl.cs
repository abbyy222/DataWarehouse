using System;
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
    public partial class Chapl : Form
    {
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("big Data.mdf") + ";Integrated Security=True;");
        public Chapl()
        {
            InitializeComponent();
        }

        private void ChapDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Chapl_Load(object sender, EventArgs e)
        {

            DisplayData();
        }
        private void DisplayData()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string query = "Select * From ChaplainT";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable da = new DataTable();
            sda.Fill(da);
            ChapDGV.DataSource = da;

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            ChaplAdd ad = new ChaplAdd();
                ad.Show();
            
        }
    }
}
