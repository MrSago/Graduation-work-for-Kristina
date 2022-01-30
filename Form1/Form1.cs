
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Компьютерная_графика2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void SetWelcomePage()
        {
            string pdfDir = $"{Directory.GetCurrentDirectory()}\\Resources\\Welcome.pdf";

            if (axAcroPDF1.src != pdfDir)
            {
                axAcroPDF1.LoadFile(pdfDir);
                axAcroPDF1.setShowToolbar(false);
            }
        }

        /// <summary>
        /// События кнопок.
        /// </summary>
        private void OpenPdfToolStripClick(object sender, EventArgs e)
        {
            string pdfName = (sender as ToolStripMenuItem).Text;
            string pdfDir = $"{Directory.GetCurrentDirectory()}\\Resources\\{pdfName}.pdf";

            if (axAcroPDF1.src != pdfDir)
            {
                axAcroPDF1.LoadFile(pdfDir);
                axAcroPDF1.setShowToolbar(false);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            axAcroPDF1.src = "none";
            Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Тест1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm();

            testForm.StartPosition = FormStartPosition.Manual;
            testForm.Location = new Point(Location.X, Location.Y);

            string testName = (sender as ToolStripMenuItem).Text + ".test";
            testForm.InitTest(testName);

            Hide();
            testForm.ShowDialog();

            Show();
        }

        private void Тест2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

