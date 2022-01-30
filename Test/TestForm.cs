
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

            for (int id = 0; id < testClass.ListQuestions.Length; ++id)
            {
                QControl control = InitQControl(id);

                for (int n = 0; n < testClass.ListQuestions[id].Answers.Count; ++n)
                {
                    control.CheckedListBox.Items.Add(testClass.ListQuestions[id].Answers.ElementAt(n));
                }

                qControls.Add(control);
            }
        }

        private struct QControl
        {
            public CheckedListBox CheckedListBox { get; set; }
            public TextBox TextBox { get; set; }
        }

        private ITestClass testClass;
        private List<QControl> qControls;
        private int yOffSet = 3;

        private QControl InitQControl(int id)
        {
            QControl qControl = new QControl
            {
                CheckedListBox = new CheckedListBox(),
                TextBox = new TextBox()
            };

            // 
            // textBox
            // 
            qControl.TextBox.BackColor = SystemColors.ButtonFace;
            qControl.TextBox.BorderStyle = BorderStyle.None;
            qControl.TextBox.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            qControl.TextBox.Location = new Point(3, yOffSet);
            qControl.TextBox.Multiline = true;
            qControl.TextBox.Name = "QtextBox" + qControls.Count.ToString();
            qControl.TextBox.ReadOnly = true;
            qControl.TextBox.Text = testClass.ListQuestions[id].Question;
            qControl.TextBox.Size = new Size(750, 20 * (qControl.TextBox.Text.Length / 50 + 1));
            yOffSet += 20 * (qControl.TextBox.Text.Length / 50 + 1);
            //qControl.textBox.TabIndex = 2;
            panel1.Controls.Add(qControl.TextBox);

            // 
            // checkedListBox
            // 
            qControl.CheckedListBox.CheckOnClick = true;
            qControl.CheckedListBox.BackColor = SystemColors.ButtonFace;
            qControl.CheckedListBox.BorderStyle = BorderStyle.None;
            qControl.CheckedListBox.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            qControl.CheckedListBox.FormattingEnabled = true;
            qControl.CheckedListBox.Location = new Point(3, yOffSet);
            yOffSet += 25 + testClass.ListQuestions.ElementAt(id).Answers.Count * qControl.CheckedListBox.ItemHeight;
            qControl.CheckedListBox.Name = "QcheckedListBox" + qControls.Count.ToString();
            qControl.CheckedListBox.Size = new Size(750, testClass.ListQuestions.ElementAt(id).Answers.Count * qControl.CheckedListBox.ItemHeight);
            //qControl.checkedListBox.TabIndex = 1;
            panel1.Controls.Add(qControl.CheckedListBox);
            qControl.CheckedListBox.SelectedIndexChanged += new EventHandler(CheckedListBox_SelectedIndexChanged);

            return (qControl);
        }

        private void CheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox checkedListBox = sender as CheckedListBox;

            if (checkedListBox.CheckedItems.Count > 1)
            {
                for (int i = 0; i < checkedListBox.Items.Count; i++)
                {
                    checkedListBox.SetItemChecked(i, false);
                }

                checkedListBox.SetItemChecked(checkedListBox.SelectedIndex, true);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int id = 0; id < qControls.Count; ++id)
            {
                testClass.CheckAnswer(id, qControls.ElementAt(id).CheckedListBox.SelectedIndex + 1);
            }

            DialogResult result = MessageBox.Show(
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

