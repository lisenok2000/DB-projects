namespace Client
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.PlainBut = new System.Windows.Forms.Button();
            this.StableBut = new System.Windows.Forms.Button();
            this.TrainBut = new System.Windows.Forms.Button();
            this.TrainersBut = new System.Windows.Forms.Button();
            this.HorseBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlainBut
            // 
            this.PlainBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlainBut.Location = new System.Drawing.Point(213, 12);
            this.PlainBut.Name = "PlainBut";
            this.PlainBut.Size = new System.Drawing.Size(228, 65);
            this.PlainBut.TabIndex = 11;
            this.PlainBut.Text = "Недоступные площадки";
            this.PlainBut.UseVisualStyleBackColor = true;
            this.PlainBut.Click += new System.EventHandler(this.PlainBut_Click);
            // 
            // StableBut
            // 
            this.StableBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StableBut.Location = new System.Drawing.Point(436, 351);
            this.StableBut.Name = "StableBut";
            this.StableBut.Size = new System.Drawing.Size(228, 65);
            this.StableBut.TabIndex = 12;
            this.StableBut.Text = "Лошади без стойл";
            this.StableBut.UseVisualStyleBackColor = true;
            this.StableBut.Click += new System.EventHandler(this.StableBut_Click);
            // 
            // TrainBut
            // 
            this.TrainBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrainBut.Location = new System.Drawing.Point(436, 259);
            this.TrainBut.Name = "TrainBut";
            this.TrainBut.Size = new System.Drawing.Size(228, 65);
            this.TrainBut.TabIndex = 13;
            this.TrainBut.Text = "Общие тренировки лошадей";
            this.TrainBut.UseVisualStyleBackColor = true;
            this.TrainBut.Click += new System.EventHandler(this.TrainBut_Click);
            // 
            // TrainersBut
            // 
            this.TrainersBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrainersBut.Location = new System.Drawing.Point(12, 259);
            this.TrainersBut.Name = "TrainersBut";
            this.TrainersBut.Size = new System.Drawing.Size(228, 65);
            this.TrainersBut.TabIndex = 14;
            this.TrainersBut.Text = "Поломки у работников";
            this.TrainersBut.UseVisualStyleBackColor = true;
            this.TrainersBut.Click += new System.EventHandler(this.TrainersBut_Click);
            // 
            // HorseBut
            // 
            this.HorseBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HorseBut.Location = new System.Drawing.Point(12, 351);
            this.HorseBut.Name = "HorseBut";
            this.HorseBut.Size = new System.Drawing.Size(228, 65);
            this.HorseBut.TabIndex = 15;
            this.HorseBut.Text = "Поломки у лошадей";
            this.HorseBut.UseVisualStyleBackColor = true;
            this.HorseBut.Click += new System.EventHandler(this.HorseBut_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(676, 428);
            this.Controls.Add(this.HorseBut);
            this.Controls.Add(this.TrainersBut);
            this.Controls.Add(this.TrainBut);
            this.Controls.Add(this.StableBut);
            this.Controls.Add(this.PlainBut);
            this.Name = "Form8";
            this.Text = "Проверка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form8_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlainBut;
        private System.Windows.Forms.Button StableBut;
        private System.Windows.Forms.Button TrainBut;
        private System.Windows.Forms.Button TrainersBut;
        private System.Windows.Forms.Button HorseBut;
    }
}