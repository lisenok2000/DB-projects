namespace AutoShop
{
    partial class Assistance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assistance));
            this.lab_hello = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.but_show_warehouses = new System.Windows.Forms.Button();
            this.but_exp = new System.Windows.Forms.Button();
            this.but_sales = new System.Windows.Forms.Button();
            this.but_charges = new System.Windows.Forms.Button();
            this.but_edit_war = new System.Windows.Forms.Button();
            this.but_edit_exp = new System.Windows.Forms.Button();
            this.but_edit_sales = new System.Windows.Forms.Button();
            this.but_edit_charges = new System.Windows.Forms.Button();
            this.but_assist_back = new System.Windows.Forms.Button();
            this.but_extra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_hello
            // 
            this.lab_hello.AutoSize = true;
            this.lab_hello.BackColor = System.Drawing.Color.Transparent;
            this.lab_hello.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_hello.Location = new System.Drawing.Point(12, 20);
            this.lab_hello.Name = "lab_hello";
            this.lab_hello.Size = new System.Drawing.Size(576, 49);
            this.lab_hello.TabIndex = 2;
            this.lab_hello.Text = "Доброго времени суток, оператор.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "Чем вам помочь?";
            // 
            // but_show_warehouses
            // 
            this.but_show_warehouses.BackColor = System.Drawing.Color.Pink;
            this.but_show_warehouses.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_show_warehouses.BackgroundImage")));
            this.but_show_warehouses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_show_warehouses.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_show_warehouses.Location = new System.Drawing.Point(25, 164);
            this.but_show_warehouses.Name = "but_show_warehouses";
            this.but_show_warehouses.Size = new System.Drawing.Size(242, 120);
            this.but_show_warehouses.TabIndex = 7;
            this.but_show_warehouses.Text = "Посмотреть склад";
            this.but_show_warehouses.UseVisualStyleBackColor = false;
            this.but_show_warehouses.Click += new System.EventHandler(this.but_show_warehouses_Click);
            // 
            // but_exp
            // 
            this.but_exp.BackColor = System.Drawing.Color.Pink;
            this.but_exp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_exp.BackgroundImage")));
            this.but_exp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_exp.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_exp.Location = new System.Drawing.Point(297, 164);
            this.but_exp.Name = "but_exp";
            this.but_exp.Size = new System.Drawing.Size(242, 120);
            this.but_exp.TabIndex = 8;
            this.but_exp.Text = "Посмотреть\r\nстатьи\r\nрасходов";
            this.but_exp.UseVisualStyleBackColor = false;
            this.but_exp.Click += new System.EventHandler(this.but_exp_Click);
            // 
            // but_sales
            // 
            this.but_sales.BackColor = System.Drawing.Color.Pink;
            this.but_sales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_sales.BackgroundImage")));
            this.but_sales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_sales.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_sales.Location = new System.Drawing.Point(565, 164);
            this.but_sales.Name = "but_sales";
            this.but_sales.Size = new System.Drawing.Size(242, 120);
            this.but_sales.TabIndex = 9;
            this.but_sales.Text = "Посмотреть\r\nжурнал\r\nпродаж";
            this.but_sales.UseVisualStyleBackColor = false;
            this.but_sales.Click += new System.EventHandler(this.but_sales_Click);
            // 
            // but_charges
            // 
            this.but_charges.BackColor = System.Drawing.Color.Pink;
            this.but_charges.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_charges.BackgroundImage")));
            this.but_charges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_charges.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_charges.Location = new System.Drawing.Point(832, 164);
            this.but_charges.Name = "but_charges";
            this.but_charges.Size = new System.Drawing.Size(242, 120);
            this.but_charges.TabIndex = 10;
            this.but_charges.Text = "Посмотреть\r\nжурнал\r\nрасходов";
            this.but_charges.UseVisualStyleBackColor = false;
            this.but_charges.Click += new System.EventHandler(this.but_charges_Click);
            // 
            // but_edit_war
            // 
            this.but_edit_war.BackColor = System.Drawing.Color.Pink;
            this.but_edit_war.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_edit_war.BackgroundImage")));
            this.but_edit_war.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_edit_war.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_edit_war.Location = new System.Drawing.Point(25, 317);
            this.but_edit_war.Name = "but_edit_war";
            this.but_edit_war.Size = new System.Drawing.Size(242, 120);
            this.but_edit_war.TabIndex = 11;
            this.but_edit_war.Text = "Редактировать склад";
            this.but_edit_war.UseVisualStyleBackColor = false;
            this.but_edit_war.Click += new System.EventHandler(this.but_edit_war_Click);
            // 
            // but_edit_exp
            // 
            this.but_edit_exp.BackColor = System.Drawing.Color.Pink;
            this.but_edit_exp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_edit_exp.BackgroundImage")));
            this.but_edit_exp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_edit_exp.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_edit_exp.Location = new System.Drawing.Point(297, 317);
            this.but_edit_exp.Name = "but_edit_exp";
            this.but_edit_exp.Size = new System.Drawing.Size(242, 120);
            this.but_edit_exp.TabIndex = 12;
            this.but_edit_exp.Text = "Редактировать\r\nстатьи\r\nрасходов";
            this.but_edit_exp.UseVisualStyleBackColor = false;
            this.but_edit_exp.Click += new System.EventHandler(this.but_edit_exp_Click);
            // 
            // but_edit_sales
            // 
            this.but_edit_sales.BackColor = System.Drawing.Color.Pink;
            this.but_edit_sales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_edit_sales.BackgroundImage")));
            this.but_edit_sales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_edit_sales.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_edit_sales.Location = new System.Drawing.Point(565, 317);
            this.but_edit_sales.Name = "but_edit_sales";
            this.but_edit_sales.Size = new System.Drawing.Size(242, 120);
            this.but_edit_sales.TabIndex = 13;
            this.but_edit_sales.Text = "Редактировать\r\nжурнал\r\nпродаж";
            this.but_edit_sales.UseVisualStyleBackColor = false;
            this.but_edit_sales.Click += new System.EventHandler(this.but_edit_sales_Click);
            // 
            // but_edit_charges
            // 
            this.but_edit_charges.BackColor = System.Drawing.Color.Pink;
            this.but_edit_charges.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_edit_charges.BackgroundImage")));
            this.but_edit_charges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_edit_charges.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_edit_charges.Location = new System.Drawing.Point(832, 317);
            this.but_edit_charges.Name = "but_edit_charges";
            this.but_edit_charges.Size = new System.Drawing.Size(242, 120);
            this.but_edit_charges.TabIndex = 14;
            this.but_edit_charges.Text = "Редактировать\r\nжурнал\r\nрасходов";
            this.but_edit_charges.UseVisualStyleBackColor = false;
            this.but_edit_charges.Click += new System.EventHandler(this.but_edit_charges_Click);
            // 
            // but_assist_back
            // 
            this.but_assist_back.BackColor = System.Drawing.Color.Pink;
            this.but_assist_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_assist_back.BackgroundImage")));
            this.but_assist_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_assist_back.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_assist_back.Location = new System.Drawing.Point(890, 24);
            this.but_assist_back.Name = "but_assist_back";
            this.but_assist_back.Size = new System.Drawing.Size(184, 47);
            this.but_assist_back.TabIndex = 15;
            this.but_assist_back.Text = "Назад";
            this.but_assist_back.UseVisualStyleBackColor = false;
            this.but_assist_back.Click += new System.EventHandler(this.but_assist_back_Click);
            // 
            // but_extra
            // 
            this.but_extra.BackColor = System.Drawing.Color.Pink;
            this.but_extra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_extra.BackgroundImage")));
            this.but_extra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_extra.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_extra.Location = new System.Drawing.Point(430, 458);
            this.but_extra.Name = "but_extra";
            this.but_extra.Size = new System.Drawing.Size(260, 120);
            this.but_extra.TabIndex = 16;
            this.but_extra.Text = "Дополнительные\r\nфункции";
            this.but_extra.UseVisualStyleBackColor = false;
            this.but_extra.Click += new System.EventHandler(this.but_extra_Click);
            // 
            // Assistance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 590);
            this.Controls.Add(this.but_extra);
            this.Controls.Add(this.but_assist_back);
            this.Controls.Add(this.but_edit_charges);
            this.Controls.Add(this.but_edit_sales);
            this.Controls.Add(this.but_edit_exp);
            this.Controls.Add(this.but_edit_war);
            this.Controls.Add(this.but_charges);
            this.Controls.Add(this.but_sales);
            this.Controls.Add(this.but_exp);
            this.Controls.Add(this.but_show_warehouses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_hello);
            this.Name = "Assistance";
            this.Text = "Assistance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Assistance_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_hello;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_show_warehouses;
        private System.Windows.Forms.Button but_exp;
        private System.Windows.Forms.Button but_sales;
        private System.Windows.Forms.Button but_charges;
        private System.Windows.Forms.Button but_edit_war;
        private System.Windows.Forms.Button but_edit_exp;
        private System.Windows.Forms.Button but_edit_sales;
        private System.Windows.Forms.Button but_edit_charges;
        private System.Windows.Forms.Button but_assist_back;
        private System.Windows.Forms.Button but_extra;
    }
}