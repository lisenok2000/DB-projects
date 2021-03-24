namespace AutoShop
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.tc_insert = new System.Windows.Forms.TabControl();
            this.War = new System.Windows.Forms.TabPage();
            this.but_war_back = new System.Windows.Forms.Button();
            this.but_war_enter = new System.Windows.Forms.Button();
            this.tb_war_amount = new System.Windows.Forms.TextBox();
            this.tb_war_quant = new System.Windows.Forms.TextBox();
            this.tb_war_name = new System.Windows.Forms.TextBox();
            this.tb_war_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sales = new System.Windows.Forms.TabPage();
            this.tb_sales_warid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.but_sales_back = new System.Windows.Forms.Button();
            this.but_sales_enter = new System.Windows.Forms.Button();
            this.tb_sales_amount = new System.Windows.Forms.TextBox();
            this.tb_sales_quant = new System.Windows.Forms.TextBox();
            this.tb_sales_date = new System.Windows.Forms.TextBox();
            this.tb_sales_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.exp = new System.Windows.Forms.TabPage();
            this.but_expitems_back = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.but_expitems_enter = new System.Windows.Forms.Button();
            this.tb_expitems_id = new System.Windows.Forms.TextBox();
            this.tb_expitems_name = new System.Windows.Forms.TextBox();
            this.charges = new System.Windows.Forms.TabPage();
            this.but_charges_back = new System.Windows.Forms.Button();
            this.but_charges_enter = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_charges_amount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_charges_chargedate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_charges_expitid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_charges_id = new System.Windows.Forms.TextBox();
            this.tc_insert.SuspendLayout();
            this.War.SuspendLayout();
            this.sales.SuspendLayout();
            this.exp.SuspendLayout();
            this.charges.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_insert
            // 
            this.tc_insert.Controls.Add(this.War);
            this.tc_insert.Controls.Add(this.sales);
            this.tc_insert.Controls.Add(this.exp);
            this.tc_insert.Controls.Add(this.charges);
            this.tc_insert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_insert.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tc_insert.Location = new System.Drawing.Point(0, 0);
            this.tc_insert.Name = "tc_insert";
            this.tc_insert.SelectedIndex = 0;
            this.tc_insert.Size = new System.Drawing.Size(800, 450);
            this.tc_insert.TabIndex = 1;
            this.tc_insert.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tc_insert_Selecting);
            // 
            // War
            // 
            this.War.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("War.BackgroundImage")));
            this.War.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.War.Controls.Add(this.but_war_back);
            this.War.Controls.Add(this.but_war_enter);
            this.War.Controls.Add(this.tb_war_amount);
            this.War.Controls.Add(this.tb_war_quant);
            this.War.Controls.Add(this.tb_war_name);
            this.War.Controls.Add(this.tb_war_id);
            this.War.Controls.Add(this.label4);
            this.War.Controls.Add(this.label3);
            this.War.Controls.Add(this.label2);
            this.War.Controls.Add(this.label1);
            this.War.Location = new System.Drawing.Point(4, 29);
            this.War.Name = "War";
            this.War.Padding = new System.Windows.Forms.Padding(3);
            this.War.Size = new System.Drawing.Size(792, 417);
            this.War.TabIndex = 0;
            this.War.Text = "Warehouses";
            this.War.UseVisualStyleBackColor = true;
            // 
            // but_war_back
            // 
            this.but_war_back.BackColor = System.Drawing.Color.Pink;
            this.but_war_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_war_back.BackgroundImage")));
            this.but_war_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_war_back.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_war_back.Location = new System.Drawing.Point(584, 332);
            this.but_war_back.Name = "but_war_back";
            this.but_war_back.Size = new System.Drawing.Size(184, 47);
            this.but_war_back.TabIndex = 14;
            this.but_war_back.Text = "Назад";
            this.but_war_back.UseVisualStyleBackColor = false;
            this.but_war_back.Click += new System.EventHandler(this.but_war_back_Click);
            // 
            // but_war_enter
            // 
            this.but_war_enter.BackColor = System.Drawing.Color.Pink;
            this.but_war_enter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_war_enter.BackgroundImage")));
            this.but_war_enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_war_enter.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_war_enter.Location = new System.Drawing.Point(32, 332);
            this.but_war_enter.Name = "but_war_enter";
            this.but_war_enter.Size = new System.Drawing.Size(184, 47);
            this.but_war_enter.TabIndex = 13;
            this.but_war_enter.Text = "Ввод";
            this.but_war_enter.UseVisualStyleBackColor = false;
            this.but_war_enter.Click += new System.EventHandler(this.but_war_enter_Click);
            // 
            // tb_war_amount
            // 
            this.tb_war_amount.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_war_amount.Location = new System.Drawing.Point(335, 270);
            this.tb_war_amount.Name = "tb_war_amount";
            this.tb_war_amount.Size = new System.Drawing.Size(198, 41);
            this.tb_war_amount.TabIndex = 7;
            // 
            // tb_war_quant
            // 
            this.tb_war_quant.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_war_quant.Location = new System.Drawing.Point(335, 189);
            this.tb_war_quant.Name = "tb_war_quant";
            this.tb_war_quant.Size = new System.Drawing.Size(198, 41);
            this.tb_war_quant.TabIndex = 6;
            // 
            // tb_war_name
            // 
            this.tb_war_name.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_war_name.Location = new System.Drawing.Point(335, 112);
            this.tb_war_name.Name = "tb_war_name";
            this.tb_war_name.Size = new System.Drawing.Size(198, 41);
            this.tb_war_name.TabIndex = 5;
            // 
            // tb_war_id
            // 
            this.tb_war_id.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_war_id.Location = new System.Drawing.Point(335, 34);
            this.tb_war_id.Name = "tb_war_id";
            this.tb_war_id.Size = new System.Drawing.Size(198, 41);
            this.tb_war_id.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(187, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(198, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(223, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(263, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "id:";
            // 
            // sales
            // 
            this.sales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sales.BackgroundImage")));
            this.sales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sales.Controls.Add(this.tb_sales_warid);
            this.sales.Controls.Add(this.label9);
            this.sales.Controls.Add(this.but_sales_back);
            this.sales.Controls.Add(this.but_sales_enter);
            this.sales.Controls.Add(this.tb_sales_amount);
            this.sales.Controls.Add(this.tb_sales_quant);
            this.sales.Controls.Add(this.tb_sales_date);
            this.sales.Controls.Add(this.tb_sales_id);
            this.sales.Controls.Add(this.label5);
            this.sales.Controls.Add(this.label6);
            this.sales.Controls.Add(this.label7);
            this.sales.Controls.Add(this.label8);
            this.sales.Location = new System.Drawing.Point(4, 29);
            this.sales.Name = "sales";
            this.sales.Padding = new System.Windows.Forms.Padding(3);
            this.sales.Size = new System.Drawing.Size(792, 417);
            this.sales.TabIndex = 1;
            this.sales.Text = "Sales";
            this.sales.UseVisualStyleBackColor = true;
            // 
            // tb_sales_warid
            // 
            this.tb_sales_warid.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_sales_warid.Location = new System.Drawing.Point(568, 225);
            this.tb_sales_warid.Name = "tb_sales_warid";
            this.tb_sales_warid.Size = new System.Drawing.Size(198, 41);
            this.tb_sales_warid.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(366, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 37);
            this.label9.TabIndex = 25;
            this.label9.Text = "warehouse id:";
            // 
            // but_sales_back
            // 
            this.but_sales_back.BackColor = System.Drawing.Color.Pink;
            this.but_sales_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_sales_back.BackgroundImage")));
            this.but_sales_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_sales_back.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_sales_back.Location = new System.Drawing.Point(582, 334);
            this.but_sales_back.Name = "but_sales_back";
            this.but_sales_back.Size = new System.Drawing.Size(184, 47);
            this.but_sales_back.TabIndex = 24;
            this.but_sales_back.Text = "Назад";
            this.but_sales_back.UseVisualStyleBackColor = false;
            this.but_sales_back.Click += new System.EventHandler(this.but_sales_back_Click);
            // 
            // but_sales_enter
            // 
            this.but_sales_enter.BackColor = System.Drawing.Color.Pink;
            this.but_sales_enter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_sales_enter.BackgroundImage")));
            this.but_sales_enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_sales_enter.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_sales_enter.Location = new System.Drawing.Point(29, 334);
            this.but_sales_enter.Name = "but_sales_enter";
            this.but_sales_enter.Size = new System.Drawing.Size(184, 47);
            this.but_sales_enter.TabIndex = 23;
            this.but_sales_enter.Text = "Ввод";
            this.but_sales_enter.UseVisualStyleBackColor = false;
            this.but_sales_enter.Click += new System.EventHandler(this.but_sales_enter_Click);
            // 
            // tb_sales_amount
            // 
            this.tb_sales_amount.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_sales_amount.Location = new System.Drawing.Point(150, 225);
            this.tb_sales_amount.Name = "tb_sales_amount";
            this.tb_sales_amount.Size = new System.Drawing.Size(198, 41);
            this.tb_sales_amount.TabIndex = 22;
            // 
            // tb_sales_quant
            // 
            this.tb_sales_quant.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_sales_quant.Location = new System.Drawing.Point(150, 144);
            this.tb_sales_quant.Name = "tb_sales_quant";
            this.tb_sales_quant.Size = new System.Drawing.Size(198, 41);
            this.tb_sales_quant.TabIndex = 21;
            // 
            // tb_sales_date
            // 
            this.tb_sales_date.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_sales_date.Location = new System.Drawing.Point(568, 144);
            this.tb_sales_date.Name = "tb_sales_date";
            this.tb_sales_date.Size = new System.Drawing.Size(198, 41);
            this.tb_sales_date.TabIndex = 20;
            // 
            // tb_sales_id
            // 
            this.tb_sales_id.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_sales_id.Location = new System.Drawing.Point(328, 34);
            this.tb_sales_id.Name = "tb_sales_id";
            this.tb_sales_id.Size = new System.Drawing.Size(198, 41);
            this.tb_sales_id.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(2, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 37);
            this.label5.TabIndex = 18;
            this.label5.Text = "quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 37);
            this.label6.TabIndex = 17;
            this.label6.Text = "amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(419, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 37);
            this.label7.TabIndex = 16;
            this.label7.Text = "sale date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(256, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 37);
            this.label8.TabIndex = 15;
            this.label8.Text = "id:";
            // 
            // exp
            // 
            this.exp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exp.BackgroundImage")));
            this.exp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exp.Controls.Add(this.but_expitems_back);
            this.exp.Controls.Add(this.label14);
            this.exp.Controls.Add(this.label13);
            this.exp.Controls.Add(this.but_expitems_enter);
            this.exp.Controls.Add(this.tb_expitems_id);
            this.exp.Controls.Add(this.tb_expitems_name);
            this.exp.Location = new System.Drawing.Point(4, 29);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(792, 417);
            this.exp.TabIndex = 2;
            this.exp.Text = "Expense_items";
            this.exp.UseVisualStyleBackColor = true;
            // 
            // but_expitems_back
            // 
            this.but_expitems_back.BackColor = System.Drawing.Color.Pink;
            this.but_expitems_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_expitems_back.BackgroundImage")));
            this.but_expitems_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_expitems_back.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_expitems_back.Location = new System.Drawing.Point(578, 341);
            this.but_expitems_back.Name = "but_expitems_back";
            this.but_expitems_back.Size = new System.Drawing.Size(184, 47);
            this.but_expitems_back.TabIndex = 36;
            this.but_expitems_back.Text = "Назад";
            this.but_expitems_back.UseVisualStyleBackColor = false;
            this.but_expitems_back.Click += new System.EventHandler(this.but_expitems_back_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(269, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 37);
            this.label14.TabIndex = 27;
            this.label14.Text = "id:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(231, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 37);
            this.label13.TabIndex = 28;
            this.label13.Text = "name:";
            // 
            // but_expitems_enter
            // 
            this.but_expitems_enter.BackColor = System.Drawing.Color.Pink;
            this.but_expitems_enter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_expitems_enter.BackgroundImage")));
            this.but_expitems_enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_expitems_enter.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_expitems_enter.Location = new System.Drawing.Point(25, 341);
            this.but_expitems_enter.Name = "but_expitems_enter";
            this.but_expitems_enter.Size = new System.Drawing.Size(184, 47);
            this.but_expitems_enter.TabIndex = 35;
            this.but_expitems_enter.Text = "Ввод";
            this.but_expitems_enter.UseVisualStyleBackColor = false;
            this.but_expitems_enter.Click += new System.EventHandler(this.but_expitems_enter_Click);
            // 
            // tb_expitems_id
            // 
            this.tb_expitems_id.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_expitems_id.Location = new System.Drawing.Point(341, 114);
            this.tb_expitems_id.Name = "tb_expitems_id";
            this.tb_expitems_id.Size = new System.Drawing.Size(198, 41);
            this.tb_expitems_id.TabIndex = 31;
            // 
            // tb_expitems_name
            // 
            this.tb_expitems_name.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_expitems_name.Location = new System.Drawing.Point(341, 195);
            this.tb_expitems_name.Name = "tb_expitems_name";
            this.tb_expitems_name.Size = new System.Drawing.Size(198, 41);
            this.tb_expitems_name.TabIndex = 32;
            // 
            // charges
            // 
            this.charges.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("charges.BackgroundImage")));
            this.charges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.charges.Controls.Add(this.but_charges_back);
            this.charges.Controls.Add(this.but_charges_enter);
            this.charges.Controls.Add(this.label15);
            this.charges.Controls.Add(this.tb_charges_amount);
            this.charges.Controls.Add(this.label12);
            this.charges.Controls.Add(this.tb_charges_chargedate);
            this.charges.Controls.Add(this.label11);
            this.charges.Controls.Add(this.tb_charges_expitid);
            this.charges.Controls.Add(this.label10);
            this.charges.Controls.Add(this.tb_charges_id);
            this.charges.Location = new System.Drawing.Point(4, 29);
            this.charges.Name = "charges";
            this.charges.Size = new System.Drawing.Size(792, 417);
            this.charges.TabIndex = 3;
            this.charges.Text = "Charges";
            this.charges.UseVisualStyleBackColor = true;
            // 
            // but_charges_back
            // 
            this.but_charges_back.BackColor = System.Drawing.Color.Pink;
            this.but_charges_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_charges_back.BackgroundImage")));
            this.but_charges_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_charges_back.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_charges_back.Location = new System.Drawing.Point(590, 342);
            this.but_charges_back.Name = "but_charges_back";
            this.but_charges_back.Size = new System.Drawing.Size(184, 47);
            this.but_charges_back.TabIndex = 24;
            this.but_charges_back.Text = "Назад";
            this.but_charges_back.UseVisualStyleBackColor = false;
            this.but_charges_back.Click += new System.EventHandler(this.but_charges_back_Click);
            // 
            // but_charges_enter
            // 
            this.but_charges_enter.BackColor = System.Drawing.Color.Pink;
            this.but_charges_enter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_charges_enter.BackgroundImage")));
            this.but_charges_enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_charges_enter.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_charges_enter.Location = new System.Drawing.Point(27, 342);
            this.but_charges_enter.Name = "but_charges_enter";
            this.but_charges_enter.Size = new System.Drawing.Size(184, 47);
            this.but_charges_enter.TabIndex = 23;
            this.but_charges_enter.Text = "Ввод";
            this.but_charges_enter.UseVisualStyleBackColor = false;
            this.but_charges_enter.Click += new System.EventHandler(this.but_charges_enter_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(282, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 37);
            this.label15.TabIndex = 15;
            this.label15.Text = "id:";
            // 
            // tb_charges_amount
            // 
            this.tb_charges_amount.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_charges_amount.Location = new System.Drawing.Point(338, 111);
            this.tb_charges_amount.Name = "tb_charges_amount";
            this.tb_charges_amount.Size = new System.Drawing.Size(198, 41);
            this.tb_charges_amount.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(123, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 37);
            this.label12.TabIndex = 16;
            this.label12.Text = "expense item id:";
            // 
            // tb_charges_chargedate
            // 
            this.tb_charges_chargedate.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_charges_chargedate.Location = new System.Drawing.Point(338, 189);
            this.tb_charges_chargedate.Name = "tb_charges_chargedate";
            this.tb_charges_chargedate.Size = new System.Drawing.Size(198, 41);
            this.tb_charges_chargedate.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(217, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 37);
            this.label11.TabIndex = 17;
            this.label11.Text = "amount:";
            // 
            // tb_charges_expitid
            // 
            this.tb_charges_expitid.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_charges_expitid.Location = new System.Drawing.Point(338, 272);
            this.tb_charges_expitid.Name = "tb_charges_expitid";
            this.tb_charges_expitid.Size = new System.Drawing.Size(198, 41);
            this.tb_charges_expitid.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(167, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 37);
            this.label10.TabIndex = 18;
            this.label10.Text = "charge date:";
            // 
            // tb_charges_id
            // 
            this.tb_charges_id.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_charges_id.Location = new System.Drawing.Point(338, 32);
            this.tb_charges_id.Name = "tb_charges_id";
            this.tb_charges_id.Size = new System.Drawing.Size(198, 41);
            this.tb_charges_id.TabIndex = 19;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tc_insert);
            this.Name = "Edit";
            this.Text = "Edit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Edit_FormClosed);
            this.tc_insert.ResumeLayout(false);
            this.War.ResumeLayout(false);
            this.War.PerformLayout();
            this.sales.ResumeLayout(false);
            this.sales.PerformLayout();
            this.exp.ResumeLayout(false);
            this.exp.PerformLayout();
            this.charges.ResumeLayout(false);
            this.charges.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_insert;
        private System.Windows.Forms.TabPage War;
        private System.Windows.Forms.Button but_war_back;
        private System.Windows.Forms.Button but_war_enter;
        private System.Windows.Forms.TextBox tb_war_amount;
        private System.Windows.Forms.TextBox tb_war_quant;
        private System.Windows.Forms.TextBox tb_war_name;
        private System.Windows.Forms.TextBox tb_war_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage sales;
        private System.Windows.Forms.TextBox tb_sales_warid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button but_sales_back;
        private System.Windows.Forms.Button but_sales_enter;
        private System.Windows.Forms.TextBox tb_sales_amount;
        private System.Windows.Forms.TextBox tb_sales_quant;
        private System.Windows.Forms.TextBox tb_sales_date;
        private System.Windows.Forms.TextBox tb_sales_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage exp;
        private System.Windows.Forms.Button but_expitems_back;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button but_expitems_enter;
        private System.Windows.Forms.TextBox tb_expitems_id;
        private System.Windows.Forms.TextBox tb_expitems_name;
        private System.Windows.Forms.TabPage charges;
        private System.Windows.Forms.Button but_charges_back;
        private System.Windows.Forms.Button but_charges_enter;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_charges_amount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_charges_chargedate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_charges_expitid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_charges_id;
    }
}