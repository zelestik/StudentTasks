using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace УспеваемостьСтудентов
{
    public partial class fmNewTask : Form
    {
        public User User { get; private set; }
        public fmNewTask(User user)
        {
            this.User = user;
            InitializeComponent();
            if (User.Role != 1) //Если не староста - убираем checkBox групповой задачи
            {
                cbGroup.Checked = false;
                cbGroup.Hide();
            }
        }

        private void buAdd_Click(object sender, EventArgs e)
        {
            var task = new Task(textBox2.Text, 0, textBox1.Text, 0, 0);
            string output = JsonConvert.SerializeObject(task);
            var con = new Connection();
            var res = con.post($"post_tasks/{User.Username}/{User.Password}", output);
            if (res == "0")
            {
                MessageBox.Show("Успешно");
                this.Close();
            }
            else
            {
                MessageBox.Show("Возникла ошибка при передаче данных " + res);
            }

        }
    }
}
