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
    public partial class StartMenu : Form
    {
        private string[] logins = new string[3];
        private OracleConnection shopDB = new OracleConnection();
        private OracleDataAdapter da;

        public StartMenu()
        {
            InitializeComponent();
            logins[0] = "admin";
            logins[1] = "operator";
            logins[2] = "purchaser";
            shopDB.ConnectionString = "DATA SOURCE=localhost:1521/xe;PASSWORD=anzhelika;PERSIST SECURITY INFO=True;USER ID=c##anzhelika";
            try
            {
                shopDB.Open();
                MessageBox.Show("Соединение с базой произведено успешно.", "Подключение", MessageBoxButtons.OK);
                da = new OracleDataAdapter("SELECT * FROM LOGINS", shopDB);
                DataTable table = new DataTable("LOGINS");
                ds_shop.Tables.Add(table);
                da.Fill(ds_shop, "LOGINS");
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка подключения к базе. Попробуйте еще раз.", "Подключение", MessageBoxButtons.OK);
                Close();
            }
            
        }

        private int hashCode(string s)
        {
            int res = 0;
            for (int i = 0; i < s.Length; i++)
                res += s[i];
            res *= res;
            res >>= 3;
            res %= 2048;
            return res;
        }

        private void but_enter_Click(object sender, EventArgs e)
        {
            bool logedIn = false;
            for (int i = 0; i < int.Parse(ds_shop.Tables["LOGINS"].Rows.Count.ToString()); i++)
            {
                if ((tb_login.Text == ds_shop.Tables["LOGINS"].Rows[i]["login"].ToString()) && 
                    (hashCode(tb_password.Text).ToString() == ds_shop.Tables["LOGINS"].Rows[i]["pasword"].ToString()))
                {
                    Assistance AsistForm = new Assistance(this, shopDB, logins[i]);
                    AsistForm.Show();
                    this.Hide();
                    logedIn = true;
                }
            }
            if(!logedIn)
            {
                MessageBox.Show("Неверно введен логин или пароль", "Авторизация", MessageBoxButtons.OK);
            }
            tb_password.Text = "";
        }

        private void but_esc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
