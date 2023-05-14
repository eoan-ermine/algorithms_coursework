using System;
using System.Windows.Forms;

using AlgorithmsCourseworkLibrary;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;

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
            System.Windows.Forms.Application.Exit();
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

            object t1 = WdDefaultTableBehavior.wdWord9TableBehavior;
            object t2 = WdAutoFitBehavior.wdAutoFitContent;

            Table tbl = Word.ActiveDocument.Tables.Add(Word.Selection.Range, 2, AlgorithmsCoursework.answers.Length, t1, t2);
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

        private void writeExcelButton_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Workbook workBook;
            Worksheet workSheet;

            workBook = app.Workbooks.Add();
            workSheet = (Worksheet)workBook.Worksheets.get_Item(1);
            workSheet.Name = "Массив исходный";
            workSheet.Cells[1, 1] = "Массив ответов";
            for (int i = 0; i != AlgorithmsCoursework.answers.Length; i++)
            {
                workSheet.Cells[2, i + 1] = "[" + i + "]";
                workSheet.Cells[3, i + 1] = Convert.ToInt32(AlgorithmsCoursework.answers[i]);
            }
            
            Microsoft.Office.Interop.Excel.Range range = workSheet.Range[workSheet.Cells[2, 1], workSheet.Cells[3, AlgorithmsCoursework.answers.Length]];
            range.Cells.Font.Name = "Times New Roman";
            range.Cells.Font.Size = 14;
            range.Cells.Columns.AutoFit();
            range.Borders.get_Item(XlBordersIndex.xlEdgeBottom).LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            range.Borders.get_Item(XlBordersIndex.xlEdgeRight).LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            range.Borders.get_Item(XlBordersIndex.xlInsideHorizontal).LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            range.Borders.get_Item(XlBordersIndex.xlInsideVertical).LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            range.Borders.get_Item(XlBordersIndex.xlEdgeTop).LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

            workSheet.Range[("A7")].Select();
            app.Visible = true;
            app.UserControl= true;
        }

        private void openExcelButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx|Excel Macro-Enabled Workbook (*.xlsm)|*.xlsm|All files (*.*)|*.*";
            openFileDialog.Title = "Выберите документ Excel";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Вы не выбрали файл", "Открыть", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            System.Diagnostics.Process.Start(openFileDialog.FileName);

        }
    }
}