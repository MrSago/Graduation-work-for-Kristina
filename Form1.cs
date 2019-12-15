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
        /// Лекции
        /// </summary>
        private void введениеВКомпьютернуюГрафикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
           axAcroPDF1.LoadFile($"{ProgramData.currentDir}\\Resources\\Лекции\\Введение в компьютерную графику.pdf");
        }

        private void растроваяГрафикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile($"{ProgramData.currentDir}\\Resources\\Лекции\\Растровая графика.pdf");
        }

        private void векторнаяГрафикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile($"{ProgramData.currentDir}\\Resources\\Лекции\\Векторная графика.pdf");
        }

        private void цветовыеМоделиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile($"{ProgramData.currentDir}\\Resources\\Лекции\\Цветовые модели.pdf");
        }

        /// <summary>
        /// Практические работы
        /// </summary>
        private void gimpПрактическаяРабота1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile($"{ProgramData.currentDir}\\Resources\\Практические\\Gimp. Практическая работа 1.pdf");
        }

        private void gimpПрактическаяРабота2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile($"{ProgramData.currentDir}\\Resources\\Практические\\Gimp. Практическая работа 2.pdf");
        }

        private void inkscapeПрактическаяРабота1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile($"{ProgramData.currentDir}\\Resources\\Практические\\Inkscape. Практическая работа 1.pdf");
        }

        private void inkscapeПрактическаяРабота2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile($"{ProgramData.currentDir}\\Resources\\Практические\\Inkscape. Практическая работа 2.pdf");
        }

        /// <summary>
        /// Самостоятельные работы
        /// </summary>
        private void векторныйРедакторInkscapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile($"{ProgramData.currentDir}\\Resources\\Самостоятельные\\Векторный редактор Inkscape.pdf");
        }

        private void работаВAdobePhotoshopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile($"{ProgramData.currentDir}\\Resources\\Самостоятельные\\Работа в Adobe Photoshop.pdf");
        }

        private void растровыйРедакторGIMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile($"{ProgramData.currentDir}\\Resources\\Самостоятельные\\Растровый редактор GIMP.pdf");
        }

        /// <summary>
        /// События кнопок
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                prevState = WindowState;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                prevState = WindowState;
                WindowState = FormWindowState.Normal;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
            {
                prevState = WindowState;
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                if (prevState == FormWindowState.Normal)
                {
                    prevState = WindowState;
                    WindowState = FormWindowState.Normal;
                }
                else
                {
                    prevState = WindowState;
                    WindowState = FormWindowState.Maximized;
                }
            }
        }
    }
}
