using System;
using System.Windows.Forms;

using AlgorithmsCourseworkLibrary;

namespace AlgorithmsCourseworkGUI
{
    public partial class Question09 : Form
    {
        public Question09()
        {
            InitializeComponent();

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
            if (CB1.SelectedIndex == -1 || CB2.SelectedIndex == -1 || CB3.SelectedIndex == -1 || CB4.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите ответ во всех полях", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (CB1.SelectedIndex == 2 && CB2.SelectedIndex == 0 && CB3.SelectedIndex == 1 && CB4.SelectedIndex == 3)
            {
                MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AlgorithmsCoursework.n += 1;
                AlgorithmsCoursework.answers[8] = true;
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AlgorithmsCoursework.answers[8] = false;
            }

            this.Hide();
            Question11 nextForm = new Question11();
            nextForm.Show();
        }
    }
}