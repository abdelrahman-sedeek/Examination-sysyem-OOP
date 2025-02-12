﻿using Examination_sysyem.answers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_sysyem.questions
{
    public class TrueOrFalseQuestion:Questions
    {
        public bool CorrectAnswerIndex { get; set; }
        public TrueOrFalseQuestion(string header, string body,  double marks, bool correctAnswerIndex) : base(body, header, marks)
        {
            CorrectAnswerIndex = correctAnswerIndex;
        }

        public override void Display()
        {
            Console.WriteLine($"{Header}:{Body} (True or flase)");
        }

        public override Answers GetAnswer()
        {
            Console.Write("Enter True or False: ");
            string response = Console.ReadLine();
            return new Answers(new List<string> { response });

        }

        public override Answers GetCorrectAnswer()
        {
            return new Answers(new List<string> { CorrectAnswerIndex.ToString() });
        }

        public override bool IsCorrect(Answers Answer)
        {
            string userInput = Answer.AnswerInput[0];
            bool userAnswer;
            if (!bool.TryParse(userInput, out userAnswer))
            {
                return false; 
            }
            return userAnswer == CorrectAnswerIndex ;
        }
    }
}
