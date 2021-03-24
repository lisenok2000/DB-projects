namespace AutoShop
{
    partial class Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete));
            this.but_back = new System.Windows.Forms.Button();
            this.but_enter = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_back
            // 
            this.but_back.BackColor = System.Drawing.Color.Pink;
            this.but_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_back.BackgroundImage")));
            this.but_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_back.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_back.Location = new System.Drawing.Point(588, 376);
            this.but_back.Name = "but_back";
            this.but_back.Size = new System.Drawing.Size(184, 47);
            this.but_back.TabIndex = 18;
            this.but_back.Text = "Назад";
            this.but_back.UseVisualStyleBackColor = false;
            this.but_back.Click += new System.EventHandler(this.but_back_Click);
            // 
            // but_enter
            // 
            this.but_enter.BackColor = System.Drawing.Color.Pink;
            this.but_enter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_enter.BackgroundImage")));
            this.but_enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_enter.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_enter.Location = new System.Drawing.Point(36, 376);
            this.but_enter.Name = "but_enter";
            this.but_enter.Size = new System.Drawing.Size(184, 47);
            this.but_enter.TabIndex = 17;
            this.but_enter.Text = "Ввод";
            this.but_enter.UseVisualStyleBackColor = false;
            this.but_enter.Click += new System.EventHandler(this.but_enter_Click);
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_id.Location = new System.Drawing.Point(331, 186);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(198, 41);
            this.tb_id.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(259, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "id:";
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_back);
            this.Controls.Add(this.but_enter);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label1);
            this.Name = "Delete";
            this.Text = "Delete";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Delete_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_back;
        private System.Windows.Forms.Button but_enter;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label1;
    }
}