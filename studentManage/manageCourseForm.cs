using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentManage
{
    public partial class manageCourseForm : Form
    {
        courseClass course = new courseClass();
        public manageCourseForm()
        {
            InitializeComponent();
        }
        public void clear_data()
        {
            textBox_coursename.Clear();
            textBox_desciption.Clear();
            textBox_hours.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void manageCourseForm_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            showTable();
        }
        public void showTable()
        {
            dataGridView_student.RowTemplate.Height = 40;
            dataGridView_student.DataSource = course.getCourseList();


        }


        bool verify()
        {
            if ((textBox_coursename.Text == "") || (textBox_hours.Text == "") || (textBox_desciption.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            clear_data();
        }
        
        private void button_update_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                int id = Convert.ToInt32(textBox_courseid.Text);
                string cname = textBox_coursename.Text.ToString();
                int chours = Convert.ToInt32(textBox_hours.Text);
                string opt = radioButton1.Checked ? "No" : "Yes";
                
                string desc = textBox_desciption.Text.ToString();
               

                if (course.updateCourse(id, cname, chours, desc, opt))
                {
                    MessageBox.Show("Course details Updated Successfully!");
                    showTable();
                    clear_data();

                }
                else
                {
                    MessageBox.Show("DataBase connect failed!!", "Database connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {

                MessageBox.Show("Complete the form to add course details", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (textBox_courseid.Text.ToString() == "")
            {
                MessageBox.Show("Select student first", "Nothing selected");
            }
            else
            {

                int id = Convert.ToInt32(textBox_courseid.Text);


                DialogResult dr = MessageBox.Show("Do You Want to Erase Student Details?", "Remove Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    if (course.deleteCourse(id))
                    {
                        MessageBox.Show("Course details Updated Successfully!");
                        showTable();
                        clear_data();
                    }
                    else
                    {
                        MessageBox.Show("DataBase connect failed!!", "Database connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void dataGridView_student_Click(object sender, EventArgs e)
        {
            textBox_courseid.Text = dataGridView_student.CurrentRow.Cells[0].Value.ToString();
            textBox_coursename.Text = dataGridView_student.CurrentRow.Cells[1].Value.ToString();
            textBox_hours.Text = dataGridView_student.CurrentRow.Cells[2].Value.ToString();
            textBox_desciption.Text = dataGridView_student.CurrentRow.Cells[3].Value.ToString();

            

            if (dataGridView_student.CurrentRow.Cells[4].Value.ToString() == "No")
            {

                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }

        }
    }
}
