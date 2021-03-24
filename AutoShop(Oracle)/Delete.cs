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
    public partial class Delete : Form
    {
        string tableName_;
        Editor form_edit_;
        OracleConnection shopDB_;
        public Delete(string tableName, Editor form_edit, OracleConnection shopDB)
        {
            InitializeComponent();
            tableName_ = tableName;
            form_edit_ = form_edit;
            shopDB_ = shopDB;
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            Close();
            form_edit_.Show();
        }

        private void but_enter_Click(object sender, EventArgs e)
        {
            if (tb_id.Text == "")
            {
                MessageBox.Show("Введите id строки, которую вы хотите удалить.", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            String strSQL = "delete from " + tableName_ + " where id = :p1";
            OracleCommand cmdIC = shopDB_.CreateCommand();
            cmdIC.CommandText = strSQL;

            cmdIC.Parameters.Add(new OracleParameter("p1", tb_id.Text));

            try
            {
                cmdIC.ExecuteNonQuery();
                tb_id.Text = "";
                MessageBox.Show("Удаление прошло успешно!");
            }
            catch (OracleException exc)
            {
                MessageBox.Show(exc.ToString());
            }

        }

        private void Delete_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_edit_.Show();
        }
    }
}
