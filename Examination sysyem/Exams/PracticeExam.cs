using Examination_sysyem.answers;
using Examination_sysyem.questions;
using Examination_sysyem.subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_sysyem.Exams
{
    public class PracticeExam: Exam<Questions, Answers>
    {
        public PracticeExam(int time, int numberOfQuestions,Subject subject )
            : base(time, numberOfQuestions,subject) { }

        public override void ShowExam()
        {
          
            foreach (var item in QuestionAnswer)
            {
                bool IsCorrect=item.Key.IsCorrect(item.Value);
                item.Key.Display();

                Console.WriteLine(IsCorrect? " 'Correct' ": $" 'InCorrect '\n Correct Answer: {item.Key.GetCorrectAnswer()} ");
                //Console.WriteLine($"Correct Answer: {item.Key.GetCorrectAnswer()}");
                Console.WriteLine($"Your Answer: {item.Value}");

            }
        }

    }
}
