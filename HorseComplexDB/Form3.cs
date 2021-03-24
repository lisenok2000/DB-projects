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
    public partial class Form3 : Form
    {
        private OleDbDataAdapter da;
        int whatFunc_;
        public Form3(OleDbConnection ComplexDB, string tableName, int whatFunc)
        {
            InitializeComponent();
            whatFunc_ = whatFunc;
            switch(whatFunc)
            {
                case 0:
                    try
                    {
                        da = new OleDbDataAdapter("SELECT * FROM " + "[" + tableName + "]", ComplexDB);
                        DataTable table = new DataTable(tableName);
                        Text = tableName;
                        tableSet.Tables.Add(table);
                        tablesView.DataSource = tableSet.Tables[tableName];
                        da.Fill(tableSet, tableName);
                        Show();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("У вас нет доступа к этой таблице.", "Таблица", MessageBoxButtons.OK);
                        Close();
                    }
                    break;
                case 1:
                    if (tableName == "") return;
                    try
                    {
                        da = new OleDbDataAdapter("FindWorker " + "[" + tableName + "]", ComplexDB);
                        DataTable table = new DataTable("Поиск");
                        Text = "Поиск";
                        table.Columns.Add("id", typeof(int));
                        table.Columns.Add("ФИО", typeof(string));
                        table.Columns.Add("Возраст", typeof(int));
                        table.Columns.Add("Телефон", typeof(string));
                        tableSet.Tables.Add(table);
                        tablesView.DataSource = tableSet.Tables["Поиск"];

                        da.Fill(tableSet, "Поиск");
                        tableSet.Tables["Поиск"].Columns[4].ColumnName = "Должность";
                        Show();
                    }
                    catch (OleDbException exc)
                    {
                        MessageBox.Show(exc.ToString());
                        Close();
                    }
                    break;
                case 2:
                    try
                    {
                        da = new OleDbDataAdapter("FindPlainsInUse", ComplexDB);
                        DataTable table = new DataTable("Недоступные площадки");
                        Text = "Недоступные площадки";
                        tableSet.Tables.Add(table);
                        tablesView.DataSource = tableSet.Tables["Недоступные площадки"];

                        da.Fill(tableSet, "Недоступные площадки");
                        Show();
                    }
                    catch (OleDbException exc)
                    {
                        MessageBox.Show(exc.ToString());
                        Close();
                    }
                    break;
                case 3:
                    try
                    {
                        da = new OleDbDataAdapter("FindBadPerson", ComplexDB);
                        DataTable table = new DataTable("Список поломок у работников");
                        Text = "Список поломок у работников";
                        tableSet.Tables.Add(table);
                        tablesView.DataSource = tableSet.Tables["Список поломок у работников"];

                        da.Fill(tableSet, "Список поломок у работников");
                        Show();
                    }
                    catch (OleDbException exc)
                    {
                        MessageBox.Show(exc.ToString());
                        Close();
                    }
                    break;
                case 4:
                    try
                    {
                        da = new OleDbDataAdapter("FindBadHorse", ComplexDB);
                        DataTable table = new DataTable("Список поломок у лошадей");
                        Text = "Список поломок у лошадей";
                        tableSet.Tables.Add(table);
                        tablesView.DataSource = tableSet.Tables["Список поломок у лошадей"];

                        da.Fill(tableSet, "Список поломок у лошадей");
                        Show();
                    }
                    catch (OleDbException exc)
                    {
                        MessageBox.Show(exc.ToString());
                        Close();
                    }
                    break;
                case 5:
                    try
                    {
                        da = new OleDbDataAdapter("FindAllTrainesForHorses", ComplexDB);
                        DataTable table = new DataTable("Общие тренировки");
                        Text = "Общие тренировки";
                        tableSet.Tables.Add(table);
                        tablesView.DataSource = tableSet.Tables["Общие тренировки"];

                        da.Fill(tableSet, "Общие тренировки");
                        Show();
                    }
                    catch (OleDbException exc)
                    {
                        MessageBox.Show(exc.ToString());
                        Close();
                    }
                    break;
                case 6:
                    try
                    {
                        da = new OleDbDataAdapter("FindHorsesWithoutStables", ComplexDB);
                        DataTable table = new DataTable("Лошади без места простоя");
                        Text = "Лошади без места простоя";
                        tableSet.Tables.Add(table);
                        tablesView.DataSource = tableSet.Tables["Лошади без места простоя"];

                        da.Fill(tableSet, "Лошади без места простоя");
                        Show();
                    }
                    catch (OleDbException exc)
                    {
                        MessageBox.Show(exc.ToString());
                        Close();
                    }
                    break;
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(whatFunc_ == 1)
            {
                tableSet.Tables.Remove("Поиск");
            }
        }
    }
}
