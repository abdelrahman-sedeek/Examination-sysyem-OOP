using Examination_sysyem.questions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_sysyem.QuestionList
{
    public class ChooseOneList : List<ChoodeOneQuestion>, IQuestionList<ChoodeOneQuestion>
    {
        public string FilePath { get; set; }

        public ChooseOneList(string filePath)
        {
            var directory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            FilePath = filePath;
        }

        public new void Add(ChoodeOneQuestion chooseOne)
        {
            base.Add(chooseOne);
            LogTandFQuestionToFile(chooseOne);
        }

        public void DisplayQuestionsInfo()
        {
            foreach (var question in this)
            {
                question.Display();
                Console.WriteLine("============================================");
            }
        }

        public void LogTandFQuestionToFile(ChoodeOneQuestion ChooseOne)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FilePath, true))
                {

                    writer.WriteLine($"Header: {ChooseOne.Header}");
                    writer.WriteLine($"Body: {ChooseOne.Body}");
                    writer.WriteLine($"Marks: {ChooseOne.Marks}");
                    writer.WriteLine($"Available options for this question");
                    for (int i = 0; i < ChooseOne.Options.Count; i++)
                    {
                        writer.WriteLine($"option {i + 1}. {ChooseOne.Options[i]} ");
                    }
                    writer.WriteLine($"Correct option for this question :  {ChooseOne.Options[ChooseOne.CorrectAnswerIndex]}");
                    writer.WriteLine("============================================");
                    writer.WriteLine();
                }
            }
          
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
