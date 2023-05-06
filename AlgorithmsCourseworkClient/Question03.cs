using System;
using System.Windows.Forms;

using AlgorithmsCourseworkLibrary;

namespace AlgorithmsCourseworkGUI
{
    public partial class Question03 : Form
    {
        public Question03()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            int result = AlgorithmsCoursework.Question03(checkBox1, checkBox2, checkBox3, checkBox4, checkBox5);
            if (result == 1)
            {
                this.Hide();
                Question04 nextForm = new Question04();
                nextForm.Show();
            }
        }
    }
}
