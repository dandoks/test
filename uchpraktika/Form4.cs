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
    public partial class Form4 : Form
    {
        public int n;
        
        public Form4()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
        }

        private void buttonMain4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void buttonVvod_Click(object sender, EventArgs e)
        {
            try
            {
                n = int.Parse(textBoxSize.Text);
                if (n > 0)
                {
                    dataGridView1.RowCount = n;
                    dataGridView1.ColumnCount = n;

                }
                else MessageBox.Show("Ошибка: введено отрицательное число или 0");
            }
            catch
            {
                MessageBox.Show("Введите число");
            }
            textBoxSize.Clear();
            dataGridView2.Rows.Clear();
        }

        private void buttonVp4_Click(object sender, EventArgs e)
        {
            try
            {
                
            int[,] matrix = new int[n, n];
                dataGridView2.RowCount = n;
                dataGridView2.ColumnCount = n;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {

                        matrix[i, j] = int.Parse(Convert.ToString(dataGridView1.Rows[i].Cells[j].Value));
                    if (i == j) matrix[i, j] = 1;
                    if (i > j) matrix[i, j] = 0;
                    if (i < j) matrix[i, j] = i + j;
                    dataGridView2.Rows[i].Cells[j].Value = matrix[i, j];


                }
                }
            }
            catch
            {
                MessageBox.Show("Введите числа");
            }
            dataGridView1.Rows.Clear();
        }
    }
}
