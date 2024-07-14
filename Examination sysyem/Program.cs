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

            Questions q4 = new TrueOrFalseQuestion("Q4", "Water freezes at 0 degrees Celsius.", 5, true);
            Questions q5 = new ChoodeOneQuestion("Q5", "Which element has the chemical symbol 'O'?", 5, new List<string> { "Oxygen", "Hydrogen", "Gold", "Osmium" }, 0);
            Questions q6 = new ChooseAllQuestions("Q6", "Select all even numbers", 5, new List<string> { "1", "2", "3", "4" }, new List<int> { 1, 3 });






            Exam practice = new PracticeExam(30, 3);
            practice.QuestionAnswer.Add(q1,  null);
            practice.QuestionAnswer.Add(q2,  null);
            practice.QuestionAnswer.Add(q3,  null);
            Exam Final = new FinalExam(30, 3);
            Final.QuestionAnswer.Add(q4, null);
            Final.QuestionAnswer.Add(q5, null);
            Final.QuestionAnswer.Add(q6, null);

            Console.WriteLine("Choose the type of exam:");
            Console.WriteLine("1. Practice Exam");
            Console.WriteLine("2. Final Exam");
            Console.Write("Enter your choice (1 or 2): ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                practice.TakeExam();
                practice.ShowExam();

            }
            else if (choice == 2)
            {
                Final.TakeExam();
                Final.ShowExam();
            }
        }
    }
}
