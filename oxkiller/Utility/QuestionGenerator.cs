using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oxkiller.Utility
{
    public static class QuestionGenerator
    {
        public static List<Question> getQuestion(string q,string a,string text = "")
        {
            List<Question> result = new List<Question>();
            List<string> allInitials = pinyin.getAllPossibleInitials(q);
            foreach(string s in allInitials)
            {
                if(String.IsNullOrWhiteSpace(text))
                {
                    result.Add(new Question(QuestionIndex.getPreciseIndex(s), q, a,q));
                }
                else
                {
                    result.Add(new Question(QuestionIndex.getPreciseIndex(s), q, a, text));
                }

            }
            return result;
        }

        public static void addQuestion(this QuestionMemoryDB qdb,string q,string a,string text)
        {
            List<Question> allQ = getQuestion(q, a,text);
            qdb.allQuestion.AddRange(allQ);
        }
    }
}
