namespace AutoShop
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.but_insert = new System.Windows.Forms.Button();
            this.but_edit = new System.Windows.Forms.Button();
            this.but_delete = new System.Windows.Forms.Button();
            this.but_backToAssist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_insert
            // 
            this.but_insert.BackColor = System.Drawing.Color.Pink;
            this.but_insert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_insert.BackgroundImage")));
            this.but_insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_insert.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_insert.Location = new System.Drawing.Point(72, 21);
            this.but_insert.Name = "but_insert";
            this.but_insert.Size = new System.Drawing.Size(286, 66);
            this.but_insert.TabIndex = 12;
            this.but_insert.Text = "Добавить строку";
            this.but_insert.UseVisualStyleBackColor = false;
            this.but_insert.Click += new System.EventHandler(this.but_insert_Click);
            // 
            // but_edit
            // 
            this.but_edit.BackColor = System.Drawing.Color.Pink;
            this.but_edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_edit.BackgroundImage")));
            this.but_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_edit.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_edit.Location = new System.Drawing.Point(72, 121);
            this.but_edit.Name = "but_edit";
            this.but_edit.Size = new System.Drawing.Size(286, 66);
            this.but_edit.TabIndex = 13;
            this.but_edit.Text = "Изменить строку";
            this.but_edit.UseVisualStyleBackColor = false;
            this.but_edit.Click += new System.EventHandler(this.but_edit_Click);
            // 
            // but_delete
            // 
            this.but_delete.BackColor = System.Drawing.Color.Pink;
            this.but_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_delete.BackgroundImage")));
            this.but_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_delete.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_delete.Location = new System.Drawing.Point(72, 223);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(286, 67);
            this.but_delete.TabIndex = 14;
            this.but_delete.Text = "Удалить строку";
            this.but_delete.UseVisualStyleBackColor = false;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // but_backToAssist
            // 
            this.but_backToAssist.BackColor = System.Drawing.Color.Pink;
            this.but_backToAssist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_backToAssist.BackgroundImage")));
            this.but_backToAssist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_backToAssist.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_backToAssist.Location = new System.Drawing.Point(72, 320);
            this.but_backToAssist.Name = "but_backToAssist";
            this.but_backToAssist.Size = new System.Drawing.Size(286, 65);
            this.but_backToAssist.TabIndex = 15;
            this.but_backToAssist.Text = "Назад";
            this.but_backToAssist.UseVisualStyleBackColor = false;
            this.but_backToAssist.Click += new System.EventHandler(this.but_backToAssist_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(420, 421);
            this.Controls.Add(this.but_backToAssist);
            this.Controls.Add(this.but_delete);
            this.Controls.Add(this.but_edit);
            this.Controls.Add(this.but_insert);
            this.Name = "Editor";
            this.Text = "Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Editor_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_insert;
        private System.Windows.Forms.Button but_edit;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Button but_backToAssist;
    }
}