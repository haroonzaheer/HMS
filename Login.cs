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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String username = txtusername.Text;
            String pass = txtpassword.Text;
            if (username == "admin" && pass == "admin")
            {
                //MessageBox.Show("You have entered right Username and Password");
                this.Hide();
               Dashboard ds = new Dashboard();
                ds.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
