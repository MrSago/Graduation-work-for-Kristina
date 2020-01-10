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
            Form1 form1 = new Form1();

            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = new Point(Location.X, Location.Y);

            form1.Size = Size;
            form1.WindowState = FormWindowState.Normal;

            Hide();
            form1.ShowDialog();
            form1.Close();
            form1 = null;
            
            Show();
            Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);

            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(Location.X, Location.Y);

            Hide();
            form2.ShowDialog();
            form2.Close();
            form2 = null;

            Show();
            Select();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.StartPosition = FormStartPosition.Manual;
            form3.Location = new Point(Location.X, Location.Y);

            Hide();
            form3.ShowDialog();
            form3.Close();
            form3 = null;

            Show();
            Select();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            form4.StartPosition = FormStartPosition.Manual;
            form4.Location = new Point(Location.X, Location.Y);

            Hide();
            form4.ShowDialog();
            form4.Close();
            form4 = null;

            Show();
            Select();
        }
    }
}
