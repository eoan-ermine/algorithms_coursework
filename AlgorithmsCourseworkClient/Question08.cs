using System;
using System.Windows.Forms;

using AlgorithmsCourseworkLibrary;

namespace AlgorithmsCourseworkGUI
{
    public partial class Question08 : Form
    {
        public Question08()
        {
            InitializeComponent();

            AlgorithmsCoursework.setupVersion(versionLabel);
            AlgorithmsCoursework.setupTimer(timeLabel);
            AlgorithmsCoursework.setupProgressBar(progressBar);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            int result = AlgorithmsCoursework.Question08(
                listBox2.Items[0].ToString(), listBox2.Items[1].ToString(), listBox2.Items[2].ToString(),
                listBox2.Items[3].ToString(), listBox2.Items[4].ToString()
            );
            if (result == 1)
            {
                this.Hide();
                Question09 nextForm = new Question09();
                nextForm.Show();
            }
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
