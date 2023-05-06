using System.Windows.Forms;

namespace AlgorithmsCourseworkGUI
{
    public partial class TitleForm : Form
    {
        public TitleForm()
        {
            InitializeComponent();
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
    }
}
