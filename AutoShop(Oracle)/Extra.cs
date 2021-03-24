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
    public partial class Extra : Form
    {
        OracleConnection shopDB_;
        Assistance form_assist_;

        public Extra(Assistance form_assist,  OracleConnection shopDB)
        {
            InitializeComponent();
            form_assist_ = form_assist;
            shopDB_ = shopDB;
        }

        private void Extra_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_assist_.Enabled = true;
        }

        private void but_profit_Click(object sender, EventArgs e)
        {
            string profit;
            String strSQL = "profit_prediction";
            OracleCommand cmdIC = shopDB_.CreateCommand();
            cmdIC.CommandType = CommandType.StoredProcedure;
            cmdIC.CommandText = strSQL;

            cmdIC.Parameters.Add(new OracleParameter("profit", OracleDbType.Double, ParameterDirection.Output));

            try
            {
                cmdIC.ExecuteNonQuery();
                profit = cmdIC.Parameters["profit"].Value.ToString();
                MessageBox.Show("Прибыль: " + profit, "Прибыль", MessageBoxButtons.OK);
            }
            catch (OracleException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void but_middle_count_Click(object sender, EventArgs e)
        {
            String strSQL = "CREATE TABLE \"HELP\" (\"ID\" NUMBER(*, 0), \"NAME\" VARCHAR(20), \"COUNT\" NUMBER(*, 0))";
            OracleCommand cmdIC = shopDB_.CreateCommand();
            cmdIC.CommandText = strSQL;
            try
            {
                cmdIC.ExecuteNonQuery();
            }
            catch (OracleException exc)
            {
                MessageBox.Show(exc.ToString());
            }

            strSQL = "middle_count";
            cmdIC = shopDB_.CreateCommand();
            cmdIC.CommandType = CommandType.StoredProcedure;
            cmdIC.CommandText = strSQL;
            try
            {
                cmdIC.ExecuteNonQuery();
            }
            catch (OracleException exc)
            {
                MessageBox.Show(exc.ToString());
            }

            Table form_table = new Table(null, this, 1, "", shopDB_);
            Enabled = false;
            form_table.Show();
        }

        private void but_products_date_Click(object sender, EventArgs e)
        {
            if(tb_products_prod1.Text == "" || tb_products_prod2.Text == "")
            {
                MessageBox.Show("Введите товары.", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            String strSQL = "CREATE TABLE \"HELP\" (\"ID\" NUMBER(*,0), \"COMMON_DATE\" TIMESTAMP(3))";
            OracleCommand cmdIC = shopDB_.CreateCommand();
            cmdIC.CommandText = strSQL;
            try
            {
                cmdIC.ExecuteNonQuery();
            }
            catch (OracleException exc)
            {
                MessageBox.Show(exc.ToString());
            }

            strSQL = "products_date";
            cmdIC = shopDB_.CreateCommand();
            cmdIC.CommandType = CommandType.StoredProcedure;
            cmdIC.CommandText = strSQL;

            cmdIC.Parameters.Add(new OracleParameter("p1", tb_products_prod1.Text));
            cmdIC.Parameters.Add(new OracleParameter("p2", tb_products_prod2.Text));
            try
            {
                cmdIC.ExecuteNonQuery();
            }
            catch (OracleException exc)
            {
                MessageBox.Show(exc.ToString());
            }

            Table form_table = new Table(null, this, 1, "", shopDB_);
            Enabled = false;
            form_table.Show();
            tb_products_prod1.Text = "";
            tb_products_prod2.Text = "";
        }

        private void but_income_expense_Click(object sender, EventArgs e)
        {
            if (tb_income_exp_date1.Text == "" || tb_income_exp_date2.Text == "")
            {
                MessageBox.Show("Введите период времени.", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            string income, expense;
            String strSQL = "income_expense";
            OracleCommand cmdIC = shopDB_.CreateCommand();
            cmdIC.CommandType = CommandType.StoredProcedure;
            cmdIC.CommandText = strSQL;

            cmdIC.Parameters.Add(new OracleParameter("p1", tb_income_exp_date1.Text));
            cmdIC.Parameters.Add(new OracleParameter("p2", tb_income_exp_date2.Text));
            cmdIC.Parameters.Add(new OracleParameter("income", OracleDbType.Double, ParameterDirection.Output));
            cmdIC.Parameters.Add(new OracleParameter("expense", OracleDbType.Double, ParameterDirection.Output));

            try
            {
                cmdIC.ExecuteNonQuery();
                income = cmdIC.Parameters["income"].Value.ToString();
                expense = cmdIC.Parameters["expense"].Value.ToString();
                MessageBox.Show("Доход: " + income + "\nРасход: " + expense, "Доход и расход", MessageBoxButtons.OK);
            }
            catch (OracleException exc)
            {
                MessageBox.Show(exc.ToString());
            }
            tb_income_exp_date1.Text = "";
            tb_income_exp_date2.Text = "";
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            form_assist_.Enabled = true;
            Close();
        }
    }
}
