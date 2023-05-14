using AlgorithmsCourseworkLibrary;
using System;
using System.Windows.Forms;

namespace AlgorithmsCourseworkGUI
{
    public partial class PlayerForm : Form
    {
        OpenFileDialog openFileDialog;

        public PlayerForm()
        {
            InitializeComponent();

            AlgorithmsCoursework.setupVersion(versionLabel);
            AlgorithmsCoursework.setupTimer(timeLabel);
        }

        private void PlayerForm_Load(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            this.Text = "Windows Media Player, версия = " + player.versionInfo;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void titleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TitleForm nextForm = new TitleForm();
            nextForm.Show();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            player.URL = openFileDialog.FileName;
            player.Ctlcontrols.play();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void полноэкранныйРежимToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                player.fullScreen = true;
        }

        private void паузаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void начатьВоспроизведениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void выключитьвключитьЗвукToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.settings.mute = !player.settings.mute;
        }

        private void свойстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.ShowPropertyPages();
        }
    }
}
