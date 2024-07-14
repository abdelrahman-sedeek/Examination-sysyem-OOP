using Examination_sysyem.answers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_sysyem.questions
{
    public class ChooseAllQuestions:Questions
    {
        public List<string> Options { get; set; }
        public List<int> CorrectAnswerIndices { get; set; }
        public ChooseAllQuestions(string header, string body,  double marks,  List<string> options,List<int> _correctAnswer)
            :base(header, body, marks)
        {
            Options = options;
            CorrectAnswerIndices = new List<int>();
        }
        public override  void Display()
        {
            Console.WriteLine($"{Header}:{Body} (Choose All correct answers)");
            for(int i = 0; i < Options.Count; i++)
            {
                Console.WriteLine($"{i+1}: {Options[i]}");
            }

        }

        public override Answers GetAnswer()
        {
            Console.WriteLine();
            Console.Write("Enter the numbers of your choices  ");
            string response = Console.ReadLine();
            List<string> responses = response.Split(',').Select(r => ( r.Trim()) ).ToList();
            return new Answers( responses );

        }

        public override Answers GetCorrectAnswer()
        {

            var correctAnswers = CorrectAnswerIndices.Select(i => (i + 1).ToString()).ToList();
            return new Answers(correctAnswers);
        }

        public override bool IsCorrect(Answers Answer)
        {
            for(int i = 0;i<Answer.AnswerInput.Count;i++)
            {

                if (!(CorrectAnswerIndices.ToString()).Contains( Answer.AnswerInput[i]))
                {
                    return false;
                }

            }
            return true;
        }
    }
}
