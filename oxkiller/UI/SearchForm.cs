using oxkiller.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oxkiller.UI
{
    public partial class SearchForm : Form
    {
        QuestionMemoryDB qdb = new QuestionMemoryDB();

        int maxResult = 10;

        public SearchForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                List<string> allInitial = new List<string>();
                allInitial.Add(textBox1.Text.ToUpper());
                List<string> result = new List<string>();
                foreach(string s in allInitial)
                {
                    List<Question> singleResult = qdb.getQuestion(s);
                    foreach(Question q in singleResult)
                    {
                        result.Add(q.ToString());
                    }
                    if(result.Count > maxResult) break;
                }
                listBox1.DataSource = result;
            }
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            qdb.addQuestion("一加一等于二", "O");
            qdb.addQuestion("行行好行行好","O");
            qdb.addQuestion("一加一等于三", "X");
            qdb.addQuestion("一加二等于二", "X");
            qdb.addQuestion("一加二等于三", "O");
            qdb.addQuestion("一加三等于二", "X");
            qdb.addQuestion("二加一等于二", "X");
            qdb.addQuestion("二加一等于二", "X");
            qdb.sort();
        }
    }
}
