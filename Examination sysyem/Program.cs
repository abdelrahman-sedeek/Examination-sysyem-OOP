using Examination_sysyem.questions;
using System;
using System.Collections.Generic;
using Examination_sysyem.answers;
using Examination_sysyem.Exams;

namespace Examination_sysyem
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Questions q1 = new TrueOrFalseQuestion("Q1", "The Earth is flat.", 5);
            Questions q2 = new ChoodeOneQuestion("Q2", "Body = \"Which is the largest planet?\"", 5, new List<string> { "Earth", "Mars", "Jupiter", "Saturn" });

            AnswerList answerQ1 = new AnswerList() ;
            answerQ1.Add(new Answers( new List<string> { "5" }));
           
        
            Exam practice = new PracticeExam(30, 1);
            practice.QuestionAnswer.Add(q1,  answerQ1);
           
            AnswerList answerQ2 = new AnswerList();
            answerQ2.Add(new Answers(new List<string> { "Jupiter" }));
            Exam finalExam = new FinalExam(60,1);
            finalExam.QuestionAnswer.Add(q2, answerQ2);

            practice.ShowExam();
        }
    }
}
