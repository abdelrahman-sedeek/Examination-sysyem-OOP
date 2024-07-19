using Examination_sysyem.questions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_sysyem.QuestionList
{
    public class ChooseAllFile : List<ChooseAllQuestions>, IQuestionList<ChooseAllQuestions>
    {
        public string FilePath { get; set; }
        public ChooseAllFile( string filePath) {
            var directory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            FilePath = filePath;

        }
        public  void Add(ChooseAllQuestions ChooseAllQuestion)
        {
            base.Add(ChooseAllQuestion);
            LogTandFQuestionToFile(ChooseAllQuestion);
        }
        public void DisplayQuestionsInfo()
        {
            foreach (var question in this)
            {
                question.Display();
                Console.WriteLine("============================================");
            }
        }

        public void LogTandFQuestionToFile(ChooseAllQuestions ChooseAllQuestion)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FilePath, true))
                {

                    writer.WriteLine($"Header: {ChooseAllQuestion.Header}");
                    writer.WriteLine($"Body: {ChooseAllQuestion.Body}");
                    writer.WriteLine($"Marks: {ChooseAllQuestion.Marks}");
                    for (int i = 0; i < ChooseAllQuestion.Options.Count; i++)
                        writer.WriteLine($"Option {i + 1}. {ChooseAllQuestion.Options[i]} ");
                    writer.WriteLine($"Correct options for this question : ");
                    writer.WriteLine(ChooseAllQuestion.GetCorrectAnswer());
                    writer.WriteLine();
                    writer.WriteLine("============================================");
                    writer.WriteLine();
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
