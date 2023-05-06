using System;
using System.Windows.Forms;

using AlgorithmsCourseworkLibrary;

namespace AlgorithmsCourseworkGUI
{
    public partial class Question02 : Form
    {
        public Question02()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            int result = AlgorithmsCoursework.UnaryQuestion(1, answerInput.Text, "инцидент");
            if (result == 1)
            {
                this.Hide();
                Question03 nextForm = new Question03();
                nextForm.Show();
            }
        }
    }
}
