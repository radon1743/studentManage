using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentManage
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }



        private void splashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int startpoint = 0;

        public void loginform() {
            this.Hide();
            var mainForm = new Form1();
            mainForm.FormClosed += (s, args) => this.Close();
            mainForm.Show();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Update();
            startpoint++;
            progressBar1.Value = startpoint;
            if (startpoint > 99) {
                timer1.Stop();
                loginform();
            }
            
        }
    }
}
