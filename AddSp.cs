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
    public partial class AddSp : Form
    {
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("big Data.mdf") + ";Integrated Security=True;"); public AddSp()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string checkBoxValue = "";
            if (YaC.Checked)
            {
                checkBoxValue = "Yes";
            }
            else if(NoC.Checked)
            {
                checkBoxValue = "No";
            }
          SqlCommand co = new SqlCommand("Insert into SportsT(RegistrationNo, ActivelyInSports, SportsName, ChampionshipTitles, MedalsWon)Values(@RA, @AS, @AD, @GE, @AG)", con);

            co.Parameters.AddWithValue("RA", RegT.Text);
            co.Parameters.AddWithValue("@AS", checkBoxValue);
           
            co.Parameters.AddWithValue("@AD", TypeT.Text);
            co.Parameters.AddWithValue("@GE", WonC.SelectedItem.ToString());
            co.Parameters.AddWithValue("@AG", MedalC.SelectedItem.ToString());

            try
            {
                con.Open();
                co.ExecuteNonQuery();
                MessageBox.Show("Data Added You will be redirected to the sport Database to view your data");
                Sports sp = new Sports();
                sp.Show();
                this.Hide();

            }
            catch (Exception)
            {

                throw;
            }
        }

    }

}
  
