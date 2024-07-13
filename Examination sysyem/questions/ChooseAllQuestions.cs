using Examination_sysyem.answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_sysyem.questions
{
    public class ChooseAllQuestions:Questions
    {
        public List<string> Options { get; set; }
        public List<int> CorrectAnswers { get; set; }
        public ChooseAllQuestions(string header, string body,  double marks,  List<string> options,List<int> _correctAnswer)
            :base(header, body, marks)
        {
            Options = options;
            CorrectAnswers = new List<int>();
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
    }
}
