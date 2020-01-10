using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Компьютерная_графика2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile($"{Directory.GetCurrentDirectory()}\\Resources\\Welcome.pdf");
        }

        /// <summary>
        /// События кнопок.
        /// </summary>
        private void openPdfToolStripClick(object sender, EventArgs e)
        {
            string pdfName = (sender as ToolStripMenuItem).Text;
            string pdfDir = $"{Directory.GetCurrentDirectory()}\\Resources\\{pdfName}.pdf";

            if (axAcroPDF1.src != pdfDir)
            {
                axAcroPDF1.LoadFile(pdfDir);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prevState = WindowState;

            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axAcroPDF1.src = "none";
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            prevState = WindowState;

            if (WindowState != FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                if (prevState == FormWindowState.Normal)
                {
                    WindowState = FormWindowState.Normal;
                }
                else
                {
                    WindowState = FormWindowState.Maximized;
                }
            }
        }

        private void тест1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm();

            testForm.StartPosition = FormStartPosition.Manual;
            testForm.Location = new Point(Location.X, Location.Y);

            string testName = (sender as ToolStripMenuItem).Text + ".test";
            testForm.InitTest(testName);

            Hide();
            testForm.ShowDialog();
            testForm.Close();
            testForm = null;

            Show();
            Select();
        }

        private void тест2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm();

            testForm.StartPosition = FormStartPosition.Manual;
            testForm.Location = new Point(Location.X, Location.Y);

            string testName = (sender as ToolStripMenuItem).Text + ".test";
            testForm.InitTest(testName);

            Hide();
            testForm.ShowDialog();
            testForm.Close();
            testForm = null;

            Show();
            Select();
        }
    }
}
