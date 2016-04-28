using oxkiller.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oxkiller.UI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            FileManager fm = new FileManager();
            QuestionMemoryDB.setDB((QuestionMemoryDB)fm.readFileWithGeneratedPath("QuestionDB", "txt", typeof(QuestionMemoryDB)));
            QuestionMemoryDB.getDB().sort();
        }

        private void conversionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConversionTest frm = new ConversionTest();
            frm.Show();
        }

        private void startSearchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm frm = new SearchForm();
            frm.Show();
        }

        private void loadDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aQFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    MessageBox.Show(openFileDialog1.FileName);
                    int count = QuestionImporter.QAformatImporter(openFileDialog1.FileName);
                    MessageBox.Show("Import Success. " + count + " entries imported.");
                    new FileManager().writeFileWithGeneratedPath(QuestionMemoryDB.getDB(), "QuestionDB","txt");
                    MessageBox.Show("Save complete.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
