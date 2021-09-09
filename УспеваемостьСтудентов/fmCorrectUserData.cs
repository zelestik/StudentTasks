using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace StudentTasks
{
    public partial class fmCorrectUserData : Form
    {
        public List<UserToAdd> Users { get; private set; }
        public int IdRole;
        public fmTasks FM;
        public fmCorrectUserData(string firstname, string secondName, string email, string password, string login, int idRole, fmTasks fm)
        {
            InitializeComponent();
            txtFirstName.Text = firstname;
            txtSecondName.Text = secondName;
            txtEmail.Text = email;
            txtPassword.Text = password;
            txtLogin.Text = login;
            IdRole = idRole;
            FM = fm;
        }

        private void buNotAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSecondName.Text != "" && txtEmail.Text != "" && txtPassword.Text != "" && txtLogin.Text != "")
            {
                var con = new Connection();
                con.GetJSON("check_email_login/" + txtLogin.Text + "/" + txtEmail.Text);
                var user = new UserToAdd(txtFirstName.Text, txtSecondName.Text, txtEmail.Text, txtLogin.Text, txtPassword.Text, IdRole);
                string json = JsonSerializer.Serialize(user);
                if (con.Status == 0)
                {
                    con.PostJSON("reg", json);
                    if (con.Status == 1)
                    {
                        FM.countAddedUsers++;
                        this.Close();
                    }
                    else
                        MessageBox.Show("Какая-то ошибка");
                }
                else if (con.Status == 1)
                {
                    txtLogin.Text = "";
                    textBox_TextChanged(txtLogin, new EventArgs());
                }
                else if (con.Status == 2)
                {
                    txtEmail.Text = "";
                    textBox_TextChanged(txtEmail, new EventArgs());
                }
                else if (con.Status == 3)
                {
                    txtLogin.Text = "";
                    textBox_TextChanged(txtLogin, new EventArgs());
                    txtEmail.Text = "";
                    textBox_TextChanged(txtEmail, new EventArgs());
                }
            }

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            this.Invalidate();   
        }

        private void fmCorrectUserData_Paint(object sender, PaintEventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.BorderStyle = BorderStyle.None;
                Pen p = new Pen(Color.Red);
                Graphics g = e.Graphics;
                int variance = 3;
                g.DrawRectangle(p, new Rectangle(txtEmail.Location.X - variance, txtEmail.Location.Y - variance, txtEmail.Width + variance, txtEmail.Height + variance));
            }
            else
                txtEmail.BackColor = Color.White;
            if (txtLogin.Text == "")
            {
                txtLogin.BorderStyle = BorderStyle.None;
                Pen p = new Pen(Color.Red);
                Graphics g = e.Graphics;
                int variance = 3;
                g.DrawRectangle(p, new Rectangle(txtLogin.Location.X - variance, txtLogin.Location.Y - variance, txtLogin.Width + variance, txtLogin.Height + variance));
            }
            else
                txtLogin.BackColor = Color.White;
            if (txtSecondName.Text == "")
            {
                txtSecondName.BorderStyle = BorderStyle.None;
                Pen p = new Pen(Color.Red);
                Graphics g = e.Graphics;
                int variance = 3;
                g.DrawRectangle(p, new Rectangle(txtSecondName.Location.X - variance, txtSecondName.Location.Y - variance, txtSecondName.Width + variance, txtSecondName.Height + variance));
            }
            else
                txtSecondName.BackColor = Color.White;
            if (txtPassword.Text == "")
            {
                txtPassword.BorderStyle = BorderStyle.None;
                Pen p = new Pen(Color.Red);
                Graphics g = e.Graphics;
                int variance = 3;
                g.DrawRectangle(p, new Rectangle(txtPassword.Location.X - variance, txtPassword.Location.Y - variance, txtPassword.Width + variance, txtPassword.Height + variance));
            }
            else
                txtPassword.BackColor = Color.White;

        }

        private void btnSaveAbsolute_Click(object sender, EventArgs e)
        {
            if (txtSecondName.Text != "" && txtEmail.Text != "" && txtPassword.Text != "" && txtLogin.Text != "")
            {
                var res = MessageBox.Show("При принудительном сохранении уникальность email и логина не проверяется. " +
                "Зарегистрированные пользователи с дублирующими email или логинами будут заблокированы, а новый пользователь будет добавлен в стоп-лист. " +
                "Продолжить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    var con = new Connection();
                    var user = new UserToAdd(txtFirstName.Text, txtSecondName.Text, txtEmail.Text, txtLogin.Text, txtPassword.Text, IdRole);
                    string json = JsonSerializer.Serialize(user);
                    con.PostJSON("reg", json);
                    if (con.Status == 1)
                    {
                        FM.countAddedUsers++;
                        this.Close();
                    }
                    else
                        MessageBox.Show("Какая-то ошибка");
                }
            }
            else
            {
                MessageBox.Show("Обязательные поля должны быть заполнены", "Проверьте запонение полей", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
