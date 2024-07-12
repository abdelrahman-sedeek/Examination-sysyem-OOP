using Examination_sysyem.answers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_sysyem.questions
{
    public class TrueOrFalseQuestion:Questions
    {

        public TrueOrFalseQuestion(string header, string body,  double marks, Answers CorrectAnswer) :base(body, header, marks, CorrectAnswer){}

        public override void Display()
        {
            Console.WriteLine($"{Header}:{Body} (True or flase)");
        }
    }
}
