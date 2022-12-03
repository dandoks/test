
namespace uchpraktika
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMain5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDanTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonentPath = new System.Windows.Forms.Button();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.radioButtonProizvod = new System.Windows.Forms.RadioButton();
            this.radioButtonSerNom = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewRezSearch = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxKolAdd = new System.Windows.Forms.TextBox();
            this.textBoxProizAdd = new System.Windows.Forms.TextBox();
            this.textBoxSerNmAdd = new System.Windows.Forms.TextBox();
            this.textBoxPriceAdd = new System.Windows.Forms.TextBox();
            this.textBoxNameAdd = new System.Windows.Forms.TextBox();
            this.button1Add = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxDel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonSort = new System.Windows.Forms.Button();
            this.dataGridViewSort = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButtonKol = new System.Windows.Forms.RadioButton();
            this.radioButtonSortPrice = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezSearch)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSort)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMain5
            // 
            this.buttonMain5.Location = new System.Drawing.Point(1214, 600);
            this.buttonMain5.Name = "buttonMain5";
            this.buttonMain5.Size = new System.Drawing.Size(83, 32);
            this.buttonMain5.TabIndex = 0;
            this.buttonMain5.Text = "К главной";
            this.buttonMain5.UseVisualStyleBackColor = true;
            this.buttonMain5.Click += new System.EventHandler(this.buttonMain5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Справочник инвентаря спортивного зала";
            // 
            // dataGridViewDanTable
            // 
            this.dataGridViewDanTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewDanTable.Location = new System.Drawing.Point(23, 66);
            this.dataGridViewDanTable.Name = "dataGridViewDanTable";
            this.dataGridViewDanTable.Size = new System.Drawing.Size(543, 157);
            this.dataGridViewDanTable.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Наименование";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Производитель";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Цена";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Сер. Ном.";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Кол-во";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Данные:";
            // 
            // buttonentPath
            // 
            this.buttonentPath.Location = new System.Drawing.Point(28, 240);
            this.buttonentPath.Name = "buttonentPath";
            this.buttonentPath.Size = new System.Drawing.Size(75, 23);
            this.buttonentPath.TabIndex = 6;
            this.buttonentPath.Text = "Ввести";
            this.buttonentPath.UseVisualStyleBackColor = true;
            this.buttonentPath.Click += new System.EventHandler(this.buttonentPath_Click);
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Location = new System.Drawing.Point(27, 60);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(92, 17);
            this.radioButtonName.TabIndex = 7;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "По названию";
            this.radioButtonName.UseVisualStyleBackColor = true;
            // 
            // radioButtonProizvod
            // 
            this.radioButtonProizvod.AutoSize = true;
            this.radioButtonProizvod.Location = new System.Drawing.Point(27, 83);
            this.radioButtonProizvod.Name = "radioButtonProizvod";
            this.radioButtonProizvod.Size = new System.Drawing.Size(121, 17);
            this.radioButtonProizvod.TabIndex = 8;
            this.radioButtonProizvod.TabStop = true;
            this.radioButtonProizvod.Text = "По производителю";
            this.radioButtonProizvod.UseVisualStyleBackColor = true;
            // 
            // radioButtonSerNom
            // 
            this.radioButtonSerNom.AutoSize = true;
            this.radioButtonSerNom.Location = new System.Drawing.Point(27, 107);
            this.radioButtonSerNom.Name = "radioButtonSerNom";
            this.radioButtonSerNom.Size = new System.Drawing.Size(89, 17);
            this.radioButtonSerNom.TabIndex = 9;
            this.radioButtonSerNom.TabStop = true;
            this.radioButtonSerNom.Text = "По сер. ном.";
            this.radioButtonSerNom.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(23, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Поиск";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(171, 62);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(141, 20);
            this.textBoxSearch.TabIndex = 11;
            // 
            // dataGridViewRezSearch
            // 
            this.dataGridViewRezSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridViewRezSearch.Location = new System.Drawing.Point(27, 139);
            this.dataGridViewRezSearch.Name = "dataGridViewRezSearch";
            this.dataGridViewRezSearch.Size = new System.Drawing.Size(536, 139);
            this.dataGridViewRezSearch.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Производитель";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Сер. ном.";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "Кол-во";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(171, 101);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxKolAdd);
            this.panel1.Controls.Add(this.textBoxProizAdd);
            this.panel1.Controls.Add(this.textBoxSerNmAdd);
            this.panel1.Controls.Add(this.textBoxPriceAdd);
            this.panel1.Controls.Add(this.textBoxNameAdd);
            this.panel1.Controls.Add(this.button1Add);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(22, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 203);
            this.panel1.TabIndex = 14;
            // 
            // textBoxKolAdd
            // 
            this.textBoxKolAdd.Location = new System.Drawing.Point(82, 144);
            this.textBoxKolAdd.Name = "textBoxKolAdd";
            this.textBoxKolAdd.Size = new System.Drawing.Size(100, 20);
            this.textBoxKolAdd.TabIndex = 11;
            // 
            // textBoxProizAdd
            // 
            this.textBoxProizAdd.Location = new System.Drawing.Point(79, 61);
            this.textBoxProizAdd.Name = "textBoxProizAdd";
            this.textBoxProizAdd.Size = new System.Drawing.Size(100, 20);
            this.textBoxProizAdd.TabIndex = 10;
            // 
            // textBoxSerNmAdd
            // 
            this.textBoxSerNmAdd.Location = new System.Drawing.Point(86, 114);
            this.textBoxSerNmAdd.Name = "textBoxSerNmAdd";
            this.textBoxSerNmAdd.Size = new System.Drawing.Size(100, 20);
            this.textBoxSerNmAdd.TabIndex = 9;
            // 
            // textBoxPriceAdd
            // 
            this.textBoxPriceAdd.Location = new System.Drawing.Point(64, 87);
            this.textBoxPriceAdd.Name = "textBoxPriceAdd";
            this.textBoxPriceAdd.Size = new System.Drawing.Size(100, 20);
            this.textBoxPriceAdd.TabIndex = 8;
            // 
            // textBoxNameAdd
            // 
            this.textBoxNameAdd.Location = new System.Drawing.Point(70, 37);
            this.textBoxNameAdd.Name = "textBoxNameAdd";
            this.textBoxNameAdd.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameAdd.TabIndex = 7;
            // 
            // button1Add
            // 
            this.button1Add.Location = new System.Drawing.Point(212, 175);
            this.button1Add.Name = "button1Add";
            this.button1Add.Size = new System.Drawing.Size(75, 23);
            this.button1Add.TabIndex = 6;
            this.button1Add.Text = "Добавить";
            this.button1Add.UseVisualStyleBackColor = true;
            this.button1Add.Click += new System.EventHandler(this.button1Add_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Кол-во";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Сер. ном.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Цена";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Произв.";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Наим.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(24, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Добавление данных";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Controls.Add(this.radioButtonName);
            this.panel2.Controls.Add(this.buttonSearch);
            this.panel2.Controls.Add(this.radioButtonProizvod);
            this.panel2.Controls.Add(this.dataGridViewRezSearch);
            this.panel2.Controls.Add(this.radioButtonSerNom);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(395, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 296);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dataGridViewDanTable);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.buttonentPath);
            this.panel3.Location = new System.Drawing.Point(22, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(739, 307);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.buttonDelete);
            this.panel4.Controls.Add(this.textBoxDel);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(6, 562);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 70);
            this.panel4.TabIndex = 17;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(244, 34);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxDel
            // 
            this.textBoxDel.Location = new System.Drawing.Point(122, 37);
            this.textBoxDel.Name = "textBoxDel";
            this.textBoxDel.Size = new System.Drawing.Size(100, 20);
            this.textBoxDel.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Введите сер. ном.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label11.Location = new System.Drawing.Point(9, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "Удаление данных";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.buttonSort);
            this.panel5.Controls.Add(this.dataGridViewSort);
            this.panel5.Controls.Add(this.radioButtonKol);
            this.panel5.Controls.Add(this.radioButtonSortPrice);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(778, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(519, 303);
            this.panel5.TabIndex = 18;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(153, 59);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(83, 23);
            this.buttonSort.TabIndex = 4;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // dataGridViewSort
            // 
            this.dataGridViewSort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSort.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridViewSort.Location = new System.Drawing.Point(3, 88);
            this.dataGridViewSort.Name = "dataGridViewSort";
            this.dataGridViewSort.Size = new System.Drawing.Size(511, 150);
            this.dataGridViewSort.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.Frozen = true;
            this.dataGridViewTextBoxColumn7.HeaderText = "Производитель";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.Frozen = true;
            this.dataGridViewTextBoxColumn8.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.Frozen = true;
            this.dataGridViewTextBoxColumn9.HeaderText = "Сер. ном.";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.Frozen = true;
            this.dataGridViewTextBoxColumn10.HeaderText = "Кол-во";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // radioButtonKol
            // 
            this.radioButtonKol.AutoSize = true;
            this.radioButtonKol.Location = new System.Drawing.Point(18, 65);
            this.radioButtonKol.Name = "radioButtonKol";
            this.radioButtonKol.Size = new System.Drawing.Size(99, 17);
            this.radioButtonKol.TabIndex = 2;
            this.radioButtonKol.TabStop = true;
            this.radioButtonKol.Text = "По количеству";
            this.radioButtonKol.UseVisualStyleBackColor = true;
            // 
            // radioButtonSortPrice
            // 
            this.radioButtonSortPrice.AutoSize = true;
            this.radioButtonSortPrice.Location = new System.Drawing.Point(18, 42);
            this.radioButtonSortPrice.Name = "radioButtonSortPrice";
            this.radioButtonSortPrice.Size = new System.Drawing.Size(66, 17);
            this.radioButtonSortPrice.TabIndex = 1;
            this.radioButtonSortPrice.TabStop = true;
            this.radioButtonSortPrice.Text = "По цене";
            this.radioButtonSortPrice.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label13.Location = new System.Drawing.Point(14, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "Сортировка";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Location = new System.Drawing.Point(1004, 335);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 100);
            this.panel6.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Сохранение в файл";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 644);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonMain5);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSort)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMain5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDanTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonentPath;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.RadioButton radioButtonProizvod;
        private System.Windows.Forms.RadioButton radioButtonSerNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewRezSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxKolAdd;
        private System.Windows.Forms.TextBox textBoxProizAdd;
        private System.Windows.Forms.TextBox textBoxSerNmAdd;
        private System.Windows.Forms.TextBox textBoxPriceAdd;
        private System.Windows.Forms.TextBox textBoxNameAdd;
        private System.Windows.Forms.Button button1Add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxDel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioButtonKol;
        private System.Windows.Forms.RadioButton radioButtonSortPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.DataGridView dataGridViewSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
    }
}