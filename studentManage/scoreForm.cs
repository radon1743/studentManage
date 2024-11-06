using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentManage
{
    public partial class scoreForm : Form
    {

        courseClass course = new courseClass();
        studentClass student = new studentClass();
        public scoreForm()
        {
            InitializeComponent();
        }

        public void showStudentTable()
        {
            dataGridView_student.RowTemplate.Height = 40;
            dataGridView_student.DataSource = student.getStudentList();
        }

        public void showsScoreTable()
        {
            dataGridView_scorelist.RowTemplate.Height = 40;
            dataGridView_scorelist.DataSource = course.getCourseList();
        }

        private void scoreForm_Load(object sender, EventArgs e)
        {
            comboBox_course.DataSource = course.getCourseList();
            comboBox_course.DisplayMember = "coursename";
            comboBox_course.ValueMember = "coursename";

            showStudentTable();
           
        }
    }
}
