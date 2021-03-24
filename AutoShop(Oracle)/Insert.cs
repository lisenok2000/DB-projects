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
    public partial class Insert : Form
    {
        int selectedTab_;
        string tableName_;
        Editor form_edit_;
        OracleConnection shopDB_;
        public Insert(int selectedTab, string tableName, Editor form_edit, OracleConnection shopDB)
        {
            InitializeComponent();
            selectedTab_ = selectedTab;
            tableName_ = tableName;
            form_edit_ = form_edit;
            shopDB_ = shopDB;
            tc_insert.SelectedTab = tc_insert.TabPages[selectedTab_];
        }

        private void tc_insert_Selecting(object sender, TabControlCancelEventArgs e)
        {
            tc_insert.SelectedTab = tc_insert.TabPages[selectedTab_];
            e.Cancel = false;
        }

        private void Insert_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_edit_.Show();
        }

        private void but_war_enter_Click(object sender, EventArgs e)
        {
            String strSQL = "insert into warehouses (id, name, quantity, amount) values (:p1, :p2, :p3, :p4)";
            OracleCommand cmdIC = shopDB_.CreateCommand();
            cmdIC.CommandText = strSQL;

            cmdIC.Parameters.Add(new OracleParameter("p1", tb_war_id.Text));
            cmdIC.Parameters.Add(new OracleParameter("p2", tb_war_name.Text));
            cmdIC.Parameters.Add(new OracleParameter("p3", tb_war_quant.Text));
            cmdIC.Parameters.Add(new OracleParameter("p4", tb_war_amount.Text));

            try
            {
                cmdIC.ExecuteNonQuery();
                MessageBox.Show("Добавление прошло успешно!");

                tb_war_id.Text = "";
                tb_war_name.Text = "";
                tb_war_quant.Text = "";
                tb_war_amount.Text = "";
            }
            catch (OracleException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void but_sales_enter_Click(object sender, EventArgs e)
        {
            String strSQL = "insert into sales (id, amount, quantity, sale_data, warehouse_id) values (:p1, :p2, :p3, :p4, :p5)";
            OracleCommand cmdIC = shopDB_.CreateCommand();
            cmdIC.CommandText = strSQL;

            cmdIC.Parameters.Add(new OracleParameter("p1", tb_sales_id.Text));
            cmdIC.Parameters.Add(new OracleParameter("p2", tb_sales_amount.Text));
            cmdIC.Parameters.Add(new OracleParameter("p3", tb_sales_quant.Text));
            cmdIC.Parameters.Add(new OracleParameter("p4", tb_sales_date.Text));
            cmdIC.Parameters.Add(new OracleParameter("p5", tb_sales_warid.Text));

            try
            {
                cmdIC.ExecuteNonQuery();
                MessageBox.Show("Добавление прошло успешно!");

                tb_sales_id.Text = "";
                tb_sales_amount.Text = "";
                tb_sales_quant.Text = "";
                tb_sales_date.Text = "";
                tb_sales_warid.Text = "";
            }
            catch (OracleException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void but_expitems_enter_Click(object sender, EventArgs e)
        {
            String strSQL = "insert into expense_items (id, name) values (:p1, :p2)";
            OracleCommand cmdIC = shopDB_.CreateCommand();
            cmdIC.CommandText = strSQL;

            cmdIC.Parameters.Add(new OracleParameter("p1", tb_expitems_id.Text));
            cmdIC.Parameters.Add(new OracleParameter("p2", tb_expitems_name.Text));

            try
            {
                cmdIC.ExecuteNonQuery();
                MessageBox.Show("Добавление прошло успешно!");

                tb_expitems_id.Text = "";
                tb_expitems_name.Text = "";
            }
            catch (OracleException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }


        private void but_charges_enter_Click(object sender, EventArgs e)
        {
            String strSQL = "insert into charges (id, amount, charge_data, expense_item_id) values (:p1, :p2, :p3, :p4)";
            OracleCommand cmdIC = shopDB_.CreateCommand();
            cmdIC.CommandText = strSQL;

            cmdIC.Parameters.Add(new OracleParameter("p1", tb_charges_id.Text));
            cmdIC.Parameters.Add(new OracleParameter("p2", tb_charges_amount.Text));
            cmdIC.Parameters.Add(new OracleParameter("p3", tb_charges_chargedate.Text));
            cmdIC.Parameters.Add(new OracleParameter("p4", tb_charges_expitid.Text));

            try
            {
                cmdIC.ExecuteNonQuery();
                MessageBox.Show("Добавление прошло успешно!");

                tb_charges_id.Text = "";
                tb_charges_amount.Text = "";
                tb_charges_chargedate.Text = "";
                tb_charges_expitid.Text = "";
            }
            catch (OracleException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void but_war_back_Click(object sender, EventArgs e)
        {
            Close();
            form_edit_.Show();
        }

        private void but_sales_back_Click(object sender, EventArgs e)
        {
            Close();
            form_edit_.Show();
        }

        private void but_expitems_back_Click(object sender, EventArgs e)
        {
            Close();
            form_edit_.Show();
        }

        private void but_charges_back_Click(object sender, EventArgs e)
        {
            Close();
            form_edit_.Show();
        }

    }
}
