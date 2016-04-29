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
        QuestionMemoryDB qdb = QuestionMemoryDB.getDB();

        int maxResult = 10;

        public SearchForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchForQuestion();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                searchForQuestion();
            }
        }

        private void searchForQuestion()
        {
            List<string> allInitial = new List<string>();
            allInitial.Add(textBox1.Text.ToUpper());
            List<string> result = new List<string>();
            foreach (string s in allInitial)
            {
                List<Question> singleResult = qdb.getQuestion(s);
                foreach (Question q in singleResult)
                {
                    result.Add(q.ToString());
                }
                if (result.Count > maxResult) break;
            }
            listBox1.DataSource = result;
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

            FileManager fm = new FileManager();
            qdb = QuestionMemoryDB.getDB();
            //fm.writeFileWithGeneratedPath(qdb, "QuestionDB","txt");
            //qdb = (QuestionMemoryDB)fm.readFileWithGeneratedPath("QuestionDB", "txt", typeof(QuestionMemoryDB));
            //QuestionMemoryDB.setDB(qdb);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
