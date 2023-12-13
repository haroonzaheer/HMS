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
    public partial class Updaterecord : Form
    {
        public Updaterecord()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard db = new Dashboard();
            db.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(textBox1.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-QEQGKFA;Initial Catalog=hospital;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select* from AddPatient inner join PatientMore on AddPatient.pid = PatientMore.pid where AddPatient.pid = " + pid + "";
                


                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid PID! ");

            }




            
        }
        int indexRow;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
          

            DataGridViewRow row = dataGridView1.Rows[indexRow];

            textBox1.Text = row.Cells[7].Value.ToString();

            txtname.Text = row.Cells[0].Value.ToString();

            txtcontact.Text = row.Cells[2].Value.ToString();

            txtaddress.Text = row.Cells[1].Value.ToString();

            txtany.Text = row.Cells[6].Value.ToString();

            txtage.Text = row.Cells[3].Value.ToString();

            combogender.Text = row.Cells[4].Value.ToString();

           comboblood.Text = row.Cells[5].Value.ToString();

            comboward.Text = row.Cells[12].Value.ToString();

            combowardtype.Text = row.Cells[13].Value.ToString();

            symptoms.Text = row.Cells[9].Value.ToString();

            diagnosis.Text = row.Cells[10].Value.ToString();

            medicine.Text = row.Cells[11].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];

            newDataRow.Cells[0].Value = txtname.Text;
            newDataRow.Cells[1].Value = txtaddress.Text;
            newDataRow.Cells[2].Value = txtcontact.Text;
            newDataRow.Cells[3].Value = txtage.Text;
            newDataRow.Cells[4].Value = combogender.Text;
            newDataRow.Cells[5].Value = comboblood.Text;
            newDataRow.Cells[6].Value = txtany.Text;
            newDataRow.Cells[7].Value = textBox1.Text;
            newDataRow.Cells[9].Value = symptoms.Text;
            newDataRow.Cells[10].Value = diagnosis.Text;
            newDataRow.Cells[11].Value = medicine.Text;
            newDataRow.Cells[12].Value = comboward.Text;
            newDataRow.Cells[13].Value = combowardtype.Text;
            

      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-QEQGKFA;Initial Catalog=hospital;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from AddPatient where pid = " + textBox1.Text + "";
                cmd.CommandText = "delete from PatientMore where pid = " + textBox1.Text + "";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                MessageBox.Show("Deleted succssfuly");
                dataGridView1.DataSource = DS.Tables[0];
            }
            catch (Exception)
            {

            }
        }
                
                
            
                

            

        }
}

