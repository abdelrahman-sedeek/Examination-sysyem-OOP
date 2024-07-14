using Examination_sysyem.answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_sysyem.questions
{
    public abstract class Questions
    {
        
        public string Header { get; set; }
        public string Body { get; set; }
        public double Marks { get; set; }
        //public  AnswerList CorrectAnswer { get; set; 

        public Questions(string header,string body,  double marks)
        {
            Body = body;
            Header = header;
            Marks = marks;
            //CorrectAnswer = new AnswerList() ;
        }

        public abstract Answers GetAnswer();
        public abstract Answers GetCorrectAnswer();
        public abstract bool IsCorrect(Answers Answer);
        public abstract void Display();
    }
}
