using System;
using System.Windows.Forms;


namespace AlgorithmsCourseworkGUI
{
    public partial class SplashScreenForm : Form
    {
        Timer timer = new Timer();

        public SplashScreenForm()
        {
            InitializeComponent();

            // Устанавливаем таймер, чтобы через пять секунд он выполнил указанную функцию
            timer.Tick += SwitchToTitleForm;
            timer.Interval = 5000;
            timer.Start();
        }

        public void SwitchToTitleForm(object e, EventArgs v)
        {
            // Останавливаем таймер. Иначе он начнет повторяться. Он нам больше не нужен
            timer.Stop();

            // Переходим к титульной форме
            this.Hide();
            TitleForm nextForm = new TitleForm();
            nextForm.Show();
        }
    }
}
