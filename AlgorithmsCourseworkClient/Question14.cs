using System;
using System.Windows.Forms;

using AlgorithmsCourseworkLibrary;

namespace AlgorithmsCourseworkGUI
{
    public partial class Question14 : Form
    {
        private int value;

        public Question14()
        {
            InitializeComponent();
            value = HSB.Value;
            answerLabel.Text = "Ваш ответ: " + value.ToString();

            AlgorithmsCoursework.setupVersion(versionLabel);
            AlgorithmsCoursework.setupTimer(timeLabel);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (HSB.Value >= 10 && HSB.Value <= 20)
            {
                MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AlgorithmsCoursework.n += 1;
                AlgorithmsCoursework.answers[13] = true;
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AlgorithmsCoursework.answers[13] = false;
            }

            this.Hide();
            Question15 nextForm = new Question15();
            nextForm.Show();
        }

        private void HSB_Scroll(object sender, ScrollEventArgs e)
        {
            value = e.NewValue;
            answerLabel.Text = "Ваш ответ: " + value.ToString();
        }
    }
}