using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oxkiller.Utility
{
    public static class QuestionImporter
    {
        public static double progress;

        public static int singleQuestionImporter(string question)
        {
            try
            {
                string cleanLine = question;
                cleanLine = Regex.Replace(cleanLine, @"\s+", "");
                cleanLine = cleanLine.Split('(')[0];
                cleanLine = cleanLine.Split('（')[0];
                for (int currentStart = 0; currentStart < cleanLine.Length - 1; currentStart++)
                {
                    string cleanLineSub = cleanLine.Substring(currentStart);
                    QuestionMemoryDB.getDB().addQuestion(
                        cleanLineSub.Substring(0, cleanLineSub.Length - 1),
                        cleanLineSub.Substring(cleanLineSub.Length - 1, 1),
                        cleanLine.Substring(0, cleanLine.Length - 1)
                        );
                }
                return 0;
            }
            catch (Exception)
            {
                throw;
                return -1;
            }

        }

        public static int QAformatImporter(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);
            int count = 0;
            int progressCounter = 0;
            int totalLines = lines.Count();
            foreach(string line in lines)
            {
                progressCounter++;
                progress = progressCounter * 100 / totalLines;
                if (String.IsNullOrWhiteSpace(line)) continue;
                try
                {
                    singleQuestionImporter(line);
                    count++;
                }
                catch (Exception)
                {
                    string notimported = line;
                    //MessageBox.Show("Failed to import the following line:" + line);
                }
            }
            QuestionMemoryDB.getDB().sort();
            return count;
        }
    }
}
