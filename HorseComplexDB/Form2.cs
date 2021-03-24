using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form2 : Form
    {
        Form1 MainForm_;
        // 0 - Директор
        // 1 - Тренер
        // 2 - Конюх
        int User_;
        public Form2(Form1 MainForm, int User)
        {
            InitializeComponent();
            MainForm_ = MainForm;
            User_ = User;
            if (User_ != 0) FindBut.Enabled = false;
            if(User == 0)
                ComplexDB.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-3TJHR5I\\SQLEXPRESS;Password=admin;User ID=admin;Initial Catalog=HorseComplex";
            else if(User == 1)
                ComplexDB.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-3TJHR5I\\SQLEXPRESS;Password=trainer;User ID=trainer;Initial Catalog=HorseComplex";
            else
                ComplexDB.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-3TJHR5I\\SQLEXPRESS;Password=stableman;User ID=stableman;Initial Catalog=HorseComplex";
            try
            {
                ComplexDB.Open();
                MessageBox.Show("Подключено.", "Подключение", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка подключения к базе. Попробуйте еще раз.", "Подключение", MessageBoxButtons.OK);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            ComplexDB.Close();
            MainForm_.Show();
        }

        private void TablesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool existTable = false;
            foreach (Form tbl in this.MdiChildren)
                if (tbl.Text == TablesBox.SelectedItem.ToString())
                {
                    tbl.Activate();
                    existTable = true;
                    break;
                }
            if (!existTable)
            {
                Form3 table = new Form3(ComplexDB, TablesBox.SelectedItem.ToString(), 0)
                {
                    MdiParent = this
                };
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (TablesBox.SelectedItem == null)
                return;
            bool existTable = false;
            foreach (Form tbl in this.MdiChildren)
                if (tbl.Text == "Удаление строки")
                {
                    tbl.Activate();
                    existTable = true;
                    break;
                }
            if (!existTable)
            {
                Form6 deleteForm = new Form6(TablesBox.SelectedIndex, ComplexDB)
                {
                    MdiParent = this
                };
                deleteForm.Show();
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (TablesBox.SelectedItem == null)
                return;
            bool existTable = false;
            foreach (Form tbl in this.MdiChildren)
                if (tbl.Text == "Изменение строки")
                {
                    tbl.Activate();
                    existTable = true;
                    break;
                }
            if (!existTable)
            {
                Form5 changeForm = new Form5(TablesBox.SelectedIndex, ComplexDB)
                {
                    MdiParent = this
                };
                changeForm.Show();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (TablesBox.SelectedItem == null)
                return;
            bool existTable = false;
            foreach (Form tbl in this.MdiChildren)
                if (tbl.Text == "Добавление строки")
                {
                    tbl.Activate();
                    existTable = true;
                    break;
                }
            if (!existTable)
            {
                Form4 addForm = new Form4(TablesBox.SelectedIndex, ComplexDB)
                {
                    MdiParent = this
                };
                addForm.Show();
            }            
        }

        private void FindBut_Click(object sender, EventArgs e)
        {
            bool existTable = false;
            foreach (Form tbl in this.MdiChildren)
                if (tbl.Text == "Поиск")
                {
                    tbl.Activate();
                    MessageBox.Show("Чтобы снова начать поиск, закройте таблицу поиска.");
                    existTable = true;
                    break;
                }
            if (!existTable)
            {
                Form7 table = new Form7(this, ComplexDB)
                {
                    MdiParent = this
                };
                table.Show();
            }
        }

        private void SelectBut_Click(object sender, EventArgs e)
        {
            Form8 table = new Form8(this, ComplexDB);
            table.Show();
            Enabled = false;
        }
    }
}
