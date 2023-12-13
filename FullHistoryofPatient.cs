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
    public partial class FullHistoryofPatient : Form
    {
        public FullHistoryofPatient()
        {
            InitializeComponent();
        }

        private void btnfullhistory_Click(object sender, EventArgs e)
        {




            
            

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

        private void btnhospitalinformation_Click(object sender, EventArgs e)
        {

            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard db = new Dashboard();
            db.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-QEQGKFA;Initial Catalog=hospital;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select* from AddPatient inner join PatientMore on AddPatient.pid = PatientMore.pid";
           
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}
