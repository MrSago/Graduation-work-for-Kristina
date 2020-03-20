using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Компьютерная_графика2
{
    static class StaticForms
    {
        public static WelcomeForm welcomeForm;
        public static MainForm mainForm;
        public static Form1 form1;
        public static Form2 form2;
        public static Form3 form3;
        public static Form4 form4;

        public static void Init()
        {
            try
            {
                welcomeForm = new WelcomeForm();
                mainForm = new MainForm();
                form1 = new Form1();
                form2 = new Form2();
                form3 = new Form3();
                form4 = new Form4();
            }
            catch (Exception e)
            {
                using (FileStream fstream = new FileStream($"{Directory.GetCurrentDirectory()}\\Exception.txt", FileMode.Create))
                {
                    byte[] array = new UTF8Encoding(true).GetBytes(e.ToString());
                    fstream.Write(array, 0, array.Length);
                }

                MessageBox.Show(
                    "Вызвано исключение во время работы программы! Возможно у вас не установлен Adobe Acrobat Reader. Информация об этой ошибке записана в файл Exception.txt",
                    "Exception runtime!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );

                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }
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

            StaticForms.Init();
            Application.Run(StaticForms.welcomeForm);
        }
    }
}
