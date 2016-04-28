using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oxkiller.Utility
{
    /// <summary>
    /// A model class that represents questions (and its answers).
    /// </summary>
    public class Question
    {
        public Question(long index, string question,string answer)
        {
            this.index = index;
            this.question = question;
            this.answer = answer;
        }


        /// <summary>
        /// Q text.
        /// </summary>
        public string question;

        /// <summary>
        /// index of the question, used for searching.
        /// </summary>
        public long index;

        /// <summary>
        /// A text (O or X or specified answer).
        /// </summary>
        public string answer;

        public override string ToString()
        {
            return "[" + answer + "]" + question;
        }
    }
}
