using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
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
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private void buLogin_Click(object sender, EventArgs e)
        {
            if (!cbOffline.Checked)
            {
                if (tbUser.Text != "" && tbPass.Text != "")
                {
                    var user = new OnlineUser(tbUser.Text.ToLower(new CultureInfo("en-US", false)), tbPass.Text);
                    var a = user.LoginUser();
                    if (a == 1) //Успешный вход
                    {
                        Form fmTasks = new fmTasks(user);
                        this.Hide();
                        fmTasks.Show();
                    }
                    else if (a == -1)
                        MessageBox.Show("Неверный логин или пароль");
                    else if (a == -2)
                        MessageBox.Show("Возникла ошибка сервера, проверьте подключение к интернету и доступность сервера");
                }
                else
                    MessageBox.Show("Имя пользователя или пароль не могут быть пустыми");
            }
            else
            {
                try
                {
                    string username = File.ReadAllText(@"User");
                    
                    var res = MessageBox.Show("Найдены задачи пользователя " + username + "\nПродолжить?", "Подтвердите действие", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        var user = new OfflineUser(username);
                        Form fmTasks = new fmTasks(user);
                        this.Hide();
                        fmTasks.Show();
                    }
                }
                catch
                {
                    MessageBox.Show("Файл сохранения не найден");
                }

            }
        }

        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buLogin_Click(sender, e);
        }

        private void cbOffline_CheckedChanged(object sender, EventArgs e)
        {
            tbUser.Enabled = !tbUser.Enabled;
            tbPass.Enabled = !tbPass.Enabled;
        }
    }
}
