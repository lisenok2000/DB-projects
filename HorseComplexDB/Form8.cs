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
    public partial class Form8 : Form
    {
        Form2 parent_;
        OleDbConnection ComplexDB_;
        public Form8(Form2 form, OleDbConnection ComplexDB)
        {
            InitializeComponent();
            parent_ = form;
            ComplexDB_ = ComplexDB;
        }

        private void PlainBut_Click(object sender, EventArgs e)
        {
            bool existTable = false;
            foreach (Form tbl in parent_.MdiChildren)
                if (tbl.Text == "Недоступные площадки")
                {
                    tbl.Activate();
                    existTable = true;
                    break;
                }
            if (!existTable)
            {
                Form3 table = new Form3(ComplexDB_, null, 2)
                {
                    MdiParent = parent_
                };
                table.Show();
            }
            Close();
        }

        private void TrainersBut_Click(object sender, EventArgs e)
        {
            bool existTable = false;
            foreach (Form tbl in parent_.MdiChildren)
                if (tbl.Text == "Список поломок у работников")
                {
                    tbl.Activate();
                    existTable = true;
                    break;
                }
            if (!existTable)
            {
                Form3 table = new Form3(ComplexDB_, null, 3)
                {
                    MdiParent = parent_
                };
                table.Show();
            }
            Close();
        }

        private void HorseBut_Click(object sender, EventArgs e)
        {
            bool existTable = false;
            foreach (Form tbl in parent_.MdiChildren)
                if (tbl.Text == "Список поломок у лошадей")
                {
                    tbl.Activate();
                    existTable = true;
                    break;
                }
            if (!existTable)
            {
                Form3 table = new Form3(ComplexDB_, null, 4)
                {
                    MdiParent = parent_
                };
                table.Show();
            }
            Close();
        }

        private void TrainBut_Click(object sender, EventArgs e)
        {
            bool existTable = false;
            foreach (Form tbl in parent_.MdiChildren)
                if (tbl.Text == "Общие тренировки")
                {
                    tbl.Activate();
                    existTable = true;
                    break;
                }
            if (!existTable)
            {
                Form3 table = new Form3(ComplexDB_, null, 5)
                {
                    MdiParent = parent_
                };
                table.Show();
            }
            Close();
        }

        private void StableBut_Click(object sender, EventArgs e)
        {
            bool existTable = false;
            foreach (Form tbl in parent_.MdiChildren)
                if (tbl.Text == "Лошади без места простоя")
                {
                    tbl.Activate();
                    existTable = true;
                    break;
                }
            if (!existTable)
            {
                Form3 table = new Form3(ComplexDB_, null, 6)
                {
                    MdiParent = parent_
                };
                table.Show();
            }
            Close();
        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent_.Enabled = true;
        }
    }
}
