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
            backgroundWork = backgroundReadDB;
            backgroundWorker1.RunWorkerAsync();
        }

        private void conversionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConversionTest frm = new ConversionTest();
            frm.Show();
        }

        private void startSearchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm frm = new SearchForm();
            try
            {
                frm.Show();
            }
            catch (Exception)
            {
                //do nothing
            }

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
                    getProgress = () => QuestionImporter.progress*0.9;
                    ProgressCheckingTimer.Start();
                    backgroundWork = QAImporterAsync;
                    backgroundWorker1.RunWorkerAsync();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Import failed. Original error: " + ex.Message);
                }
            }
        }

        private void QAImporterAsync()
        {
            backgroundWorker1.ReportProgress(0, null);
            toolStripStatusLabel1.Text = "Importing...";
            QuestionImporter.QAformatImporter(openFileDialog1.FileName);
            backgroundWorker1.ReportProgress(90, null);
            toolStripStatusLabel1.Text = "Saving imported entries to database...";
            new FileManager().writeFileWithGeneratedPath(QuestionMemoryDB.getDB(), "QuestionDB", "txt");
            backgroundWorker1.ReportProgress(100, null);
            toolStripStatusLabel1.Text = "Done!";
        }

        Action backgroundWork;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWork();
        }

        private void backgroundReadDB()
        {
            FileManager fm = new FileManager();
            backgroundWorker1.ReportProgress(0, null);
            toolStripStatusLabel1.Text = "Loading database from default file...";
            QuestionMemoryDB.setDB((QuestionMemoryDB)fm.readFileWithGeneratedPath("QuestionDB", "txt", typeof(QuestionMemoryDB)));
            backgroundWorker1.ReportProgress(50, null);
            toolStripStatusLabel1.Text = "Preparing database...";
            QuestionMemoryDB.getDB().sort();
            backgroundWorker1.ReportProgress(100, null);
            toolStripStatusLabel1.Text = "Done!";
        }

        Func<double> getProgress;


        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        private void ProgressCheckingTimer_Tick(object sender, EventArgs e)
        {
            backgroundWorker1.ReportProgress((int)getProgress(), null);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ProgressCheckingTimer.Stop();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox frm = new AboutBox();
            frm.Show();
        }

        
    }
}
