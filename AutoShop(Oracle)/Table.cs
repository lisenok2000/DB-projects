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
    public partial class Table : Form
    {
        private OracleDataAdapter da;
        Assistance form_assist_;
        Extra form_extra_;
        OracleConnection shopDB_;
        string tableName_;
        int whatOption_;
        public Table(Assistance form_asist, Extra form_extra, int whatOption, string tableName, OracleConnection shopDB)
        {
            InitializeComponent();
            form_assist_ = form_asist;
            tableName_ = tableName;
            whatOption_ = whatOption;
            shopDB_ = shopDB;
            form_extra_ = form_extra;
            switch (whatOption)
            {
                case 0:
                    try
                    {
                        da = new OracleDataAdapter("SELECT * FROM " + tableName_, shopDB);
                        DataTable table = new DataTable(tableName_);
                        Text = tableName_;
                        ds_shop.Tables.Add(table);
                        dg_table.DataSource = ds_shop.Tables[tableName_];
                        da.Fill(ds_shop, tableName_);
                        Show();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("У вас нет доступа к этой таблице.", "Таблица", MessageBoxButtons.OK);
                        if (tableName_ == "Warehouses")
                            form_assist_.war_opened = false;
                        else if (tableName_ == "Sales")
                            form_assist_.sales_opened = false;
                        else if (tableName_ == "Charges")
                            form_assist_.charges_opened = false;
                        else
                            form_assist_.exp_opened = false;
                        Close();
                    }
                    break;
                case 1:
                    try
                    {
                        da = new OracleDataAdapter("SELECT * FROM HELP", shopDB);
                        DataTable table = new DataTable("HELP");
                        Text = "Middle count";
                        ds_shop.Tables.Add(table);
                        dg_table.DataSource = ds_shop.Tables["HELP"];
                        da.Fill(ds_shop, "HELP");
                        Show();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Запрос не был выполнен.", "Таблица", MessageBoxButtons.OK);
                        string strSQL = "DROP TABLE HELP";
                        OracleCommand cmdIC = shopDB_.CreateCommand(); 
                        cmdIC.CommandType = CommandType.Text;
                        cmdIC.CommandText = strSQL;
                        try
                        {
                            cmdIC.ExecuteNonQuery();
                        }
                        catch (OracleException exc)
                        {
                            MessageBox.Show(exc.ToString());
                        }
                        form_extra_.Enabled = true;
                        Close();
                    }
                    break;
            }
        }

        private void Table_FormClosed(object sender, FormClosedEventArgs e)
        {
            switch (whatOption_)
            {
                case 0:
                    if (tableName_ == "Warehouses")
                        form_assist_.war_opened = false;
                    else if (tableName_ == "Sales")
                        form_assist_.sales_opened = false;
                    else if (tableName_ == "Charges")
                        form_assist_.charges_opened = false;
                    else
                        form_assist_.exp_opened = false;
                    break;
                case 1:
                    string strSQL = "DROP TABLE HELP";
                    OracleCommand cmdIC = shopDB_.CreateCommand();
                    cmdIC.CommandType = CommandType.Text;
                    cmdIC.CommandText = strSQL;
                    try
                    {
                        cmdIC.ExecuteNonQuery();
                    }
                    catch (OracleException exc)
                    {
                        MessageBox.Show(exc.ToString());
                    }
                    form_extra_.Enabled = true;
                    break;
            }
        }
    }
}
