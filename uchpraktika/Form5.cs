using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Microsoft.VisualBasic.FileIO;

namespace uchpraktika
{
    public partial class Form5 : Form
    {
        public List<SportInv> SportInvList = new List<SportInv>();
        public int sch = 0;
        
        public Form5()
        {
            InitializeComponent();
        }

        private void buttonMain5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();
        }

        private void buttonentPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            if (of.FileName != "")
            {
                try
                {
                    dataGridViewDanTable.ColumnCount = 5;

                    using (TextFieldParser tfp = new TextFieldParser(of.FileName))
                    {

                        tfp.TextFieldType = FieldType.Delimited;
                        tfp.SetDelimiters(";");
                        while (!tfp.EndOfData)
                        {

                            dataGridViewDanTable.RowCount++;
                            string[] fields = tfp.ReadFields();

                            string N = fields[0];
                            string P = fields[1];
                            int Pr = int.Parse(fields[2]);
                            string Ser = fields[3];
                            int K = int.Parse(fields[4]);

                            SportInvList.Add(new SportInv(N, P, Pr, Ser, K));
                            try
                            {
                                for (int i = 0; i < fields.Length; i++)
                                {
                                    dataGridViewDanTable.Rows[sch].Cells[i].Value = fields[i];

                                }
                            }
                            catch
                            {
                                MessageBox.Show("В файле содержаться некорректные данные");
                            }
                            sch++;

                        }
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Введён некорректный файл");
                    
                }
            }
            else MessageBox.Show("Вы не выбрали файл");
        }
        public class SportInv
        {
            public string Name;
            public string Proizvoditel;
            public int Price;
            public string SerNom;
            public int Kolvo;
            public SportInv(string Name, string Proizvoditel, int Price, string SerNom, int Kolvo)
            {
                this.Name = Name;
                this.Proizvoditel = Proizvoditel;
                this.Price = Price;
                this.SerNom = SerNom;
                this.Kolvo = Kolvo;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string Search = textBoxSearch.Text;
            bool b = true;
            int k = 0;
            dataGridViewRezSearch.RowCount = 1;
            dataGridViewRezSearch.ColumnCount = 5;
            if (radioButtonName.Checked == true)
            {
                foreach (var i in SportInvList)
                {
                    if (Search.ToLower() == i.Name.ToLower())
                    {
                        dataGridViewRezSearch.RowCount++;
                        dataGridViewRezSearch.Rows[k].Cells[0].Value = i.Name;
                        dataGridViewRezSearch.Rows[k].Cells[1].Value = i.Proizvoditel;
                        dataGridViewRezSearch.Rows[k].Cells[2].Value = i.Price;
                        dataGridViewRezSearch.Rows[k].Cells[3].Value = i.SerNom;
                        dataGridViewRezSearch.Rows[k].Cells[4].Value = i.Kolvo;
                        k++;
                        b = false;
                    }
                }
            }
            else if (radioButtonProizvod.Checked == true)
            {
                foreach (var i in SportInvList)
                {
                    if (Search.ToLower() == i.Proizvoditel.ToLower())
                    {
                        dataGridViewRezSearch.RowCount++;
                        dataGridViewRezSearch.Rows[k].Cells[0].Value = i.Name;
                        dataGridViewRezSearch.Rows[k].Cells[1].Value = i.Proizvoditel;
                        dataGridViewRezSearch.Rows[k].Cells[2].Value = i.Price;
                        dataGridViewRezSearch.Rows[k].Cells[3].Value = i.SerNom;
                        dataGridViewRezSearch.Rows[k].Cells[4].Value = i.Kolvo;
                        k++;
                        b = false;
                    }
                }
            }
            else if (radioButtonSerNom.Checked == true)
            {
                foreach (var i in SportInvList)
                {
                    if (Search.ToLower() == i.SerNom.ToLower())
                    {
                        dataGridViewRezSearch.RowCount++;
                        dataGridViewRezSearch.Rows[k].Cells[0].Value = i.Name;
                        dataGridViewRezSearch.Rows[k].Cells[1].Value = i.Proizvoditel;
                        dataGridViewRezSearch.Rows[k].Cells[2].Value = i.Price;
                        dataGridViewRezSearch.Rows[k].Cells[3].Value = i.SerNom;
                        dataGridViewRezSearch.Rows[k].Cells[4].Value = i.Kolvo;
                        k++;
                        b = false;
                    }
                }
                
            }
            else MessageBox.Show("Не был выбран признак поиска");
            if (b == true) MessageBox.Show("Ничего не найдено");
            textBoxSearch.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1Add_Click(object sender, EventArgs e)
        {
            string Nadd = textBoxNameAdd.Text;
            string Pradd = textBoxProizAdd.Text;
            string PriceAdd = textBoxPriceAdd.Text;      
            string SerNadd = textBoxSerNmAdd.Text;
            string KolAdd = textBoxKolAdd.Text;
            if (Nadd == "" || Pradd == "" || PriceAdd == "" || SerNadd == "" || KolAdd == "") MessageBox.Show("Все поля должны быть заполнены");
            else
            {
                int PrAd;
                int KolAd;
                try
                {
                    PrAd = int.Parse(PriceAdd);
                    KolAd = int.Parse(KolAdd);

                    dataGridViewDanTable.RowCount++;
                    SportInvList.Add(new SportInv(Nadd, Pradd, PrAd, SerNadd, KolAd));
                    dataGridViewDanTable.Rows[sch].Cells[0].Value = Nadd;
                    dataGridViewDanTable.Rows[sch].Cells[1].Value = Pradd;
                    dataGridViewDanTable.Rows[sch].Cells[2].Value = PriceAdd;
                    dataGridViewDanTable.Rows[sch].Cells[3].Value = SerNadd;
                    dataGridViewDanTable.Rows[sch].Cells[4].Value = KolAdd;
                    sch++;
                }
                catch
                {
                    MessageBox.Show("Введены некорректные данные");
                }
            }
            textBoxNameAdd.Clear();
            textBoxProizAdd.Clear();
            textBoxPriceAdd.Clear();
            textBoxSerNmAdd.Clear();
            textBoxKolAdd.Clear();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {

                bool b = false;
                string sdel = textBoxDel.Text;
                int ind = 0;
                if (sdel != "")
                {
                    foreach (var i in SportInvList)
                    {
                        if (sdel == i.SerNom)
                        {
                            ind = SportInvList.IndexOf(i);
                            b = true;
                        }
                    }
                    if (b == true)
                    {
                        SportInvList.RemoveAt(ind);
                        dataGridViewDanTable.Rows.RemoveAt(ind);
                    }
                    else MessageBox.Show("Элемент не найден");
                }
                else MessageBox.Show("Введите серийный номер");
                textBoxDel.Clear();
                sch--;
            }
            catch
            {
                MessageBox.Show("Удаление невозможно. Данные отсутсвуют");
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            dataGridViewSort.RowCount = 1;
            dataGridViewSort.ColumnCount = 5;
            int z = 0;
            if (radioButtonSortPrice.Checked == true)
            {
                for (int i = 0; i < SportInvList.Count; i++)
                {
                    for (int j = i + 1; j < SportInvList.Count; j++)
                    {
                        if (SportInvList[i].Price > SportInvList[j].Price)
                        {
                            var temp = SportInvList[i];
                            SportInvList[i] = SportInvList[j];
                            SportInvList[j] = temp;
                        }
                    }
                }
                foreach (var i in SportInvList)
                {
                    dataGridViewSort.RowCount++;
                    dataGridViewSort.Rows[z].Cells[0].Value = i.Name;
                    dataGridViewSort.Rows[z].Cells[1].Value = i.Proizvoditel;
                    dataGridViewSort.Rows[z].Cells[2].Value = i.Price;
                    dataGridViewSort.Rows[z].Cells[3].Value = i.SerNom;
                    dataGridViewSort.Rows[z].Cells[4].Value = i.Kolvo;
                    z++;
                }
            }

            else if (radioButtonKol.Checked == true)
            {
                for (int i = 0; i < SportInvList.Count; i++)
                {
                    for (int j = i + 1; j < SportInvList.Count; j++)
                    {
                        if (SportInvList[i].Kolvo > SportInvList[j].Kolvo)
                        {
                            var temp = SportInvList[i];
                            SportInvList[i] = SportInvList[j];
                            SportInvList[j] = temp;
                        }
                    }
                }
                foreach (var i in SportInvList)
                {
                    dataGridViewSort.RowCount++;
                    dataGridViewSort.Rows[z].Cells[0].Value = i.Name;
                    dataGridViewSort.Rows[z].Cells[1].Value = i.Proizvoditel;
                    dataGridViewSort.Rows[z].Cells[2].Value = i.Price;
                    dataGridViewSort.Rows[z].Cells[3].Value = i.SerNom;
                    dataGridViewSort.Rows[z].Cells[4].Value = i.Kolvo;
                    z++;
                }
            }
            else MessageBox.Show("Не был выбран признак сортировки");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                using (StreamWriter sw = new StreamWriter(ofd.FileName))
                {
                    foreach (var i in SportInvList)
                    {
                        sw.WriteLine($"{i.Name};{i.Proizvoditel};{i.Price};{i.SerNom};{i.Kolvo}");
                    }
                }
                MessageBox.Show("Сохранение прошло успешно");
            }
            else MessageBox.Show("Вы не выбрали путь");
        }
    }
}