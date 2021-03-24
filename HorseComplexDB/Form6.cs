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
    public partial class Form6 : Form
    {
        int SelectedTab_;
        OleDbConnection ComplexDB_;
        public Form6(int SelectedTab, OleDbConnection ComplexDB)
        {
            InitializeComponent();
            SelectedTab_ = SelectedTab;
            ComplexDB_ = ComplexDB;
        }

        private void delBut_Click(object sender, EventArgs e)
        {
            if (NumStr.Text == "")
            {
                MessageBox.Show("Введите номер строки.");
                return;
            }
            String strSQL = "";
            OleDbCommand cmdIC;
            if (SelectedTab_ == 0)
            {
                strSQL = "DELETE FROM Владельцы WHERE id=?";
            }
            else if (SelectedTab_ == 1)
            {
                strSQL = "DELETE FROM [Закрепление лошадей] WHERE [id лошади]=?";
            }
            else if (SelectedTab_ == 2)
            {
                strSQL = "DELETE FROM [Закрепление стойл] WHERE [id стойла]=?";
            }
            else if (SelectedTab_ == 3)
            {
                strSQL = "DELETE FROM [Конюхи] WHERE id=?";
            }
            else if (SelectedTab_ == 4)
            {
                strSQL = "DELETE FROM [Лошади] WHERE id=?";
            }
            else if (SelectedTab_ == 5)
            {
                strSQL = "DELETE FROM [Резерв площадок] WHERE [id площадки]=?";
            }
            else if (SelectedTab_ == 6)
            {
                strSQL = "DELETE FROM [Сломанное снаряжение] WHERE id=?";
            }
            else if (SelectedTab_ == 7)
            {
                strSQL = "DELETE FROM [Стойла] WHERE id=?";
            }
            else if (SelectedTab_ == 8)
            {
                strSQL = "DELETE FROM [Тренеры] WHERE id=?";
            }
            else if (SelectedTab_ == 9)
            {
                strSQL = "DELETE FROM [Тренировки] WHERE id=?";
            }
            else
            {
                strSQL = "DELETE FROM [Экипировка] WHERE [Тип]=?";
                cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 50);

                cmdIC.Parameters[0].Value = NumStr.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    NumStr.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                }
                return;
            }
            cmdIC = new OleDbCommand(strSQL, ComplexDB_);

            cmdIC.Parameters.Add("@p1", OleDbType.Integer);

            cmdIC.Parameters[0].Value = NumStr.Text;
            try
            {
                cmdIC.ExecuteNonQuery();
                NumStr.Text = "";
                MessageBox.Show("Строчка успешно удалена.");
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
