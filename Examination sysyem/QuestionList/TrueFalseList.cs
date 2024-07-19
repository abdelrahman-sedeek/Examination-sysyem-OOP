using Examination_sysyem.questions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_sysyem.QuestionList
{
    public class TrueFalseList : List<TrueOrFalseQuestion> , IQuestionList<TrueOrFalseQuestion>
    {
        public string FilePath { get; set; }

        public TrueFalseList(string filePath)
        {
            var directory = Path.GetDirectoryName(filePath);

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            FilePath = filePath;
        }

        public void Add(TrueOrFalseQuestion TandFQuestion)
        {
            base.Add(TandFQuestion);
            LogTandFQuestionToFile(TandFQuestion);

        }

        public void DisplayQuestionsInfo()
        {

            foreach (var question in this)
            {
                question.Display(); 
                Console.WriteLine("============================================");
            }
            
        }

        public void LogTandFQuestionToFile(TrueOrFalseQuestion TrueAndFalsequestion)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FilePath, true))
                {

                    writer.WriteLine($"Header: {TrueAndFalsequestion.Header}");
                    writer.WriteLine($"Body: {TrueAndFalsequestion.Body}");
                    writer.WriteLine($"Marks: {TrueAndFalsequestion.Marks}");
                    writer.WriteLine($"Question Correct Answer : {TrueAndFalsequestion.CorrectAnswerIndex}");
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
