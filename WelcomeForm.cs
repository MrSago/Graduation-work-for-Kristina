using System;
using System.Drawing;
using System.Windows.Forms;

namespace Компьютерная_графика2
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProgramData.mainForm.StartPosition = FormStartPosition.Manual;
            ProgramData.mainForm.Location = new Point(Location.X, Location.Y);

            Hide();
            ProgramData.mainForm.ShowDialog();
            Close();
        }
    }
}
