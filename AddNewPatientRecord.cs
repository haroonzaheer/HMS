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
    public partial class AddNewPatientRecord : Form
    {
        public AddNewPatientRecord()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtname.Text;
                String address = txtaddress.Text;
                Int64 contact = Convert.ToInt64(txtcontact.Text);
                int age = Convert.ToInt32(txtage.Text);
                String blood = comboblood.Text;
                String any = txtany.Text;
                String gender = combogender.Text;
                int pid = Convert.ToInt32(txtpid.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-QEQGKFA;Initial Catalog=hospital;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into AddPatient values ('" + name + "', '" + address + "', '" + contact + "', '" + age + "', '" + gender + "', '" + blood + "', '" + any + "', '" + pid + "'  )";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                MessageBox.Show(" Data Saved");
            }
            catch (Exception)
            {
                MessageBox.Show(" Invalid Data Fomat or Invalid PID! ");

            }

          /* 
            txtname.Clear();
            txtcontact.Clear();
            txtage.Clear();
            comboblood.ResetText();
            txtaddress.Clear();
            combogender.ResetText();
            txtany.Clear();
            txtpid.Clear();
        */
            }

        private void btnexit_Click(object sender, EventArgs e)
        {
            ;        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard db = new Dashboard();
            db.Show();
        }
    }
}
