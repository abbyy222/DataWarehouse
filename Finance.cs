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
    public partial class Finance : Form
    {
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("big Data.mdf") + ";Integrated Security=True;"); 
        public Finance()
        {
            InitializeComponent();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            NewFinance finance = new NewFinance();
            finance.Show();
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
            FinanceDGV.DataSource = da;

        }
        private void FinanceDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Finance_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
