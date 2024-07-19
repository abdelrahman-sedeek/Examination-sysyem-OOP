using Examination_sysyem.questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Examination_sysyem.QuestionList
{
    public interface IQuestionList<T>
    {
        public new void Add( T TandFQuestion);
        public void LogTandFQuestionToFile(T TrueAndFalsequestion);
        public  void DisplayQuestionsInfo();
    }
}
