using System;
using System.Windows.Forms;

using AlgorithmsCourseworkLibrary;

namespace AlgorithmsCourseworkGUI
{
    public partial class Question13 : Form
    {
        private int value;

        public Question13()
        {
            InitializeComponent();
            value = HSB.Value;
            answerLabel.Text = "Ваш ответ: " + value.ToString();

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
            if (HSB.Value >= 0 && HSB.Value <= 16)
            {
                MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AlgorithmsCoursework.n += 1;
                AlgorithmsCoursework.answers[12] = true;
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AlgorithmsCoursework.answers[12] = false;
            }

            this.Hide();
            Question14 nextForm = new Question14();
            nextForm.Show();
        }

        private void HSB_Scroll(object sender, ScrollEventArgs e)
        {
            value = e.NewValue;
            answerLabel.Text = "Ваш ответ: " + value.ToString();
        }
    }
}