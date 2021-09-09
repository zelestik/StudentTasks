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
using System.Threading;
using System.Net;

namespace StudentTasks
{
    public partial class fmRegistration : Form
    {
        
        
        public fmRegistration()
        {
            InitializeComponent();
        }


        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtFIO.Text != "" && txtPassword.Text != "" && txtUserName.Text != "")
            {
                Connection con = new Connection();
                string str = JsonSerializer.Serialize(new UserToAdd("", txtFIO.Text, txtEmail.Text, txtUserName.Text, txtPassword.Text, 0));
                con.PostJSON("reg", str);
                if (con.Status == 1)
                {
                    MessageBox.Show("Запрос на регистрацию отправлен", "Запрос отправлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                    MessageBox.Show("Возникла ошибка при регистрации. Возможно введённый email или username заняты или возникла ошибка сервера", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
