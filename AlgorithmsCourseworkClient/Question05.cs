﻿using System;
using System.Windows.Forms;

using AlgorithmsCourseworkLibrary;

namespace AlgorithmsCourseworkGUI
{
    public partial class Question05 : Form
    {
        public Question05()
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
            int result = AlgorithmsCoursework.Question05(radioButton1, radioButton2, radioButton3, radioButton4, radioButton5);
            if (result != -1)
            {
                this.Hide();
                Question05 nextForm = new Question05();
                nextForm.Show();
            }
        }
    }
}
