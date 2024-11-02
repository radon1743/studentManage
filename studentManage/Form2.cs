using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentManage
{

    public partial class Form2 : Form
    {
       
        studentClass student = new studentClass();
        public Form2()
        {
            InitializeComponent();
            
            customizeDesign();
        }

        



        private void Form2_Load(object sender, EventArgs e)
        {
            label_TotStd.Text = "Total Students : " + student.totalStudents();
            label_MStd.Text = "Male : " + student.maleStudents();
            label_FStd.Text = "Female : " + student.femaleStudents();

        }
        private void customizeDesign() { 
            panel_studentMenu.Visible = false;
            panel_scoreMenu.Visible = false;
            panel_courseMenu.Visible = false;

        }
        private void hideSubMenu() {

            if (panel_studentMenu.Visible == true)
                panel_studentMenu.Visible = false;
            if (panel_scoreMenu.Visible == true)
                panel_scoreMenu.Visible = false;
            if (panel_courseMenu.Visible == true)
                panel_courseMenu.Visible = false;
        }

        private void showSubMenu(Panel p) {

            if (p.Visible == false)
            {
                hideSubMenu();
                p.Visible = true;
            }
            else { 
                p.Visible = false;
            }
        }

        private void button_std_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_studentMenu);
        }
        #region studentSubMenu 
        private void button1_Click(object sender, EventArgs e)
        {
            //code
            openChildForm(new registerForm());
            hideSubMenu();


           /* var registrationForm = new registerForm();
            registrationForm.TopMost = true;
            registrationForm.FormClosed += (s, args) => this.Close();
            registrationForm.Show();*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //code
            openChildForm(new manageForm());
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //code
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //code
            hideSubMenu();
        }
        #endregion studentSubMenu 

        private void button5_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_courseMenu);
        }

        #region courseSubMenu
        private void button9_Click(object sender, EventArgs e)
        {
            //code
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //code
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //code
            hideSubMenu();
        }
        #endregion courseSubMenu


        private void button_Score_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_scoreMenu);
        }
        #region scoreSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
            //code
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //code
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //code
            hideSubMenu();
        }
        #endregion courseSubMenu


        private void button11_Click(object sender, EventArgs e)
        {
            if (activate != null) {
                activate.Close();
                
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Form activate = null;
       private void openChildForm(Form childForm)
        {

            if (activate != null) { activate.Close();}
            activate = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_mainForm.Controls.Add(childForm);
            panel_mainForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void panel_mainForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
