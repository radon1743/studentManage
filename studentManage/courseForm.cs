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

namespace studentManage
{
    public partial class courseForm : Form
    {

        courseClass course = new courseClass();
        public courseForm()
        {
            InitializeComponent();
        }

        private void courseForm_Load(object sender, EventArgs e)
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
        public void clear_data() {
            textBox_coursename.Clear();
            textBox_desciption.Clear();
            textBox_hours.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            clear_data();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                string cname = textBox_coursename.Text.ToString();
                int hours = Convert.ToInt32(textBox_hours.Text);
                
                string opt = radioButton1.Checked ? "No" : "Yes";
                
                string desc = textBox_desciption.Text.ToString();

                if (course.insertCourse(cname,hours,desc,opt))
                {
                    MessageBox.Show("Student details added Successfully!");
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

                MessageBox.Show("Complete the form to add student details", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
