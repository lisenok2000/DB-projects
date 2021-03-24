namespace Client
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
            this.tablesView = new System.Windows.Forms.DataGridView();
            this.tableSet = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.tablesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tablesView
            // 
            this.tablesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablesView.Location = new System.Drawing.Point(0, 0);
            this.tablesView.Name = "tablesView";
            this.tablesView.RowTemplate.Height = 24;
            this.tablesView.Size = new System.Drawing.Size(800, 450);
            this.tablesView.TabIndex = 0;
            // 
            // tableSet
            // 
            this.tableSet.DataSetName = "tableSet";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablesView);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tablesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablesView;
        private System.Data.DataSet tableSet;
    }
}