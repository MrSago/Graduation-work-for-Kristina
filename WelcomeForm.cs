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
            StaticForms.mainForm.StartPosition = FormStartPosition.Manual;
            StaticForms.mainForm.Location = new Point(Location.X, Location.Y);

            Hide();
            StaticForms.mainForm.ShowDialog();
            Close();
        }
    }
}
