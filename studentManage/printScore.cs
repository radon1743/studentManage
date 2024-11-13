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
    public partial class printScore : Form
    {
        scoreClass score = new scoreClass();

        public printScore()
        {
            InitializeComponent();
        }

        private void printScore_Load(object sender, EventArgs e)
        {
            showTable();
        }
        
        
        public void showTable()
        {
            dataGridView_student.RowTemplate.Height = 40;
            dataGridView_student.DataSource = score.getScoreList();
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
    }
}
    

