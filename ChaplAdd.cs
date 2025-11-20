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
    public partial class ChaplAdd : Form
    {
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("big Data.mdf") + ";Integrated Security=True;");
        public ChaplAdd()
        {
            InitializeComponent();
        }

        private int comboHeight = 0;
        private int targetHeight = 34;
        private bool isAnimating = false;
        private List<string> fiveYearAbbreviations = new List<string> { "NSC", "LAW", "MED", "Nsc", "Law", "Med" };
        private void MatricT_TextChanged(object sender, EventArgs e)
        {
            string matNo = MatricT.Text.Trim();
            bool isFiveYearCourse = fiveYearAbbreviations.Any(abbreviation => matNo.Contains(abbreviation)); 
            if(isFiveYearCourse)
            {
                isAnimating = true;
                comboHeight = 0;
                FifthC.Visible = true;
                timerComboAnimation.Start();
            }
            else
            {
                comboHeight = 0;
                FifthC.Visible = false;
            }
        }

        private void ChaplAdd_Load(object sender, EventArgs e)
        {
            FifthC.Height = 0;
            FifthC.Visible = false;
            DemT.Visible = false;
            PosiT.Visible = false;
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            InsertChaplaincyValues();
        }

        private void timerComboAnimation_Tick(object sender, EventArgs e)
        {
            if(comboHeight< targetHeight)
            {
                comboHeight += 5;
                FifthC.Height = comboHeight;
            }
            else if(!FifthC.Visible &&  comboHeight > 0)
            {
                comboHeight -= -5;
                FifthC.Height = comboHeight;
                if(comboHeight ==0)
                {
                    timerComboAnimation.Stop();
                    isAnimating = false;
                      
                }
                //timerComboAnimation.Stop();
                //isAnimating = false;
            }
            else
            {
                timerComboAnimation.Stop();
                isAnimating = false;
            }
        }

        private void YesD_CheckedChanged(object sender, EventArgs e)
        {
            if(YesD.Checked)
            {
                DemT.Visible = true;
                NoD.Checked = false;
            }
        }

        private void NoD_CheckedChanged(object sender, EventArgs e)
        {
            if(NoD.Checked)
            {
                YesD.Checked = false;
                DemT.Visible = false;
            }
        }
        private void InsertChaplaincyValues()
        {
            string positionHeld = "";
            if(YesCH.Checked)
            {
                if(!string.IsNullOrEmpty(PosiT.Text.Trim()))
                {
                    positionHeld = PosiT.Text.Trim();
                }
                else
                {
                    MessageBox.Show("Please Enter the Position name of this student");
                }
            }

            else if(NoCH.Checked)
            {
                positionHeld = "No position Occupied";
            }
            else
            {
                MessageBox.Show("Please Select Either Yes or No for PositionHeld");
            }



            string DemeritPoints = "";
            if (YesD.Checked)
            {
                if (!string.IsNullOrEmpty(DemT.Text.Trim()))
                {
                   DemeritPoints = DemT.Text.Trim();
                }
                else
                {
                    MessageBox.Show("Please Enter the Demerit points of this student");
                }
            }

            else if (NoD.Checked)
            {
                DemeritPoints = "No Demerit Points";
            }
            else
            {
                MessageBox.Show("Please Select Either Yes or No for Demerits Points");
            }
            string MatricNo = MatricT.Text.Trim();
            string worship100 = FirstC.Text.Trim();
            string worship200 = SecondC.Text.Trim();
            string worship300 = ThirdC.Text.Trim();
            string worship400 = FourthC.Text.Trim();
            string worship500 = FifthC.Text.Trim();

            if(string.IsNullOrEmpty(worship500))
            {
                worship500 = "Graduated At 400Level";

            }
            try
            {

                SqlCommand Co = new SqlCommand("Insert into ChaplainT(RegistrationNo, [100Level], [200Level], [300Level], [400Level], [500Level], PositionHeld, Demerits, Remarks)Values(@RE, @FI, @SE, @TH, @FO, @FF, @PH, @DE, @RM)", con);
                Co.Parameters.AddWithValue("@RE", MatricNo);
                Co.Parameters.AddWithValue("@FI", worship100);
                Co.Parameters.AddWithValue("@SE", worship200);
                Co.Parameters.AddWithValue("@TH", worship300);
                Co.Parameters.AddWithValue("@FO", worship400);
                Co.Parameters.AddWithValue("@FF", worship500);
                Co.Parameters.AddWithValue("@PH", positionHeld);
                Co.Parameters.AddWithValue("@DE", DemeritPoints);
                Co.Parameters.AddWithValue("@RM", RemT.Text.Trim());
                try
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    Co.ExecuteNonQuery();
                    MessageBox.Show("Success You have inserted your data into the Data Warehouse");
                    //ClearComboBoxes();

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void RemT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void YesCH_CheckedChanged(object sender, EventArgs e)
        {
            if(YesCH.Checked)
            {
                PosiT.Visible = true;
                NoCH.Checked = false;
            }
        }

        private void NoCH_CheckedChanged(object sender, EventArgs e)
        {

            if (NoCH.Checked)
            {
                PosiT.Visible = false;
                YesCH.Checked = false;
            }
        }
    }
}
