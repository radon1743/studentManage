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

        private void button3_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Baroda student List";
            printer.SubTitle = string.Format("Date & Time: {0} ",DateTime.Now);
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
    }
}
