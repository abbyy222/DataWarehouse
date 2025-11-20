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
    public partial class StaffD : Form
    {
        static SqlConnection con = new SqlConnection(@"Data Source=(localdb)\braham;Initial Catalog=""C:\USERS\ABRAHAM\BIG DATA.MDF"";Integrated Security=True");
        public StaffD()
        {
            InitializeComponent();
        }

        private void StaffD_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
        private void DisplayData()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string query = "Select * From StaffT";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable da = new DataTable();
            sda.Fill(da);
            StaffDGV.DataSource = da;

        }

        private void StaffDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
