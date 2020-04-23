using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Компьютерная_графика2
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        public void InitTest(String fileName)
        {
            qControls = new List<QControl>();
            testClass = new TestClass(fileName);
            label1.Text = "Загружен тест: " + fileName;

            for (Int32 id = 0; id < testClass.ListQuestions.Length; ++id)
            {
                QControl control = InitQControl(id);

                for (Int32 n = 0; n < testClass.ListQuestions[id].answers.Count; ++n)
                {
                    control.checkedListBox.Items.Add(testClass.ListQuestions[id].answers.ElementAt(n));
                }

                qControls.Add(control);
            }
        }

        private struct QControl
        {
            public CheckedListBox checkedListBox { get; set; }
            public TextBox textBox { get; set; }
        }

        private ITestClass testClass;
        private List<QControl> qControls;
        private Int32 yOffSet = 3;

        private QControl InitQControl(Int32 id)
        {
            QControl qControl = new QControl();

            qControl.checkedListBox = new CheckedListBox();
            qControl.textBox = new TextBox();

            // 
            // textBox
            // 
            qControl.textBox.BackColor = SystemColors.ButtonFace;
            qControl.textBox.BorderStyle = BorderStyle.None;
            qControl.textBox.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            qControl.textBox.Location = new Point(3, yOffSet);
            qControl.textBox.Multiline = true;
            qControl.textBox.Name = "QtextBox" + qControls.Count.ToString();
            qControl.textBox.ReadOnly = true;
            qControl.textBox.Text = testClass.ListQuestions[id].question;
            qControl.textBox.Size = new Size(750, 20 * (qControl.textBox.Text.Length / 50 + 1));
            yOffSet += 20 * (qControl.textBox.Text.Length / 50 + 1);
            //qControl.textBox.TabIndex = 2;
            panel1.Controls.Add(qControl.textBox);

            // 
            // checkedListBox
            // 
            qControl.checkedListBox.CheckOnClick = true;
            qControl.checkedListBox.BackColor = SystemColors.ButtonFace;
            qControl.checkedListBox.BorderStyle = BorderStyle.None;
            qControl.checkedListBox.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            qControl.checkedListBox.FormattingEnabled = true;
            qControl.checkedListBox.Location = new Point(3, yOffSet);
            yOffSet += 25 + testClass.ListQuestions.ElementAt(id).answers.Count * qControl.checkedListBox.ItemHeight;
            qControl.checkedListBox.Name = "QcheckedListBox" + qControls.Count.ToString();
            qControl.checkedListBox.Size = new Size(750, testClass.ListQuestions.ElementAt(id).answers.Count * qControl.checkedListBox.ItemHeight);
            //qControl.checkedListBox.TabIndex = 1;
            panel1.Controls.Add(qControl.checkedListBox);
            qControl.checkedListBox.SelectedIndexChanged += new EventHandler(checkedListBox_SelectedIndexChanged);

            return (qControl);
        }

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox checkedListBox = sender as CheckedListBox;

            if (checkedListBox.CheckedItems.Count > 1)
            {
                for (int i = 0; i < checkedListBox.Items.Count; i++)
                    checkedListBox.SetItemChecked(i, false);
                checkedListBox.SetItemChecked(checkedListBox.SelectedIndex, true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (Int32 id = 0; id < qControls.Count; ++id)
            {
                testClass.CheckAnswer(id, qControls.ElementAt(id).checkedListBox.SelectedIndex + 1);
            }

            DialogResult result = MessageBox.Show (
                    "Ваш результат: " + testClass.GetResult() + "\nХотите начать тест заново?",
                    "Тест завершён!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );

            if (result == DialogResult.Yes)
            {
                String fileName = testClass.FileName;
                TestForm_FormClosing(null, null);
                InitTest(fileName);
            }
            else
            {
                TestForm_FormClosing(null, null);
                Close();
            }
        }

        private void TestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            qControls = null;
            testClass = null;
            yOffSet = 3;
            panel1.Controls.Clear();
        }
    }
}
