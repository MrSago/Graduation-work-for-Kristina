
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Компьютерная_графика2
{
    public struct SQuestion
    {
        public string Question { get; set; }
        public List<string> Answers { get; set; }
        public int TrueAnswer { get; set; }
        public int CheckedAnswer { get; set; }
    }

    interface ITestClass
    {
        string FileName { get; }
        SQuestion[] ListQuestions { get; }
        void CheckAnswer(int id, int answer);
        string GetResult();
    }

    class TestClass : ITestClass
    {
        public string FileName { get; }

        public SQuestion[] ListQuestions { get; }

        public TestClass(string fileName)
        {
            List<SQuestion> NewListQuestions = new List<SQuestion>();
            StreamReader streamReader;
            try
            {
                streamReader = new StreamReader($"{Directory.GetCurrentDirectory()}\\Resources\\{fileName}", Encoding.UTF8);
            }
            catch (Exception)
            {
                throw new Exception("Can't read file.");
            }
            FileName = fileName;
            string str = streamReader.ReadLine();

            try
            {
                if (str != "[START]")
                {
                    throw new Exception("Don't have start point");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    e.ToString(),
                    "Exception error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );
            }

            str = streamReader.ReadLine();
            do
            {
                if (str == "[QS]")
                {
                    SQuestion question = new SQuestion();
                    List<string> answers = new List<string>();

                    str = streamReader.ReadLine();

                    do
                    {
                        string paramStr = str[0].ToString() + str[1].ToString();
                        string prm = str.Substring(4, str.Length - 5);

                        switch (paramStr)
                        {
                            case "$Q":
                                question.Question = prm;
                                break;

                            case "$A":
                                answers.Add(prm);
                                break;

                            case "$T":
                                question.TrueAnswer = short.Parse(prm);
                                break;

                            default:
                                break;
                        }

                        str = streamReader.ReadLine();

                    } while (!string.IsNullOrEmpty(str) && str != "[QE]");

                    question.CheckedAnswer = -1;
                    question.Answers = answers;

                    NewListQuestions.Add(question);
                }

                str = streamReader.ReadLine();

            } while (!string.IsNullOrEmpty(str) && str != "[END]");

            streamReader.Close();

            ListQuestions = NewListQuestions.ToArray();
            NewListQuestions.Clear();
        }

        public void CheckAnswer(int id, int answer)
        {
            ListQuestions[id].CheckedAnswer = answer;
        }

        public string GetResult()
        {
            int countTrueAnswers = 0;

            foreach (SQuestion q in ListQuestions)
            {
                if (q.TrueAnswer == q.CheckedAnswer)
                {
                    ++countTrueAnswers;
                }
            }

            return $"{countTrueAnswers}/{ListQuestions.Length}";
        }
    }
}

