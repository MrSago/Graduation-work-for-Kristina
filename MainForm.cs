using System;
using System.Drawing;
using System.Windows.Forms;

namespace Компьютерная_графика2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProgramData.form1.StartPosition = FormStartPosition.Manual;
            ProgramData.form1.Location = new Point(Location.X, Location.Y);
            ProgramData.form1.Size = Size;
            ProgramData.form1.WindowState = FormWindowState.Normal;

            Hide();
            ProgramData.form1.ShowDialog();
            
            Show();
            Activate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProgramData.form2.StartPosition = FormStartPosition.Manual;
            ProgramData.form2.Location = new Point(Location.X, Location.Y);

            Hide();
            ProgramData.form2.ShowDialog();

            Show();
            Activate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProgramData.form3.StartPosition = FormStartPosition.Manual;
            ProgramData.form3.Location = new Point(Location.X, Location.Y);

            Hide();
            ProgramData.form3.ShowDialog();

            Show();
            Activate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProgramData.form4.StartPosition = FormStartPosition.Manual;
            ProgramData.form4.Location = new Point(Location.X, Location.Y);

            Hide();
            ProgramData.form4.ShowDialog();

            Show();
            Activate();
        }
    }
}
