using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace studentManage
{
    public partial class manageScore : Form

    {

        scoreClass score = new scoreClass();
        studentClass student = new studentClass();
        courseClass course = new courseClass();
        bool isscore = false;
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
            dataGridView_maintable.DataSource = score.getScoreList("SELECT * FROM SCORE_TABLE WHERE student_id=@id", Convert.ToInt32(textBox_id.Text));
            toggleScoreTableVisible();
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
            toggleScoreTableVisible();
        }


        public void toggleScoreTableVisible()
        {
            if (isscore)
            {
                isscore = false;
            }
            else
            {
                isscore = true;
            }
        }


        private void dataGridView_maintable_Click(object sender, EventArgs e)
        {
            if (isscore)
            {
                textBox_id.Text = dataGridView_maintable.CurrentRow.Cells[0].Value.ToString();
                comboBox_course.Text = dataGridView_maintable.CurrentRow.Cells[1].Value.ToString();
                textBox_score.Text = dataGridView_maintable.CurrentRow.Cells[2].Value.ToString();
               
            }
            else
            {
                textBox_id.Text = dataGridView_maintable.CurrentRow.Cells[0].Value.ToString();
                showsScoreTable();
                textBox_score.Text = dataGridView_maintable.CurrentRow.Cells[2].Value.ToString();
                textBox_desciption.Text = dataGridView_maintable.CurrentRow.Cells[3].Value.ToString();
            }

        }
        public void clear_data()
        {
            textBox_desciption.Clear();
            textBox_id.Clear();
            textBox_score.Clear();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            clear_data();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text.ToString() == "")
            {
                MessageBox.Show("Select student first", "Nothing selected");
            }
            else
            {

                int id = Convert.ToInt32(textBox_id.Text);
                string cname = comboBox_course.Text.ToString();
                DialogResult dr = MessageBox.Show("Do You Want to Erase Student Details?", "Remove Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    if (score.deleteStudentscore(id, cname))
                    {
                        MessageBox.Show("Student score deleted Successfully!");
                        showsScoreTable();
                        clear_data();
                    }
                    else
                    {
                        MessageBox.Show("DataBase connect failed!!", "Database connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
        bool verify()
        {
            if (textBox_desciption.Text == "" || textBox_id.Text == "" || textBox_score.Text == "")
            {
                return false;
            }
            else
            {
                return true;

            }

        }
        private void button_update_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                int id = Convert.ToInt32(textBox_id.Text);
                string cname = comboBox_course.Text.ToString();
                string desc = textBox_desciption.Text.ToString();
                float sc = (float)Convert.ToDouble(textBox_score.Text);


                if (score.updateScore(id, cname, sc, desc))
                {
                    MessageBox.Show("Student's score Updated Successfully!");
                    showsScoreTable();
                    clear_data();

                }
                else
                {
                    MessageBox.Show("DataBase connect failed!!", "Database connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {

                MessageBox.Show("Complete the form to add student details", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
