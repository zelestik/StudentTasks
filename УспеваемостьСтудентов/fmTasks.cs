using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УспеваемостьСтудентов
{
    public partial class fmTasks : Form
    {
        public User User { get; private set; }
        public fmTasks(User user)
        {
            InitializeComponent();
            User = user;
            if (User is OnlineUser u)
            {
                if (u.Role == 2) //Если Админ - отключаем кнопку добавления задачи
                    buNT.Hide();
                if (u.Group == null)
                    buGroup.Hide();
                laWelcome.Text += u.Name;
            }
            else
            {
                buGroup.Hide();
                buAbout.Hide();
                laWelcome.Text = "Оффлайн режим";
            }
            listView1.FullRowSelect = true;
            listView1.MouseClick += new MouseEventHandler(ListView1_Click);
            Refresh_Tasks();

        }

        private void Refresh_Tasks()
        {
            if (User is OnlineUser u_on)
                u_on.RefreshTasks();
            else if (User is OfflineUser u_off)
                u_off.RefreshTasks();
            listView1.Clear();
            if (User.Tasks != null && User.Tasks.Count != 0)
            {
                int col_num = 6;
                listView1.Columns.Add("Название", listView1.Width/col_num);
                listView1.Columns.Add("Описание", listView1.Width/col_num);
                listView1.Columns.Add("Сделать до", listView1.Width / col_num);
                listView1.Columns.Add("Тип", listView1.Width / col_num);
                if (User is OnlineUser u && u.Role == 2)
                    listView1.Columns.Add("Группа", listView1.Width / col_num);
                else
                {
                    listView1.Columns.Add("Статус", listView1.Width / col_num);
                    listView1.Columns.Add("Осталось дней", listView1.Width / col_num);
                }
                foreach (var task in User.Tasks)
                {
                    int year = Convert.ToInt32(task.ExpirationDate / 10000);
                    int month = Convert.ToInt32(task.ExpirationDate / 100 - year * 100);
                    int day = Convert.ToInt32(task.ExpirationDate % 100);
                    DateTime expDate = new DateTime(year, month, day);
                    int daysLeft = (expDate - DateTime.Now).Days;
                    ListViewItem item = new ListViewItem(task.Name, Convert.ToInt32(task.Id));
                    item.SubItems.Add(task.Description);
                    item.SubItems.Add(expDate.ToString("dd.MM.yyyy"));
                    item.SubItems.Add(task.Type);
                    if (User is OnlineUser u_on1 && u_on1.Role == 2) // Для админа добавляем поле Группа
                    {
                        item.SubItems.Add(task.Group);
                    }
                    else //Для остальных пользователей - поле с количеством оставшихся дней
                    {
                        item.SubItems.Add(task.Status);
                        if (daysLeft >= 0)
                            item.SubItems.Add(daysLeft.ToString());
                        else
                            item.SubItems.Add("Время истекло");
                    }
                    item.Tag = task;
                    listView1.Items.Add(item);
                }
            }
            else if (User.Tasks is null) // Если при получении задач получили Null - возникла ошибка при получении данных
            {
                MessageBox.Show("Возникла ошибка сервера, проверьте подключение к интернету и доступность сервера, приложение будет закрыто");
                Application.Exit();
            }
            else // Если задач нет
            {
                listView1.Columns.Add("", -2, HorizontalAlignment.Left);
                ListViewItem item = new ListViewItem("У Вас нет задач");
                item.Tag = "NOTASK";
                listView1.Items.Add(item);
            }
        }
        private void ListView1_Click(object sender, MouseEventArgs e) // Выбор задачи
        {
            if (e.Button == MouseButtons.Left)
            {
                if (listView1.SelectedItems[0].Tag.ToString() != "NOTASK")
                {
                    Form fm = new fmSelectedItem(listView1.SelectedItems[0], User);
                    fm.Show();
                }
            }
        }

        private void fmTasks_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (User is OnlineUser u && u.Role != 2) //Если онлайн пользователь и не админ
            {
                var res = MessageBox.Show("Сохранить задачи на компьютер? \nВы сможете продолжить работу оффлайн", "Подтвердите действие", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    var db = new Local_db();
                    db.saveTasks(u);
                    File.WriteAllText(@"User", User.Username);
                }
            }
            Application.Exit();
        }

        private void buRefresh_Click(object sender, EventArgs e)
        {
            Refresh_Tasks();
        }

        private void buAbout_Click(object sender, EventArgs e) 
        {
            if (User is OnlineUser u)
            {
                Form fm = new fmAbout(u);
                fm.Show();
            }
        }

        private void buNT_Click(object sender, EventArgs e)
        {
            Form fm = new fmNewTask(User);
            fm.Show();
        }

        private void buGroup_Click(object sender, EventArgs e)
        {
            if (User is OnlineUser u && u.Group != null)
            {
                Form fm = new fmGroupTasks(u);
                fm.Show();
            }
        }
    }
}
