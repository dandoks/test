using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uchpraktika
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonMain1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();
        }

        private void buttonVp1_Click(object sender, EventArgs e)
        {

            try
            {
                double x = double.Parse(textBoxX1.Text);
                if (x > 0)
                {
                    double y1 = 3 * x + Math.Exp(x + 1.35);
                    if (y1 != 0)
                    {
                        double y = (Math.Pow(Math.Sin(x + 3.5), 2) + Math.Log10(x)) / y1;
                        y = Math.Round(y, 4);
                        labelRez1.Text = $"y={Convert.ToString(y)}";
                    }
                    else MessageBox.Show("Ошибка: деление на ноль");
                }
                else MessageBox.Show("Ошибка: логарифм нельзя извлечь из отриц. числа");
            }
            catch 
            {
                MessageBox.Show("Введите число");
            }
           
        }

        private void buttonVp2_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBoxX2.Text);

                if (x < 1)
                {
                    double y = Math.Tan(2 * x + 4.2) - Math.Abs(Math.Log10(x));
                    y = Math.Round(y, 4);
                    labelRez2.Text = $"y={Convert.ToString(y)}";
                }
                else
                if (x >= 2 && x <= 5)
                {
                    double y = Math.Sin(x) + Math.Sqrt(6 * x);
                    y = Math.Round(y, 4);
                    labelRez2.Text = $"y={Convert.ToString(y)}";
                }
                else
                if (x > 7)
                {
                    double y = 6 + Math.Atan((2 * x) / (1 + Math.Sqrt(x)));
                    y = Math.Round(y, 4);
                    labelRez2.Text = $"y={Convert.ToString(y)}";
                }
                else MessageBox.Show("Функция не определена");

            }
            catch
            {
                MessageBox.Show("Введите число");
            }
        }

        private void buttonVp3_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBoxX3.Text);
                if (x < 0) MessageBox.Show("Ошибка: извлечение логарифма из отриц. знач.");
                else
                {
                    double p = 1;
                    double fac;
                    for (int n = 3; n <= 8; n++)
                    {

                        fac = 1;
                        for (int i = 1; i <= 2 * n + 2; i++)
                        {
                            fac *= i;
                        }
                        p = p * (fac + Math.Log10(x * n)) / (Math.Pow(x, n + 4));

                    }

                    p = Math.Round(p, 4);
                    labelRez3.Text = $"P={Convert.ToString(p)}";
                }
            }
            catch
            {
                MessageBox.Show("Введите число");
            }
        }
    }
}
