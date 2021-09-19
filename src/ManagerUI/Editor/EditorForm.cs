using ManagerLibrary;
using ManagerLibrary.AutoFiller;
using ManagerLibrary.Export;
using ManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ManagerUI
{
    public partial class EditorForm : Form
    {
        /// <summary>
        /// All words loaded from data source
        /// </summary>
        List<WordModel> AllWords = new List<WordModel>();

        /// <summary>
        /// The words to display in lstWords after filtered
        /// </summary>
        List<WordModel> ListedWords = new List<WordModel>();

        /// <summary>
        /// Stores the candidate tags for cmbCandidateTags.
        /// </summary>
        List<TagModel> CandidateTags = new List<TagModel>();

        /// <summary>
        /// Stores the selected tags for lstSelectedTags.
        /// </summary>
        List<TagModel> SelectedTags = new List<TagModel>();

        /// <summary>
        /// The auto-filler for current word (of spelling in the txtWordText)
        /// </summary>
        public IAutoFiller AutoFiller { get; set; }

        /// <summary>
        /// Constructor of the VocabEditorForm.
        /// </summary>
        public EditorForm()
        {
            InitializeComponent();

            LoadWordList();
            ClearWordEditorInput();

            LoadTaggingBox();

            LoadTagList();
            ClearTagEditorInput();
        }

        /// <summary>
        /// Load all the words from data source using Connection.GetAllWords().
        /// Then wire up all the words to lstWords.
        /// The order of the words will be reversed to guarantee 
        /// the lastest added words are always on the top.
        /// </summary>
        private void LoadWordList()
        {
            AllWords = GlobalConfig.Connection.GetAllWordSpellings();
            AllWords.Reverse();

            ListedWords = AllWords;
            WireUpWordList();
        }

        /// <summary>
        /// Wire ListedWords up to the lstWords for display.
        /// The selected index will automatically set to be 0 
        /// if any item is in the list.
        /// </summary>
        private void WireUpWordList()
        {
            lstWords.DataSource = ListedWords;
            lstWords.DisplayMember = "WordText";
            lblNumFiltered.Text = $"Filtered: {ListedWords.Count} / {AllWords.Count}";
            //if(lstWords.SelectedIndex != -1)
            //{
            //    lstWords.SetSelected(lstWords.SelectedIndex, false);
            //}
        }

        /// <summary>
        /// Load all the tags to the CandidateTags member,
        /// clear all the tags in SelectedTags memeber,
        /// wire the lists up to display.
        /// </summary>
        private void LoadTaggingBox()
        {
            CandidateTags = GlobalConfig.Connection.GetAllTags();
            SelectedTags = new List<TagModel>();
            WireUpTaggingLists();
        }

        /// <summary>
        /// Wire up / Refresh the cmbCandidateTags and lstSelectedTags
        /// to display latest data.
        /// </summary>
        private void WireUpTaggingLists()
        {
            // The NULL assignment is necessary for refreshing.
            lstSelectedTags.DataSource = null;
            lstSelectedTags.DataSource = SelectedTags;
            lstSelectedTags.DisplayMember = "TagName";
            if (lstSelectedTags.SelectedIndex != -1)
            {
                lstSelectedTags.SetSelected(lstSelectedTags.SelectedIndex, false);
            }

            cmbCandidateTags.DataSource = null;
            cmbCandidateTags.DataSource = CandidateTags;
            cmbCandidateTags.DisplayMember = "TagName";
        }

        /// <summary>
        /// Basic validation for user inputs in Word Editor.
        /// </summary>
        /// <returns></returns>
        private bool ValidateWordEditor()
        {
            bool res = true;

            if (txtWordText.Text.Length > 50)
            {
                MessageBox.Show("The length of word exceeds 50, " +
                    "which will be trucated.");
                res = false;
            }
            else if (txtWordText.Text.Length == 0)
            {
                MessageBox.Show("Please input the word.");
                res = false;
            }

            return res;
        }

        /// <summary>
        /// For btnCreateWord, validate the input based on ValidateWordEditor(),
        /// adding repetition checks and warning dialog.
        /// </summary>
        /// <returns></returns>
        private bool ValidateFormForCreateWord()
        {
            bool res = ValidateWordEditor();

            if (res)
            {
                if (GlobalConfig.Connection.GetAllWordSpellings().Any(x => x.WordText.ToLower() == txtWordText.Text.ToLower()))
                {
                    res = MessageBox.Show(
                        "There has already been similar words in the notebook, are you sure to create another one?",
                        "Tips",
                        MessageBoxButtons.YesNo) == DialogResult.Yes;
                }
            }

            return res;
        }

        /// <summary>
        /// For btnUpdateWord, validate the input based on ValidateWordEditor(),
        /// adding checks and warning dialog for misoperation.
        /// It means if the update info has different spelling, a dialog will prompt out
        /// for comfirmation. Same for updating the spelling to one already exsists.
        /// No repetition check for update spelling.
        /// </summary>
        /// <returns></returns>
        private bool ValidateFormForUpdateWord()
        {
            bool res = ValidateWordEditor();

            if (res)
            {
                if (lstWords.SelectedItem != null)
                {
                    if (((WordModel)lstWords.SelectedItem).WordText != txtWordText.Text)
                    {
                        res = MessageBox.Show(
                            "Are you sure to change the spelling of the seleted word(s)?",
                            "Tips",
                            MessageBoxButtons.YesNo) == DialogResult.Yes;
                    }
                }
                else
                {
                    res = false;
                    MessageBox.Show("Please select the word to update.");
                }
            }

            return res;
        }


        private void btnCreateWord_Click(object sender, EventArgs e)
        {
            CreateWord();
        }

        /// <summary>
        /// Validate the table selection and user inputs
        /// and commit a creation of a new word to data storage.
        /// </summary>
        private void CreateWord()
        {
            //LongmanDict dict = new LongmanDict();
            //if (String.IsNullOrEmpty(txtDefinition.Text.Trim()))
            //{
            //    dict = new LongmanDict(txtWordText.Text);
            //    txtDefinition.Text = dict.DefinitionText();
            //}
            //if(String.IsNullOrEmpty(txtContext.Text.Trim()))
            //{
            //    if (String.IsNullOrEmpty(dict.FullLink))
            //    {
            //        dict = new LongmanDict(txtWordText.Text);
            //    }
            //    txtContext.Text = dict.ContextText();
            //    if (!String.IsNullOrEmpty(txtContext.Text))
            //    {
            //        txtContextSource.Text = dict.FullLink;
            //    }
            //}

            if (tabVocabEditor.SelectedTab == tbpWordEditor && ValidateFormForCreateWord())
            {
                WordModel mdl = new WordModel(
                    txtWordText.Text,
                    txtDefinition.Text,
                    txtContext.Text,
                    txtContextSource.Text,
                    txtNote.Text,
                    SelectedTags);

                GlobalConfig.Connection.CreateWord(mdl);

                // The word added will be on the top of the list,
                // where it will be automatically selected and displayed
                LoadWordList();
            }
        }

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            TagModel tag = (TagModel)cmbCandidateTags.SelectedItem;

            if (tag != null) // The IF check is necessary.
            {
                CandidateTags.Remove(tag);
                SelectedTags.Add(tag);
                WireUpTaggingLists();
            }
        }

        private void btnRemoveTag_Click(object sender, EventArgs e)
        {
            TagModel tag = (TagModel)lstSelectedTags.SelectedItem;

            if (tag != null)
            {
                SelectedTags.Remove(tag);
                CandidateTags.Add(tag);
                WireUpTaggingLists();
            }
        }

        private void lstWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstWords.SelectedItem != null)
            {
                int selectedWordId = ((WordModel)lstWords.SelectedItem).WordID;

                DisplayWord(GlobalConfig.Connection.GetWordById(selectedWordId));
            }
            else
            {
                ClearWordEditorInput();
            }
        }

        /// <summary>
        /// Display a given word onto the editor board.
        /// Do nothing if null is passed.
        /// </summary>
        /// <param name="mdl">The WordModel object to display.</param>
        private void DisplayWord(WordModel mdl)
        {
            if (mdl != null)
            {
                // Text boxes.
                txtWordText.Text = mdl.WordText;
                txtDefinition.Text = mdl.Definition;
                txtContext.Text = mdl.Context;
                txtContextSource.Text = mdl.ContextSource;
                txtNote.Text = mdl.Note;

                // Tags.
                SelectedTags = mdl.Tags;
                CandidateTags = new List<TagModel>();
                foreach (TagModel tag in GlobalConfig.Connection.GetAllTags())
                {
                    if (!mdl.Tags.Any(x => x.TagID == tag.TagID))
                    {
                        CandidateTags.Add(tag);
                    }
                }
                WireUpTaggingLists();
            }
        }

        private void btnUpdateWord_Click(object sender, EventArgs e)
        {
            UpdateWord();
        }

        /// <summary>
        /// Validate the table selection and user input
        /// and commit a update of the selected word to the storage.
        /// </summary>
        private void UpdateWord()
        {
            if (tabVocabEditor.SelectedTab == tbpWordEditor && ValidateFormForUpdateWord())
            {
                WordModel mdl = new WordModel(
                    txtWordText.Text,
                    txtDefinition.Text,
                    txtContext.Text,
                    txtContextSource.Text,
                    txtNote.Text,
                    SelectedTags);
                mdl.WordID = ((WordModel)lstWords.SelectedItem).WordID;

                GlobalConfig.Connection.UpdateWordById(mdl);

                // Store the idx and recover the selection
                // after reloading the words
                LoadWordList();
                for(int i = 0; i < lstWords.Items.Count; i++)
                {
                    if(((WordModel)lstWords.Items[i]).WordID == mdl.WordID)
                    {
                        lstWords.SetSelected(i, true);
                        break;
                    }
                }

            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstWords.SelectedItem != null)
            {
                GlobalConfig.Connection.RemoveWordById(((WordModel)lstWords.SelectedItem).WordID);

                LoadWordList();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearWordEditorInput();
        }

        /// <summary>
        /// Reset all the user input on editor board.
        /// </summary>
        private void ClearWordEditorInput(bool unselected = true)
        {
            if (lstWords.SelectedItem != null && unselected)
            {
                lstWords.SetSelected(lstWords.SelectedIndex, false);
            }

            txtWordText.Text = "";
            txtDefinition.Text = "";
            txtContext.Text = "";
            txtContextSource.Text = "";
            txtNote.Text = "";

            CandidateTags = GlobalConfig.Connection.GetAllTags();
            SelectedTags = new List<TagModel>();
            WireUpTaggingLists();
        }

        /// <summary>
        /// Refresh the table page when switching page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabVocabEditor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabVocabEditor.SelectedTab == tbpWordEditor)
            {
                // Both branches are for update the candidate tags in tagging box.
                if (lstWords.SelectedItem == null)
                {
                    ClearWordEditorInput();
                }
                else
                {
                    int selectedWordId = ((WordModel)lstWords.SelectedItem).WordID;
                    DisplayWord(GlobalConfig.Connection.GetWordById(selectedWordId));
                }
            }
            else if (tabVocabEditor.SelectedTab == tbpTagEditor)
            {
                if (lstTags.SelectedItem != null)
                {
                    FilterTaggedWords();
                }
            }
        }

        private void ClearTagEditorInput()
        {
            txtTagName.Text = "";
            txtTagInfo.Text = "";
            if (lstTags.SelectedItem != null)
            {
                lstTags.SetSelected(lstTags.SelectedIndex, false);
            }
        }

        private void LoadTagList()
        {
            List<TagModel> loadedTags = GlobalConfig.Connection.GetAllTags();
            loadedTags.Reverse();
            lstTags.DataSource = loadedTags;
            lstTags.DisplayMember = "TagName";
        }

        private void btnUpdateTag_Click(object sender, EventArgs e)
        {
            UpdateTag();
        }

        /// <summary>
        /// Validate the selection of table page and user inputs
        /// and commit an update of the selected tag to the storage.
        /// </summary>
        private void UpdateTag()
        {
            if (tabVocabEditor.SelectedTab == tbpTagEditor && ValidateFormForUpdateTag())
            {
                TagModel mdl = new TagModel(
                ((TagModel)lstTags.SelectedItem).TagID,
                txtTagName.Text, txtTagInfo.Text);

                GlobalConfig.Connection.UpdateTagById(mdl);

                LoadTagList();
            }
        }

        private void btnCreateTag_Click(object sender, EventArgs e)
        {
            CreateTag();
        }

        /// <summary>
        /// Validate the selection of table page and user inputs
        /// and commit an creation of a new tag to the storage.
        /// </summary>
        private void CreateTag()
        {
            if (tabVocabEditor.SelectedTab == tbpTagEditor && ValidateFormForCreateTag())
            {
                TagModel newTag = new TagModel(0, txtTagName.Text, txtTagInfo.Text);

                GlobalConfig.Connection.CreateTag(newTag);

                LoadTagList();
            }
        }

        /// <summary>
        /// Validation for user input in Tag Editor table page.
        /// </summary>
        /// <returns></returns>
        private bool ValidateTagEditor()
        {
            bool res = true;

            if (txtTagName.Text.Length > 50)
            {
                MessageBox.Show("The length of tag name exceeds 50, " +
                    "which will be trucated.");
                res = false;
            }
            if (txtTagName.Text.Length == 0)
            {
                MessageBox.Show("Please input the name to create a new tag.");
                res = false;
            }

            return res;
        }

        /// <summary>
        /// Based on ValidateTagEditor(), check repetition.
        /// </summary>
        /// <returns></returns>
        private bool ValidateFormForCreateTag()
        {
            bool res = ValidateTagEditor();

            if (res)
            {
                if (GlobalConfig.Connection.GetAllTags().Any(x => x.TagName == txtTagName.Text))
                {
                    res = MessageBox.Show(
                        "There has already been similar tags, are you sure to create another one?",
                        "Tips",
                        MessageBoxButtons.YesNo) == DialogResult.Yes;
                }
            }

            return res;
        }

        private bool ValidateFormForUpdateTag()
        {
            bool res = ValidateTagEditor();

            if (res)
            {
                if (lstTags.SelectedItem != null)
                {
                    if (((TagModel)lstTags.SelectedItem).TagName != txtTagName.Text)
                    {
                        res = MessageBox.Show(
                            "Are you sure to change the name of the tag?",
                            "Tips",
                            MessageBoxButtons.YesNo) == DialogResult.Yes;
                    }
                }
                else
                {
                    res = false;
                    MessageBox.Show("Please select the tag to update.");
                }
            }

            return res;
        }

        private void btnClearTagEditor_Click(object sender, EventArgs e)
        {
            ClearTagEditorInput();
        }

        private void btnDeleteTag_Click(object sender, EventArgs e)
        {
            bool comfirm = MessageBox.Show(
                    "All words will lose this tag after deletion, are you sure to continue?",
                    "Tips",
                    MessageBoxButtons.YesNo) == DialogResult.Yes;

            if (comfirm)
            {
                GlobalConfig.Connection.DeleteTagById(((TagModel)lstTags.SelectedItem).TagID);
                LoadTagList();
            }
        }

        private void lstTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTags.SelectedItem != null)
            {
                TagModel selectedTag = (TagModel)(lstTags.SelectedItem);

                // Display tag info.
                txtTagName.Text = selectedTag.TagName;
                txtTagInfo.Text = selectedTag.TagInfo;

                // Filter tagged words and display on lstTaggedWords;
                FilterTaggedWords();
            }
            else
            {
                lstTaggedWords.DataSource = null;
                grpTaggedFilter.Text = "Tagged Words: 0";
            }
        }

        /// <summary>
        /// Filter tagged words and display on lstTaggedWords.
        /// </summary>
        private void FilterTaggedWords()
        {
            if (lstTags.SelectedItem != null)
            {
                int tag_id = ((TagModel)lstTags.SelectedItem).TagID;
                lstTaggedWords.DataSource = GlobalConfig.Connection.GetTaggedWordSpellings(tag_id);
                lstTaggedWords.DisplayMember = "WordText";
                lstTaggedWords.SelectedIndex = -1;
                grpTaggedFilter.Text = $"Tagged Words: {lstTaggedWords.Items.Count}";
            }
        }

        private void lstSelectedTags_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int idx = this.lstSelectedTags.IndexFromPoint(e.Location);

            if (idx != System.Windows.Forms.ListBox.NoMatches)
            {
                int tag_id = ((TagModel)lstSelectedTags.SelectedItem).TagID;

                tabVocabEditor.SelectedTab = tbpTagEditor;
                foreach (TagModel tag in (List<TagModel>)lstTags.DataSource)
                {
                    if (tag.TagID == tag_id)
                    {
                        lstTags.SelectedItem = tag;
                        break;
                    }
                }
            }
        }


        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtWordFilter.Text))
            {
                ListedWords = Filter(txtWordFilter.Text, AllWords);
            }
            else
            {
                ListedWords = AllWords;
            }

            WireUpWordList();
            // Do not auto-select the item when filtering.
            if(lstWords.SelectedIndex != -1)
            {
                lstWords.SetSelected(lstWords.SelectedIndex, false);
            }
            
        }

        private List<WordModel> Filter(string key, List<WordModel> words)
        {
            string pattern = $".*?{key.ToLower()}.*?";
            List<WordModel> filteredWords = new List<WordModel>();
            foreach (WordModel word in words)
            {
                if (Regex.IsMatch(word.WordText.ToLower(), pattern))
                {
                    filteredWords.Add(word);
                }
            }

            return filteredWords;
        }

        private void lstTaggedWords_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int idx = this.lstTaggedWords.IndexFromPoint(e.Location);

            if (idx != System.Windows.Forms.ListBox.NoMatches)
            {
                int word_id = ((WordModel)lstTaggedWords.SelectedItem).WordID;

                tabVocabEditor.SelectedTab = tbpTagEditor;

                // Reset the filter guarenteeing all words are displayed.
                // Position the clicked word and jump to the WordEditor Page
                // to show the details of the word.
                txtWordFilter.Text = "";
                foreach (WordModel word in (List<WordModel>)lstWords.DataSource)
                {
                    if (word.WordID == word_id)
                    {
                        lstWords.SelectedItem = word;
                        break;
                    }
                }
                tabVocabEditor.SelectedTab = tbpWordEditor;
            }
        }


        private void lstSelectedTags_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (lstSelectedTags.SelectedItem != null)
                {
                    TagModel tag = (TagModel)lstSelectedTags.SelectedItem;
                    SelectedTags.Remove(tag);
                    CandidateTags.Add(tag);
                    WireUpTaggingLists();
                }
            }
        }

        private void tsmiMDExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog locDialog = new SaveFileDialog();
            locDialog.FileName = "vocab_export_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            locDialog.DefaultExt = ".md";

            if (locDialog.ShowDialog() == DialogResult.OK)
            {
                MDExporter exporter = new MDExporter(AllWords, locDialog.FileName);
                exporter.Export();
                MessageBox.Show($"Export file \"{locDialog.FileName}\" is successfully created.");
            }
        }

        private void recycleBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecycleBinForm newFrm = new RecycleBinForm();

            newFrm.ShowDialog();

            LoadWordList();
        }

        private void EditorForm_KeyDown(object sender, KeyEventArgs e)
        {
                switch(tabVocabEditor.SelectedIndex)
                {
                    // case Word Editor
                    case 0:
                        if (e.KeyData == (Keys.Control | Keys.Shift | Keys.Enter))
                        {
                            CreateWord();
                        }
                        else if (e.KeyData == (Keys.Control | Keys.S))
                        {
                            UpdateWord();
                        }
                        break;
                    // case Tag Editor
                    case 1:
                        if (e.KeyData == (Keys.Control | Keys.Shift | Keys.Enter))
                        {
                            CreateTag();
                        }
                        else if (e.KeyData == (Keys.Control | Keys.S))
                        {
                            UpdateTag();
                        }
                    break;
                }
            
        }

        private void txtWordFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(lstWords.Items.Count > 0)
                {
                    lstWords.SetSelected(0, true);
                }
                lstWords.Focus();
            }
        }

        private void txtDefinition_KeyDown(object sender, KeyEventArgs e)
        {
            // Auto Fill with Web Crawler
            if(e.KeyData == (Keys.Control | Keys.Shift | Keys.F))
            {
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {
                    AutoAppendDefinition();
                }
                else
                {
                    MessageBox.Show("No available network connection!");
                }
            }
        }

        private void autoFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoFill();
        }

        private void AutoFill()
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                if (String.IsNullOrEmpty(txtDefinition.Text.Trim()))
                {
                    AutoAppendDefinition();
                }
                if (String.IsNullOrEmpty(txtContext.Text.Trim()))
                {
                    AutoAppendContext();
                }
            }
            else
            {
                MessageBox.Show("No available network connection!");
            }
        }

        private void AutoAppendDefinition()
        {
            RefreshAutoFiller();
            string content = AutoFiller.DefinitionText();

            if (!String.IsNullOrEmpty(content))
            {
                txtDefinition.Text += content;
            }
            else
            {
                MessageBox.Show($"Find no definition from {AutoFiller.SourceText()}");
            }
        }

        private void AutoAppendContext()
        {
            RefreshAutoFiller();
            string content = AutoFiller.ContextText();

            if (!String.IsNullOrEmpty(content))
            {
                txtContext.Text += content;
                txtContextSource.Text += AutoFiller.SourceText();
            }
            else
            {
                MessageBox.Show($"Find no example from {AutoFiller.SourceText()}");
            }
        }

        private void txtContext_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == (Keys.Control | Keys.Shift | Keys.F))
            {
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {
                    var dict = new LongmanFiller(txtWordText.Text);
                    AutoAppendDefinition();
                    AutoAppendContext();
                }
                else
                {
                    MessageBox.Show("No available network connection!");
                }
            }
        }

        private void txtWordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.Shift | Keys.F))
            {
                AutoFill();
            }
        }

        private void RefreshAutoFiller()
        {
            if (AutoFiller == null || AutoFiller.Spelling() != txtWordText.Text)
            {
                AutoFiller = new LongmanFiller(txtWordText.Text);
            }
        }
    }
}
