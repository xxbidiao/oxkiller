using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oxkiller.Utility
{
    /// <summary>
    /// Index of the question text.
    /// The index use 5 bit for each character, starting from lowest bit.
    /// Index - Character Mapping:
    /// 0 - Nothing (Question is not enough long)
    /// 1 - A
    /// 2 - B
    /// ...
    /// 26 - Z
    /// 27-30 (Reserved)
    /// 31 - Terminal (Do not use - for logic in this class)
    /// </summary>
    public class QuestionIndex
    {
        static long[] locationMoverLookup = { 34359738368L, 1073741824L, 33554432L, 1048576L, 32768L, 1024L, 32L, 1L };

        const int maxLength = 8;

        static char charNextToZ
        {
            get
            {
                return (char)('Z' + 1);
            }
        }

        /// <summary>
        /// Get the precise index of the given string.
        /// the string will be filled with spaces if not enough long.
        /// </summary>
        /// <param name="initials">Initial string.</param>
        /// <returns></returns>
        public static long getPreciseIndex(string initials)
        {
            string cleanInitials = initials.ToUpper();
            long result = 0;
            int length = maxLength;
            if (initials.Length < length) length = initials.Length;
            for(int i = 0; i < length; i++)
            {
                long currentCharInitial = 1 + cleanInitials[i] - 'A';
                if (currentCharInitial < 0) currentCharInitial = 0; //TODO: currently only for spaces - not yet dealing with bad input
                if (currentCharInitial > 31) currentCharInitial = 31;
                result += currentCharInitial * locationMoverLookup[i];
            }
            return result;
        }

        /// <summary>
        /// Get all possible index with given initial.
        /// </summary>
        /// <param name="initials">initial string.</param>
        /// <returns>Minimum and maximum possible index of given initial.</returns>
        public static Tuple<long,long> getPossibleIndex(string initials)
        {
            long minimum = getPreciseIndex(initials);
            long maximum = getPreciseIndex(initials +charNextToZ);
            return new Tuple<long,long>(minimum,maximum);
        }
    }
}
