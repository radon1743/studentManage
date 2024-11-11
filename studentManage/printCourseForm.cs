using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;


namespace studentManage
{
    public partial class printCourseForm : Form
    {
        courseClass course = new courseClass();
        public printCourseForm()
        {
            InitializeComponent();
        }

        private void printCourseForm_Load(object sender, EventArgs e)
        {
            showTable();
        }
        public void showTable()
        {
            dataGridView_student.RowTemplate.Height = 40;
            dataGridView_student.DataSource = course.getCourseList();
        }

        public void sortCourse()
        {
            dataGridView_student.RowTemplate.Height = 40;
            if (radioButton1.Checked == true)
            {
                dataGridView_student.DataSource = course.getCourselist_opt("SELECT * FROM COURSE_TABLE");
            }
            else if (radioButton2.Checked == true)
            {
                dataGridView_student.DataSource = course.getCourselist_opt("SELECT * FROM COURSE_TABLE WHERE optional = 'Yes'");
            }
            else if (radioButton3.Checked == true)
            {
                dataGridView_student.DataSource = course.getCourselist_opt("SELECT * FROM COURSE_TABLE WHERE optional = 'No'");
            }
            else
            {
                dataGridView_student.DataSource = course.getCourselist_opt("SELECT * FROM COURSE_TABLE");
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sortCourse();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            sortCourse();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sortCourse();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Baroda school Course List";
            printer.SubTitle = string.Format("Date & Time: {0} ", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Made by rachit";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            // printer.PrintPreviewDataGridView(dataGridView_student);
            printer.PrintPreviewNoDisplay(dataGridView_student);
        }
        public void filterTable()
        {
            if (textBox1.Text.ToString() == "")
            {
                showTable();
            }
            else
            {
                dataGridView_student.RowTemplate.Height = 40;
                dataGridView_student.DataSource = course.searchCourse(textBox1.Text.ToString());
            }



        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filterTable();
        }

        private void dataGridView_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
