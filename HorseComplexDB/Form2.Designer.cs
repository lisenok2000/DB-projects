namespace Client
{
    partial class Form2
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
            this.ComplexDB = new System.Data.OleDb.OleDbConnection();
            this.TablesBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.FindBut = new System.Windows.Forms.Button();
            this.SelectBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComplexDB
            // 
            this.ComplexDB.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-3TJHR5I\\SQLEXPRESS;Password=admin;User ID=" +
    "admin;Initial Catalog=HorseComplex";
            // 
            // TablesBox
            // 
            this.TablesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TablesBox.FormattingEnabled = true;
            this.TablesBox.Items.AddRange(new object[] {
            "Владельцы",
            "Закрепление лошадей",
            "Закрепление стойл",
            "Конюхи",
            "Лошади",
            "Резерв площадок",
            "Сломанное снаряжение",
            "Стойла",
            "Тренеры",
            "Тренировки",
            "Экипировка"});
            this.TablesBox.Location = new System.Drawing.Point(12, 144);
            this.TablesBox.Name = "TablesBox";
            this.TablesBox.Size = new System.Drawing.Size(310, 33);
            this.TablesBox.Sorted = true;
            this.TablesBox.TabIndex = 0;
            this.TablesBox.SelectedIndexChanged += new System.EventHandler(this.TablesBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Что вы хотите сделать?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите таблицу:";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(12, 202);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(214, 48);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить строку";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(12, 272);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(214, 48);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Удалить строку";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.Location = new System.Drawing.Point(12, 340);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(214, 48);
            this.changeButton.TabIndex = 6;
            this.changeButton.Text = "Изменить строку";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // FindBut
            // 
            this.FindBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindBut.Location = new System.Drawing.Point(12, 410);
            this.FindBut.Name = "FindBut";
            this.FindBut.Size = new System.Drawing.Size(214, 48);
            this.FindBut.TabIndex = 8;
            this.FindBut.Text = "Поиск";
            this.FindBut.UseVisualStyleBackColor = true;
            this.FindBut.Click += new System.EventHandler(this.FindBut_Click);
            // 
            // SelectBut
            // 
            this.SelectBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectBut.Location = new System.Drawing.Point(12, 479);
            this.SelectBut.Name = "SelectBut";
            this.SelectBut.Size = new System.Drawing.Size(214, 48);
            this.SelectBut.TabIndex = 10;
            this.SelectBut.Text = "Проверка";
            this.SelectBut.UseVisualStyleBackColor = true;
            this.SelectBut.Click += new System.EventHandler(this.SelectBut_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.SelectBut);
            this.Controls.Add(this.FindBut);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TablesBox);
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1500, 1000);
            this.MinimumSize = new System.Drawing.Size(1500, 1000);
            this.Name = "Form2";
            this.Text = "Обзор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.OleDb.OleDbConnection ComplexDB;
        private System.Windows.Forms.ComboBox TablesBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button FindBut;
        private System.Windows.Forms.Button SelectBut;
    }
}