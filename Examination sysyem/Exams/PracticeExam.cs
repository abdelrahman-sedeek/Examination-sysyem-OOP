using Examination_sysyem.answers;
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
          
            foreach (var item in QuestionAnswer)
            {
                bool IsCorrect=item.Key.IsCorrect(item.Value);
                item.Key.Display();

                Console.WriteLine(IsCorrect? " 'Correct' ": $" 'InCorrect '\n Correct Answer: {item.Key.GetCorrectAnswer()} ");
                
                Console.WriteLine($"Your Answer: {item.Value}");

            }
        }

    }
}
