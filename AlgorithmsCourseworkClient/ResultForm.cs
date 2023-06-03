using System;
using System.Linq;
using System.Windows.Forms;

using AlgorithmsCourseworkLibrary;

namespace AlgorithmsCourseworkGUI
{
    public partial class ResultForm : Form
    {
        int[] sortedKeys  = null;
        bool[] sortedValues = null;

        // ...
        public ResultForm()
        {
            InitializeComponent();

            AlgorithmsCoursework.SetupVersion(versionLabel);
            AlgorithmsCoursework.SetupTimer(timeLabel);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fetchButton_Click(object sender, EventArgs e)
        {
            int[,] resultsMatrix = AlgorithmsCoursework.GetResultsMatrix();
            AlgorithmsCoursework.OutputRows(resultView, resultsMatrix);
        }

        private void plotButton_Click(object sender, EventArgs e)
        {
            chart.Series[0].Points.AddXY(0, AlgorithmsCoursework.n);
            chart.Series[1].Points.AddXY(1, AlgorithmsCoursework.answers.Length - AlgorithmsCoursework.n);
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            if (resultView.RowCount == 0)
            {
                MessageBox.Show("Получите результаты тестирования", "Операция невозможна", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AlgorithmsCoursework.WriteWord(resultView);
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            AlgorithmsCoursework.OpenFile("Microsoft Word (*.docx)|*.docx|All files (*.*)|*.*", "Выберите документ Word");
        }

        private void writeExcelButton_Click(object sender, EventArgs e)
        {
            AlgorithmsCoursework.WriteExcel(
                Enumerable.Range(1, AlgorithmsCoursework.answers.Length).ToArray(),
                AlgorithmsCoursework.answers
            );
        }

        private void openExcelButton_Click(object sender, EventArgs e)
        {
            AlgorithmsCoursework.OpenFile(
                "Excel Workbook (*.xlsx)|*.xlsx|Excel Macro-Enabled Workbook (*.xlsm)|*.xlsm|All files (*.*)|*.*",
                "Выберите документ Excel"
            );
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            sortedKeys = new int[AlgorithmsCoursework.answers.Length];
            sortedValues = new bool[AlgorithmsCoursework.answers.Length];
            for (int i = 0; i != AlgorithmsCoursework.answers.Length; ++i)
            {
                sortedKeys[i] = i + 1;
                sortedValues[i] = AlgorithmsCoursework.answers[i];
            }

            AlgorithmsCoursework.Sort(sortedKeys, sortedValues);
            AlgorithmsCoursework.OutputRows(sortedView, sortedKeys, sortedValues);
        }

        private void writeSortExcelButton_Click(object sender, EventArgs e)
        {
            if (sortedKeys == null || sortedValues == null)
            {
                MessageBox.Show("Выполните сортировку", "Операция невозможна", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
             }

            AlgorithmsCoursework.Sort(sortedKeys, sortedValues);
            AlgorithmsCoursework.WriteExcel(sortedKeys, sortedValues);
        }

        private void insertColumnButton_Click(object sender, EventArgs e)
        {
            string name = "";
            while (name == "")
                name = Microsoft.VisualBasic.Interaction.InputBox("Пожалуйста, введите название нового столбца", "Создание столбца");

            var column = new DataGridViewTextBoxColumn();
            column.ReadOnly = false;
            column.Name = name;
            resultView.Columns.Add(column);
        }
    }
}