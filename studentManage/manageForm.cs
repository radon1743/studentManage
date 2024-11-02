using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace studentManage
{
    public partial class manageForm : Form
    {
        studentClass student = new studentClass();
        public manageForm()
        {
            InitializeComponent();
        }

        private void registerForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        public void showTable()
        {
            dataGridView_student.RowTemplate.Height = 40;

            dataGridView_student.DataSource = student.getStudentList();


        }


        private void manageForm_Load(object sender, EventArgs e)
        { 
            showTable();

        }

        private void dataGridView_student_Click(object sender, EventArgs e)
        {
            textBox_id.Text = dataGridView_student.CurrentRow.Cells[0].Value.ToString();
            textBox_firstname.Text = dataGridView_student.CurrentRow.Cells[1].Value.ToString();
            textBox_lastname.Text = dataGridView_student.CurrentRow.Cells[2].Value.ToString();

            dateTimePicker_dob.Value = (DateTime)dataGridView_student.CurrentRow.Cells[3].Value;

            if (dataGridView_student.CurrentRow.Cells[4].Value.ToString() == "Male")
            {

                radioButton1.Checked = true;
            }
            else {
                radioButton2.Checked = true;
            }

            
            textBox_phone.Text = dataGridView_student.CurrentRow.Cells[5].Value.ToString();
            textBox_address.Text = dataGridView_student.CurrentRow.Cells[6].Value.ToString();

            byte[] img = (byte[])dataGridView_student.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(img);
            picturebox_studentImage.Image = Image.FromStream(ms);
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_firstname.Clear();
            textBox_lastname.Clear();
            textBox_address.Clear();
            textBox_phone.Clear();
            picturebox_studentImage.Image = null;
            radioButton2.Enabled = false;
            radioButton1.Enabled = false;
            dateTimePicker_dob.Value = DateTime.Now;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Select Photo(*.jpg;*.png)|*.jpg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picturebox_studentImage.Image = Image.FromFile(openFileDialog.FileName);

            }
        }
        public void filterTable()
        {
            if (textBox_search.Text.ToString() == "")
            {
                showTable();
            }
            else {
                dataGridView_student.RowTemplate.Height = 40;
                dataGridView_student.DataSource = student.searchStudent(textBox_search.Text.ToString());
            }
            


        }


        

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            filterTable();
        }
    }
}
