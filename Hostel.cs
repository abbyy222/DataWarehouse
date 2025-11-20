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
    public partial class Hostel : Form
    {
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("big Data.mdf") + ";Integrated Security=True;"); public Hostel()
        {
            InitializeComponent();
        }

        private void AdBtn_Click(object sender, EventArgs e)
        {
            NewH ne = new NewH();
            ne.Show();
            this.Hide();
        }
        private void DisplayData()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string query = "Select * From FinanceT";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable da = new DataTable();
            sda.Fill(da);
            HostelDGV.DataSource = da;

        }
        private void Hostel_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
    }
}
