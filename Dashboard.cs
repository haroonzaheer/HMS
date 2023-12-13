using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
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

        private void btnexit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnaddpatient_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AddNewPatientRecord anpr = new AddNewPatientRecord();
            anpr.Show();
        }

        private void btnadddiagnosis_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AddDiagnosisInformation adi = new AddDiagnosisInformation();
            adi.Show();
        }

        private void btnfullhistory_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FullHistoryofPatient fhop = new FullHistoryofPatient();
            fhop.Show();
        }

        private void btnhospitalinformation_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HospitalInformation hi = new HospitalInformation();
            hi.Show();
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Login lgn = new Login();
            lgn.Show();
        }

        private void btnupdatedelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            Updaterecord ur = new Updaterecord();
            ur.Show();
        }
    }
}
