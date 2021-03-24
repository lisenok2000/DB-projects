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
    public partial class Form5 : Form
    {
        int SelectedTab_;
        OleDbConnection ComplexDB_;
        public Form5(int SelectedTab, OleDbConnection ComplexDB)
        {
            InitializeComponent();
            SelectedTab_ = SelectedTab;
            ComplexDB_ = ComplexDB;
            addTabControl.SelectedTab = addTabControl.TabPages[SelectedTab_];
        }

        private void addTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            addTabControl.SelectedTab = addTabControl.TabPages[SelectedTab_];
            e.Cancel = false;
        }

        private void addBut0_Click(object sender, EventArgs e)
        {
            if(NumStr0.Text == "")
            {
                MessageBox.Show("Введите номер строки.");
                return;
            }
            bool Ok = true;
            if(FIO0.Text != "")
            {
                String strSQL = "UPDATE Владельцы SET ФИО=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 50);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = FIO0.Text;
                cmdIC.Parameters[1].Value = NumStr0.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    FIO0.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Phone0.Text != "")
            {
                String strSQL = "UPDATE Владельцы SET  Телефон=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 11);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Phone0.Text;
                cmdIC.Parameters[1].Value = NumStr0.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Phone0.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Email0.Text != "")
            {
                String strSQL = "UPDATE Владельцы SET Почта=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 50);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Email0.Text;
                cmdIC.Parameters[1].Value = NumStr0.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Email0.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if(Ok)
            {
                MessageBox.Show("Изменения внесены успешно.");
            }

        }

        private void addBut1_Click(object sender, EventArgs e)
        {
            if (NumStr1.Text == "")
            {
                MessageBox.Show("Введите номер строки.");
                return;
            }
            bool Ok = true;
            if (idTrainer1.Text != "")
            {
                String strSQL = "UPDATE [Закрепление лошадей] SET [id тренера]=? WHERE [id лошади]=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.Integer);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = idTrainer1.Text;
                cmdIC.Parameters[1].Value = NumStr1.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    idTrainer1.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Time1.Text != "")
            {
                String strSQL = "UPDATE [Закрепление лошадей] SET [[Время совместной работы(дни)]]=? WHERE [id лошади]=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.Integer);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Time1.Text;
                cmdIC.Parameters[1].Value = NumStr1.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Time1.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Ok)
            {
                MessageBox.Show("Изменения внесены успешно.");
            }
        }

        private void addBut2_Click(object sender, EventArgs e)
        {
            if (NumStr2.Text == "")
            {
                MessageBox.Show("Введите номер строки.");
                return;
            }
            bool Ok = true;
            if (idStableman2.Text != "")
            {
                String strSQL = "UPDATE [Закрепление стойл] SET [id конюха]=? WHERE [id стойла]=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.Integer);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = idStableman2.Text;
                cmdIC.Parameters[1].Value = NumStr2.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    idStableman2.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Time2.Text != "")
            {
                String strSQL = "UPDATE [Закрепление стойл] SET [Время закрепления(дни)]=? WHERE [id стойла]=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.Integer);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Time2.Text;
                cmdIC.Parameters[1].Value = NumStr2.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Time2.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Ok)
            {
                MessageBox.Show("Изменения внесены успешно.");
            }
        }

        private void addBut3_Click(object sender, EventArgs e)
        {
            if (NumStr3.Text == "")
            {
                MessageBox.Show("Введите номер строки.");
                return;
            }
            bool Ok = true;
            if (FIO3.Text != "")
            {
                String strSQL = "UPDATE Конюхи SET ФИО=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 50);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = FIO3.Text;
                cmdIC.Parameters[1].Value = NumStr3.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    FIO3.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Age3.Text != "")
            {
                String strSQL = "UPDATE Конюхи SET Возраст=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.Integer);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Age3.Text;
                cmdIC.Parameters[1].Value = NumStr3.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Age3.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Phone3.Text != "")
            {
                String strSQL = "UPDATE Конюхи SET Телефон=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 11);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Phone3.Text;
                cmdIC.Parameters[1].Value = NumStr3.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Phone3.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Ok)
            {
                MessageBox.Show("Изменения внесены успешно.");
            }
        }

        private void addBut4_Click(object sender, EventArgs e)
        {
            if (NumStr4.Text == "")
            {
                MessageBox.Show("Введите номер строки.");
                return;
            }
            bool Ok = true;
            if (Name4.Text != "")
            {
                String strSQL = "UPDATE Лошади SET Кличка=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 20);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Name4.Text;
                cmdIC.Parameters[1].Value = NumStr4.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Name4.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Age4.Text != "")
            {
                String strSQL = "UPDATE Лошади SET Возраст=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.Integer);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Age4.Text;
                cmdIC.Parameters[1].Value = NumStr4.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Age4.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Gender4.Text != "")
            {
                String strSQL = "UPDATE Лошади SET Пол=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 1);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Gender4.Text;
                cmdIC.Parameters[1].Value = NumStr4.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Gender4.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Zvanie4.Text != "")
            {
                String strSQL = "UPDATE Лошади SET Звание=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 4);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Zvanie4.Text;
                cmdIC.Parameters[1].Value = NumStr4.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Zvanie4.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Razrad4.Text != "")
            {
                String strSQL = "UPDATE Лошади SET Разряд=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.SmallInt);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Razrad4.Text;
                cmdIC.Parameters[1].Value = NumStr4.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Razrad4.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Owner4.Text != "")
            {
                String strSQL = "UPDATE Лошади SET Владелец=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.Integer);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Owner4.Text;
                cmdIC.Parameters[1].Value = NumStr4.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Owner4.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Data4.Text != "")
            {
                String strSQL = "UPDATE Лошади SET [Дата окончания проживания]=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 10);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Data4.Text;
                cmdIC.Parameters[1].Value = NumStr4.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Data4.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Ok)
            {
                MessageBox.Show("Изменения внесены успешно.");
            }
        }

        private void addBut5_Click(object sender, EventArgs e)
        {
            if (NumStr5.Text == "")
            {
                MessageBox.Show("Введите номер строки.");
                return;
            }
            bool Ok = true;
            if (Sost5.Text != "")
            {
                String strSQL = "UPDATE [Резерв площадок] SET Состояние=? WHERE [id площадки]=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.SmallInt);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Sost5.Text;
                cmdIC.Parameters[1].Value = NumStr5.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Sost5.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Access5.Text != "")
            {
                String strSQL = "UPDATE [Резерв площадок] SET [Доступность]=? WHERE [id площадки]=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.Binary);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Access5.Text;
                cmdIC.Parameters[1].Value = NumStr5.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Access5.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Data5.Text != "")
            {
                String strSQL = "UPDATE [Резерв площадок] SET [Дата последнего резервирования]=? WHERE [id площадки]=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 10);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Data5.Text;
                cmdIC.Parameters[1].Value = NumStr5.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Data5.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Time5.Text != "")
            {
                String strSQL = "UPDATE [Резерв площадок] SET [Время последнего резервирования]=? WHERE [id площадки]=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 5);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Time5.Text;
                cmdIC.Parameters[1].Value = NumStr5.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Time5.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Trainer5.Text != "")
            {
                String strSQL = "UPDATE [Резерв площадок] SET [Последней занимавший тренер]=? WHERE [id площадки]=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.Integer);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Trainer5.Text;
                cmdIC.Parameters[1].Value = NumStr5.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Trainer5.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Ok)
            {
                MessageBox.Show("Изменения внесены успешно.");
            }
        }

        private void addBut6_Click(object sender, EventArgs e)
        {
            if (NumStr6.Text == "")
            {
                MessageBox.Show("Введите номер строки.");
                return;
            }
            bool Ok = true;
            if (Type6.Text != "")
            {
                String strSQL = "UPDATE [Сломанное снаряжение] SET [Тип снаряжения]=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 50);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Type6.Text;
                cmdIC.Parameters[1].Value = NumStr6.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Type6.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (idHorse6.Text != "")
            {
                String strSQL = "UPDATE [Сломанное снаряжение] SET [id лошади]=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.Integer);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = idHorse6.Text;
                cmdIC.Parameters[1].Value = NumStr6.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    idHorse6.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Sost6.Text != "")
            {
                String strSQL = "UPDATE [Сломанное снаряжение] SET [Состояние снаряжения]=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.SmallInt);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Sost6.Text;
                cmdIC.Parameters[1].Value = NumStr6.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Sost6.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Dolzh6.Text != "")
            {
                String strSQL = "UPDATE [Сломанное снаряжение] SET [Должность доложившего]=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 20);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Dolzh6.Text;
                cmdIC.Parameters[1].Value = NumStr6.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Dolzh6.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (idDolzh6.Text != "")
            {
                String strSQL = "UPDATE [Сломанное снаряжение] SET [id доложившего]=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.Integer);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = idDolzh6.Text;
                cmdIC.Parameters[1].Value = NumStr6.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    idDolzh6.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Data6.Text != "")
            {
                String strSQL = "UPDATE [Сломанное снаряжение] SET [Дата обнаружения]=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 10);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Data6.Text;
                cmdIC.Parameters[1].Value = NumStr6.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Data6.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Time6.Text != "")
            {
                String strSQL = "UPDATE [Сломанное снаряжение] SET [Время обнаружения]=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 5);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Time6.Text;
                cmdIC.Parameters[1].Value = NumStr6.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Time6.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Place6.Text != "")
            {
                String strSQL = "UPDATE [Сломанное снаряжение] SET [Место обнаружения]=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 20);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Place6.Text;
                cmdIC.Parameters[1].Value = NumStr6.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Place6.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Ok)
            {
                MessageBox.Show("Изменения внесены успешно.");
            }
        }

        private void addBut7_Click(object sender, EventArgs e)
        {
            if (NumStr7.Text == "")
            {
                MessageBox.Show("Введите номер строки.");
                return;
            }
            bool Ok = true;
            if (Sost7.Text != "")
            {
                String strSQL = "UPDATE Стойла SET [Состояние]=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.SmallInt);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Sost7.Text;
                cmdIC.Parameters[1].Value = NumStr7.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Sost7.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (idHorse7.Text != "")
            {
                String strSQL = "UPDATE Стойла SET [Проживающая лошадь]=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.Integer);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = idHorse7.Text;
                cmdIC.Parameters[1].Value = NumStr7.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    idHorse7.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Ok)
            {
                MessageBox.Show("Изменения внесены успешно.");
            }
        }

        private void addBut8_Click(object sender, EventArgs e)
        {
            if (NumStr8.Text == "")
            {
                MessageBox.Show("Введите номер строки.");
                return;
            }
            bool Ok = true;
            if (FIO8.Text != "")
            {
                String strSQL = "UPDATE [Тренеры] SET [ФИО]=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 50);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = FIO8.Text;
                cmdIC.Parameters[1].Value = NumStr8.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    FIO8.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Age8.Text != "")
            {
                String strSQL = "UPDATE [Тренеры] SET [Возраст]=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.Integer);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Age8.Text;
                cmdIC.Parameters[1].Value = NumStr8.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Age8.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Stazh8.Text != "")
            {
                String strSQL = "UPDATE [Тренеры] SET [Стаж(дни)]=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.Integer);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Stazh8.Text;
                cmdIC.Parameters[1].Value = NumStr8.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Stazh8.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Phone8.Text != "")
            {
                String strSQL = "UPDATE [Тренеры] SET [Телефон]=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 11);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Phone8.Text;
                cmdIC.Parameters[1].Value = NumStr8.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Phone8.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Ok)
            {
                MessageBox.Show("Изменения внесены успешно.");
            }
        }

        private void addBut9_Click(object sender, EventArgs e)
        {
            if (NumStr9.Text == "")
            {
                MessageBox.Show("Введите номер строки.");
                return;
            }
            bool Ok = true;
            if (idHorse9.Text != "")
            {
                String strSQL = "UPDATE [Тренировки] SET [id лошади]=? WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.Integer);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = idHorse9.Text;
                cmdIC.Parameters[1].Value = NumStr9.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    idHorse9.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (idTrainer9.Text != "")
            {
                String strSQL = "UPDATE [Тренировки] SET [id тренера] WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.Integer);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = idTrainer9.Text;
                cmdIC.Parameters[1].Value = NumStr9.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    idTrainer9.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Data9.Text != "")
            {
                String strSQL = "UPDATE [Тренировки] SET [Дата тренировки] WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 11);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Data9.Text;
                cmdIC.Parameters[1].Value = NumStr9.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Data9.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Length9.Text != "")
            {
                String strSQL = "UPDATE [Тренировки] SET [Длительность тренировки(часы)] WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.Integer);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = Length9.Text;
                cmdIC.Parameters[1].Value = NumStr9.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Length9.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (PlaceNum9.Text != "")
            {
                String strSQL = "UPDATE [Тренировки] SET [Номер площадки] WHERE id=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.Integer);
                cmdIC.Parameters.Add("@p2", OleDbType.Integer);

                cmdIC.Parameters[0].Value = PlaceNum9.Text;
                cmdIC.Parameters[1].Value = NumStr9.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    PlaceNum9.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Ok)
            {
                MessageBox.Show("Изменения внесены успешно.");
            }
        }

        private void addBut10_Click(object sender, EventArgs e)
        {
            if (NumStr10.Text == "")
            {
                MessageBox.Show("Введите номер строки.");
                return;
            }
            bool Ok = true;
            if (Werehouse10.Text != "")
            {
                String strSQL = "UPDATE [Экипировка] SET [На складе]=? WHERE [Тип]=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.Integer);
                cmdIC.Parameters.Add("@p2", OleDbType.VarChar, 50);

                cmdIC.Parameters[0].Value = Werehouse10.Text;
                cmdIC.Parameters[1].Value = NumStr10.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Werehouse10.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Used10.Text != "")
            {
                String strSQL = "UPDATE [Экипировка] SET [Используются]=? WHERE [Тип]=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.Integer);
                cmdIC.Parameters.Add("@p2", OleDbType.VarChar, 50);

                cmdIC.Parameters[0].Value = Used10.Text;
                cmdIC.Parameters[1].Value = NumStr10.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Used10.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Repair10.Text != "")
            {
                String strSQL = "UPDATE [Экипировка] SET [Необходим ремонт]=? WHERE [Тип]=?";
                OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

                cmdIC.Parameters.Add("@p1", OleDbType.Integer);
                cmdIC.Parameters.Add("@p2", OleDbType.VarChar, 50);

                cmdIC.Parameters[0].Value = Repair10.Text;
                cmdIC.Parameters[1].Value = NumStr10.Text;
                try
                {
                    cmdIC.ExecuteNonQuery();
                    Repair10.Text = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show(exc.ToString());
                    Ok = false;
                }
            }
            if (Ok)
            {
                MessageBox.Show("Изменения внесены успешно.");
            }
        }
    }
}
