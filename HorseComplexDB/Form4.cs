using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Client
{
    public partial class Form4 : Form
    {
        int SelectedTab_;
        OleDbConnection ComplexDB_;
        public Form4(int SelectedTab, OleDbConnection ComplexDB)
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
            String strSQL = "INSERT INTO Владельцы (ФИО, Телефон, Почта) VALUES (?, ?, ?)";
            OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

            cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 50);
            cmdIC.Parameters.Add("@p2", OleDbType.VarChar, 11);
            cmdIC.Parameters.Add("@p3", OleDbType.VarChar, 50);

            cmdIC.Parameters[0].Value = FIO0.Text;
            if(Phone0.Text == "")
                cmdIC.Parameters[1].Value = null;
            else
                cmdIC.Parameters[1].Value = Phone0.Text;
            if (Email0.Text == "")
                cmdIC.Parameters[2].Value = null;
            else
                cmdIC.Parameters[2].Value = Email0.Text;

            try
            {
                cmdIC.ExecuteNonQuery();
                MessageBox.Show("Добавление прошло успешно!");

                FIO0.Text = "";
                Phone0.Text = "";
                Email0.Text = "";
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void addBut1_Click(object sender, EventArgs e)
        {
            String strSQL = "INSERT INTO [Закрепление лошадей] ([id лошади], [id тренера], [Время совместной работы(дни)]) VALUES (?, ?, ?)";
            OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

            cmdIC.Parameters.Add("@p1", OleDbType.Integer);
            cmdIC.Parameters.Add("@p2", OleDbType.Integer);
            cmdIC.Parameters.Add("@p3", OleDbType.Integer);

            cmdIC.Parameters[0].Value = idHorse1.Text;
            cmdIC.Parameters[1].Value = idTrainer1.Text;
            if (Time1.Text == "")
                cmdIC.Parameters[2].Value = null;
            else
                cmdIC.Parameters[2].Value = Time1.Text;

            try
            {
                cmdIC.ExecuteNonQuery();
                MessageBox.Show("Добавление прошло успешно!");

                idHorse1.Text = "";
                idTrainer1.Text = "";
                Time1.Text = "";
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void addBut2_Click(object sender, EventArgs e)
        {
            String strSQL = "INSERT INTO [Закрепление стойл] ([id стойла], [id конюха], [Время закрепления(дни)]) VALUES (?, ?, ?)";
            OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

            cmdIC.Parameters.Add("@p1", OleDbType.Integer);
            cmdIC.Parameters.Add("@p2", OleDbType.Integer);
            cmdIC.Parameters.Add("@p3", OleDbType.Integer);

            cmdIC.Parameters[0].Value = idStable2.Text;
            cmdIC.Parameters[1].Value = idStableman2.Text;
            if (Time2.Text == "")
                cmdIC.Parameters[2].Value = null;
            else
                cmdIC.Parameters[2].Value = Time2.Text;

            try
            {
                cmdIC.ExecuteNonQuery();
                MessageBox.Show("Добавление прошло успешно!");

                idStable2.Text = "";
                idStableman2.Text = "";
                Time2.Text = "";
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void addBut3_Click(object sender, EventArgs e)
        {
            String strSQL = "INSERT INTO Конюхи (ФИО, Возраст, Телефон) VALUES (?, ?, ?)";
            OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

            cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 50);
            cmdIC.Parameters.Add("@p2", OleDbType.Integer);
            cmdIC.Parameters.Add("@p3", OleDbType.VarChar, 11);

            cmdIC.Parameters[0].Value = FIO3.Text;
            if (Age3.Text == "")
                cmdIC.Parameters[1].Value = null;
            else
                cmdIC.Parameters[1].Value = Age3.Text;
            if (Phone3.Text == "")
                cmdIC.Parameters[2].Value = null;
            else
                cmdIC.Parameters[2].Value = Phone3.Text;

            try
            {
                cmdIC.ExecuteNonQuery();
                MessageBox.Show("Добавление прошло успешно!");

                FIO3.Text = "";
                Age3.Text = "";
                Phone3.Text = "";
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void addBut4_Click(object sender, EventArgs e)
        {
            String strSQL = "INSERT INTO Лошади (Кличка, Пол, Возраст, Звание, Разряд, Владелец, [Дата окончания проживания]) VALUES (?, ?, ?, ?, ?, ?, ?)";
            OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

            cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 20);
            cmdIC.Parameters.Add("@p2", OleDbType.VarChar, 1);
            cmdIC.Parameters.Add("@p3", OleDbType.Integer);
            cmdIC.Parameters.Add("@p4", OleDbType.VarChar, 4);
            cmdIC.Parameters.Add("@p5", OleDbType.SmallInt);
            cmdIC.Parameters.Add("@p6", OleDbType.Integer);
            cmdIC.Parameters.Add("@p7", OleDbType.VarChar, 10);

            cmdIC.Parameters[0].Value = Name4.Text;
            cmdIC.Parameters[1].Value = Gender4.Text;
            cmdIC.Parameters[2].Value = Age4.Text;
            if (Zvanie4.Text == "")
                cmdIC.Parameters[3].Value = null;
            else
                cmdIC.Parameters[3].Value = Zvanie4.Text;
            if (Razrad4.Text == "")
                cmdIC.Parameters[4].Value = null;
            else
                cmdIC.Parameters[4].Value = Razrad4.Text;
            cmdIC.Parameters[5].Value = Owner4.Text;
            cmdIC.Parameters[6].Value = Data4.Text;

            try
            {
                cmdIC.ExecuteNonQuery();
                MessageBox.Show("Добавление прошло успешно!");

                Name4.Text = "";
                Gender4.Text = "";
                Age4.Text = "";
                Zvanie4.Text = "";
                Razrad4.Text = "";
                Owner4.Text = "";
                Data4.Text = "";
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void addBut5_Click(object sender, EventArgs e)
        {
            String strSQL = "INSERT INTO [Резерв площадок] (Состояние, Доступность, [Дата последнего резервирования], [Время последнего резервирования], [Последний занимавший тренер]) VALUES (?, ?, ?, ?, ?)";
            OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

            cmdIC.Parameters.Add("@p1", OleDbType.SmallInt);
            cmdIC.Parameters.Add("@p2", OleDbType.Binary);
            cmdIC.Parameters.Add("@p3", OleDbType.VarChar, 10);
            cmdIC.Parameters.Add("@p4", OleDbType.VarChar, 5);
            cmdIC.Parameters.Add("@p5", OleDbType.Integer);

            cmdIC.Parameters[0].Value = Sost5.Text;
            cmdIC.Parameters[1].Value = Access5.Text;
            if (Data5.Text == "")
                cmdIC.Parameters[2].Value = null;
            else
                cmdIC.Parameters[2].Value = Data5.Text;
            if (Time5.Text == "")
                cmdIC.Parameters[3].Value = null;
            else
                cmdIC.Parameters[3].Value = Time5.Text;
            if (Trainer5.Text == "")
                cmdIC.Parameters[4].Value = null;
            else
                cmdIC.Parameters[4].Value = Trainer5.Text;

            try
            {
                cmdIC.ExecuteNonQuery();
                MessageBox.Show("Добавление прошло успешно!");

                Sost5.Text = "";
                Access5.Text = "";
                Data5.Text = "";
                Time5.Text = "";
                Trainer5.Text = "";
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void addBut6_Click(object sender, EventArgs e)
        {
            String strSQL = "INSERT INTO [Сломанное снаряжение] ([Тип снаряжения], [Должность доложившего], [id доложившего], [Дата обнаружения], [Время обнаружения], [Место обнаружения], [id лошади], [Состояние снаряжения]) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
            OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

            cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 50);
            cmdIC.Parameters.Add("@p2", OleDbType.VarChar, 20);
            cmdIC.Parameters.Add("@p3", OleDbType.Integer);
            cmdIC.Parameters.Add("@p4", OleDbType.VarChar, 10);
            cmdIC.Parameters.Add("@p5", OleDbType.VarChar, 5);
            cmdIC.Parameters.Add("@p6", OleDbType.VarChar, 20);
            cmdIC.Parameters.Add("@p7", OleDbType.Integer);
            cmdIC.Parameters.Add("@p8", OleDbType.SmallInt);

            cmdIC.Parameters[0].Value = Type6.Text;
            cmdIC.Parameters[1].Value = Dolzh6.Text;
            cmdIC.Parameters[2].Value = idDolzh6.Text;
            cmdIC.Parameters[3].Value = Data6.Text;
            cmdIC.Parameters[4].Value = Time6.Text;
            cmdIC.Parameters[5].Value = Place6.Text;
            if (idHorse6.Text == "")
                cmdIC.Parameters[6].Value = null;
            else
                cmdIC.Parameters[6].Value = idHorse6.Text;
            cmdIC.Parameters[7].Value = Sost6.Text;

            try
            {
                cmdIC.ExecuteNonQuery();
                MessageBox.Show("Добавление прошло успешно!");

                Type6.Text = "";
                Dolzh6.Text = "";
                idDolzh6.Text = "";
                Data6.Text = "";
                Time6.Text = "";
                Place6.Text = "";
                idHorse6.Text = "";
                Sost6.Text = "";
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void addBut7_Click(object sender, EventArgs e)
        {
            String strSQL = "INSERT INTO Стойла ([Состояние], [Проживающая лошадь]) VALUES (?, ?)";
            OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

            cmdIC.Parameters.Add("@p1", OleDbType.SmallInt);
            cmdIC.Parameters.Add("@p2", OleDbType.Integer);

            cmdIC.Parameters[0].Value = Sost7.Text;
            if (idHorse7.Text == "")
                cmdIC.Parameters[1].Value = null;
            else
                cmdIC.Parameters[1].Value = idHorse7.Text;

            try
            {
                cmdIC.ExecuteNonQuery();
                MessageBox.Show("Добавление прошло успешно!");

                Sost7.Text = "";
                idHorse7.Text = "";
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void addBut8_Click(object sender, EventArgs e)
        {
            String strSQL = "INSERT INTO [Тренеры] ([ФИО], [Возраст], [Стаж(дни)], [Телефон]) VALUES (?, ?, ?, ?)";
            OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

            cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 50);
            cmdIC.Parameters.Add("@p2", OleDbType.Integer);
            cmdIC.Parameters.Add("@p3", OleDbType.Integer);
            cmdIC.Parameters.Add("@p4", OleDbType.VarChar, 11);

            cmdIC.Parameters[0].Value = FIO8.Text;
            cmdIC.Parameters[1].Value = Age8.Text;
            if (Stazh8.Text == "")
                cmdIC.Parameters[2].Value = null;
            else
                cmdIC.Parameters[2].Value = Stazh8.Text;
            if (Phone8.Text == "")
                cmdIC.Parameters[3].Value = null;
            else
                cmdIC.Parameters[3].Value = Phone8.Text;

            try
            {
                cmdIC.ExecuteNonQuery();
                MessageBox.Show("Добавление прошло успешно!");

                FIO8.Text = "";
                Age8.Text = "";
                Stazh8.Text = "";
                Phone8.Text = "";
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void addBut9_Click(object sender, EventArgs e)
        {
            String strSQL = "INSERT INTO [Тренировки] ([id лошади], [id тренера], [Дата тренировки], [Длительность тренировки(часы)], [Номер площадки]) VALUES (?, ?, ?, ?, ?)";
            OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

            cmdIC.Parameters.Add("@p1", OleDbType.Integer);
            cmdIC.Parameters.Add("@p2", OleDbType.Integer);
            cmdIC.Parameters.Add("@p3", OleDbType.VarChar, 10);
            cmdIC.Parameters.Add("@p4", OleDbType.Double);
            cmdIC.Parameters.Add("@p5", OleDbType.Integer);

            cmdIC.Parameters[0].Value = idHorse9.Text;
            cmdIC.Parameters[1].Value = idTrainer9.Text;
            cmdIC.Parameters[2].Value = Data9.Text;
            cmdIC.Parameters[3].Value = Length9.Text;
            cmdIC.Parameters[4].Value = PlaceNum9.Text;

            try
            {
                cmdIC.ExecuteNonQuery();
                MessageBox.Show("Добавление прошло успешно!");

                idHorse9.Text = "";
                idTrainer9.Text = "";
                Data9.Text = "";
                Length9.Text = "";
                PlaceNum9.Text = "";
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void addBut10_Click(object sender, EventArgs e)
        {
            String strSQL = "INSERT INTO [Экипировка] ([Тип], [На складе], [Используются], [Необходим ремонт]) VALUES (?, ?, ?, ?)";
            OleDbCommand cmdIC = new OleDbCommand(strSQL, ComplexDB_);

            cmdIC.Parameters.Add("@p1", OleDbType.VarChar, 50);
            cmdIC.Parameters.Add("@p2", OleDbType.Integer);
            cmdIC.Parameters.Add("@p3", OleDbType.Integer);
            cmdIC.Parameters.Add("@p4", OleDbType.Integer);

            cmdIC.Parameters[0].Value = Type10.Text;
            cmdIC.Parameters[1].Value = Werehouse10.Text;
            cmdIC.Parameters[2].Value = Used10.Text;
            cmdIC.Parameters[3].Value = Repair10.Text;

            try
            {
                cmdIC.ExecuteNonQuery();
                MessageBox.Show("Добавление прошло успешно!");

                Type10.Text = "";
                Werehouse10.Text = "";
                Used10.Text = "";
                Repair10.Text = "";
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
