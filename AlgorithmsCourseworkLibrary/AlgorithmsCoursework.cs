using System;
using System.Drawing;
using System.Windows.Forms;

using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using CheckBox = System.Windows.Forms.CheckBox;

namespace AlgorithmsCourseworkLibrary
{
    public class AlgorithmsCoursework
    {
        public static int n = 0;
        public static bool[] answers = new bool[16];
        public static int version = 100;

        public static int UnaryQuestion(int index, string userAnswer, string rightAnswer)
        {
            userAnswer = userAnswer.Trim().ToLower();
            if (userAnswer == "")
            {
                MessageBox.Show("Вы не ввели ответ на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            else if (userAnswer == rightAnswer)
            {
                MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                answers[index] = true;
                return 1;
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                answers[index] = false;
                return 0;
            }
        }

        public static int Question03(CheckBox CB1, CheckBox CB2, CheckBox CB3, CheckBox CB4, CheckBox CB5)
        {
            if (!CB1.Checked && !CB2.Checked && !CB3.Checked && !CB4.Checked && !CB5.Checked)
            {
                MessageBox.Show("Вы не выбрали ни один из вариантов ответа", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            } else if (CB1.Checked && !CB2.Checked && !CB3.Checked && CB4.Checked && !CB5.Checked)
            {
                MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                answers[2] = true;
                return 1;
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                answers[2] = false;
                return 0;
            }
        }

        public static int Question04(CheckBox CB1, CheckBox CB2, CheckBox CB3, CheckBox CB4, CheckBox CB5)
        {
            if (!CB1.Checked && !CB2.Checked && !CB3.Checked && !CB4.Checked && !CB5.Checked)
            {
                MessageBox.Show("Вы не выбрали ни один из вариантов ответа", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            else if (CB1.Checked && CB2.Checked && !CB3.Checked && CB4.Checked && !CB5.Checked)
            {
                MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                answers[3] = true;
                return 1;
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                answers[3] = false;
                return 0;
            }
        }

        public static int Question05(RadioButton RB1, RadioButton RB2, RadioButton RB3, RadioButton RB4, RadioButton RB5)
        {
            if (!RB1.Checked && !RB2.Checked && !RB3.Checked && !RB4.Checked && !RB5.Checked)
            {
                MessageBox.Show("Вы не выбрали ни один из вариантов ответа", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            else if (RB2.Checked)
            {
                MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                answers[4] = true;
                return 1;
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                answers[4] = false;
                return 0;
            }
        }

        public static int Question06(RadioButton RB1, RadioButton RB2, RadioButton RB3, RadioButton RB4)
        {
            if (!RB1.Checked && !RB2.Checked && !RB3.Checked && !RB4.Checked)
            {
                MessageBox.Show("Вы не выбрали ни один из вариантов ответа", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            else if (RB3.Checked)
            {
                MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                answers[5] = true;
                return 1;
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                answers[5] = false;
                return 0;
            }
        }

        public static int Question07(string answer1, string answer2, string answer3, string answer4, string answer5)
        {
            if (
                answer1 == "Автоматизированные системы планирования потребностей распределения" && answer2 == "Планирование ресурсов предприятия" &&
                answer3 == "Управление календарным планированием" && answer4 == "Планирование материальных потребностей" &&
                answer5 == "Управление загрузкой производственных мощностей"
            )
            {
                MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                answers[6] = true;
                return 1;
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                answers[6] = false;
                return 0;
            }
        }

        public static int Question08(string answer1, string answer2, string answer3, string answer4, string answer5)
        {
            if (
                answer1 == "Система управления взаимоотношениями с поставщиками" &&
                answer2 == "Система управления виртуальными логистическими цепочками" &&
                answer3 == "Система управления жизненным циклом продукта" &&
                answer4 == "Система управления финансами со стороны различных участников" &&
                answer5 == "Система управления знаниями о бизнесе"
            )
            {
                MessageBox.Show("Вы ответили правильно", "Правильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                answers[7] = true;
                return 1;
            }
            else
            {
                MessageBox.Show("Вы ответили неправильно", "Неправильный ответ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                answers[7] = false;
                return 0;
            }
        }

        public static void setupVersion(ToolStripStatusLabel label)
        {
            int version = AlgorithmsCoursework.version;
            int major = version / 100, minor = (version / 10) % 10, patch = version % 10;
            label.Text = string.Format("Версия программы: {0}.{1}.{2}", major, minor, patch);
        }

        public static void setupTimer(ToolStripStatusLabel label)
        {
            Timer timer = new Timer();
            timer.Tick += (object e, EventArgs v) => updateDate(label);
            timer.Interval = 1000;
            timer.Start();
            updateDate(label);
        }

        public static void setupProgressBar(ProgressBar progressBar)
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = 16;
            progressBar.Value = n;
        }

        private static void updateDate(ToolStripStatusLabel label)
        {
            string dateInfo = DateTime.Now.ToString("dddd, dd MMMM yyyy, HH:mm:ss");
            label.Text = dateInfo.Substring(0, 1).ToUpper() + dateInfo.Substring(1);
        }


        // ResultForm.cs
        public static void OutputRows(DataGridView view, int[] keys, bool[] values)
        {
            view.Rows.Clear();
            for (int i = 0; i != keys.Length; i++)
            {
                view.Rows.Add(keys[i], values[i] == true ? "Верно" : "Неверно");
            }
        }

        public static void SaveChartAsImage(ChartObject chart)
        {
            chart.CopyPicture(
                Microsoft.Office.Interop.Excel.XlPictureAppearance.xlScreen,
                Microsoft.Office.Interop.Excel.XlCopyPictureFormat.xlBitmap
            );
            Bitmap image = new Bitmap(Clipboard.GetImage());

            SaveFileDialog saveFileDIalog = new SaveFileDialog();
            saveFileDIalog.Filter = "Image (*.jpg) | *.jpg";
            saveFileDIalog.Title = "Сохранить изображение";

            while (saveFileDIalog.ShowDialog() != DialogResult.OK)
                continue;

            image.Save(saveFileDIalog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        public static void WriteExcel(int[] keys, bool[] values)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Workbook workBook;
            Worksheet workSheet;

            workBook = app.Workbooks.Add();
            workSheet = (Worksheet)workBook.Worksheets.get_Item(1);
            workSheet.Name = "Массив исходный";
            workSheet.Cells[1, 1] = "Массив ответов";
            for (int i = 0; i != values.Length; i++)
            {
                workSheet.Cells[2, i + 1] = "[" + keys[i] + "]";
                workSheet.Cells[3, i + 1] = Convert.ToInt32(values[i]);
            }

            Microsoft.Office.Interop.Excel.Range range = workSheet.Range[workSheet.Cells[2, 1], workSheet.Cells[3, values.Length]];
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

            workSheet.Cells[4, 1] = "Правильные ответы";
            workSheet.Cells[4, 2] = "=SUM(A3:P3)";
            workSheet.Cells[5, 1] = "Неправильные ответы";
            workSheet.Cells[5, 2] = "=" + values.Length + "-SUM(A3:P3)";

            object misValue = System.Reflection.Missing.Value;

            Microsoft.Office.Interop.Excel.Range chartRange;

            ChartObjects xlCharts = (ChartObjects)workSheet.ChartObjects(Type.Missing);
            ChartObject myChart = (ChartObject)xlCharts.Add(0, 80, 300, 250);
            Microsoft.Office.Interop.Excel.Chart chartPage = myChart.Chart;

            chartRange = workSheet.get_Range("A4", "B5");
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = XlChartType.xlColumnClustered;
            chartPage.Legend.Delete();

            SaveChartAsImage(myChart);

            workSheet.Range[("A7")].Select();
            app.Visible = true;
            app.UserControl = true;
        }
        public static void WriteWord(DataGridView view)
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

            int length = view.RowCount, columns = view.ColumnCount;
            Table tbl = Word.ActiveDocument.Tables.Add(Word.Selection.Range, columns, length, t1, t2);

            for (int i = 0; i != columns; ++i)
            {
                for (int j = 0; j != length; ++j)
                {
                    object value = view.Rows[j].Cells[i].Value;
                    tbl.Cell(i + 1, j + 1).Range.InsertAfter(value == null ? "null": value.ToString());
                }
            }
        }

        public static void Sort(int[] keys, bool[] values)
        {
            for (int j = 1; j != values.Length; ++j)
            {
                var key = keys[j];
                var value = values[j];
                var i = j - 1;

                while (i >= 0 && Convert.ToInt32(values[i]) > Convert.ToInt32(value))
                {
                    keys[i + 1] = keys[i];
                    values[i + 1] = values[i];
                    i = i - 1;
                }

                keys[i + 1] = key;
                values[i + 1] = value;
            }
        }

        public static void OpenFile(string filters, string title)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = filters;
            openFileDialog.Title = title;
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Вы не выбрали файл", "Открыть", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            System.Diagnostics.Process.Start(openFileDialog.FileName);

        }
    }
}