using Examination_sysyem.answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Examination_sysyem.questions
{
    public class ChoodeOneQuestion :Questions
    {
        public List<string> Options { get; set; }
        public int CorrectAnswerIndex { get; set; }
        public ChoodeOneQuestion(string header, string body,  double marks, List<string> options,int _CorrectAnswerIndex)
            : base(header, body,  marks)
        {
            Options = options;
            CorrectAnswerIndex = _CorrectAnswerIndex;
        }
        public override void Display()
        {
            Console.WriteLine($"{Header}:{Body} (Choose one answer)");
            for (int i = 0; i < Options.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {Options[i]}");
            }
        }

  

       
        public override Answers GetAnswer()
        {

            Console.Write("Enter the number of your choice: ");
            string response = Console.ReadLine();
            
           
            return new Answers(new List<string> { response });
        }

        public override Answers GetCorrectAnswer()
        {
            return new Answers(new List<string> { (CorrectAnswerIndex + 1 ).ToString() });
        }

        public override bool IsCorrect(Answers Answer)
        {
            string userResponse = Answer.AnswerInput[0];

            return int.Parse(userResponse) - 1 == CorrectAnswerIndex;
        }
    }
}
