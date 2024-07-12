using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_sysyem.Exams
{
    public class FinalExam:Exam
    {
        public FinalExam(int time,int NumberOfquestions):base(time,NumberOfquestions) { }
        
        public override void ShowExam()
        {
            throw new NotImplementedException();
        }
    }
}
