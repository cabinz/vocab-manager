namespace ManagerUI
{
    partial class RecycleBinForm
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
            this.tlpRecycleBin = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRecover = new System.Windows.Forms.Button();
            this.lstRemovedWords = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tlpRecycleBin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRecycleBin
            // 
            this.tlpRecycleBin.ColumnCount = 2;
            this.tlpRecycleBin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpRecycleBin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpRecycleBin.Controls.Add(this.btnClear, 1, 2);
            this.tlpRecycleBin.Controls.Add(this.btnRecover, 1, 1);
            this.tlpRecycleBin.Controls.Add(this.lstRemovedWords, 0, 0);
            this.tlpRecycleBin.Controls.Add(this.btnDelete, 1, 0);
            this.tlpRecycleBin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRecycleBin.Location = new System.Drawing.Point(0, 0);
            this.tlpRecycleBin.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tlpRecycleBin.Name = "tlpRecycleBin";
            this.tlpRecycleBin.RowCount = 3;
            this.tlpRecycleBin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpRecycleBin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpRecycleBin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpRecycleBin.Size = new System.Drawing.Size(543, 660);
            this.tlpRecycleBin.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(386, 601);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 52);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRecover
            // 
            this.btnRecover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecover.Location = new System.Drawing.Point(386, 304);
            this.btnRecover.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(151, 283);
            this.btnRecover.TabIndex = 2;
            this.btnRecover.Text = "Recover";
            this.btnRecover.UseVisualStyleBackColor = true;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // lstRemovedWords
            // 
            this.lstRemovedWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRemovedWords.FormattingEnabled = true;
            this.lstRemovedWords.ItemHeight = 37;
            this.lstRemovedWords.Location = new System.Drawing.Point(6, 7);
            this.lstRemovedWords.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.lstRemovedWords.Name = "lstRemovedWords";
            this.tlpRecycleBin.SetRowSpan(this.lstRemovedWords, 3);
            this.lstRemovedWords.Size = new System.Drawing.Size(368, 646);
            this.lstRemovedWords.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(386, 7);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(151, 283);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // RecycleBinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 660);
            this.Controls.Add(this.tlpRecycleBin);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "RecycleBinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RecycleBinForm";
            this.tlpRecycleBin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRecycleBin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.ListBox lstRemovedWords;
        private System.Windows.Forms.Button btnDelete;
    }
}