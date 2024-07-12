﻿using Examination_sysyem.answers;
using Examination_sysyem.questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_sysyem.Exams
{
    public class PracticeExam:Exam
    {
        public PracticeExam(int time, int numberOfQuestions )
            : base(time, numberOfQuestions) { }

        public override void ShowExam()
        {
            Console.WriteLine("Practice Exam:");
            foreach (var item in QuestionAnswer)
            {
                item.Key.Display();
             
                foreach (var answer in item.Value)
                {
                    Console.WriteLine($"your Answer: {answer.AnswerInput}\n");

                }
                //Console.WriteLine(item.Key.CorrectAnswer.AnswerInput); 
            }
        }

    }
}
