using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practikf
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем значения из текстовых полей
                double a = GetDoubleFromTextBox(textBoxA);
                double b = GetDoubleFromTextBox(textBoxB);
                double c = GetDoubleFromTextBox(textBoxC);

                // Проверяем корректность значений
                if (a == 0)
                {
                    throw new ArgumentException("Это не квадратное уравнение.");
                }

                // Вычисляем дискриминант
                double discriminant = CalculateDiscriminant(a, b, c);

                // Выводим результаты через MessageBox
                MessageBox.Show($"Дискриминант: {discriminant}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Выводим сообщение об ошибке через MessageBox
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем значения из текстовых полей
                double a = GetDoubleFromTextBox(textBoxA);
                double b = GetDoubleFromTextBox(textBoxB);
                double c = GetDoubleFromTextBox(textBoxC);

                // Проверяем корректность значений
                if (a == 0)
                {
                    throw new ArgumentException("Это не квадратное уравнение.");
                }

                // Вычисляем дискриминант
                double discriminant = CalculateDiscriminant(a, b, c);

                // Определяем количество корней
                if (discriminant > 0)
                {
                    double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    MessageBox.Show($"Корни: x1 = {root1}, x2 = {root2}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (discriminant == 0)
                {
                    double root = -b / (2 * a);
                    MessageBox.Show($"Корень: x = {root}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Корней нет", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Выводим сообщение об ошибке через MessageBox
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxC.Clear();
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Авторы: Морозов Кирилл и Завизиступ Даниил", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private double GetDoubleFromTextBox(TextBox textBox)
        {
            if (!double.TryParse(textBox.Text, out double result))
            {
                throw new ArgumentException("Введите корректные данные.");
            }
            return result;
        }

        private double CalculateDiscriminant(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
    }
}
