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
    
    public partial class Form3 : Form
    {
        
       
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();
        }

        

        
        private void buttonExecute_Click(object sender, EventArgs e)
        {
            dataGridViewDanMas.Rows.Clear();
            dataGridViewRez.Rows.Clear();
            try
            {
                string ent = textBoxDanMas.Text;
            string[] t1 = ent.Split(' ');
            int[] mass = new int[t1.Length];
            dataGridViewDanMas.RowCount = 1;
            dataGridViewDanMas.ColumnCount = t1.Length;
            for (int i = 0; i < t1.Length; i++)
            {
                mass[i] = int.Parse(t1[i]);
                dataGridViewDanMas.Rows[0].Cells[i].Value = t1[i];
            }
            //int kol = 0;
            //for (int i = 0; i < mass.Length; i++)
            //{

            //    for (int j = i + 1; j < mass.Length; j++)
            //    {
            //        if (mass[i] + mass[j] == 0)
            //        {
            //            kol = kol + 2;

            //        }
            //        else continue;

            //    }
            //}
            int[] masind = new int[mass.Length];
            for (int i = 0; i < mass.Length; i++)
                {

                for (int j = i + 1; j < mass.Length; j++)
                    {
                    if (mass[i] + mass[j] == 0)
                    {
                        masind[i] = i;
                        masind[j] = j;
                    }
                    }
            }
            //BubbleSort(masind);
            dataGridViewRez.ColumnCount = masind.Length;
            dataGridViewRez.RowCount = 1;
            dataGridViewRez.ColumnCount = masind.Length;
            for (int i = 0; i < masind.Length; i++)
            {
                if (i != 0)
                {
                    if (masind[i] == 0) continue;
                }
                dataGridViewRez.Rows[0].Cells[i].Value = masind[i];
            }
            }
            catch
            {
                MessageBox.Show("Введите числа");
            }

        }

      
        static int[] BubbleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }
    }
}
