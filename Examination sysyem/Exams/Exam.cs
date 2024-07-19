using System;
using System.Collections.Generic;

using Examination_sysyem.questions;
using Examination_sysyem.answers;
using System.Collections;
using Examination_sysyem.subject;
using static Examination_sysyem.ExamModeEvent;

namespace Examination_sysyem.Exams
{
    public abstract class Exam<TQuestion, TAnswer> : ICloneable, IComparable<Exam<TQuestion, TAnswer>>
        where TQuestion:Questions
        where TAnswer:Answers
        
    {
        modeType mode { get; set; }
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Subject Subject { get; set; }
        public Dictionary<Questions, Answers> QuestionAnswer { get; set; }
       
        public Exam(int time, int numberOfQuestions,Subject _subject)
        {
           this.Time = time;
            this.NumberOfQuestions = numberOfQuestions;
            this.QuestionAnswer = new Dictionary<Questions, Answers>();
            this.Subject = _subject;
            mode =modeType.Queued;
        }

        public  void TakeExam()
        {
            Console.WriteLine($"Time is: {Time} minutes");
            foreach (var x in QuestionAnswer.Keys)
            {
                x.Display();
                Answers answer = x.GetAnswer();
                QuestionAnswer[x] = answer;
               
            }
            
        }
        
        public abstract void ShowExam();

        public object Clone()
        {
           return MemberwiseClone();
        }


        public int CompareTo(Exam<TQuestion, TAnswer> other)
        {
            throw new NotImplementedException();
        }
        //public override bool Equals(Exam other)
        //{

        //        return this.Subject == other.Subject && this.Time == other.Time;


        //}
    }
}
