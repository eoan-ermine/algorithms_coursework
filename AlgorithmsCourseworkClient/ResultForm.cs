using System;
using System.Windows.Forms;

using AlgorithmsCourseworkLibrary;

namespace AlgorithmsCourseworkGUI
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();

            AlgorithmsCoursework.setupVersion(versionLabel);
            AlgorithmsCoursework.setupTimer(timeLabel);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fetchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i != AlgorithmsCoursework.answers.Length; ++i)
            {
                resultView.Rows.Add(i + 1, AlgorithmsCoursework.answers[i] == true ? "Верно" : "Неверно");
            }
        }

        private void plotButton_Click(object sender, EventArgs e)
        {
            chart.Series[0].Points.AddXY(0, AlgorithmsCoursework.n);
            chart.Series[1].Points.AddXY(1, AlgorithmsCoursework.answers.Length - AlgorithmsCoursework.n);
        }

        private void writeButton_Click(object sender, EventArgs e)
        {

        }
    }
}