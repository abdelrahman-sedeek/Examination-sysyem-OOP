using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_sysyem.Exams
{
    public class FinalExam : Exam
    {
        public FinalExam(int time, int NumberOfquestions) : base(time, NumberOfquestions) { }

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam:");
            foreach (var item in QuestionAnswer)
            {
                bool IsCorrect = item.Key.IsCorrect(item.Value);
                item.Key.Display();
                Console.WriteLine(IsCorrect ? "'Correct' " : "'InCorrect' ");
                    Console.WriteLine($"Your Answer: {item.Value}");

            }
        }
    }

}