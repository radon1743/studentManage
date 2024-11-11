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
    public partial class manageScore : Form

    {

        scoreClass score = new scoreClass();
        studentClass student = new studentClass();
        courseClass course = new courseClass();

        public manageScore()
        {
            InitializeComponent();
        }
        public void showStudentTable()
        {
            dataGridView_maintable.RowTemplate.Height = 40;
            dataGridView_maintable.DataSource = student.getStudentList_gender("SELECT student_id,firstname,lastname FROM STUDENT_TABLE");
        }

        public void showsScoreTable()
        {
            dataGridView_maintable.RowTemplate.Height = 40;
            dataGridView_maintable.DataSource = score.getScoreList("SELECT * FROM SCORE_TABLE WHERE student_id=@id",Convert.ToInt32(textBox_id.Text));
        }


        private void manageScore_Load(object sender, EventArgs e)
        {
            showStudentTable();
            comboBox_course.DataSource = course.getCourseList();
            comboBox_course.DisplayMember = "coursename";
            comboBox_course.ValueMember = "coursename";

            showStudentTable();
            
        }

        private void button_studentlist_Click(object sender, EventArgs e)
        {
            showStudentTable();
        }

        private void dataGridView_maintable_Click(object sender, EventArgs e)
        {
            textBox_id.Text = dataGridView_maintable.CurrentRow.Cells[0].Value.ToString();
            showsScoreTable();
            textBox_score.Text = dataGridView_maintable.CurrentRow.Cells[2].Value.ToString();
            textBox_desciption.Text = dataGridView_maintable.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
