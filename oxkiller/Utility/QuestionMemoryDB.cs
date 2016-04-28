using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace oxkiller.Utility
{
    public class QuestionMemoryDB
    {
        #region singleton

        public static QuestionMemoryDB DBObject = new QuestionMemoryDB();

        public static QuestionMemoryDB getDB()
        {
            if (DBObject == null)
                DBObject = new QuestionMemoryDB();
            return DBObject;
        }

        public static void setDB(QuestionMemoryDB qdbNew)
        {
            DBObject = qdbNew;
        }

        QuestionMemoryDB()
        {

        }

        #endregion

        #region properties

        public List<Question> allQuestion = new List<Question>();

        bool sorted = false;

        #endregion

        #region logic

        /// <summary>
        /// Get possible questions using index.
        /// </summary>
        /// <param name="initial">The initial index.</param>
        /// <param name="limit">The maximum records.</param>
        /// <returns>All possible questions.</returns>
        public List<Question> getQuestion(string initial,int limit = 10)
        {
            if (!sorted) sort();
            long indexLow, indexHigh;
            Tuple<long, long> resultTuple = QuestionIndex.getPossibleIndex(initial);
            indexLow = resultTuple.Item1;
            indexHigh = resultTuple.Item2;
            int locationLow = allQuestion.BinarySearch(new Question(indexLow, "", ""), (q1, q2) => q1.index.CompareTo(q2.index));
            if (locationLow < 0) locationLow = -locationLow - 1; // only one -1 since we need to take the previous one
            int locationHigh = allQuestion.BinarySearch(new Question(indexHigh, "", ""), (q1, q2) => q1.index.CompareTo(q2.index));
            if (locationHigh < 0) locationHigh = -locationHigh - 1 - 1; //first for index inversion, second for not picking the one just larger than locationHigh.
            List<Question> result = new List<Question>();
            for(int i = locationLow; i<=locationHigh; i++)
            {
                result.Add(allQuestion[i]);
                if (result.Count > limit) break;
            }
            return result;
        }

        public void add(Question q)
        {
            allQuestion.Add(q);
            sorted = false;
        }

        public void sort()
        {
            allQuestion.Sort((q1,q2)=>q1.index.CompareTo(q2.index));
            sorted = true;
        }

        #endregion

    }
}
