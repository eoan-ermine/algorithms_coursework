using System;
using System.Windows.Forms;

using AlgorithmsCourseworkLibrary;

namespace AlgorithmsCourseworkGUI
{
    public partial class Question01 : Form
    {
        public Question01()
        {
            InitializeComponent();
            answerInput.Focus();

            AlgorithmsCoursework.SetupVersion(versionLabel);
            AlgorithmsCoursework.SetupTimer(timeLabel);
            AlgorithmsCoursework.SetupProgressBar(progressBar);
            AlgorithmsCoursework.SetupRemainingQuestionsCount(questionsCount);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            int result = AlgorithmsCoursework.UnaryQuestion(0, answerInput.Text, "корпоративная информационная система");
            if (result != -1)
            {
                this.Hide();
                Question02 nextForm = new Question02();
                nextForm.Show();
            }
        }
    }
}
