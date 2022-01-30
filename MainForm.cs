
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

        private void Button1_Click(object sender, EventArgs e)
        {
            StaticForms.form1.StartPosition = FormStartPosition.Manual;
            StaticForms.form1.Location = new Point(Location.X, Location.Y);

            StaticForms.form1.SetWelcomePage();

            Hide();
            StaticForms.form1.ShowDialog();

            Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            StaticForms.form2.StartPosition = FormStartPosition.Manual;
            StaticForms.form2.Location = new Point(Location.X, Location.Y);

            Hide();
            StaticForms.form2.ShowDialog();

            Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            StaticForms.form3.StartPosition = FormStartPosition.Manual;
            StaticForms.form3.Location = new Point(Location.X, Location.Y);

            Hide();
            StaticForms.form3.ShowDialog();

            Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            StaticForms.form4.StartPosition = FormStartPosition.Manual;
            StaticForms.form4.Location = new Point(Location.X, Location.Y);

            Hide();
            StaticForms.form4.ShowDialog();

            Show();
        }
    }
}

