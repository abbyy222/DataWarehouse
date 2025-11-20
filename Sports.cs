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

    public partial class Sports : Form
    {
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("big Data.mdf") + ";Integrated Security=True;");
        public Sports()
        {
            InitializeComponent();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DisplayData()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string query = "Select * From SportsT";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable da = new DataTable();
            sda.Fill(da);
            SportsDGV.DataSource = da;
        }
        
        private void Sports_Load(object sender, EventArgs e)
        {
            DisplayData();

        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            AddSp add = new AddSp();
            add.Show();
            this.Hide();

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
