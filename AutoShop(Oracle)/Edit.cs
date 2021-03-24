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
    public partial class Edit : Form
    {
        int selectedTab_;
        string tableName_;
        Editor form_edit_;
        OracleConnection shopDB_;
        public Edit(int selectedTab, string tableName, Editor form_edit, OracleConnection shopDB)
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

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_edit_.Show();
        }

        private void but_war_enter_Click(object sender, EventArgs e)
        {
            bool allOK = true;
            if(tb_war_id.Text == "")
            {
                MessageBox.Show("Введите id строки, которую вы хотите изменить.", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            if(tb_war_amount.Text != "")
            {
                String strSQL = "update warehouses set amount = :p1 where id = " + tb_war_id.Text;
                OracleCommand cmdIC = shopDB_.CreateCommand();
                cmdIC.CommandText = strSQL;

                cmdIC.Parameters.Add(new OracleParameter("p1", tb_war_amount.Text));

                try
                {
                    cmdIC.ExecuteNonQuery();
                    tb_war_amount.Text = "";
                }
                catch (OracleException exc)
                {
                    MessageBox.Show(exc.ToString());
                    allOK = false;
                }
            }
            if (tb_war_name.Text != "")
            {
                String strSQL = "update warehouses set name = :p1  where id = " + tb_war_id.Text;
                OracleCommand cmdIC = shopDB_.CreateCommand();
                cmdIC.CommandText = strSQL;

                cmdIC.Parameters.Add(new OracleParameter("p1", tb_war_name.Text));

                try
                {
                    cmdIC.ExecuteNonQuery();
                    tb_war_name.Text = "";
                }
                catch (OracleException exc)
                {
                    MessageBox.Show(exc.ToString());
                    allOK = false;
                }
            }
            if (tb_war_quant.Text != "")
            {
                String strSQL = "update warehouses set quantity = :p1  where id = " + tb_war_id.Text;
                OracleCommand cmdIC = shopDB_.CreateCommand();
                cmdIC.CommandText = strSQL;

                cmdIC.Parameters.Add(new OracleParameter("p1", tb_war_quant.Text));

                try
                {
                    cmdIC.ExecuteNonQuery();
                    tb_war_quant.Text = "";
                }
                catch (OracleException exc)
                {
                    MessageBox.Show(exc.ToString());
                    allOK = false;
                }
            }
            if(allOK)
            {
                MessageBox.Show("Изменение прошло успешно!");
            }
        }

        private void but_sales_enter_Click(object sender, EventArgs e)
        {
            bool allOK = true;
            if (tb_sales_id.Text == "")
            {
                MessageBox.Show("Введите id строки, которую вы хотите изменить.", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            if (tb_sales_amount.Text != "")
            {
                String strSQL = "update sales set amount = :p1 where id = " + tb_sales_id.Text;
                OracleCommand cmdIC = shopDB_.CreateCommand();
                cmdIC.CommandText = strSQL;

                cmdIC.Parameters.Add(new OracleParameter("p1", tb_sales_amount.Text));

                try
                {
                    cmdIC.ExecuteNonQuery();
                    tb_sales_amount.Text = "";
                }
                catch (OracleException exc)
                {
                    MessageBox.Show(exc.ToString());
                    allOK = false;
                }
            }
            if (tb_sales_quant.Text != "")
            {
                String strSQL = "update sales set quantity = :p1 where id = " + tb_sales_id.Text;
                OracleCommand cmdIC = shopDB_.CreateCommand();
                cmdIC.CommandText = strSQL;

                cmdIC.Parameters.Add(new OracleParameter("p1", tb_sales_quant.Text));

                try
                {
                    cmdIC.ExecuteNonQuery();
                    tb_sales_quant.Text = "";
                }
                catch (OracleException exc)
                {
                    MessageBox.Show(exc.ToString());
                    allOK = false;
                }
            }
            if (tb_sales_date.Text != "")
            {
                String strSQL = "update sales set sale_data = :p1 where id = " + tb_sales_id.Text;
                OracleCommand cmdIC = shopDB_.CreateCommand();
                cmdIC.CommandText = strSQL;

                cmdIC.Parameters.Add(new OracleParameter("p1", tb_sales_date.Text));

                try
                {
                    cmdIC.ExecuteNonQuery();
                    tb_sales_date.Text = "";
                }
                catch (OracleException exc)
                {
                    MessageBox.Show(exc.ToString());
                    allOK = false;
                }
            }
            if (tb_sales_warid.Text != "")
            {
                String strSQL = "update sales set warehouse_id = :p1 where id = " + tb_sales_id.Text;
                OracleCommand cmdIC = shopDB_.CreateCommand();
                cmdIC.CommandText = strSQL;

                cmdIC.Parameters.Add(new OracleParameter("p1", tb_sales_warid.Text));

                try
                {
                    cmdIC.ExecuteNonQuery();
                    tb_sales_warid.Text = "";
                }
                catch (OracleException exc)
                {
                    MessageBox.Show(exc.ToString());
                    allOK = false;
                }
            }
            if (allOK)
            {
                MessageBox.Show("Изменение прошло успешно!");
            }
        }

        private void but_expitems_enter_Click(object sender, EventArgs e)
        {
            bool allOK = true;
            if (tb_expitems_id.Text == "")
            {
                MessageBox.Show("Введите id строки, которую вы хотите изменить.", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            if (tb_expitems_name.Text != "")
            {
                String strSQL = "update expense_items set name = :p1 where id = " + tb_expitems_id.Text;
                OracleCommand cmdIC = shopDB_.CreateCommand();
                cmdIC.CommandText = strSQL;

                cmdIC.Parameters.Add(new OracleParameter("p1", tb_expitems_name.Text));

                try
                {
                    cmdIC.ExecuteNonQuery();
                    tb_expitems_name.Text = "";
                }
                catch (OracleException exc)
                {
                    MessageBox.Show(exc.ToString());
                    allOK = false;
                }
            }
            if (allOK)
            {
                MessageBox.Show("Изменение прошло успешно!");
            }
        }

        private void but_charges_enter_Click(object sender, EventArgs e)
        {
            bool allOK = true;
            if (tb_charges_id.Text == "")
            {
                MessageBox.Show("Введите id строки, которую вы хотите изменить.", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            if (tb_charges_amount.Text != "")
            {
                String strSQL = "update charges set amount = :p1 where id = " + tb_charges_id.Text;
                OracleCommand cmdIC = shopDB_.CreateCommand();
                cmdIC.CommandText = strSQL;

                cmdIC.Parameters.Add(new OracleParameter("p1", tb_charges_amount.Text));

                try
                {
                    cmdIC.ExecuteNonQuery();
                    tb_charges_amount.Text = "";
                }
                catch (OracleException exc)
                {
                    MessageBox.Show(exc.ToString());
                    allOK = false;
                }
            }
            if (tb_charges_chargedate.Text != "")
            {
                String strSQL = "update charges set charge_data = :p1 where id = " + tb_charges_id.Text;
                OracleCommand cmdIC = shopDB_.CreateCommand();
                cmdIC.CommandText = strSQL;

                cmdIC.Parameters.Add(new OracleParameter("p1", tb_charges_chargedate.Text));

                try
                {
                    cmdIC.ExecuteNonQuery();
                    tb_charges_chargedate.Text = "";
                }
                catch (OracleException exc)
                {
                    MessageBox.Show(exc.ToString());
                    allOK = false;
                }
            }
            if (tb_charges_expitid .Text != "")
            {
                String strSQL = "update charges set expense_item_id = :p1 where id = " + tb_charges_id.Text;
                OracleCommand cmdIC = shopDB_.CreateCommand();
                cmdIC.CommandText = strSQL;

                cmdIC.Parameters.Add(new OracleParameter("p1", tb_charges_expitid.Text));

                try
                {
                    cmdIC.ExecuteNonQuery();
                    tb_charges_expitid.Text = "";
                }
                catch (OracleException exc)
                {
                    MessageBox.Show(exc.ToString());
                    allOK = false;
                }
            }
            if (allOK)
            {
                MessageBox.Show("Изменение прошло успешно!");
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
