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
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            var Word = new Microsoft.Office.Interop.Word.Application
            {
                Visible = true,
            };
            var inf = Type.Missing;
            var Document = Word.Documents.Add(inf);
            Word.Selection.TypeText("Массив ответов");

            object t1 = Microsoft.Office.Interop.Word.WdDefaultTableBehavior.wdWord9TableBehavior;
            object t2 = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent;

            Microsoft.Office.Interop.Word.Table tbl = Word.ActiveDocument.Tables.Add(Word.Selection.Range, 2, AlgorithmsCoursework.answers.Length, t1, t2);
            for (int i = 0; i != AlgorithmsCoursework.answers.Length; ++i)
            {
                tbl.Cell(1, i + 1).Range.InsertAfter("[" + Convert.ToString(i) + "]");
                tbl.Cell(2, i + 1).Range.InsertAfter(Convert.ToInt32(AlgorithmsCoursework.answers[i]).ToString());
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Microsoft Word (*.docx)|*.docx|All files (*.*)|*.*";
            openFileDialog.Title = "Выберите документ Word";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Вы не выбрали файл", "Открыть", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            System.Diagnostics.Process.Start(openFileDialog.FileName);
        }
    }
}