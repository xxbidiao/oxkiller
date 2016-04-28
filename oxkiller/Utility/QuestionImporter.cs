﻿using System;
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
        public static int QAformatImporter(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);
            int count = 0;
            foreach(string line in lines)
            {
                if (String.IsNullOrWhiteSpace(line)) continue;
                try
                {
                    string cleanLine = line.Split('(')[0];
                    cleanLine = Regex.Replace(cleanLine, @"\s+", "");
                    QuestionMemoryDB.getDB().addQuestion(cleanLine.Substring(0, cleanLine.Length - 1), cleanLine.Substring(cleanLine.Length - 1, 1));
                    count++;
                }
                catch (Exception)
                {
                    string notimported = line;
                    MessageBox.Show("Failed to import the following line:" + line);
                }
            }
            return count;
        }
    }
}
