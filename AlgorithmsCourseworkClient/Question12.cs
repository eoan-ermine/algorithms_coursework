using System;
using System.Windows.Forms;

using AlgorithmsCourseworkLibrary;

namespace AlgorithmsCourseworkGUI
{
    public partial class Question12 : Form
    {
        public Question12()
        {
            InitializeComponent();

            AlgorithmsCoursework.setupVersion(versionLabel);
            AlgorithmsCoursework.setupTimer(timeLabel);
            AlgorithmsCoursework.setupProgressBar(progressBar);
            AlgorithmsCoursework.setupRemainingQuestionsCount(questionsCount);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (TB.Value == 2007)
            {
                MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AlgorithmsCoursework.n += 1;
                AlgorithmsCoursework.answers[11] = true;
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AlgorithmsCoursework.answers[11] = false;
            }

            this.Hide();
            Question13 nextForm = new Question13();
            nextForm.Show();
        }
    }
}