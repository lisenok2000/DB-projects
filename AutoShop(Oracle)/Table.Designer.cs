namespace AutoShop
{
    partial class Table
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
            this.dg_table = new System.Windows.Forms.DataGridView();
            this.ds_shop = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dg_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_shop)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_table
            // 
            this.dg_table.AllowUserToAddRows = false;
            this.dg_table.AllowUserToDeleteRows = false;
            this.dg_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_table.Location = new System.Drawing.Point(0, 0);
            this.dg_table.Name = "dg_table";
            this.dg_table.ReadOnly = true;
            this.dg_table.RowTemplate.Height = 24;
            this.dg_table.Size = new System.Drawing.Size(800, 450);
            this.dg_table.TabIndex = 0;
            // 
            // ds_shop
            // 
            this.ds_shop.DataSetName = "NewDataSet";
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dg_table);
            this.Name = "Table";
            this.Text = "Table";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Table_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dg_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_shop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_table;
        private System.Data.DataSet ds_shop;
    }
}