using System.Windows.Forms;

namespace AlgorithmsCourseworkClient
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
    }
}
