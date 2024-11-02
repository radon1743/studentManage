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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "" && 
                passwordTextBox.Text == "")
            
            {
                this.Hide();
                var mainForm = new Form2();
                mainForm.FormClosed += (s, args) => this.Close();
                mainForm.Show();

                //MessageBox.Show("Right email or Password");
            }   
            else 
            {
                MessageBox.Show("Wrong email or Password");
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            emailTextBox.Clear();
            passwordTextBox.Clear();
            emailTextBox.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
