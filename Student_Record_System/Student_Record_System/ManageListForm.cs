using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Student_Record_System.classes;

namespace Student_Record_System
{
    public partial class ManageListForm : Form
    {
        public ManageListForm()
        {
            InitializeComponent();
            
        }
        Code cs = new Code();
        int selectedRow;
        DataTable dt = new DataTable();
        int id = 0;
        long phone = 0;
        string name = " ";
        string fname = " ";
        string address = " ";
        string co = " ";
        string gender = " ";
        int selectedindex;


        private void ManageListForm_Load(object sender, EventArgs e)
        {
            //table.Columns.Add("ID", typeof(int));
            //table.Columns.Add("Name", typeof(string));
            //table.Columns.Add("Father Name", typeof(string));
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            radioButton1.Checked = true;

            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Father Name", typeof(string));
            dt.Columns.Add("DateOfBirth", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("Course", typeof(string));
            dt.Columns.Add("Phone", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dataGridView1.DataSource = dt;
            // comboBox2.SelectedIndex = 0;
            try
            {

                getdata();

            }
            catch (Exception)
            {

                MessageBox.Show("Your File is Empty Plz fill ");
            }
            //cs.readdata();





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = comboBox2.SelectedItem.ToString();
          // MessageBox.Show(s);
            DataView dv = dt.DefaultView;

           dv.RowFilter = s+" like '%" + textBox1.Text + "%'";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == " " || textBoxFname.Text == " " || textBoxID.Text == " " || textBoxPhone.Text == " " || textBoxAddress.Text == " ")
            {
                MessageBox.Show("Fill All Fields");
            }
            else
            {
                name = textBoxName.Text;
                fname = textBoxFname.Text;
                id = Convert.ToInt32(textBoxID.Text);
                phone = Convert.ToInt64(textBoxPhone.Text);


                address = textBoxAddress.Text;
                DateTime dob = dateTimePicker1.Value;
                gender = " ";

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
                    dt.Rows.Add(id, name, fname, dob.ToShortDateString() , gender, co, phone, address);
                    MessageBox.Show("Student Added");
                    exporttotext();
                    //getdata();
                }
            }
        }
       

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdatarow = dataGridView1.Rows[selectedindex];
            newdatarow.Cells[0].Value = textBoxID.Text;
            newdatarow.Cells[1].Value = textBoxName.Text;
            newdatarow.Cells[2].Value = textBoxFname.Text;
            int bornyear = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            co = comboBox1.SelectedItem.ToString();
            if ((this_year - bornyear) < 15)
            {
                MessageBox.Show("The Student Age Must be greater than 15 years");
            }
            else
            {
                newdatarow.Cells[3].Value = dateTimePicker1.Value;
            }

                if (radioButton2.Checked)
            {
                    gender = "female";
                }
            else if (radioButton1.Checked)
            {
                        gender = "male";
                    }
                    newdatarow.Cells[4].Value = gender;
                    newdatarow.Cells[5].Value = comboBox1.SelectedItem.ToString();
                    newdatarow.Cells[6].Value = textBoxPhone.Text;
                    newdatarow.Cells[7].Value = textBoxAddress.Text;

            exporttotext();
            //getdata();

            MessageBox.Show("Data updated");
        }
        
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            selectedRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRow);
            exporttotext();
            getdata();
        }

       

        private void exporttotext()
        {
            //TextWriter 
            var sw = new StreamWriter(@"D:\SDN\Student_Record_System\Student_Record_System\Student_Record_System\bin\Debug\Student_Record.txt");
            int rowcount = dataGridView1.Rows.Count;
            for (int i = 0; i < rowcount-1 ; i++)
            {
                sw.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString() + "\t" +
                dataGridView1.Rows[i].Cells[1].Value.ToString() + "\t" +
                dataGridView1.Rows[i].Cells[2].Value.ToString() + "\t" +
                dataGridView1.Rows[i].Cells[3].Value.ToString() + "\t" +
                dataGridView1.Rows[i].Cells[4].Value.ToString() + "\t" +
                dataGridView1.Rows[i].Cells[5].Value.ToString() + "\t" +
                dataGridView1.Rows[i].Cells[6].Value.ToString() + "\t" +
                dataGridView1.Rows[i].Cells[7].Value.ToString());
            }
            sw.Close(); 
        }


        private void getdata()
        {
            dt.Clear();
            //cs.readdata();

            var tr = new StreamReader(@"D:\SDN\Student_Record_System\Student_Record_System\Student_Record_System\bin\Debug\Student_Record.txt") ;
            {

                while (!tr.EndOfStream)
                {
                    var data = tr.ReadLine();

                    string[] parts = data.Split('\t');
                    dt.Rows.Add(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7]);

                }
            }
            dt.AcceptChanges();
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login_Form l = new Login_Form();
            this.Hide();
            l.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login_Form l = new Login_Form();
            this.Hide();
            l.Show();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedindex = e.RowIndex;
            DataGridViewRow newdatarow = dataGridView1.Rows[selectedindex];
            textBoxID.Text = newdatarow.Cells[0].Value.ToString();
            textBoxName.Text = newdatarow.Cells[1].Value.ToString() ;
            textBoxFname.Text =newdatarow.Cells[2].Value.ToString() ;
            
            co = comboBox1.SelectedItem.ToString();

            dateTimePicker1.Text = newdatarow.Cells[3].Value.ToString() ;

            gender = newdatarow.Cells[4].Value.ToString();
            comboBox1.SelectedItem= newdatarow.Cells[5].Value.ToString() ;
            textBoxPhone.Text =newdatarow.Cells[6].Value.ToString();
            textBoxAddress.Text =newdatarow.Cells[7].Value.ToString() ;
        }
    }
}

