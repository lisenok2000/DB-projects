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
    public partial class Assistance : Form
    {
        StartMenu StMenu_;
        OracleConnection shopDB_;
        string user_;
        public bool war_opened = false, sales_opened = false, exp_opened = false, charges_opened = false;

        public Assistance(StartMenu StMenu, OracleConnection shopDB, string user)
        {
            
            InitializeComponent();
            StMenu_ = StMenu;
            user_ = user;
            shopDB_ = shopDB;
            
            if (user_ == "admin")
                lab_hello.Text = "Доброго времени суток, администратор!";
            else if (user_ == "operator")
                lab_hello.Text = "Доброго времени суток, оператор!";
            else
                lab_hello.Text = "Доброго времени суток, покупатель!";
        }

        private void Assistance_FormClosed(object sender, FormClosedEventArgs e)
        {
            StMenu_.Show();
        }
        private void but_assist_back_Click(object sender, EventArgs e)
        {
            StMenu_.Show();
            Close();
        }

        private void but_show_warehouses_Click(object sender, EventArgs e)
        {
            if (!war_opened)
            {
                Table form_table = new Table(this, null, 0, "Warehouses", shopDB_);
                war_opened = true;
            }
        }

        private void but_exp_Click(object sender, EventArgs e)
        {
            if (!exp_opened)
            {
                Table form_table = new Table(this, null, 0, "Expense_items", shopDB_);
                exp_opened = true;
            }
        }

        private void but_sales_Click(object sender, EventArgs e)
        {
            if (!sales_opened)
            {
                Table form_table = new Table(this, null, 0, "Sales", shopDB_);
                sales_opened = true;
            }
        }

        private void but_charges_Click(object sender, EventArgs e)
        {
            if (!charges_opened)
            {
                Table form_table = new Table(this, null,  0, "Charges", shopDB_);
                charges_opened = true;
            }
        }

        private void but_edit_war_Click(object sender, EventArgs e)
        {
            Editor form_edit = new Editor(this, "Warehouses", shopDB_);
            Enabled = false;
            form_edit.Show();
        }

        private void but_edit_exp_Click(object sender, EventArgs e)
        {
            Editor form_edit = new Editor(this, "Expense_items", shopDB_);
            Enabled = false;
            form_edit.Show();
        }

        private void but_edit_sales_Click(object sender, EventArgs e)
        {
            Editor form_edit = new Editor(this, "Sales", shopDB_);
            Enabled = false;
            form_edit.Show();
        }

        private void but_edit_charges_Click(object sender, EventArgs e)
        {
            Editor form_edit = new Editor(this, "Charges", shopDB_);
            Enabled = false;
            form_edit.Show();
        }

        private void but_extra_Click(object sender, EventArgs e)
        {
            Extra form_extra = new Extra(this, shopDB_);
            Enabled = false;
            form_extra.Show();
        }
    }
}
