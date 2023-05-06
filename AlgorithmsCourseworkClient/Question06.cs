using System;
using System.Windows.Forms;

using AlgorithmsCourseworkLibrary;

namespace AlgorithmsCourseworkGUI
{
    public partial class Question06 : Form
    {
        public Question06()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            int result = AlgorithmsCoursework.Question06(radioButton1, radioButton2, radioButton3, radioButton4);
            if (result == 1)
            {
                this.Hide();
                Question06 nextForm = new Question06();
                nextForm.Show();
            }
        }
    }
}
