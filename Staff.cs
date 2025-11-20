using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;

namespace BigData
{
    public partial class Staff : Form
    {
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("big Data.mdf") + ";Integrated Security=True;");
        public Staff()
        {
            InitializeComponent();
        }

        private void gunaCheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DeptC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDepartment = DeptC.SelectedItem.ToString();
          DepCH.Items.Clear();

           
              // Dynamic query to select all rows from the department column
                string query = $"SELECT [{selectedDepartment}] FROM DeptT WHERE [{selectedDepartment}] IS NOT NULL";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string course = reader[selectedDepartment]?.ToString().Trim();
                            if (!string.IsNullOrEmpty(course))
                            {
                                DepCH.Items.Add(course);
                            }
                        }
                    }
                }
            



        }

        private void Staff_Load(object sender, EventArgs e)
        {
            FacultyC.Visible = false;
            DeptC.Visible = false;
            CertiC.Visible = false;
            DepCH.Visible = false;


        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            List<string> selectedCourses = new List<string>();
            foreach(var item in DepCH.CheckedItems)
            {
                selectedCourses.Add(item.ToString());

            }
            string coursesTaught = string.Join(",", selectedCourses);
            if (NameT.Text.Length == 0 && CertiC.SelectedIndex == -1 && DeptC.SelectedIndex == -1 && FacultyC.SelectedIndex == -1 && PositionC.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill up the required Fields");
            }
            else
            {
                SqlCommand com = new SqlCommand("INSERT INTO StaffT(LecturerName, Faculty, Position, Department, CertificationAttained, CourseLectured, Status, Date) VALUES(@NA, @FA, @PO, @DE, @CA, @CL, @ST, @DA)", con);
                com.Parameters.AddWithValue("@NA", NameT.Text.Trim());
                com.Parameters.AddWithValue("@FA", FacultyC.SelectedItem.ToString());
                com.Parameters.AddWithValue("@PO", PositionC.SelectedItem.ToString());
                com.Parameters.AddWithValue("@DE", DeptC.SelectedItem.ToString());
                com.Parameters.AddWithValue("@CA", CertiC.SelectedItem.ToString());
                com.Parameters.AddWithValue("@CL", coursesTaught);
                com.Parameters.AddWithValue("@ST", StatusC.SelectedItem.ToString());
                com.Parameters.AddWithValue("@DA", DateT.Value);
                try
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    com.ExecuteNonQuery();
                    MessageBox.Show("Data inserted Correctly you will be redirected to the Staff database display to view thr records");
                    con.Close();
                    StaffD sta = new StaffD();
                    sta.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void PositionC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = PositionC.SelectedItem.ToString();
            if(selectedRole == "Vice-Chancellor" || selectedRole == "Deputy Vice-Chancellor" || selectedRole == "Registrar" || selectedRole == "Vice President Student Services" || selectedRole == "Deputy Vice President Student services" || selectedRole == "Deputy Bursar" || selectedRole == "University Librarian" || selectedRole == "Deen" || selectedRole == "HOD" || selectedRole == "Lecturer")
            {
                FacultyC.Visible = true;
                DeptC.Visible = true;
                CertiC.Visible = true;
                DepCH.Visible = true;
            }
            else
            {
                FacultyC.Visible = false;
                DeptC.Visible = false;
                CertiC.Visible = false;
                DepCH.Visible = false;
            }
        }
    }
}
