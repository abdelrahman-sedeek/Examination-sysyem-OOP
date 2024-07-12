using System;
using System.Collections.Generic;

using Examination_sysyem.questions;
using Examination_sysyem.answers;

namespace Examination_sysyem.Exams
{
    public abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Dictionary<Questions, AnswerList> QuestionAnswer { get; set; }

        public Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            QuestionAnswer= new Dictionary<Questions, AnswerList>();
        }

        public abstract void ShowExam();
    }
}
