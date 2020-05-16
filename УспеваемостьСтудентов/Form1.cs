using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УспеваемостьСтудентов
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buLogin_Click(object sender, EventArgs e)
        {
            if (tbUser.Text != "" && tbPass.Text != "")
            {
                User user = new User(tbUser.Text.ToLower(new CultureInfo("en-US", false)), tbPass.Text); 
                string a = user.LoginUser();
                if (a == "1") //Успешный вход
                {
                    Form fmTasks = new fmTasks(user);
                    this.Hide();
                    fmTasks.Show();
                }
                else if (a == "-1")
                    MessageBox.Show("Неверный логин или пароль");
                else if (a == "-2")
                    MessageBox.Show("Возникла ошибка сервера, проверьте подключение к интернету и доступность сервера");
            }
            else
                MessageBox.Show("Имя пользователя или пароль не могут быть пустыми");
        }

        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buLogin_Click(sender, e);
        }
    }
}
