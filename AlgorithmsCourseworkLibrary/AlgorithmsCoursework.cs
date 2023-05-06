using System.Windows.Forms;

namespace AlgorithmsCourseworkLibrary
{
    public class AlgorithmsCoursework
    {
        public static int n = 0;
        public static bool[] answers = new bool[8];

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

    }
}
