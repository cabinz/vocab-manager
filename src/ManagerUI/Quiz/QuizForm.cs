using ManagerLibrary;
using ManagerLibrary.Export;
using ManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ManagerUI
{
    public partial class QuizForm : Form
    {
        /// <summary>
        /// Stores all the accuracy of words.
        /// </summary>
        public List<MetricModel> Quiz { get; set; } = new List<MetricModel>();

        /// <summary>
        /// Represents current position of the word 
        /// in Quiz to display.
        /// Default as -1 for showing some tips.
        /// </summary>
        public int CurPos { get; set; } = -1;

        /// <summary>
        /// The word currently shown.
        /// </summary>
        public WordModel CurWord { get; set; }

        /// <summary>
        /// All forgotten words in previous quiz was added
        /// into the list for report.
        /// </summary>
        public List<WordModel> ForgetWords { get; set; } = new List<WordModel>();

        /// <summary>
        /// Flag for Forget mode checking.
        /// </summary>
        private bool InForgetMode { get; set; } = false;


        public QuizForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load all the word accuray from the data source into the Quiz
        /// and sort them preparing for ready.
        /// </summary>
        private void LoadAllMetrics()
        {
            Quiz = GlobalConfig.Connection.GetAllMetrics();
            Quiz.Sort((x, y) => x.CompareTo(y)); // Increasing order for accuracy.
        }

        /// <summary>
        /// Load all the word accuray of the tagged words
        /// from the data source into the Quiz
        /// and sort them preparing for ready.
        /// </summary>
        /// <param name="tags"></param>
        private void LoadMetircsByTags(List<TagModel> tags)
        {
            Quiz = new List<MetricModel>();
            HashSet<int> loadedWordIds = new HashSet<int>();

            foreach (TagModel tag in tags)
            {
                List<MetricModel> taggedMetrics = GlobalConfig.Connection.GetMetircByTagId(tag.TagID);
                foreach (MetricModel metric in taggedMetrics)
                {
                    if (!loadedWordIds.Contains(metric.WordID))
                    {
                        Quiz.Add(metric);
                        loadedWordIds.Add(metric.WordID);
                    }
                }
            }
        }

        /// <summary>
        /// Increment the CurPos if there is more words, and display the 
        /// next one on the board.
        /// Set lblWordText to "No more records." if boundary check fails.
        /// </summary>
        private void DisplayNext()
        {
            if (++CurPos < Quiz.Count)
            {
                CurWord = GlobalConfig.Connection.GetWordById(Quiz[CurPos].WordID);
                lblWordText.Text = CurWord.WordText;
            }
            else
            {
                lblWordText.Text = "No more records";
            }
        }

        private void btnRemember_Click(object sender, EventArgs e)
        {
            if (CurPos == -1)
            {
                DisplayNext();
            }
            else if (CurPos < Quiz.Count)
            {
                GlobalConfig.Connection.CreateRecord(new RecordModel(
                Quiz[CurPos].WordID, true));
                DisplayNext();
            }
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            if (CurPos == -1)
            {
                DisplayNext();
            }
            else if (CurPos < Quiz.Count)
            {
                // Enter forget mode if not being.
                if (!InForgetMode)
                {
                    InForgetMode = true;
                    // Send record.
                    GlobalConfig.Connection.CreateRecord(new RecordModel(
                    Quiz[CurPos].WordID, false));
                    // Show related info abt the word.
                    txtDefinition.Text = CurWord.Definition;
                    txtContext.Text = CurWord.Context;
                    txtContext.Text +=
                        (CurWord.ContextSource != "") ?
                        $"{Environment.NewLine}----------{Environment.NewLine}SOURCE: {CurWord.ContextSource}" : "";
                    txtNote.Text = CurWord.Note;
                    // Set button to "Next". Disable "Remember".
                    btnForget.Text = "Next";
                    btnRemember.Enabled = false;
                    // Display the scroll bar of info textboxes.
                    txtDefinition.ScrollBars = ScrollBars.Vertical;
                    txtContext.ScrollBars = ScrollBars.Vertical;
                    txtNote.ScrollBars = ScrollBars.Vertical;
                    // Add the word to ForgetWords.
                    ForgetWords.Add(CurWord);
                }
                else
                {
                    InForgetMode = false;
                    // Reset info labels.
                    txtNote.Text = "";
                    txtContext.Text = "";
                    txtDefinition.Text = "";
                    // Reset the buttons.
                    btnForget.Text = "Forget";
                    btnRemember.Enabled = true;
                    // Display the scroll bar of info textboxes.
                    txtDefinition.ScrollBars = ScrollBars.None;
                    txtContext.ScrollBars = ScrollBars.None;
                    txtNote.ScrollBars = ScrollBars.None;
                    // Display next word.
                    DisplayNext();
                }
            }
        }

        private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog locDialog = new SaveFileDialog();
            locDialog.FileName = "quiz_report_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            locDialog.DefaultExt = ".md";

            if (locDialog.ShowDialog() == DialogResult.OK)
            {
                MDExporter exporter = new MDExporter(ForgetWords, locDialog.FileName);
                exporter.Export();
                MessageBox.Show($"Report \"{locDialog.FileName}\" is successfully created.");
            }
        }

        private void loadAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAllMetrics();
            if (Quiz.Count > 0)
            {
                ActivateBoard();
            }
        }

        private void loadByTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TagSelectingForm newFrm = new TagSelectingForm();

            if (newFrm.ShowDialog() == DialogResult.OK)
            {
                LoadMetircsByTags(newFrm.checkedTags);
                if (Quiz.Count > 0)
                {
                    ActivateBoard();
                }
            }
        }

        private void ActivateBoard()
        {
            btnForget.Enabled = true;
            btnRemember.Enabled = true;
            lblWordText.Text = "Click any button to start.";
            txtContext.Text = "";
            txtDefinition.Text = "";
            txtNote.Text = "";
        }
    }
}
