namespace AutoShop
{
    partial class Extra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extra));
            this.lab_hello = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.but_profit = new System.Windows.Forms.Button();
            this.but_income_expense = new System.Windows.Forms.Button();
            this.but_middle_count = new System.Windows.Forms.Button();
            this.but_products_date = new System.Windows.Forms.Button();
            this.tb_products_prod1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_products_prod2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_income_exp_date2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_income_exp_date1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.but_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_hello
            // 
            this.lab_hello.AutoSize = true;
            this.lab_hello.BackColor = System.Drawing.Color.Transparent;
            this.lab_hello.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_hello.Location = new System.Drawing.Point(12, 24);
            this.lab_hello.Name = "lab_hello";
            this.lab_hello.Size = new System.Drawing.Size(461, 123);
            this.lab_hello.TabIndex = 3;
            this.lab_hello.Text = "Запросить даты продаж, \r\nв которых два заданных товара \r\nпродавались одновременно" +
    ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 82);
            this.label1.TabIndex = 4;
            this.label1.Text = "Запросить среднюю стоимость\r\nпродаж за все время.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 82);
            this.label2.TabIndex = 5;
            this.label2.Text = "Запросить общую сумму дохода\r\n и расхода за заданный период.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(496, 82);
            this.label3.TabIndex = 6;
            this.label3.Text = "Запросить сумму предполагаемой \r\nприбыли на ближайший месяц.";
            // 
            // but_profit
            // 
            this.but_profit.BackColor = System.Drawing.Color.Pink;
            this.but_profit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_profit.BackgroundImage")));
            this.but_profit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_profit.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_profit.Location = new System.Drawing.Point(892, 421);
            this.but_profit.Name = "but_profit";
            this.but_profit.Size = new System.Drawing.Size(184, 47);
            this.but_profit.TabIndex = 14;
            this.but_profit.Text = "Запрос";
            this.but_profit.UseVisualStyleBackColor = false;
            this.but_profit.Click += new System.EventHandler(this.but_profit_Click);
            // 
            // but_income_expense
            // 
            this.but_income_expense.BackColor = System.Drawing.Color.Pink;
            this.but_income_expense.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_income_expense.BackgroundImage")));
            this.but_income_expense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_income_expense.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_income_expense.Location = new System.Drawing.Point(892, 302);
            this.but_income_expense.Name = "but_income_expense";
            this.but_income_expense.Size = new System.Drawing.Size(184, 47);
            this.but_income_expense.TabIndex = 15;
            this.but_income_expense.Text = "Запрос";
            this.but_income_expense.UseVisualStyleBackColor = false;
            this.but_income_expense.Click += new System.EventHandler(this.but_income_expense_Click);
            // 
            // but_middle_count
            // 
            this.but_middle_count.BackColor = System.Drawing.Color.Pink;
            this.but_middle_count.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_middle_count.BackgroundImage")));
            this.but_middle_count.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_middle_count.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_middle_count.Location = new System.Drawing.Point(892, 182);
            this.but_middle_count.Name = "but_middle_count";
            this.but_middle_count.Size = new System.Drawing.Size(184, 47);
            this.but_middle_count.TabIndex = 16;
            this.but_middle_count.Text = "Запрос";
            this.but_middle_count.UseVisualStyleBackColor = false;
            this.but_middle_count.Click += new System.EventHandler(this.but_middle_count_Click);
            // 
            // but_products_date
            // 
            this.but_products_date.BackColor = System.Drawing.Color.Pink;
            this.but_products_date.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_products_date.BackgroundImage")));
            this.but_products_date.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_products_date.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_products_date.Location = new System.Drawing.Point(892, 59);
            this.but_products_date.Name = "but_products_date";
            this.but_products_date.Size = new System.Drawing.Size(184, 47);
            this.but_products_date.TabIndex = 17;
            this.but_products_date.Text = "Запрос";
            this.but_products_date.UseVisualStyleBackColor = false;
            this.but_products_date.Click += new System.EventHandler(this.but_products_date_Click);
            // 
            // tb_products_prod1
            // 
            this.tb_products_prod1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_products_prod1.Location = new System.Drawing.Point(634, 12);
            this.tb_products_prod1.Name = "tb_products_prod1";
            this.tb_products_prod1.Size = new System.Drawing.Size(198, 41);
            this.tb_products_prod1.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(511, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 37);
            this.label4.TabIndex = 18;
            this.label4.Text = "товар 1:";
            // 
            // tb_products_prod2
            // 
            this.tb_products_prod2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_products_prod2.Location = new System.Drawing.Point(634, 79);
            this.tb_products_prod2.Name = "tb_products_prod2";
            this.tb_products_prod2.Size = new System.Drawing.Size(198, 41);
            this.tb_products_prod2.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(511, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 37);
            this.label5.TabIndex = 20;
            this.label5.Text = "товар 2:";
            // 
            // tb_income_exp_date2
            // 
            this.tb_income_exp_date2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_income_exp_date2.Location = new System.Drawing.Point(634, 340);
            this.tb_income_exp_date2.Name = "tb_income_exp_date2";
            this.tb_income_exp_date2.Size = new System.Drawing.Size(198, 41);
            this.tb_income_exp_date2.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(528, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 37);
            this.label6.TabIndex = 24;
            this.label6.Text = "дата 2:";
            // 
            // tb_income_exp_date1
            // 
            this.tb_income_exp_date1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_income_exp_date1.Location = new System.Drawing.Point(634, 273);
            this.tb_income_exp_date1.Name = "tb_income_exp_date1";
            this.tb_income_exp_date1.Size = new System.Drawing.Size(198, 41);
            this.tb_income_exp_date1.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(528, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 37);
            this.label7.TabIndex = 22;
            this.label7.Text = "дата 1:";
            // 
            // but_back
            // 
            this.but_back.BackColor = System.Drawing.Color.Pink;
            this.but_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_back.BackgroundImage")));
            this.but_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_back.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_back.Location = new System.Drawing.Point(892, 538);
            this.but_back.Name = "but_back";
            this.but_back.Size = new System.Drawing.Size(184, 47);
            this.but_back.TabIndex = 26;
            this.but_back.Text = "Назад";
            this.but_back.UseVisualStyleBackColor = false;
            this.but_back.Click += new System.EventHandler(this.but_back_Click);
            // 
            // Extra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 607);
            this.Controls.Add(this.but_back);
            this.Controls.Add(this.tb_income_exp_date2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_income_exp_date1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_products_prod2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_products_prod1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.but_products_date);
            this.Controls.Add(this.but_middle_count);
            this.Controls.Add(this.but_income_expense);
            this.Controls.Add(this.but_profit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_hello);
            this.Name = "Extra";
            this.Text = "Extra";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Extra_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_hello;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_profit;
        private System.Windows.Forms.Button but_income_expense;
        private System.Windows.Forms.Button but_middle_count;
        private System.Windows.Forms.Button but_products_date;
        private System.Windows.Forms.TextBox tb_products_prod1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_products_prod2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_income_exp_date2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_income_exp_date1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button but_back;
    }
}