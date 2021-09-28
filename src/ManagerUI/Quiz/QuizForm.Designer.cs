namespace ManagerUI
{
    partial class QuizForm
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
            this.lblWordText = new System.Windows.Forms.Label();
            this.btnRemember = new System.Windows.Forms.Button();
            this.btnForget = new System.Windows.Forms.Button();
            this.tlpQuizForm = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDetailBoard = new System.Windows.Forms.TableLayoutPanel();
            this.grpNote = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.grpContext = new System.Windows.Forms.GroupBox();
            this.txtContext = new System.Windows.Forms.TextBox();
            this.grpDefinition = new System.Windows.Forms.GroupBox();
            this.txtDefinition = new System.Windows.Forms.TextBox();
            this.tlpMetricBar = new System.Windows.Forms.TableLayoutPanel();
            this.lblMetricInfo = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.prgQuiz = new System.Windows.Forms.ProgressBar();
            this.mnsTop = new System.Windows.Forms.MenuStrip();
            this.tsmiTool = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadByTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGenReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpQuizForm.SuspendLayout();
            this.tlpDetailBoard.SuspendLayout();
            this.grpNote.SuspendLayout();
            this.grpContext.SuspendLayout();
            this.grpDefinition.SuspendLayout();
            this.tlpMetricBar.SuspendLayout();
            this.mnsTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWordText
            // 
            this.lblWordText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWordText.AutoSize = true;
            this.tlpQuizForm.SetColumnSpan(this.lblWordText, 2);
            this.lblWordText.Font = new System.Drawing.Font("Sitka Display", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordText.Location = new System.Drawing.Point(352, 37);
            this.lblWordText.Name = "lblWordText";
            this.lblWordText.Size = new System.Drawing.Size(488, 62);
            this.lblWordText.TabIndex = 1;
            this.lblWordText.Text = "Load words into the quiz.";
            this.lblWordText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRemember
            // 
            this.btnRemember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemember.Enabled = false;
            this.btnRemember.Location = new System.Drawing.Point(3, 488);
            this.btnRemember.Name = "btnRemember";
            this.btnRemember.Size = new System.Drawing.Size(590, 96);
            this.btnRemember.TabIndex = 3;
            this.btnRemember.Text = "Remember";
            this.btnRemember.UseVisualStyleBackColor = true;
            this.btnRemember.Click += new System.EventHandler(this.btnRemember_Click);
            // 
            // btnForget
            // 
            this.btnForget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForget.Enabled = false;
            this.btnForget.Location = new System.Drawing.Point(599, 488);
            this.btnForget.Name = "btnForget";
            this.btnForget.Size = new System.Drawing.Size(590, 96);
            this.btnForget.TabIndex = 4;
            this.btnForget.Text = "Forget";
            this.btnForget.UseVisualStyleBackColor = true;
            this.btnForget.Click += new System.EventHandler(this.btnForget_Click);
            // 
            // tlpQuizForm
            // 
            this.tlpQuizForm.ColumnCount = 2;
            this.tlpQuizForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpQuizForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpQuizForm.Controls.Add(this.lblWordText, 0, 1);
            this.tlpQuizForm.Controls.Add(this.btnRemember, 0, 4);
            this.tlpQuizForm.Controls.Add(this.btnForget, 1, 4);
            this.tlpQuizForm.Controls.Add(this.tlpDetailBoard, 0, 3);
            this.tlpQuizForm.Controls.Add(this.tlpMetricBar, 0, 2);
            this.tlpQuizForm.Controls.Add(this.prgQuiz, 0, 0);
            this.tlpQuizForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpQuizForm.Location = new System.Drawing.Point(0, 28);
            this.tlpQuizForm.Name = "tlpQuizForm";
            this.tlpQuizForm.RowCount = 5;
            this.tlpQuizForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpQuizForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tlpQuizForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpQuizForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpQuizForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tlpQuizForm.Size = new System.Drawing.Size(1192, 587);
            this.tlpQuizForm.TabIndex = 5;
            // 
            // tlpDetailBoard
            // 
            this.tlpDetailBoard.ColumnCount = 3;
            this.tlpQuizForm.SetColumnSpan(this.tlpDetailBoard, 2);
            this.tlpDetailBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpDetailBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlpDetailBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpDetailBoard.Controls.Add(this.grpNote, 2, 0);
            this.tlpDetailBoard.Controls.Add(this.grpContext, 1, 0);
            this.tlpDetailBoard.Controls.Add(this.grpDefinition, 0, 0);
            this.tlpDetailBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDetailBoard.Location = new System.Drawing.Point(3, 154);
            this.tlpDetailBoard.Name = "tlpDetailBoard";
            this.tlpDetailBoard.RowCount = 1;
            this.tlpDetailBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetailBoard.Size = new System.Drawing.Size(1186, 328);
            this.tlpDetailBoard.TabIndex = 5;
            // 
            // grpNote
            // 
            this.grpNote.Controls.Add(this.txtNote);
            this.grpNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNote.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNote.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.grpNote.Location = new System.Drawing.Point(797, 3);
            this.grpNote.Name = "grpNote";
            this.grpNote.Size = new System.Drawing.Size(386, 322);
            this.grpNote.TabIndex = 2;
            this.grpNote.TabStop = false;
            this.grpNote.Text = "Note";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.SystemColors.Window;
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(3, 39);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(380, 280);
            this.txtNote.TabIndex = 1;
            // 
            // grpContext
            // 
            this.grpContext.Controls.Add(this.txtContext);
            this.grpContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpContext.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContext.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.grpContext.Location = new System.Drawing.Point(394, 3);
            this.grpContext.Name = "grpContext";
            this.grpContext.Size = new System.Drawing.Size(397, 322);
            this.grpContext.TabIndex = 1;
            this.grpContext.TabStop = false;
            this.grpContext.Text = "Context";
            // 
            // txtContext
            // 
            this.txtContext.BackColor = System.Drawing.SystemColors.Window;
            this.txtContext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContext.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContext.Location = new System.Drawing.Point(3, 39);
            this.txtContext.Multiline = true;
            this.txtContext.Name = "txtContext";
            this.txtContext.ReadOnly = true;
            this.txtContext.Size = new System.Drawing.Size(391, 280);
            this.txtContext.TabIndex = 1;
            // 
            // grpDefinition
            // 
            this.grpDefinition.Controls.Add(this.txtDefinition);
            this.grpDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDefinition.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDefinition.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.grpDefinition.Location = new System.Drawing.Point(3, 3);
            this.grpDefinition.Name = "grpDefinition";
            this.grpDefinition.Size = new System.Drawing.Size(385, 322);
            this.grpDefinition.TabIndex = 0;
            this.grpDefinition.TabStop = false;
            this.grpDefinition.Text = "Definition";
            // 
            // txtDefinition
            // 
            this.txtDefinition.BackColor = System.Drawing.SystemColors.Window;
            this.txtDefinition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDefinition.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefinition.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDefinition.Location = new System.Drawing.Point(3, 39);
            this.txtDefinition.Multiline = true;
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.ReadOnly = true;
            this.txtDefinition.Size = new System.Drawing.Size(379, 280);
            this.txtDefinition.TabIndex = 0;
            // 
            // tlpMetricBar
            // 
            this.tlpMetricBar.BackColor = System.Drawing.SystemColors.Window;
            this.tlpMetricBar.ColumnCount = 2;
            this.tlpQuizForm.SetColumnSpan(this.tlpMetricBar, 2);
            this.tlpMetricBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.25632F));
            this.tlpMetricBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.74368F));
            this.tlpMetricBar.Controls.Add(this.lblMetricInfo, 0, 0);
            this.tlpMetricBar.Controls.Add(this.btnRemove, 1, 0);
            this.tlpMetricBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMetricBar.Location = new System.Drawing.Point(3, 110);
            this.tlpMetricBar.Name = "tlpMetricBar";
            this.tlpMetricBar.RowCount = 1;
            this.tlpMetricBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMetricBar.Size = new System.Drawing.Size(1186, 38);
            this.tlpMetricBar.TabIndex = 6;
            // 
            // lblMetricInfo
            // 
            this.lblMetricInfo.AutoSize = true;
            this.lblMetricInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMetricInfo.Location = new System.Drawing.Point(3, 0);
            this.lblMetricInfo.Name = "lblMetricInfo";
            this.lblMetricInfo.Size = new System.Drawing.Size(1016, 38);
            this.lblMetricInfo.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.Enabled = false;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnRemove.Location = new System.Drawing.Point(1025, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(158, 32);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // prgQuiz
            // 
            this.tlpQuizForm.SetColumnSpan(this.prgQuiz, 2);
            this.prgQuiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prgQuiz.Enabled = false;
            this.prgQuiz.Location = new System.Drawing.Point(3, 3);
            this.prgQuiz.Name = "prgQuiz";
            this.prgQuiz.Size = new System.Drawing.Size(1186, 24);
            this.prgQuiz.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgQuiz.TabIndex = 7;
            // 
            // mnsTop
            // 
            this.mnsTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTool,
            this.tsmiFile});
            this.mnsTop.Location = new System.Drawing.Point(0, 0);
            this.mnsTop.Name = "mnsTop";
            this.mnsTop.Size = new System.Drawing.Size(1192, 28);
            this.mnsTop.TabIndex = 6;
            this.mnsTop.Text = "menuStrip1";
            // 
            // tsmiTool
            // 
            this.tsmiTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAllToolStripMenuItem,
            this.loadByTagsToolStripMenuItem});
            this.tsmiTool.Name = "tsmiTool";
            this.tsmiTool.Size = new System.Drawing.Size(59, 24);
            this.tsmiTool.Text = "Load";
            // 
            // loadAllToolStripMenuItem
            // 
            this.loadAllToolStripMenuItem.Name = "loadAllToolStripMenuItem";
            this.loadAllToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.loadAllToolStripMenuItem.Text = "load all";
            this.loadAllToolStripMenuItem.Click += new System.EventHandler(this.loadAllToolStripMenuItem_Click);
            // 
            // loadByTagsToolStripMenuItem
            // 
            this.loadByTagsToolStripMenuItem.Name = "loadByTagsToolStripMenuItem";
            this.loadByTagsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.loadByTagsToolStripMenuItem.Text = "load by tags";
            this.loadByTagsToolStripMenuItem.Click += new System.EventHandler(this.loadByTagsToolStripMenuItem_Click);
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGenReport});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(48, 24);
            this.tsmiFile.Text = "File";
            // 
            // tsmiGenReport
            // 
            this.tsmiGenReport.Name = "tsmiGenReport";
            this.tsmiGenReport.Size = new System.Drawing.Size(251, 26);
            this.tsmiGenReport.Text = "generate report (.md)";
            this.tsmiGenReport.Click += new System.EventHandler(this.generateReportToolStripMenuItem_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1192, 615);
            this.Controls.Add(this.tlpQuizForm);
            this.Controls.Add(this.mnsTop);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnsTop;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "QuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestingForm";
            this.tlpQuizForm.ResumeLayout(false);
            this.tlpQuizForm.PerformLayout();
            this.tlpDetailBoard.ResumeLayout(false);
            this.grpNote.ResumeLayout(false);
            this.grpNote.PerformLayout();
            this.grpContext.ResumeLayout(false);
            this.grpContext.PerformLayout();
            this.grpDefinition.ResumeLayout(false);
            this.grpDefinition.PerformLayout();
            this.tlpMetricBar.ResumeLayout(false);
            this.tlpMetricBar.PerformLayout();
            this.mnsTop.ResumeLayout(false);
            this.mnsTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWordText;
        private System.Windows.Forms.Button btnRemember;
        private System.Windows.Forms.Button btnForget;
        private System.Windows.Forms.TableLayoutPanel tlpQuizForm;
        private System.Windows.Forms.TableLayoutPanel tlpDetailBoard;
        private System.Windows.Forms.GroupBox grpNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.GroupBox grpContext;
        private System.Windows.Forms.TextBox txtContext;
        private System.Windows.Forms.GroupBox grpDefinition;
        private System.Windows.Forms.TextBox txtDefinition;
        private System.Windows.Forms.MenuStrip mnsTop;
        private System.Windows.Forms.ToolStripMenuItem tsmiTool;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiGenReport;
        private System.Windows.Forms.ToolStripMenuItem loadAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadByTagsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tlpMetricBar;
        private System.Windows.Forms.Label lblMetricInfo;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ProgressBar prgQuiz;
    }
}