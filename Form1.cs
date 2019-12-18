using System;
using System.Windows.Forms;

namespace Компьютерная_графика2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Лекции.
        /// </summary>
        private void введениеВКомпьютернуюГрафикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dir = $"{ProgramData.resDir}\\Лекции\\Введение в компьютерную графику.pdf";
            if (axAcroPDF1.src != dir)
            {
                axAcroPDF1.LoadFile(dir);
            }
        }

        private void растроваяГрафикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dir = $"{ProgramData.resDir}\\Лекции\\Растровая графика.pdf";
            if (axAcroPDF1.src != dir)
            {
                axAcroPDF1.LoadFile(dir);
            }
        }

        private void векторнаяГрафикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dir = $"{ProgramData.resDir}\\Лекции\\Векторная графика.pdf";
            if (axAcroPDF1.src != dir)
            {
                axAcroPDF1.LoadFile(dir);
            }
        }

        private void цветовыеМоделиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dir = $"{ProgramData.resDir}\\Лекции\\Цветовые модели.pdf";
            if (axAcroPDF1.src != dir)
            {
                axAcroPDF1.LoadFile(dir);
            }
        }
        ////////////////

        /// <summary>
        /// Практические работы.
        /// </summary>
        private void gimpПрактическаяРабота1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dir = $"{ProgramData.resDir}\\Практические\\Gimp. Практическая работа 1.pdf";
            if (axAcroPDF1.src != dir)
            {
                axAcroPDF1.LoadFile(dir);
            }
        }

        private void gimpПрактическаяРабота2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dir = $"{ProgramData.resDir}\\Практические\\Gimp. Практическая работа 2.pdf";
            if (axAcroPDF1.src != dir)
            {
                axAcroPDF1.LoadFile(dir);
            }
        }

        private void inkscapeПрактическаяРабота1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dir = $"{ProgramData.resDir}\\Практические\\Inkscape. Практическая работа 1.pdf";
            if (axAcroPDF1.src != dir)
            {
                axAcroPDF1.LoadFile(dir);
            }
        }

        private void inkscapeПрактическаяРабота2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dir = $"{ProgramData.resDir}\\Практические\\Inkscape. Практическая работа 2.pdf";
            if (axAcroPDF1.src != dir)
            {
                axAcroPDF1.LoadFile(dir);
            }
        }
        ////////////////

        /// <summary>
        /// Самостоятельные работы.
        /// </summary>
        private void векторныйРедакторInkscapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dir = $"{ProgramData.resDir}\\Самостоятельные\\Векторный редактор Inkscape.pdf";
            if (axAcroPDF1.src != dir)
            {
                axAcroPDF1.LoadFile(dir);
            }
        }

        private void работаВAdobePhotoshopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dir = $"{ProgramData.resDir}\\Самостоятельные\\Работа в Adobe Photoshop.pdf";
            if (axAcroPDF1.src != dir)
            {
                axAcroPDF1.LoadFile(dir);
            }
        }

        private void растровыйРедакторGIMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dir = $"{ProgramData.resDir}\\Самостоятельные\\Растровый редактор GIMP.pdf";
            if (axAcroPDF1.src != dir)
            {
                axAcroPDF1.LoadFile(dir);
            }
        }
        ////////////////

        /// <summary>
        /// События кнопок.
        /// </summary>
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
            Close();
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
        ////////////////

    }
}
