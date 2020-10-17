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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void manageListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageListForm mlf = new ManageListForm();
            mlf.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addstudentform = new AddStudentForm();
            addstudentform.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Form l = new Login_Form();
            this.Hide();
            l.Show();
        }

        private void sTUDENTLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentList studentlist = new StudentList();
            studentlist.Show();
        }
    }
}
