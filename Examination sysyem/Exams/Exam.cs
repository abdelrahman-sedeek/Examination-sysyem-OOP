using System;
using System.Collections.Generic;

using Examination_sysyem.questions;
using Examination_sysyem.answers;
using System.Collections;

namespace Examination_sysyem.Exams
{
    public abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Dictionary<Questions, Answers> QuestionAnswer { get; set; }

        public Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            QuestionAnswer= new Dictionary<Questions, Answers>();
        }

        public  void TakeExam()
        {
            
            foreach (var x in QuestionAnswer.Keys)
            {
                x.Display();
                Answers answer = x.GetAnswer();
                QuestionAnswer[x] = answer;
            }
        }
        
        public abstract void ShowExam();
    }
}
