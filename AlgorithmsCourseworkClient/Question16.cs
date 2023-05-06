﻿using System;
using System.Windows.Forms;

using AlgorithmsCourseworkLibrary;

namespace AlgorithmsCourseworkGUI
{
    public partial class Question16 : Form
    {
        public Question16()
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
                CLB.CheckedItems.Count == 2 &&
                CLB.CheckedItems.Contains("Главный календарный план производства") && CLB.CheckedItems.Contains("Данные о рабочих центрах")
            )
            {
                MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AlgorithmsCoursework.n += 1;
                AlgorithmsCoursework.answers[15] = true;

                this.Hide();
                Question16 nextForm = new Question16();
                nextForm.Show();
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AlgorithmsCoursework.answers[15] = false;
            }

        }
    }
}