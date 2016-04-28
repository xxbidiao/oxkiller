using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.International.Converters.PinYinConverter;

namespace oxkiller.Utility
{
    public class pinyin
    {
        /// <summary> 
        /// Chinese characters into pinyin
        /// </summary> 
        /// <param name="str">Chinese characters</param> 
        /// <returns>Spelling</returns> 
        public static string getPinyin(string str)
        {
            string r = string.Empty;
            foreach (char obj in str)
            {
                try
                {
                    ChineseChar chineseChar = new ChineseChar(obj);
                    string t = chineseChar.Pinyins[0].ToString();
                    r += t.Substring(0, t.Length - 1);
                }
                catch
                {
                    r += obj.ToString();
                }
            }
            return r;
        }

        /// <summary> 
        /// Chinese characters into pinyin initials
        /// </summary> 
        /// <param name="str">Chinese characters</param> 
        /// <returns>The first letter</returns> 
        public static string getFirstPinyin(string str)
        {
            string r = string.Empty;
            foreach (char obj in str)
            {
                try
                {
                    ChineseChar chineseChar = new ChineseChar(obj);
                    string t = chineseChar.Pinyins[0].ToString();
                    r += t.Substring(0, 1);
                }
                catch
                {
                    r += obj.ToString();
                }
            }
            return r;
        }

        public static List<string> getAllPossibleInitials(string str, int limit = 6)
        {
            List<string> result = new List<string>();
            if (limit > str.Length) limit = str.Length;
            for (int iterations = 0; iterations < limit; iterations++ )
            {
                List<string> possibleInitials = new List<string>();
                char obj = str[iterations];
                try
                {
                    ChineseChar chineseChar = new ChineseChar(obj);
                    List<string> possiblePinyin = chineseChar.Pinyins.ToList();
                    for (int i = 0; i < possiblePinyin.Count; i++ )
                    {
                        if (possiblePinyin[i] == null) continue;
                        string s = possiblePinyin[i];
                        string initial = s.Substring(0, 1);
                        if (!possibleInitials.Contains(initial))
                        {
                            possibleInitials.Add(initial);
                        }
                    }
                    possibleInitials.Sort();
                }
                catch
                {
                    possibleInitials.Add(obj.ToString());
                }
                List<string> resultNew = new List<string>();
                if(result.Count == 0)
                {
                    resultNew = possibleInitials;
                }
                else
                {
                    foreach(string s in result)
                    {
                        foreach(string t in possibleInitials)
                        {
                            resultNew.Add(s + t);
                        }
                    }
                }
                result = resultNew;
            }
            return result;
        }
    }
}
