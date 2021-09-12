using System;
using System.Windows.Forms;

namespace ManagerUI
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnTesting_Click(object sender, EventArgs e)
        {
            QuizForm newFrm = new QuizForm();
            this.Hide();
            newFrm.ShowDialog();
            this.Show();
        }

        private void btnVocabEditor_Click(object sender, EventArgs e)
        {
            EditorForm newFrm = new EditorForm();
            this.Hide();
            newFrm.ShowDialog();
            this.Show();
        }
    }
}
