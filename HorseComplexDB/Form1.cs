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
    public partial class Form1 : Form
    {
        string[] Logins = new string[3];
        public Form1()
        {
            InitializeComponent();
            Logins[0] = "admin";
            Logins[1] = "trainer";
            Logins[2] = "stableman";
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            int i;
            bool RightLogin = false;
            for(i = 0; i < 3; i++)
            {
                if(LoginBox.Text == Logins[i] && PaswordBox.Text == Logins[i])
                {
                    RightLogin = true;
                    break;
                }
            }
            PaswordBox.Text = "";
            if (RightLogin)
            {
                Form2 secondForm = new Form2(this, i);
                secondForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверно введен логин или пароль", "Авторизация", MessageBoxButtons.OK);
            }
        }
    }
}
