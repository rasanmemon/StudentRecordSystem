using Student_Record_System.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Record_System
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        log l2 = new log();
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            l2.username= textBox1.Text;
            l2.password = textBox2.Text;
            bool msg = l2.check();
            if (msg)
            {
                MessageBox.Show("Login Success");
                this.Hide();
                ManageListForm form2 = new ManageListForm();
                form2.Show();
                        }
            else
            {
                MessageBox.Show("Wrong Username or password");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Username:admin \nPassword:admin");
            textBox1.Text = "admin";
            textBox2.Text = "admin";

        }
    }
}
