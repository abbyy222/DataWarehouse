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
    public partial class NewFinance : Form
    {
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("big Data.mdf") + ";Integrated Security=True;");
        public NewFinance()
        {
            InitializeComponent();
            //if (con.State != ConnectionState.Open)
            //{
            //    con.Open();

            //}
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string regNo = RegNoT.Text.Trim();
            if(string.IsNullOrEmpty(regNo))
            {
                MessageBox.Show("Please Enter the Registration Number so We can Retieve the Data");
                return;
            }
            string query = "SELECT * FROM FinanceT WHERE RegistrationNo = @RI";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("RI", regNo);
            try
            {
                con.Open();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)

                {
                    while (dr.Read())
                    {

                        FirstC.Text = dr["100Level"].ToString();
                        SecondC.Text = dr["200Level"].ToString();
                        ThirdC.Text = dr["300Level"].ToString();
                        FourthC.Text = dr["400Level"].ToString();
                        FifthC.Text = dr["500Level"].ToString();

                    }


                }
                else
                {
                    MessageBox.Show("No Record Found For the Entered Matric Number");
                    return;
                }
                //dr.Close();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
            finally
            {
                if(con.State== ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string registNo = RegNoT.Text.Trim();
            if (string.IsNullOrEmpty(registNo))
            {
                MessageBox.Show("Please Enter Registration Number");
                return;
            }
            string query = @"Update FinanceT Set [100Level] = @FI, [200Level] = @SE, [300Level] = @TH, [400Level] = @FO, [500Level] = @FF Where RegistrationNo = @RE";
            SqlCommand coo = new SqlCommand(query, con);
            coo.Parameters.AddWithValue("@FI", FirstC.SelectedItem.ToString());
            coo.Parameters.AddWithValue("@SE", SecondC.SelectedItem.ToString()); 
            coo.Parameters.AddWithValue("@TH", ThirdC.SelectedItem.ToString());
            coo.Parameters.AddWithValue("@FO", FourthC.SelectedItem.ToString());
            coo.Parameters.AddWithValue("@FF", FifthC.SelectedItem.ToString());
            coo.Parameters.AddWithValue("@RE", RegNoT.Text);
            try
            {
                con.Open();
                int rowsAffected = coo.ExecuteNonQuery();
                if(rowsAffected > 0)
                {
                    MessageBox.Show("Record Updated Successfully");
                    RefreshData();

                }
                else
                {
                    MessageBox.Show("Failed To Update Record");
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }

        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            if (MatricT.Text.Length != 0 && FirstT.SelectedItem.ToString() != null && SecondT.SelectedItem.ToString() != null && ThirdT.SelectedItem.ToString() != null && FourthT.SelectedItem.ToString() != null && fifthT.SelectedItem.ToString() != null)
            {
                SqlCommand Co = new SqlCommand("Insert into FinanceT(RegistrationNo, [100Level], [200Level], [300Level], [400Level], [500Level])Values(@RE, @FI, @SE, @TH, @FO, @FF)", con);
                Co.Parameters.AddWithValue("@RE", MatricT.Text);
                Co.Parameters.AddWithValue("@FI", FirstT.SelectedItem.ToString());
                Co.Parameters.AddWithValue("@SE", SecondT.SelectedItem.ToString()); 
                Co.Parameters.AddWithValue("@TH", ThirdT.SelectedItem.ToString());
                Co.Parameters.AddWithValue("@FO", FourthT.SelectedItem.ToString());
                Co.Parameters.AddWithValue("@FF", fifthT.SelectedItem.ToString());
                try
                {
                    if(con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    Co.ExecuteNonQuery();
                    MessageBox.Show("Success You have inserted your data into the Data Warehouse");
                    ClearComboBoxes();

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                  
                }
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void MaximiBt_Click(object sender, EventArgs e)
        {

        }

        private void RefreshData()
        {
            FirstC.SelectedIndex = -1;
            SecondC.SelectedIndex = -1;
            ThirdC.SelectedIndex = -1;
            FourthC.SelectedIndex = -1;
            FifthC.SelectedIndex = -1;
            RegNoT.Text = string.Empty;
        }
        private void ClearComboBoxes()
        {
            FirstT.SelectedIndex = -1;
            SecondT.SelectedIndex = -1;
            ThirdT.SelectedIndex = -1;
            FourthT.SelectedIndex = -1;
            fifthT.SelectedIndex = -1;
            MatricT.Text = string.Empty;
        }

        private void MaximiBt_Click_1(object sender, EventArgs e)
        {


        }

        private void MiniBtn_Click_1(object sender, EventArgs e)
        {
           
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
        }

        private void MaximiBt_Click_2(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void MiniBtn_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void gunaButton1_Click_2(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void UpdateBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
    
}
