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
    public partial class StudentList : Form
    {
        public StudentList()
        {
            
        }
        DataTable dt;
        public StudentList(DataTable dt)
        {
            this.dt = dt;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
