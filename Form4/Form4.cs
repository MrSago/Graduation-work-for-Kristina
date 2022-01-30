using System;
using System.Windows.Forms;

namespace Компьютерная_графика2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void AxAcroPDF1_Enter(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("none");
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
    }
}
