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
            if (txtEmail.Text == "")
                txtEmail.BackColor = Color.Red;
            if (txtLogin.Text == "")
                txtLogin.BackColor = Color.Red;
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
                    MessageBox.Show(json);
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
            if (txtEmail.Text == "")
                txtEmail.BackColor = Color.Red;
            else
                txtEmail.BackColor = Color.White;
            if (txtLogin.Text == "")
                txtLogin.BackColor = Color.Red;
            else
                txtLogin.BackColor = Color.White;
        }
    }
}
