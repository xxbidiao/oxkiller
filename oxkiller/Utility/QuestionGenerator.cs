using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oxkiller.Utility
{
    public static class QuestionGenerator
    {
        public static List<Question> getQuestion(string q,string a)
        {
            List<Question> result = new List<Question>();
            List<string> allInitials = pinyin.getAllPossibleInitials(q);
            foreach(string s in allInitials)
            {
                result.Add(new Question(QuestionIndex.getPreciseIndex(s), q, a));
            }
            return result;
        }

        public static void addQuestion(this QuestionMemoryDB qdb,string q,string a)
        {
            List<Question> allQ = getQuestion(q, a);
            qdb.allQuestion.AddRange(allQ);
        }
    }
}
