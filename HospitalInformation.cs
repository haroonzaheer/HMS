using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Hospital_Management_System
{
    public partial class HospitalInformation : Form
    {
        public HospitalInformation()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
           
        }

        private void btnaddpatient_Click(object sender, EventArgs e)
        {
            

           
        }

        private void btnadddiagnosis_Click(object sender, EventArgs e)
        {
            


           
        }

        private void btnfullhistory_Click(object sender, EventArgs e)
        {
            

           

            
        }

        private void btnhospitalinformation_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard db = new Dashboard();
            db.Show();
        }
    }
}
