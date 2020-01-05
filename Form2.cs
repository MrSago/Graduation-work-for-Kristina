using System;
using System.Drawing;
using System.Windows.Forms;

namespace Компьютерная_графика2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProgramData.mainForm.StartPosition = FormStartPosition.Manual;
            ProgramData.mainForm.Location = new Point(Location.X, Location.Y);

            Hide();
        }
    }
}
