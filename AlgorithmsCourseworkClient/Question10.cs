using System;
using System.Windows.Forms;

using AlgorithmsCourseworkLibrary;

namespace AlgorithmsCourseworkGUI
{
    public partial class Question10 : Form
    {
        public Question10()
        {
            InitializeComponent();
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
            
            if (CB1.SelectedIndex == 2 && CB2.SelectedIndex == 3 && CB3.SelectedIndex == 1 && CB4.SelectedIndex == 0)
            {
                MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AlgorithmsCoursework.n += 1;
                AlgorithmsCoursework.answers[9] = true;
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AlgorithmsCoursework.answers[9] = false;
            }

            this.Hide();
            Question11 nextForm = new Question11();
            nextForm.Show();
        }
    }
}