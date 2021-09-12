using ManagerLibrary;
using ManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ManagerUI
{
    public partial class RecycleBinForm : Form
    {
        public RecycleBinForm()
        {
            InitializeComponent();

            LoadRemovedWordList();
        }

        /// <summary>
        /// Load the removed word from data source and 
        /// display them on the lstRemovedWords board.
        /// </summary>
        private void LoadRemovedWordList()
        {
            List<WordModel> removedWords = GlobalConfig.Connection.GetRemovedWordSpellings();
            lstRemovedWords.DataSource = removedWords;
            lstRemovedWords.DisplayMember = "WordText";
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            if (lstRemovedWords.SelectedItem != null)
            {
                GlobalConfig.Connection.RecoverWordById(((WordModel)lstRemovedWords.SelectedItem).WordID);
                LoadRemovedWordList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstRemovedWords.SelectedItem != null)
            {
                GlobalConfig.Connection.DeleteWordById(((WordModel)lstRemovedWords.SelectedItem).WordID);
                LoadRemovedWordList();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            bool comfirm = MessageBox.Show(
                "All the words in recycle bin will be cleared, are you sure to continue?",
                "Warning",
                MessageBoxButtons.YesNo) == DialogResult.Yes;

            if (comfirm)
            {
                for (int i = 0; i < lstRemovedWords.Items.Count; i++)
                {
                    GlobalConfig.Connection.DeleteWordById(((WordModel)lstRemovedWords.Items[i]).WordID);
                }
                LoadRemovedWordList();
            }
        }
    }
}
