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
    public partial class NewH : Form
    {
        public NewH()
        {
            InitializeComponent();
        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLineTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {

            string registrationNo = MatricT.Text.Trim();

            if (string.IsNullOrEmpty(registrationNo))
            {
                MessageBox.Show("Please enter a registration number.");
                return;
            }

            // Connection String (replace with your actual database connection string)
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("big Data.mdf") + ";Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                InsertHostelDetails(con, registrationNo);

                // Step 2: Update Financial Status for Outstanding Damages
                // 100 Level
                if (YesCH.Checked)
                {
                    UpdateFinancialStatus(con, registrationNo, "[100Level]", "Owing");
                }
                else if (NoACH.Checked)
                {
                    UpdateFinancialStatus(con, registrationNo, "[100Level]", "Cleared");
                }

                // 200 Level
                if (YesBCH.Checked)
                {
                    UpdateFinancialStatus(con, registrationNo, "[200Level]", "Owing");
                }
                else if (NoBCH.Checked)
                {
                    UpdateFinancialStatus(con, registrationNo, "[200Level]", "Cleared");
                }

                // Repeat for 300L, 400L, and 500L
                if (YesCCH.Checked)
                {
                    UpdateFinancialStatus(con, registrationNo, "[300Level]", "Owing");
                }
                else if (NoCCH.Checked)
                {
                    UpdateFinancialStatus(con, registrationNo, "[300Level]", "Cleared");
                }

                if (YesDCH.Checked)
                {
                    UpdateFinancialStatus(con, registrationNo, "[400Level]", "Owing");
                }
                else if (NoDCH.Checked)
                {
                    UpdateFinancialStatus(con, registrationNo, "[400Level]", "Cleared");
                }

                if (YesECH.Checked)
                {
                    UpdateFinancialStatus(con, registrationNo, "[500Level]", "Owing");
                }
                else if (NoECH.Checked)
                {
                    UpdateFinancialStatus(con, registrationNo, "[500Level]", "");
                }

                MessageBox.Show("Hostel and financial information updated successfully.");
            }
        }
        private void UpdateFinancialStatus(SqlConnection con, string registrationNo, string levelColumn, string status)
        {
            string query = $@"
        UPDATE FinanceT
        SET {levelColumn} = @Status 
        WHERE RegistrationNo = @RegistrationNo";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@RegistrationNo", registrationNo);

                cmd.ExecuteNonQuery();
            }
        }

        private void InsertHostelDetails(SqlConnection con, string registrationNo)
        {
            string query = @"
        INSERT INTO HostelT (RegistrationNo, Room100Level, Room200Level, Room300Level, Room400Level, Room500Level, HostelDemerit, DateOfPermanentExit)
        VALUES (@RegistrationNo, @Room100L, @Room200L, @Room300L, @Room400L, @Room500L, @Host,  @DateOfPermanentExit)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@RegistrationNo", registrationNo);
                cmd.Parameters.AddWithValue("@Room100L", RoomA.Text.Trim());
                cmd.Parameters.AddWithValue("@Room200L", RoomB.Text.Trim());
                cmd.Parameters.AddWithValue("@Room300L", RoomC.Text.Trim());
                cmd.Parameters.AddWithValue("@Room400L", RoomD.Text.Trim());
                cmd.Parameters.AddWithValue("@Room500L", RoomE.Text.Trim());
                cmd.Parameters.AddWithValue("@Host", gHostT.Text.Trim());
                cmd.Parameters.AddWithValue("@DateOfPermanentExit", DTP.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Successfuly Inserted you will be redirected to view your records in the database");
                Hostel ho = new Hostel();
                ho.Show();
                this.Hide();
            }
        }
        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void YesCH_CheckedChanged(object sender, EventArgs e)
        {
            if(YesCH.Checked == true)
            {
                NoACH.Checked = false;
            }
        }

        private void NoACH_CheckedChanged(object sender, EventArgs e)
        {
            if(NoACH.Checked == true)
            {
                YesCH.Checked = false;
            }
        }

        private void YesBCH_CheckedChanged(object sender, EventArgs e)
        {

            if (YesBCH.Checked == true)
            {
                NoBCH.Checked = false;
            }
        }

        private void NoBCH_CheckedChanged(object sender, EventArgs e)
        {
            if (NoBCH.Checked == true)
            {
                YesBCH.Checked = false;
            }
        }

        private void YesCCH_CheckedChanged(object sender, EventArgs e)
        {
            if (YesCCH.Checked == true)
            {
                NoCCH.Checked = false;
            }
        }

        private void NoCCH_CheckedChanged(object sender, EventArgs e)
        {

            if (NoCCH.Checked == true)
            {
                YesCCH.Checked = false;
            }
        }

        private void YesDCH_CheckedChanged(object sender, EventArgs e)
        {

            if (YesDD.Checked == true)
            {
                NoDD.Checked = false;
            }
        }

        private void NoDCH_CheckedChanged(object sender, EventArgs e)
        {

            if (NoDD.Checked == true)
            {
                YesDD.Checked = false;
            }
        }

        private void YesECH_CheckedChanged(object sender, EventArgs e)
        {

            if (YesEE.Checked == true)
            {
                NoECH.Checked = false;
            }
        }

        private void NoECH_CheckedChanged(object sender, EventArgs e)
        {

            if (NoECH.Checked == true)
            {
                YesEE.Checked = false;
            }
        }
    }
}
