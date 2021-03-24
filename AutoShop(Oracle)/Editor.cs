using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace AutoShop
{
    public partial class Editor : Form
    {
        string tableName_;
        OracleConnection shopDB_;
        Assistance form_assist_;

        public Editor(Assistance form_assist, string tableName, OracleConnection shopDB)
        {
            InitializeComponent();
            tableName_ = tableName;
            form_assist_ = form_assist;
            shopDB_ = shopDB;
        }

        private void Editor_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_assist_.Enabled = true;
        }

        private void but_backToAssist_Click(object sender, EventArgs e)
        {
            Close();
            form_assist_.Enabled = true;
        }

        private void but_insert_Click(object sender, EventArgs e)
        {
            Insert form_ins;
            switch (tableName_)
            {
                case "Warehouses":
                    form_ins = new Insert(0, tableName_, this, shopDB_);
                    form_ins.Show();
                    Hide();
                    break;
                case "Sales":
                    form_ins = new Insert(1, tableName_, this, shopDB_);
                    form_ins.Show();
                    Hide();
                    break;
                case "Expense_items":
                    form_ins = new Insert(2, tableName_, this, shopDB_);
                    form_ins.Show();
                    Hide();
                    break;
                default:
                    form_ins = new Insert(3, tableName_, this, shopDB_);
                    form_ins.Show();
                    Hide();
                    break;
            }
        }

        private void but_edit_Click(object sender, EventArgs e)
        {
            Edit form_edit;
            switch (tableName_)
            {
                case "Warehouses":
                    form_edit = new Edit(0, tableName_, this, shopDB_);
                    form_edit.Show();
                    Hide();
                    break;
                case "Sales":
                    form_edit = new Edit(1, tableName_, this, shopDB_);
                    form_edit.Show();
                    Hide();
                    break;
                case "Expense_items":
                    form_edit = new Edit(2, tableName_, this, shopDB_);
                    form_edit.Show();
                    Hide();
                    break;
                default:
                    form_edit = new Edit(3, tableName_, this, shopDB_);
                    form_edit.Show();
                    Hide();
                    break;
            }
        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            Delete form_delete;
            form_delete = new Delete(tableName_, this, shopDB_);
            form_delete.Show();
            Hide();
        }
    }
}
