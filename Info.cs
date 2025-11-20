using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigData
{
    public partial class Info : UserControl
    {
        public Info()
        {
            InitializeComponent();
        }

        private void ProceedBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Finance finance = new Finance();
            finance.Show();
        }
    }
}
