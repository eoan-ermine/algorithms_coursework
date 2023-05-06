using System;
using System.Windows.Forms;

using AlgorithmsCourseworkLibrary;

namespace AlgorithmsCourseworkGUI
{
    public partial class Question15 : Form
    {
        public Question15()
        {
            InitializeComponent();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (CLB.CheckedItems.Count == 0)
            {
                MessageBox.Show("Вы не выбрали ни один из вариантов ответа", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (
                CLB.CheckedItems.Count == 3 &&
                CLB.CheckedItems.Contains("Изменчивость") && CLB.CheckedItems.Contains("Ограниченность продолжительности") && CLB.CheckedItems.Contains("Правовое и программное обеспечение")
            )
            {
                MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AlgorithmsCoursework.n += 1;
                AlgorithmsCoursework.answers[14] = true;

                this.Hide();
                Question16 nextForm = new Question16();
                nextForm.Show();
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AlgorithmsCoursework.answers[14] = false;
            }

        }
    }
}