using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Компьютерная_графика2
{
    public struct Question
    {
        public String question { get; set; }
        public List<String> answers { get; set; }
        public Int32 trueAnswer { get; set; }
        public Int32 checkedAnswer { get; set; }
    }

    interface ITestClass
    {
        String FileName { get; }
        Question[] ListQuestions { get; }
        void CheckAnswer(Int32 id, Int32 answer);
        String GetResult();
    }

    class TestClass : ITestClass
    {
        public String FileName { get; }

        public Question[] ListQuestions { get; }

        public TestClass(String fileName)
        {
            List<Question> NewListQuestions = new List<Question>();
            StreamReader streamReader = new StreamReader($"{Directory.GetCurrentDirectory()}\\Resources\\{fileName}", Encoding.UTF8);
            FileName = fileName;
            String str = streamReader.ReadLine();

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
                    Question question = new Question();
                    List<String> answers = new List<String>();

                    str = streamReader.ReadLine();

                    do
                    {
                        String paramStr = str[0].ToString() + str[1].ToString();
                        String prm = str.Substring(4, str.Length - 5);

                        switch (paramStr)
                        {
                            case "$Q":
                                question.question = prm;
                                break;

                            case "$A":
                                answers.Add(prm);
                                break;

                            case "$T":
                                question.trueAnswer = Int16.Parse(prm);
                                break;

                            default:
                                break;
                        }

                        str = streamReader.ReadLine();

                    } while (!String.IsNullOrEmpty(str) && str != "[QE]");

                    question.checkedAnswer = -1;
                    question.answers = answers;

                    NewListQuestions.Add(question);
                }

                str = streamReader.ReadLine();

            } while (!String.IsNullOrEmpty(str) && str != "[END]");

            streamReader.Close();

            ListQuestions = NewListQuestions.ToArray();
            NewListQuestions.Clear();
        }

        public void CheckAnswer(Int32 id, Int32 answer)
        {
            ListQuestions[id].checkedAnswer = answer;
        }

        public String GetResult()
        {
            Int32 countTrueAnswers = 0;

            for (Int32 id = 0; id < ListQuestions.Length; ++id)
            {
                if (ListQuestions[id].trueAnswer == ListQuestions[id].checkedAnswer)
                {
                    ++countTrueAnswers;
                }
            }

            return (countTrueAnswers.ToString() + '/' + ListQuestions.Length.ToString());
        }
    }
}
