using System;
using System.Drawing;
using System.Windows.Forms;

namespace Компьютерная_графика2
{
    public partial class Form2 : Form
    {
        public MainForm parentForm;

        public Form2(Form form)
        {
            parentForm = form as MainForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.StartPosition = FormStartPosition.Manual;
            parentForm.Location = new Point(Location.X, Location.Y);

            Hide();
        }
    }
}
