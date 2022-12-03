
namespace uchpraktika
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1Day = new System.Windows.Forms.Button();
            this.button2Day = new System.Windows.Forms.Button();
            this.button3Day = new System.Windows.Forms.Button();
            this.button4Day = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(313, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Учебная практика";
            // 
            // button1Day
            // 
            this.button1Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1Day.Location = new System.Drawing.Point(336, 76);
            this.button1Day.Name = "button1Day";
            this.button1Day.Size = new System.Drawing.Size(104, 43);
            this.button1Day.TabIndex = 1;
            this.button1Day.Text = "1 день";
            this.button1Day.UseVisualStyleBackColor = true;
            this.button1Day.Click += new System.EventHandler(this.button1Day_Click);
            // 
            // button2Day
            // 
            this.button2Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2Day.Location = new System.Drawing.Point(336, 126);
            this.button2Day.Name = "button2Day";
            this.button2Day.Size = new System.Drawing.Size(104, 42);
            this.button2Day.TabIndex = 2;
            this.button2Day.Text = "2 день";
            this.button2Day.UseVisualStyleBackColor = true;
            this.button2Day.Click += new System.EventHandler(this.button2Day_Click);
            // 
            // button3Day
            // 
            this.button3Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3Day.Location = new System.Drawing.Point(336, 174);
            this.button3Day.Name = "button3Day";
            this.button3Day.Size = new System.Drawing.Size(104, 42);
            this.button3Day.TabIndex = 3;
            this.button3Day.Text = "3 день";
            this.button3Day.UseVisualStyleBackColor = true;
            this.button3Day.Click += new System.EventHandler(this.button3Day_Click);
            // 
            // button4Day
            // 
            this.button4Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4Day.Location = new System.Drawing.Point(336, 222);
            this.button4Day.Name = "button4Day";
            this.button4Day.Size = new System.Drawing.Size(104, 42);
            this.button4Day.TabIndex = 4;
            this.button4Day.Text = "4 день";
            this.button4Day.UseVisualStyleBackColor = true;
            this.button4Day.Click += new System.EventHandler(this.button4Day_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4Day);
            this.Controls.Add(this.button3Day);
            this.Controls.Add(this.button2Day);
            this.Controls.Add(this.button1Day);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1Day;
        private System.Windows.Forms.Button button2Day;
        private System.Windows.Forms.Button button3Day;
        private System.Windows.Forms.Button button4Day;
    }
}

