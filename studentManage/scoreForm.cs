using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace studentManage
{
    public partial class scoreForm : Form
    {

        scoreClass score = new scoreClass();
        studentClass student = new studentClass();
        courseClass course = new courseClass();
        public scoreForm()
        {
            InitializeComponent();
        }

        public void showStudentTable()
        {
            dataGridView_student.RowTemplate.Height = 40;
            dataGridView_student.DataSource = student.getStudentList_gender("SELECT student_id,firstname,lastname FROM STUDENT_TABLE");
            clear_data();
        }

        public void showsScoreTable()
        {
            dataGridView_scorelist.RowTemplate.Height = 40;
            dataGridView_scorelist.DataSource = score.getScoreList();
        }
        
        private void scoreForm_Load(object sender, EventArgs e)
        {
            comboBox_course.DataSource = course.getCourseList();
            comboBox_course.DisplayMember = "coursename";
            comboBox_course.ValueMember = "coursename";

            showStudentTable();
            showsScoreTable();
           
        }

        bool verify() {
            if (textBox_desciption.Text == "" || textBox_id.Text == "" || textBox_score.Text == "")
            {
                return false;
            }
            else {
                return true;

            }
        
        }

        private void button_add_Click(object sender, EventArgs e)
        {

            if (verify())
            {
                
                
                
                int id = Convert.ToInt32(textBox_id.Text);
                float sc = (float)Convert.ToDouble(textBox_score.Text);
                string cname = comboBox_course.Text.ToString();
                string desc = textBox_desciption.Text.ToString();
                if (score.checkScore(id, cname))
                {
                    if (score.insertScore(id, cname, sc, desc))
                    {
                        MessageBox.Show("Student's score Updated Successfully!");
                        showsScoreTable();
                    }
                    else
                    {
                        MessageBox.Show("DataBase connect failed!!", "Database connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    MessageBox.Show("Student's score already exists!");
                }

            }

            else {
                MessageBox.Show("Complete the form to add student score", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            
        }


        public void clear_data() {
            textBox_desciption.Clear();
            textBox_id.Clear();
            textBox_score.Clear();

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            clear_data();
            
        }

        private void dataGridView_student_Click(object sender, EventArgs e)
        {
            textBox_id.Text = dataGridView_student.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
