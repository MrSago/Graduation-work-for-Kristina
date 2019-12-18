using System;
using System.IO;
using System.Windows.Forms;

namespace Компьютерная_графика2
{
    static class ProgramData
    {
        /// <summary>
        /// Данные приложения.
        /// </summary>
        public static MainForm mainForm = new MainForm();
        public static Form1 form1 = new Form1();
        public static Form2 form2 = new Form2();
        public static Form3 form3 = new Form3();
        public static Form4 form4 = new Form4();
        public static string currentDir = Directory.GetCurrentDirectory();
        public static string resDir = $"{currentDir}\\Resources\\";
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelcomeForm());
        }
    }
}
