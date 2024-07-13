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
            Questions q1 = new TrueOrFalseQuestion("Q1", "The Earth is flat.", 5,true);
            Questions q2 = new ChoodeOneQuestion("Q2", "Body = \"Which is the largest planet?\"", 5, new List<string> { "Earth", "Mars", "Jupiter", "Saturn" },3);
            Questions q3 = new ChooseAllQuestions("Math CA", "Select all prime numbers", 5, new List<string> { "2", "3", "4", "5" }, new List<int> { 0, 1, 3 });

            
           
        
            Exam practice = new PracticeExam(30, 1);
            practice.QuestionAnswer.Add(q1,  null);
            practice.QuestionAnswer.Add(q2,  null);
            practice.QuestionAnswer.Add(q3,  null);

            practice.TakeExam();


            practice.ShowExam();
        }
    }
}
