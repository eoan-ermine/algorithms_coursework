using System;
using System.Windows.Forms;

using AlgorithmsCourseworkLibrary;

namespace AlgorithmsCourseworkGUI
{
    public partial class TitleForm : Form
    {
        public TitleForm()
        {
            InitializeComponent();

            AlgorithmsCoursework.SetupVersion(versionLabel);
            AlgorithmsCoursework.SetupTimer(timeLabel);

            KeyPreview = true;
        }
        private void exitButton_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void theoryButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            TheoryForm nextForm = new TheoryForm();
            nextForm.Show();
        }

        private void testButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Question01 nextForm = new Question01();
            nextForm.Show();
        }

        private void playerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerForm nextForm = new PlayerForm();
            nextForm.Show();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResultForm nextForm = new ResultForm();
            nextForm.Show();
        }

        private void TitleForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F5)
            {
                MessageBox.Show("Режим разработчика успешно активирован");
                resultButton.Visible = true;
                e.Handled = true;
            }
        }
    }
}
