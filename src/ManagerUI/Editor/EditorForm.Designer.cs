namespace ManagerUI
{
    partial class EditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
            this.lstWords = new System.Windows.Forms.ListBox();
            this.txtContext = new System.Windows.Forms.TextBox();
            this.btnRemoveWord = new System.Windows.Forms.Button();
            this.btnCreateWord = new System.Windows.Forms.Button();
            this.btnUpdateWord = new System.Windows.Forms.Button();
            this.txtWordText = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtDefinition = new System.Windows.Forms.TextBox();
            this.lstSelectedTags = new System.Windows.Forms.ListBox();
            this.cmbCandidateTags = new System.Windows.Forms.ComboBox();
            this.txtContextSource = new System.Windows.Forms.TextBox();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.splWordEditor = new System.Windows.Forms.SplitContainer();
            this.tlpWordList = new System.Windows.Forms.TableLayoutPanel();
            this.txtWordFilter = new System.Windows.Forms.TextBox();
            this.picWordFilter = new System.Windows.Forms.PictureBox();
            this.lblNumFiltered = new System.Windows.Forms.Label();
            this.tlpWordEditorBoard = new System.Windows.Forms.TableLayoutPanel();
            this.grpNotes = new System.Windows.Forms.GroupBox();
            this.grpTags = new System.Windows.Forms.GroupBox();
            this.tlpTags = new System.Windows.Forms.TableLayoutPanel();
            this.grpDefinition = new System.Windows.Forms.GroupBox();
            this.grpContext = new System.Windows.Forms.GroupBox();
            this.tlpContext = new System.Windows.Forms.TableLayoutPanel();
            this.tlpWordCommitButtoms = new System.Windows.Forms.TableLayoutPanel();
            this.btnClearWordEditor = new System.Windows.Forms.Button();
            this.tabVocabEditor = new System.Windows.Forms.TabControl();
            this.tbpWordEditor = new System.Windows.Forms.TabPage();
            this.tbpTagEditor = new System.Windows.Forms.TabPage();
            this.splTagEditor = new System.Windows.Forms.SplitContainer();
            this.tlpTagList = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteTag = new System.Windows.Forms.Button();
            this.lstTags = new System.Windows.Forms.ListBox();
            this.tlpTagEditorBoard = new System.Windows.Forms.TableLayoutPanel();
            this.txtTagName = new System.Windows.Forms.TextBox();
            this.grpTagInfo = new System.Windows.Forms.GroupBox();
            this.txtTagInfo = new System.Windows.Forms.TextBox();
            this.tlpTagCommitButtoms = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreateTag = new System.Windows.Forms.Button();
            this.btnClearTagEditor = new System.Windows.Forms.Button();
            this.btnUpdateTag = new System.Windows.Forms.Button();
            this.grpTaggedFilter = new System.Windows.Forms.GroupBox();
            this.lstTaggedWords = new System.Windows.Forms.ListBox();
            this.mnsTop = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMDExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecycleBin = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoFillAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tips = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splWordEditor)).BeginInit();
            this.splWordEditor.Panel1.SuspendLayout();
            this.splWordEditor.Panel2.SuspendLayout();
            this.splWordEditor.SuspendLayout();
            this.tlpWordList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWordFilter)).BeginInit();
            this.tlpWordEditorBoard.SuspendLayout();
            this.grpNotes.SuspendLayout();
            this.grpTags.SuspendLayout();
            this.tlpTags.SuspendLayout();
            this.grpDefinition.SuspendLayout();
            this.grpContext.SuspendLayout();
            this.tlpContext.SuspendLayout();
            this.tlpWordCommitButtoms.SuspendLayout();
            this.tabVocabEditor.SuspendLayout();
            this.tbpWordEditor.SuspendLayout();
            this.tbpTagEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splTagEditor)).BeginInit();
            this.splTagEditor.Panel1.SuspendLayout();
            this.splTagEditor.Panel2.SuspendLayout();
            this.splTagEditor.SuspendLayout();
            this.tlpTagList.SuspendLayout();
            this.tlpTagEditorBoard.SuspendLayout();
            this.grpTagInfo.SuspendLayout();
            this.tlpTagCommitButtoms.SuspendLayout();
            this.grpTaggedFilter.SuspendLayout();
            this.mnsTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstWords
            // 
            this.tlpWordList.SetColumnSpan(this.lstWords, 2);
            this.lstWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstWords.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstWords.FormattingEnabled = true;
            this.lstWords.ItemHeight = 31;
            this.lstWords.Location = new System.Drawing.Point(3, 61);
            this.lstWords.Name = "lstWords";
            this.lstWords.Size = new System.Drawing.Size(217, 561);
            this.lstWords.TabIndex = 0;
            this.lstWords.SelectedIndexChanged += new System.EventHandler(this.lstWords_SelectedIndexChanged);
            // 
            // txtContext
            // 
            this.txtContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContext.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContext.Location = new System.Drawing.Point(3, 3);
            this.txtContext.Multiline = true;
            this.txtContext.Name = "txtContext";
            this.txtContext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContext.Size = new System.Drawing.Size(430, 193);
            this.txtContext.TabIndex = 3;
            this.txtContext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContext_KeyDown);
            // 
            // btnRemoveWord
            // 
            this.tlpWordList.SetColumnSpan(this.btnRemoveWord, 2);
            this.btnRemoveWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveWord.Location = new System.Drawing.Point(3, 628);
            this.btnRemoveWord.Name = "btnRemoveWord";
            this.btnRemoveWord.Size = new System.Drawing.Size(217, 54);
            this.btnRemoveWord.TabIndex = 9;
            this.btnRemoveWord.Text = "Remove";
            this.tips.SetToolTip(this.btnRemoveWord, "Remove the word to the recycle bin.");
            this.btnRemoveWord.UseVisualStyleBackColor = true;
            this.btnRemoveWord.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreateWord
            // 
            this.btnCreateWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateWord.Location = new System.Drawing.Point(3, 3);
            this.btnCreateWord.Name = "btnCreateWord";
            this.btnCreateWord.Size = new System.Drawing.Size(287, 52);
            this.btnCreateWord.TabIndex = 10;
            this.btnCreateWord.Text = "Create";
            this.tips.SetToolTip(this.btnCreateWord, "Create a new word. (Ctrl + Enter)");
            this.btnCreateWord.UseVisualStyleBackColor = true;
            this.btnCreateWord.Click += new System.EventHandler(this.btnCreateWord_Click);
            // 
            // btnUpdateWord
            // 
            this.btnUpdateWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateWord.Location = new System.Drawing.Point(598, 3);
            this.btnUpdateWord.Name = "btnUpdateWord";
            this.btnUpdateWord.Size = new System.Drawing.Size(289, 52);
            this.btnUpdateWord.TabIndex = 11;
            this.btnUpdateWord.Text = "Update";
            this.tips.SetToolTip(this.btnUpdateWord, "Save update to the selected word. (Ctrl+S)");
            this.btnUpdateWord.UseVisualStyleBackColor = true;
            this.btnUpdateWord.Click += new System.EventHandler(this.btnUpdateWord_Click);
            // 
            // txtWordText
            // 
            this.txtWordText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWordText.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordText.Location = new System.Drawing.Point(3, 3);
            this.txtWordText.Name = "txtWordText";
            this.txtWordText.Size = new System.Drawing.Size(442, 38);
            this.txtWordText.TabIndex = 12;
            this.txtWordText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWordText_KeyDown);
            // 
            // txtNote
            // 
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(3, 39);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNote.Size = new System.Drawing.Size(436, 242);
            this.txtNote.TabIndex = 13;
            // 
            // txtDefinition
            // 
            this.txtDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDefinition.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefinition.Location = new System.Drawing.Point(3, 39);
            this.txtDefinition.Multiline = true;
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDefinition.Size = new System.Drawing.Size(436, 242);
            this.txtDefinition.TabIndex = 14;
            this.txtDefinition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDefinition_KeyDown);
            // 
            // lstSelectedTags
            // 
            this.lstSelectedTags.AllowDrop = true;
            this.tlpTags.SetColumnSpan(this.lstSelectedTags, 2);
            this.lstSelectedTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSelectedTags.FormattingEnabled = true;
            this.lstSelectedTags.ItemHeight = 37;
            this.lstSelectedTags.Location = new System.Drawing.Point(3, 3);
            this.lstSelectedTags.Name = "lstSelectedTags";
            this.lstSelectedTags.Size = new System.Drawing.Size(430, 180);
            this.lstSelectedTags.TabIndex = 15;
            this.lstSelectedTags.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstSelectedTags_KeyDown);
            this.lstSelectedTags.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSelectedTags_MouseDoubleClick);
            // 
            // cmbCandidateTags
            // 
            this.cmbCandidateTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCandidateTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCandidateTags.FormattingEnabled = true;
            this.cmbCandidateTags.Location = new System.Drawing.Point(3, 189);
            this.cmbCandidateTags.Name = "cmbCandidateTags";
            this.cmbCandidateTags.Size = new System.Drawing.Size(283, 45);
            this.cmbCandidateTags.TabIndex = 16;
            // 
            // txtContextSource
            // 
            this.txtContextSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContextSource.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContextSource.Location = new System.Drawing.Point(3, 202);
            this.txtContextSource.Name = "txtContextSource";
            this.txtContextSource.Size = new System.Drawing.Size(430, 39);
            this.txtContextSource.TabIndex = 17;
            // 
            // btnAddTag
            // 
            this.btnAddTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddTag.Location = new System.Drawing.Point(292, 189);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(141, 50);
            this.btnAddTag.TabIndex = 18;
            this.btnAddTag.Text = "Tagging";
            this.btnAddTag.UseVisualStyleBackColor = true;
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
            // 
            // splWordEditor
            // 
            this.splWordEditor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splWordEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splWordEditor.Location = new System.Drawing.Point(3, 3);
            this.splWordEditor.Name = "splWordEditor";
            // 
            // splWordEditor.Panel1
            // 
            this.splWordEditor.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splWordEditor.Panel1.Controls.Add(this.tlpWordList);
            // 
            // splWordEditor.Panel2
            // 
            this.splWordEditor.Panel2.Controls.Add(this.tlpWordEditorBoard);
            this.splWordEditor.Size = new System.Drawing.Size(1137, 689);
            this.splWordEditor.SplitterDistance = 227;
            this.splWordEditor.SplitterWidth = 10;
            this.splWordEditor.TabIndex = 20;
            // 
            // tlpWordList
            // 
            this.tlpWordList.ColumnCount = 2;
            this.tlpWordList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWordList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlpWordList.Controls.Add(this.btnRemoveWord, 0, 3);
            this.tlpWordList.Controls.Add(this.lstWords, 0, 2);
            this.tlpWordList.Controls.Add(this.txtWordFilter, 0, 0);
            this.tlpWordList.Controls.Add(this.picWordFilter, 1, 0);
            this.tlpWordList.Controls.Add(this.lblNumFiltered, 0, 1);
            this.tlpWordList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWordList.Location = new System.Drawing.Point(0, 0);
            this.tlpWordList.Name = "tlpWordList";
            this.tlpWordList.RowCount = 4;
            this.tlpWordList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.790476F));
            this.tlpWordList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.857143F));
            this.tlpWordList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.79047F));
            this.tlpWordList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.561905F));
            this.tlpWordList.Size = new System.Drawing.Size(223, 685);
            this.tlpWordList.TabIndex = 10;
            // 
            // txtWordFilter
            // 
            this.txtWordFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWordFilter.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordFilter.Location = new System.Drawing.Point(3, 3);
            this.txtWordFilter.Name = "txtWordFilter";
            this.txtWordFilter.Size = new System.Drawing.Size(174, 38);
            this.txtWordFilter.TabIndex = 10;
            this.txtWordFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtWordFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWordFilter_KeyDown);
            // 
            // picWordFilter
            // 
            this.picWordFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picWordFilter.Image = ((System.Drawing.Image)(resources.GetObject("picWordFilter.Image")));
            this.picWordFilter.Location = new System.Drawing.Point(183, 3);
            this.picWordFilter.Name = "picWordFilter";
            this.picWordFilter.Size = new System.Drawing.Size(37, 33);
            this.picWordFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWordFilter.TabIndex = 11;
            this.picWordFilter.TabStop = false;
            // 
            // lblNumFiltered
            // 
            this.lblNumFiltered.AutoSize = true;
            this.tlpWordList.SetColumnSpan(this.lblNumFiltered, 2);
            this.lblNumFiltered.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumFiltered.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFiltered.Location = new System.Drawing.Point(3, 39);
            this.lblNumFiltered.Name = "lblNumFiltered";
            this.lblNumFiltered.Size = new System.Drawing.Size(217, 19);
            this.lblNumFiltered.TabIndex = 12;
            this.lblNumFiltered.Text = "Filtered: ";
            // 
            // tlpWordEditorBoard
            // 
            this.tlpWordEditorBoard.ColumnCount = 2;
            this.tlpWordEditorBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpWordEditorBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpWordEditorBoard.Controls.Add(this.txtWordText, 0, 0);
            this.tlpWordEditorBoard.Controls.Add(this.grpNotes, 1, 2);
            this.tlpWordEditorBoard.Controls.Add(this.grpTags, 1, 1);
            this.tlpWordEditorBoard.Controls.Add(this.grpDefinition, 0, 1);
            this.tlpWordEditorBoard.Controls.Add(this.grpContext, 0, 2);
            this.tlpWordEditorBoard.Controls.Add(this.tlpWordCommitButtoms, 0, 3);
            this.tlpWordEditorBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWordEditorBoard.Location = new System.Drawing.Point(0, 0);
            this.tlpWordEditorBoard.Name = "tlpWordEditorBoard";
            this.tlpWordEditorBoard.RowCount = 4;
            this.tlpWordEditorBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.084524F));
            this.tlpWordEditorBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.46178F));
            this.tlpWordEditorBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.46178F));
            this.tlpWordEditorBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.991908F));
            this.tlpWordEditorBoard.Size = new System.Drawing.Size(896, 685);
            this.tlpWordEditorBoard.TabIndex = 21;
            // 
            // grpNotes
            // 
            this.grpNotes.Controls.Add(this.txtNote);
            this.grpNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNotes.Location = new System.Drawing.Point(451, 334);
            this.grpNotes.Name = "grpNotes";
            this.grpNotes.Size = new System.Drawing.Size(442, 284);
            this.grpNotes.TabIndex = 2;
            this.grpNotes.TabStop = false;
            this.grpNotes.Text = "Notes";
            // 
            // grpTags
            // 
            this.grpTags.Controls.Add(this.tlpTags);
            this.grpTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTags.Location = new System.Drawing.Point(451, 44);
            this.grpTags.Name = "grpTags";
            this.grpTags.Size = new System.Drawing.Size(442, 284);
            this.grpTags.TabIndex = 1;
            this.grpTags.TabStop = false;
            this.grpTags.Text = "Tags";
            // 
            // tlpTags
            // 
            this.tlpTags.ColumnCount = 2;
            this.tlpTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.43835F));
            this.tlpTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.56165F));
            this.tlpTags.Controls.Add(this.lstSelectedTags, 0, 0);
            this.tlpTags.Controls.Add(this.cmbCandidateTags, 0, 1);
            this.tlpTags.Controls.Add(this.btnAddTag, 1, 1);
            this.tlpTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTags.Location = new System.Drawing.Point(3, 39);
            this.tlpTags.Name = "tlpTags";
            this.tlpTags.RowCount = 2;
            this.tlpTags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.22008F));
            this.tlpTags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.77992F));
            this.tlpTags.Size = new System.Drawing.Size(436, 242);
            this.tlpTags.TabIndex = 0;
            // 
            // grpDefinition
            // 
            this.grpDefinition.Controls.Add(this.txtDefinition);
            this.grpDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDefinition.Location = new System.Drawing.Point(3, 44);
            this.grpDefinition.Name = "grpDefinition";
            this.grpDefinition.Size = new System.Drawing.Size(442, 284);
            this.grpDefinition.TabIndex = 2;
            this.grpDefinition.TabStop = false;
            this.grpDefinition.Text = "Definition";
            // 
            // grpContext
            // 
            this.grpContext.Controls.Add(this.tlpContext);
            this.grpContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpContext.Location = new System.Drawing.Point(3, 334);
            this.grpContext.Name = "grpContext";
            this.grpContext.Size = new System.Drawing.Size(442, 284);
            this.grpContext.TabIndex = 0;
            this.grpContext.TabStop = false;
            this.grpContext.Text = "Context";
            // 
            // tlpContext
            // 
            this.tlpContext.ColumnCount = 1;
            this.tlpContext.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContext.Controls.Add(this.txtContext, 0, 0);
            this.tlpContext.Controls.Add(this.txtContextSource, 0, 1);
            this.tlpContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContext.Location = new System.Drawing.Point(3, 39);
            this.tlpContext.Name = "tlpContext";
            this.tlpContext.RowCount = 2;
            this.tlpContext.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.23141F));
            this.tlpContext.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.76859F));
            this.tlpContext.Size = new System.Drawing.Size(436, 242);
            this.tlpContext.TabIndex = 0;
            // 
            // tlpWordCommitButtoms
            // 
            this.tlpWordCommitButtoms.ColumnCount = 3;
            this.tlpWordEditorBoard.SetColumnSpan(this.tlpWordCommitButtoms, 2);
            this.tlpWordCommitButtoms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpWordCommitButtoms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlpWordCommitButtoms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpWordCommitButtoms.Controls.Add(this.btnCreateWord, 0, 0);
            this.tlpWordCommitButtoms.Controls.Add(this.btnClearWordEditor, 1, 0);
            this.tlpWordCommitButtoms.Controls.Add(this.btnUpdateWord, 2, 0);
            this.tlpWordCommitButtoms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWordCommitButtoms.Location = new System.Drawing.Point(3, 624);
            this.tlpWordCommitButtoms.Name = "tlpWordCommitButtoms";
            this.tlpWordCommitButtoms.RowCount = 1;
            this.tlpWordCommitButtoms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWordCommitButtoms.Size = new System.Drawing.Size(890, 58);
            this.tlpWordCommitButtoms.TabIndex = 3;
            // 
            // btnClearWordEditor
            // 
            this.btnClearWordEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearWordEditor.Location = new System.Drawing.Point(296, 3);
            this.btnClearWordEditor.Name = "btnClearWordEditor";
            this.btnClearWordEditor.Size = new System.Drawing.Size(296, 52);
            this.btnClearWordEditor.TabIndex = 20;
            this.btnClearWordEditor.Text = "Clear";
            this.tips.SetToolTip(this.btnClearWordEditor, "Clear the board for a new word.");
            this.btnClearWordEditor.UseVisualStyleBackColor = true;
            this.btnClearWordEditor.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tabVocabEditor
            // 
            this.tabVocabEditor.Controls.Add(this.tbpWordEditor);
            this.tabVocabEditor.Controls.Add(this.tbpTagEditor);
            this.tabVocabEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabVocabEditor.Location = new System.Drawing.Point(0, 28);
            this.tabVocabEditor.Name = "tabVocabEditor";
            this.tabVocabEditor.SelectedIndex = 0;
            this.tabVocabEditor.Size = new System.Drawing.Size(1151, 745);
            this.tabVocabEditor.TabIndex = 21;
            this.tabVocabEditor.SelectedIndexChanged += new System.EventHandler(this.tabVocabEditor_SelectedIndexChanged);
            // 
            // tbpWordEditor
            // 
            this.tbpWordEditor.Controls.Add(this.splWordEditor);
            this.tbpWordEditor.Location = new System.Drawing.Point(4, 46);
            this.tbpWordEditor.Name = "tbpWordEditor";
            this.tbpWordEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tbpWordEditor.Size = new System.Drawing.Size(1143, 695);
            this.tbpWordEditor.TabIndex = 0;
            this.tbpWordEditor.Text = "Word Viewer";
            this.tbpWordEditor.UseVisualStyleBackColor = true;
            // 
            // tbpTagEditor
            // 
            this.tbpTagEditor.Controls.Add(this.splTagEditor);
            this.tbpTagEditor.Location = new System.Drawing.Point(4, 46);
            this.tbpTagEditor.Name = "tbpTagEditor";
            this.tbpTagEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTagEditor.Size = new System.Drawing.Size(1143, 693);
            this.tbpTagEditor.TabIndex = 1;
            this.tbpTagEditor.Text = "Tag Viewer";
            this.tbpTagEditor.UseVisualStyleBackColor = true;
            // 
            // splTagEditor
            // 
            this.splTagEditor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splTagEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splTagEditor.Location = new System.Drawing.Point(3, 3);
            this.splTagEditor.Name = "splTagEditor";
            // 
            // splTagEditor.Panel1
            // 
            this.splTagEditor.Panel1.Controls.Add(this.tlpTagList);
            // 
            // splTagEditor.Panel2
            // 
            this.splTagEditor.Panel2.Controls.Add(this.tlpTagEditorBoard);
            this.splTagEditor.Size = new System.Drawing.Size(1137, 687);
            this.splTagEditor.SplitterDistance = 227;
            this.splTagEditor.SplitterWidth = 10;
            this.splTagEditor.TabIndex = 21;
            // 
            // tlpTagList
            // 
            this.tlpTagList.ColumnCount = 1;
            this.tlpTagList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTagList.Controls.Add(this.btnDeleteTag, 0, 1);
            this.tlpTagList.Controls.Add(this.lstTags, 0, 0);
            this.tlpTagList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTagList.Location = new System.Drawing.Point(0, 0);
            this.tlpTagList.Name = "tlpTagList";
            this.tlpTagList.RowCount = 2;
            this.tlpTagList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91F));
            this.tlpTagList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlpTagList.Size = new System.Drawing.Size(223, 683);
            this.tlpTagList.TabIndex = 10;
            // 
            // btnDeleteTag
            // 
            this.btnDeleteTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteTag.Location = new System.Drawing.Point(3, 624);
            this.btnDeleteTag.Name = "btnDeleteTag";
            this.btnDeleteTag.Size = new System.Drawing.Size(217, 56);
            this.btnDeleteTag.TabIndex = 9;
            this.btnDeleteTag.Text = "Delete";
            this.tips.SetToolTip(this.btnDeleteTag, "Permanently delete the tag selected.");
            this.btnDeleteTag.UseVisualStyleBackColor = true;
            this.btnDeleteTag.Click += new System.EventHandler(this.btnDeleteTag_Click);
            // 
            // lstTags
            // 
            this.lstTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTags.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTags.FormattingEnabled = true;
            this.lstTags.ItemHeight = 31;
            this.lstTags.Location = new System.Drawing.Point(3, 3);
            this.lstTags.Name = "lstTags";
            this.lstTags.Size = new System.Drawing.Size(217, 615);
            this.lstTags.TabIndex = 0;
            this.lstTags.SelectedIndexChanged += new System.EventHandler(this.lstTags_SelectedIndexChanged);
            // 
            // tlpTagEditorBoard
            // 
            this.tlpTagEditorBoard.ColumnCount = 1;
            this.tlpTagEditorBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTagEditorBoard.Controls.Add(this.txtTagName, 0, 0);
            this.tlpTagEditorBoard.Controls.Add(this.grpTagInfo, 0, 1);
            this.tlpTagEditorBoard.Controls.Add(this.tlpTagCommitButtoms, 0, 2);
            this.tlpTagEditorBoard.Controls.Add(this.grpTaggedFilter, 0, 3);
            this.tlpTagEditorBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTagEditorBoard.Location = new System.Drawing.Point(0, 0);
            this.tlpTagEditorBoard.Name = "tlpTagEditorBoard";
            this.tlpTagEditorBoard.RowCount = 4;
            this.tlpTagEditorBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.131387F));
            this.tlpTagEditorBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.74453F));
            this.tlpTagEditorBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlpTagEditorBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTagEditorBoard.Size = new System.Drawing.Size(896, 683);
            this.tlpTagEditorBoard.TabIndex = 21;
            // 
            // txtTagName
            // 
            this.txtTagName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTagName.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTagName.Location = new System.Drawing.Point(3, 3);
            this.txtTagName.Name = "txtTagName";
            this.txtTagName.Size = new System.Drawing.Size(890, 38);
            this.txtTagName.TabIndex = 12;
            // 
            // grpTagInfo
            // 
            this.grpTagInfo.Controls.Add(this.txtTagInfo);
            this.grpTagInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTagInfo.Location = new System.Drawing.Point(3, 44);
            this.grpTagInfo.Name = "grpTagInfo";
            this.grpTagInfo.Size = new System.Drawing.Size(890, 231);
            this.grpTagInfo.TabIndex = 2;
            this.grpTagInfo.TabStop = false;
            this.grpTagInfo.Text = "Tag Info";
            // 
            // txtTagInfo
            // 
            this.txtTagInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTagInfo.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTagInfo.Location = new System.Drawing.Point(3, 39);
            this.txtTagInfo.Multiline = true;
            this.txtTagInfo.Name = "txtTagInfo";
            this.txtTagInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTagInfo.Size = new System.Drawing.Size(884, 189);
            this.txtTagInfo.TabIndex = 0;
            // 
            // tlpTagCommitButtoms
            // 
            this.tlpTagCommitButtoms.ColumnCount = 3;
            this.tlpTagCommitButtoms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpTagCommitButtoms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlpTagCommitButtoms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpTagCommitButtoms.Controls.Add(this.btnCreateTag, 0, 0);
            this.tlpTagCommitButtoms.Controls.Add(this.btnClearTagEditor, 1, 0);
            this.tlpTagCommitButtoms.Controls.Add(this.btnUpdateTag, 2, 0);
            this.tlpTagCommitButtoms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTagCommitButtoms.Location = new System.Drawing.Point(3, 281);
            this.tlpTagCommitButtoms.Name = "tlpTagCommitButtoms";
            this.tlpTagCommitButtoms.RowCount = 1;
            this.tlpTagCommitButtoms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTagCommitButtoms.Size = new System.Drawing.Size(890, 55);
            this.tlpTagCommitButtoms.TabIndex = 3;
            // 
            // btnCreateTag
            // 
            this.btnCreateTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateTag.Location = new System.Drawing.Point(3, 3);
            this.btnCreateTag.Name = "btnCreateTag";
            this.btnCreateTag.Size = new System.Drawing.Size(287, 49);
            this.btnCreateTag.TabIndex = 10;
            this.btnCreateTag.Text = "Create";
            this.tips.SetToolTip(this.btnCreateTag, "Create a new tag. (Ctrl + Enter)");
            this.btnCreateTag.UseVisualStyleBackColor = true;
            this.btnCreateTag.Click += new System.EventHandler(this.btnCreateTag_Click);
            // 
            // btnClearTagEditor
            // 
            this.btnClearTagEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearTagEditor.Location = new System.Drawing.Point(296, 3);
            this.btnClearTagEditor.Name = "btnClearTagEditor";
            this.btnClearTagEditor.Size = new System.Drawing.Size(296, 49);
            this.btnClearTagEditor.TabIndex = 20;
            this.btnClearTagEditor.Text = "Clear";
            this.tips.SetToolTip(this.btnClearTagEditor, "Clear the board for a new tag.");
            this.btnClearTagEditor.UseVisualStyleBackColor = true;
            this.btnClearTagEditor.Click += new System.EventHandler(this.btnClearTagEditor_Click);
            // 
            // btnUpdateTag
            // 
            this.btnUpdateTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateTag.Location = new System.Drawing.Point(598, 3);
            this.btnUpdateTag.Name = "btnUpdateTag";
            this.btnUpdateTag.Size = new System.Drawing.Size(289, 49);
            this.btnUpdateTag.TabIndex = 11;
            this.btnUpdateTag.Text = "Update";
            this.tips.SetToolTip(this.btnUpdateTag, "Save update to the seleted tag. (Ctrl + S)");
            this.btnUpdateTag.UseVisualStyleBackColor = true;
            this.btnUpdateTag.Click += new System.EventHandler(this.btnUpdateTag_Click);
            // 
            // grpTaggedFilter
            // 
            this.grpTaggedFilter.Controls.Add(this.lstTaggedWords);
            this.grpTaggedFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTaggedFilter.Location = new System.Drawing.Point(3, 342);
            this.grpTaggedFilter.Name = "grpTaggedFilter";
            this.grpTaggedFilter.Size = new System.Drawing.Size(890, 338);
            this.grpTaggedFilter.TabIndex = 13;
            this.grpTaggedFilter.TabStop = false;
            this.grpTaggedFilter.Text = "Tagged Words: 0";
            // 
            // lstTaggedWords
            // 
            this.lstTaggedWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTaggedWords.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTaggedWords.FormattingEnabled = true;
            this.lstTaggedWords.ItemHeight = 31;
            this.lstTaggedWords.Location = new System.Drawing.Point(3, 39);
            this.lstTaggedWords.Name = "lstTaggedWords";
            this.lstTaggedWords.Size = new System.Drawing.Size(884, 296);
            this.lstTaggedWords.TabIndex = 0;
            this.lstTaggedWords.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstTaggedWords_MouseDoubleClick);
            // 
            // mnsTop
            // 
            this.mnsTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiRecycleBin,
            this.otherToolStripMenuItem});
            this.mnsTop.Location = new System.Drawing.Point(0, 0);
            this.mnsTop.Name = "mnsTop";
            this.mnsTop.Size = new System.Drawing.Size(1151, 28);
            this.mnsTop.TabIndex = 22;
            this.mnsTop.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExport});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(48, 24);
            this.tsmiFile.Text = "File";
            // 
            // tsmiExport
            // 
            this.tsmiExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMDExport});
            this.tsmiExport.Name = "tsmiExport";
            this.tsmiExport.Size = new System.Drawing.Size(160, 26);
            this.tsmiExport.Text = "export as";
            // 
            // tsmiMDExport
            // 
            this.tsmiMDExport.Name = "tsmiMDExport";
            this.tsmiMDExport.Size = new System.Drawing.Size(211, 26);
            this.tsmiMDExport.Text = "markdown (.md)";
            this.tsmiMDExport.Click += new System.EventHandler(this.tsmiMDExport_Click);
            // 
            // tsmiRecycleBin
            // 
            this.tsmiRecycleBin.Name = "tsmiRecycleBin";
            this.tsmiRecycleBin.Size = new System.Drawing.Size(105, 24);
            this.tsmiRecycleBin.Text = "Recycle Bin";
            this.tsmiRecycleBin.Click += new System.EventHandler(this.recycleBinToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoFillToolStripMenuItem,
            this.autoFillAllToolStripMenuItem});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.otherToolStripMenuItem.Text = "Auto Fill";
            // 
            // autoFillToolStripMenuItem
            // 
            this.autoFillToolStripMenuItem.Name = "autoFillToolStripMenuItem";
            this.autoFillToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.autoFillToolStripMenuItem.Text = "Fill / Append (Ctrl  + F)";
            this.autoFillToolStripMenuItem.Click += new System.EventHandler(this.autoFillToolStripMenuItem_Click);
            // 
            // autoFillAllToolStripMenuItem
            // 
            this.autoFillAllToolStripMenuItem.Name = "autoFillAllToolStripMenuItem";
            this.autoFillAllToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.autoFillAllToolStripMenuItem.Text = "Fill All";
            this.autoFillAllToolStripMenuItem.Click += new System.EventHandler(this.autoFillAllToolStripMenuItem_Click);
            // 
            // tips
            // 
            this.tips.AutomaticDelay = 50;
            this.tips.AutoPopDelay = 5000;
            this.tips.InitialDelay = 50;
            this.tips.ReshowDelay = 10;
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1151, 773);
            this.Controls.Add(this.tabVocabEditor);
            this.Controls.Add(this.mnsTop);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnsTop;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "EditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notebook";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditorForm_KeyDown);
            this.splWordEditor.Panel1.ResumeLayout(false);
            this.splWordEditor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splWordEditor)).EndInit();
            this.splWordEditor.ResumeLayout(false);
            this.tlpWordList.ResumeLayout(false);
            this.tlpWordList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWordFilter)).EndInit();
            this.tlpWordEditorBoard.ResumeLayout(false);
            this.tlpWordEditorBoard.PerformLayout();
            this.grpNotes.ResumeLayout(false);
            this.grpNotes.PerformLayout();
            this.grpTags.ResumeLayout(false);
            this.tlpTags.ResumeLayout(false);
            this.grpDefinition.ResumeLayout(false);
            this.grpDefinition.PerformLayout();
            this.grpContext.ResumeLayout(false);
            this.tlpContext.ResumeLayout(false);
            this.tlpContext.PerformLayout();
            this.tlpWordCommitButtoms.ResumeLayout(false);
            this.tabVocabEditor.ResumeLayout(false);
            this.tbpWordEditor.ResumeLayout(false);
            this.tbpTagEditor.ResumeLayout(false);
            this.splTagEditor.Panel1.ResumeLayout(false);
            this.splTagEditor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splTagEditor)).EndInit();
            this.splTagEditor.ResumeLayout(false);
            this.tlpTagList.ResumeLayout(false);
            this.tlpTagEditorBoard.ResumeLayout(false);
            this.tlpTagEditorBoard.PerformLayout();
            this.grpTagInfo.ResumeLayout(false);
            this.grpTagInfo.PerformLayout();
            this.tlpTagCommitButtoms.ResumeLayout(false);
            this.grpTaggedFilter.ResumeLayout(false);
            this.mnsTop.ResumeLayout(false);
            this.mnsTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstWords;
        private System.Windows.Forms.TextBox txtContext;
        private System.Windows.Forms.Button btnRemoveWord;
        private System.Windows.Forms.Button btnCreateWord;
        private System.Windows.Forms.Button btnUpdateWord;
        private System.Windows.Forms.TextBox txtWordText;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtDefinition;
        private System.Windows.Forms.ListBox lstSelectedTags;
        private System.Windows.Forms.ComboBox cmbCandidateTags;
        private System.Windows.Forms.TextBox txtContextSource;
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.SplitContainer splWordEditor;
        private System.Windows.Forms.Button btnClearWordEditor;
        private System.Windows.Forms.TabControl tabVocabEditor;
        private System.Windows.Forms.TabPage tbpWordEditor;
        private System.Windows.Forms.TabPage tbpTagEditor;
        private System.Windows.Forms.TableLayoutPanel tlpWordList;
        private System.Windows.Forms.TableLayoutPanel tlpWordEditorBoard;
        private System.Windows.Forms.TableLayoutPanel tlpTags;
        private System.Windows.Forms.GroupBox grpNotes;
        private System.Windows.Forms.GroupBox grpTags;
        private System.Windows.Forms.GroupBox grpDefinition;
        private System.Windows.Forms.GroupBox grpContext;
        private System.Windows.Forms.TableLayoutPanel tlpContext;
        private System.Windows.Forms.TableLayoutPanel tlpWordCommitButtoms;
        private System.Windows.Forms.SplitContainer splTagEditor;
        private System.Windows.Forms.TableLayoutPanel tlpTagList;
        private System.Windows.Forms.Button btnDeleteTag;
        private System.Windows.Forms.ListBox lstTags;
        private System.Windows.Forms.TableLayoutPanel tlpTagEditorBoard;
        private System.Windows.Forms.TextBox txtTagName;
        private System.Windows.Forms.GroupBox grpTagInfo;
        private System.Windows.Forms.TextBox txtTagInfo;
        private System.Windows.Forms.TableLayoutPanel tlpTagCommitButtoms;
        private System.Windows.Forms.Button btnCreateTag;
        private System.Windows.Forms.Button btnClearTagEditor;
        private System.Windows.Forms.Button btnUpdateTag;
        private System.Windows.Forms.TextBox txtWordFilter;
        private System.Windows.Forms.GroupBox grpTaggedFilter;
        private System.Windows.Forms.ListBox lstTaggedWords;
        private System.Windows.Forms.PictureBox picWordFilter;
        private System.Windows.Forms.MenuStrip mnsTop;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExport;
        private System.Windows.Forms.ToolStripMenuItem tsmiMDExport;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecycleBin;
        private System.Windows.Forms.ToolTip tips;
        private System.Windows.Forms.Label lblNumFiltered;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoFillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoFillAllToolStripMenuItem;
    }
}