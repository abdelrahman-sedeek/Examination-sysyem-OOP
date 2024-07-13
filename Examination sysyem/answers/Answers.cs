using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_sysyem.answers
{
    public class Answers
    {
        public List<string>  AnswerInput { get; set; }
        
        public Answers(List<string> _answerInput)
        {
            AnswerInput = _answerInput;
        }
        public bool Iscorrect(List<string> _answerInput)
        {
            return AnswerInput == _answerInput;
        }
        public override string ToString()
        {
            return string.Join(",", AnswerInput);
        }

    }
}
