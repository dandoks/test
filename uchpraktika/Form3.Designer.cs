
namespace uchpraktika
{
    partial class Form3
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
            System.Windows.Forms.Label label1;
            this.buttonMain2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDanMas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewDanMas = new System.Windows.Forms.DataGridView();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.dataGridViewRez = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanMas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRez)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            label1.Location = new System.Drawing.Point(34, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(539, 22);
            label1.TabIndex = 1;
            label1.Text = "Определение индексов противоположных элементов массива";
            // 
            // buttonMain2
            // 
            this.buttonMain2.Location = new System.Drawing.Point(706, 404);
            this.buttonMain2.Name = "buttonMain2";
            this.buttonMain2.Size = new System.Drawing.Size(82, 34);
            this.buttonMain2.TabIndex = 0;
            this.buttonMain2.Text = "К главной";
            this.buttonMain2.UseVisualStyleBackColor = true;
            this.buttonMain2.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите массив:";
            // 
            // textBoxDanMas
            // 
            this.textBoxDanMas.Location = new System.Drawing.Point(38, 82);
            this.textBoxDanMas.Name = "textBoxDanMas";
            this.textBoxDanMas.Size = new System.Drawing.Size(535, 20);
            this.textBoxDanMas.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Исходный массив:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Результат:";
            // 
            // dataGridViewDanMas
            // 
            this.dataGridViewDanMas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanMas.Location = new System.Drawing.Point(38, 167);
            this.dataGridViewDanMas.Name = "dataGridViewDanMas";
            this.dataGridViewDanMas.Size = new System.Drawing.Size(535, 59);
            this.dataGridViewDanMas.TabIndex = 6;
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(41, 108);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 8;
            this.buttonExecute.Text = "Выполнить";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // dataGridViewRez
            // 
            this.dataGridViewRez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRez.Location = new System.Drawing.Point(38, 283);
            this.dataGridViewRez.Name = "dataGridViewRez";
            this.dataGridViewRez.Size = new System.Drawing.Size(532, 62);
            this.dataGridViewRez.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewRez);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.dataGridViewDanMas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDanMas);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.buttonMain2);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanMas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRez)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMain2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDanMas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewDanMas;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.DataGridView dataGridViewRez;
    }
}