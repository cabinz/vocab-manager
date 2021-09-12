using ManagerLibrary;
using ManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ManagerUI
{
    public partial class TagSelectingForm : Form
    {
        /// <summary>
        /// Checked tags when Load is clicked.
        /// </summary>
        public List<TagModel> checkedTags { get; set; } = new List<TagModel>();

        public TagSelectingForm()
        {
            InitializeComponent();

            LoadTagCheckBoxList();
        }

        private void LoadTagCheckBoxList()
        {
            chlTagList.DataSource = GlobalConfig.Connection.GetAllTags();
            chlTagList.DisplayMember = "TagName";
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chlTagList.Items.Count; i++)
            {
                chlTagList.SetItemChecked(i, true);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chlTagList.Items.Count; i++)
            {
                if (chlTagList.GetItemCheckState(i) == CheckState.Checked)
                {
                    checkedTags.Add((TagModel)chlTagList.Items[i]);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
