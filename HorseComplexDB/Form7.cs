using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form7 : Form
    {
        Form2 parentForm_;
        OleDbConnection ComplexDB_;
        public Form7(Form2 parent, OleDbConnection ComplexDB)
        {
            InitializeComponent();
            ComplexDB_ = ComplexDB;
            parentForm_ = parent;
        }

        private void ExitBut_Click(object sender, EventArgs e)
        {
            Form3 tableFind = new Form3(ComplexDB_, FioBox.Text, 1)
            {
                MdiParent = parentForm_
            };
            Close();
        }
    }
}
