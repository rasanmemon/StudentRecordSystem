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
    public partial class AddStudentForm : Form
    {
        int id = 0;
        long phone = 0;
        string name = " ";
        string fname = " ";
        string address = " ";
        string co = " ";
        string gender = " ";

        public AddStudentForm()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //try
            //{
            if (textBoxName.Text == " " || textBoxFname.Text == " " || textBoxID.Text == " " || textBoxPhone.Text == " " || textBoxAddress.Text == " ")
            {
                MessageBox.Show("Fill All Fields");
            }
            else
            {
                name = textBoxName.Text;
                fname = textBoxFname.Text;
                id = Convert.ToInt32(textBoxID.Text);
                phone = Int64.Parse(textBoxPhone.Text);


                address = textBoxAddress.Text;
                gender = " ";
                DateTime dob = dateTimePicker1.Value;

                if (radioButton2.Checked)
                {
                    gender = "female";
                }
                else if (radioButton1.Checked)
                {
                    gender = "male";
                }
                int bornyear = dateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;
                co = comboBox1.SelectedItem.ToString();
                if ((this_year - bornyear) < 15)
                {
                    MessageBox.Show("The Student Age Must be greater than 15 years");
                }
                  else
                {
                    dt.Rows.Add(id, name, fname,dob,gender,co,phone,address);
                    MessageBox.Show("Student Added");
                   // ManageListForm mf = new ManageListForm(dt);
                    //mf.Show();
                }
            }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //dt.Rows.Add(id,name,fname);
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            radioButton1.Checked = true;

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Father Name", typeof(string));
            dt.Columns.Add("DateOfBirth", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("Course", typeof(string));
            dt.Columns.Add("Phone", typeof(int));
            dt.Columns.Add("Address", typeof(string));


        }
    }
}

