namespace ManagerUI
{
    partial class TagSelectingForm
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
            this.chlTagList = new System.Windows.Forms.CheckedListBox();
            this.tlpTagSelecting = new System.Windows.Forms.TableLayoutPanel();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tlpTagSelecting.SuspendLayout();
            this.SuspendLayout();
            // 
            // chlTagList
            // 
            this.tlpTagSelecting.SetColumnSpan(this.chlTagList, 2);
            this.chlTagList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chlTagList.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chlTagList.FormattingEnabled = true;
            this.chlTagList.Location = new System.Drawing.Point(6, 7);
            this.chlTagList.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.chlTagList.Name = "chlTagList";
            this.chlTagList.Size = new System.Drawing.Size(355, 381);
            this.chlTagList.TabIndex = 0;
            // 
            // tlpTagSelecting
            // 
            this.tlpTagSelecting.ColumnCount = 2;
            this.tlpTagSelecting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTagSelecting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTagSelecting.Controls.Add(this.btnLoad, 1, 1);
            this.tlpTagSelecting.Controls.Add(this.btnCheckAll, 0, 1);
            this.tlpTagSelecting.Controls.Add(this.chlTagList, 0, 0);
            this.tlpTagSelecting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTagSelecting.Location = new System.Drawing.Point(0, 0);
            this.tlpTagSelecting.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tlpTagSelecting.Name = "tlpTagSelecting";
            this.tlpTagSelecting.RowCount = 2;
            this.tlpTagSelecting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpTagSelecting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTagSelecting.Size = new System.Drawing.Size(367, 494);
            this.tlpTagSelecting.TabIndex = 1;
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheckAll.Location = new System.Drawing.Point(6, 402);
            this.btnCheckAll.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(171, 85);
            this.btnCheckAll.TabIndex = 2;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoad.Location = new System.Drawing.Point(189, 402);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(172, 85);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // TagSelectingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 494);
            this.Controls.Add(this.tlpTagSelecting);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TagSelectingForm";
            this.Text = "Load by Tags";
            this.tlpTagSelecting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chlTagList;
        private System.Windows.Forms.TableLayoutPanel tlpTagSelecting;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCheckAll;
    }
}