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

        public ChooseAllQuestions(string header, string body,  double marks, Answers CorrectAnswer, List<string> options)
            :base(header, body, marks, CorrectAnswer)
        {
            Options = options;
        }
        public override  void Display()
        {
            Console.WriteLine($"{Header}:{Body} (Choose All correct answers)");
            for(int i = 0; i < Options.Count; i++)
            {
                Console.WriteLine($"{i+1}: {Options[i]}");
            }

        }
    }
}
