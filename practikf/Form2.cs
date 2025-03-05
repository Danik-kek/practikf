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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем значения из текстовых полей
                int a = int.Parse(textBoxA.Text);
                int b = int.Parse(textBoxB.Text);
                int c = int.Parse(textBoxC.Text);

                // Проверяем корректность значений
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    throw new ArgumentException("Стороны треугольника должны быть больше нуля.");
                }
                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    throw new ArgumentException("Такой треугольник не существует.");
                }

                // Определяем тип треугольника по сторонам
                string typeBySides = DetermineTriangleTypeBySides(a, b, c);

                // Определяем тип треугольника по углам
                string typeByAngles = DetermineTriangleTypeByAngles(a, b, c);

                // Вычисляем периметр
                double perimeter = CalculatePerimeter(a, b, c);

                // Вычисляем площадь
                double area = CalculateArea(a, b, c);

                // Выводим результаты через MessageBox
                MessageBox.Show(
                    $"Тип треугольника по сторонам: {typeBySides}\n" +
                    $"Тип треугольника по углам: {typeByAngles}\n" +
                    $"Периметр: {perimeter}\n" +
                    $"Площадь: {area}"
                );
            }
            catch (Exception ex)
            {
                // Выводим сообщение об ошибке через MessageBox
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string DetermineTriangleTypeBySides(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                return "Равносторонний";
            }
            else if (a == b || a == c || b == c)
            {
                return "Равнобедренный";
            }
            else
            {
                return "Разносторонний";
            }
        }

        private string DetermineTriangleTypeByAngles(int a, int b, int c)
        {
            double[] sides = { a, b, c };
            Array.Sort(sides); // Сортируем стороны

            double maxSide = sides[2];
            double sumOfOtherSides = sides[0] * sides[0] + sides[1] * sides[1];

            if (maxSide * maxSide == sumOfOtherSides)
            {
                return "Прямоугольный";
            }
            else if (maxSide * maxSide < sumOfOtherSides)
            {
                return "Остроугольный";
            }
            else
            {
                return "Тупоугольный";
            }
        }

        private double CalculatePerimeter(int a, int b, int c)
        {
            return a + b + c;
        }

        private double CalculateArea(int a, int b, int c)
        {
            double p = CalculatePerimeter(a, b, c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
