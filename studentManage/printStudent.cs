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
    public partial class printStudent : Form
    {
        studentClass student = new studentClass();
        public printStudent()
        {

            InitializeComponent();
        }

        private void printStudent_Load(object sender, EventArgs e)
        {
            sortStudents();
        }


        public void sortStudents() {
            dataGridView_student.RowTemplate.Height = 40;
            if (radioButton1.Checked == true)
            {
                dataGridView_student.DataSource=student.getStudentList_gender("SELECT * FROM STUDENT_TABLE");
            }
            else if (radioButton2.Checked == true)
            {
                dataGridView_student.DataSource = student.getStudentList_gender("SELECT * FROM STUDENT_TABLE WHERE GENDER = 'Female'");
            }
            else if (radioButton3.Checked == true)
            {
                dataGridView_student.DataSource = student.getStudentList_gender("SELECT * FROM STUDENT_TABLE WHERE GENDER = 'Male'");
            }
            else {
                dataGridView_student.DataSource = student.getStudentList_gender("SELECT * FROM STUDENT_TABLE");
            }

        }
        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sortStudents();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sortStudents();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            sortStudents();
        }
    }
}
