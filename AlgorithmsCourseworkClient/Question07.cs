﻿using System;
using System.Windows.Forms;

using AlgorithmsCourseworkLibrary;

namespace AlgorithmsCourseworkGUI
{
    public partial class Question07 : Form
    {
        public Question07()
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
            int result = AlgorithmsCoursework.Question07(
                listBox2.Items[0].ToString(), listBox2.Items[1].ToString(), listBox2.Items[2].ToString(),
                listBox2.Items[3].ToString(), listBox2.Items[4].ToString()
            );
            this.Hide();
            Question08 nextForm = new Question08();
            nextForm.Show();
        }

        private void unionButton_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            int j = listBox2.SelectedIndex;

            (listBox2.Items[i], listBox2.Items[j]) = (listBox2.Items[j], listBox2.Items[i]);
            listBox2.SetSelected(i, true);
        }
    }
}
