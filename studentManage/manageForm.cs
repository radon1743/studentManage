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
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
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

        public void clear_data() {
            textBox_id.Clear(); 
            textBox_firstname.Clear();
            textBox_lastname.Clear();
            textBox_address.Clear();
            textBox_phone.Clear();
            picturebox_studentImage.Image = null;
            radioButton2.Enabled = false;
            radioButton1.Enabled = false;
            dateTimePicker_dob.Value = DateTime.Now;

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            clear_data();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text.ToString() == "")
            {
                MessageBox.Show("Select student first","Nothing selected");
            }
            else {

                int id = Convert.ToInt32(textBox_id.Text);


                DialogResult dr = MessageBox.Show("Do You Want to Erase Student Details?", "Remove Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes) {
                    if (student.deleteStudents(id))
                    {
                        MessageBox.Show("Student details Updated Successfully!");
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
        bool verify()
        {
            if ((textBox_firstname.Text == "") || (textBox_lastname.Text == "") || (textBox_address.Text == "")
                || (textBox_phone.Text == "") || picturebox_studentImage.Image == null
                )
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
                int id =  Convert.ToInt32(textBox_id.Text);
                string fname = textBox_firstname.Text.ToString();
                string lname = textBox_lastname.Text.ToString();
                DateTime bdate = dateTimePicker_dob.Value;
                string gender = radioButton1.Checked ? "Male" : "Female";
                MemoryStream ms = new MemoryStream();
                picturebox_studentImage.Image.Save(ms, picturebox_studentImage.Image.RawFormat);
                byte[] img = ms.ToArray();
                string addr = textBox_address.Text.ToString();
                string phone = textBox_phone.Text.ToString();

                if (student.updateStudents(id,fname, lname, bdate, gender, phone, addr, img))
                {
                    MessageBox.Show("Student details Updated Successfully!");
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
