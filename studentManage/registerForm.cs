using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Data;




namespace studentManage
{
    public partial class registerForm : Form
    {
       studentClass student = new studentClass();
       
        
        public registerForm()
        {
            InitializeComponent();
        }
       
        private void registerForm_Load(object sender, EventArgs e)
        {
            showTable(); 
        }

        public void showTable() {
            dataGridView_student.RowTemplate.Height = 40;
            dataGridView_student.DataSource = student.getStudentList();
            
            
        }
        

        bool verify() {
            if ((textBox_firstname.Text == "") || (textBox_lastname.Text == "") || (textBox_address.Text == "")
                || (textBox_phone.Text == "") || picturebox_studentImage.Image == null
                )
            {
                return false;
            }
            else { 
                return true;
            }
        
        }

         


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Select Photo(*.jpg;*.png)|*.jpg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picturebox_studentImage.Image = Image.FromFile(openFileDialog.FileName);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                string fname = textBox_firstname.Text.ToString();
                string lname = textBox_lastname.Text.ToString();
                DateTime bdate = dateTimePicker_dob.Value;
                string gender = radioButton1.Checked ? "Male" : "Female";
                MemoryStream ms = new MemoryStream();
                picturebox_studentImage.Image.Save(ms, picturebox_studentImage.Image.RawFormat);
                byte[] img = ms.ToArray();
                string addr = textBox_address.Text.ToString();
                string phone = textBox_phone.Text.ToString();

                if (student.insertStudents(fname, lname, bdate, gender, phone, addr, img))
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
        public void clear_data() {
            textBox_firstname.Clear();
            textBox_lastname.Clear();
            textBox_address.Clear();
            textBox_phone.Clear();
            picturebox_studentImage.Image = null;
            radioButton2.Enabled = false;
            radioButton1.Enabled = false;
            dateTimePicker_dob.Value = DateTime.Now;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            clear_data();
        }
    }
}
