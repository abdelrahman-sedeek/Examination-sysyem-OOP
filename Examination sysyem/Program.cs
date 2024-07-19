using Examination_sysyem.questions;
using System;
using System.Collections.Generic;
using Examination_sysyem.answers;
using Examination_sysyem.Exams;
using Examination_sysyem.subject;
using Examination_sysyem.QuestionList;

namespace Examination_sysyem
{
    internal class Program
    {

        static void Main(string[] args)
        {
            

        
   

            TrueOrFalseQuestion q1 = new TrueOrFalseQuestion("Q1", "The Earth is flat.", 5, true);
            ChoodeOneQuestion q2 = new ChoodeOneQuestion("Q2", "Body = \"Which is the largest planet?\"", 5, new List<string> { "Earth", "Mars", "Jupiter", "Saturn" }, 3);
            ChooseAllQuestions q3 = new ChooseAllQuestions("Math CA", "Select all prime numbers", 5, new List<string> { "2", "3", "4", "5" }, new List<string> { "0", "1", "3" });
            TrueOrFalseQuestion q4 = new TrueOrFalseQuestion("Q4", "Water freezes at 0 degrees Celsius.", 5, true);
            ChoodeOneQuestion q5 = new ChoodeOneQuestion("Q5", "Which element has the chemical symbol 'O'?", 5, new List<string> { "Oxygen", "Hydrogen", "Gold", "Osmium" }, 0);
            ChooseAllQuestions q6 = new ChooseAllQuestions("Q6", "Select all even numbers", 5, new List<string> { "1", "2", "3", "4" }, new List<string> { "1", "3" });

            string TFpath = @"D:\DEPI\c#\examination system\Examination sysyem\TureOrFlase Questions.txt";
            TrueFalseList TFfile = new TrueFalseList(TFpath);
            TFfile.Add(q1);
            TFfile.Add(q4);

            string ChooseOnePath = @"D:\DEPI\c#\examination system\Examination sysyem\ChooseOneQuestions.txt";
            ChooseOneList ChooseOneFile = new ChooseOneList(ChooseOnePath);

            ChooseOneFile.Add(q2);
            ChooseOneFile.Add(q5);
            string ChooseAllPath = @"D:\DEPI\c#\examination system\Examination sysyem\Choose All Questions.txt";
            ChooseAllFile ChooseAllFile = new ChooseAllFile(ChooseAllPath);

            ChooseAllFile.Add(q3);
            ChooseAllFile.Add(q6);


            Subject subject1 = new Subject("Math");


            Exam<Questions,Answers> practice = new PracticeExam(30, 3, subject1);
            practice.QuestionAnswer.Add(q1, null);
            practice.QuestionAnswer.Add(q2, null);
            practice.QuestionAnswer.Add(q3, null);
            Exam<Questions, Answers> Final = new FinalExam(30, 3, subject1);
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
