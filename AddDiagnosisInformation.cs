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
    public partial class AddDiagnosisInformation : Form
    {
        public AddDiagnosisInformation()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int pid = Convert.ToInt32(textBox1.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-QEQGKFA;Initial Catalog=hospital;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from AddPatient where pid = " + pid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int pid = Convert.ToInt32(textBox1.Text);
                String sympt = symptoms.Text;
                String diag = diagnosis.Text;
                String Med = medicine.Text;
                String ward = comboward.Text;
                String wardType = combowardtype.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-QEQGKFA;Initial Catalog=hospital;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into PatientMore values ('" + pid + "', '" + sympt + "', '" + diag + "', '" + Med + "', '" + ward + "', '" + wardType + "')";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);


            }
            catch (Exception)
            {
                MessageBox.Show("Any Field is Empty or Wrong Data Format ");
            }
            MessageBox.Show("Data Saved ");
            textBox1.Clear();


            symptoms.Clear();
            diagnosis.Clear();
            medicine.Clear();
            comboward.ResetText();
            combowardtype.ResetText();
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
