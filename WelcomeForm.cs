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
            MainForm mainForm = new MainForm();

            mainForm.StartPosition = FormStartPosition.Manual;
            mainForm.Location = new Point(Location.X, Location.Y);

            Hide();
            mainForm.ShowDialog();
            Close();
        }
    }
}
