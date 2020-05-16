using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            if (user.Role == 2) //Если Админ - отключаем кнопку добавления задачи
            {
                buNT.Hide();
            }
            this.User = user;
            laWelcome.Text += user.Name;
            listView1.Click += ListView1_Click;
            Refresh_Tasks();

        }

        private void Refresh_Tasks()
        {
            User.Refresh_Tasks();
            listView1.Clear();
            if (User.Tasks != null && User.Tasks.Count != 0)
            {
                int col_num;
                if (User.Role != 2)
                    col_num = 4;
                else//Если админ - появится 5 колонка - название группы
                    col_num = 5;
                listView1.Columns.Add("Название", listView1.Width/col_num);
                listView1.Columns.Add("Описание", listView1.Width/col_num);
                listView1.Columns.Add("Тип", listView1.Width /col_num);
                listView1.Columns.Add("Сделать до", listView1.Width/col_num);
                if (User.Role == 2)
                    listView1.Columns.Add("Группа", listView1.Width/col_num);
                string type;
                foreach (var task in User.Tasks)
                {
                    switch(task.Type)
                    {
                        case 1:
                            type = "Лаб. работа";
                            break;
                        case 2:
                            type = "Домашнее задание";
                            break;
                        default:
                            type = "-";
                            break;
                    }
                    int year = Convert.ToInt32(task.ExpDate / 10000);
                    int month = Convert.ToInt32(task.ExpDate / 100 - year * 100);
                    int day = Convert.ToInt32(task.ExpDate % 100);
                    DateTime expDate = new DateTime(year, month, day);
                    ListViewItem item = new ListViewItem(task.Name, Convert.ToInt32(task.Id));
                    item.SubItems.Add(task.Description);
                    item.SubItems.Add(type);
                    item.SubItems.Add(expDate.ToString("dd.MM.yyyy"));
                    item.SubItems.Add(task.Group);
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
                listView1.Items.Add("У Вас нет задач");
            }
        }
        private void ListView1_Click(object sender, EventArgs e) // Выбор задачи
        {
            Form fm = new fmSelectedItem(listView1.SelectedItems[0]);
            fm.Show();
        }

        private void fmTasks_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buRefresh_Click(object sender, EventArgs e)
        {
            Refresh_Tasks();
        }

        private void buAbout_Click(object sender, EventArgs e) 
        {
            Form fm = new fmAbout(User);
            fm.Show();
            //var msg = User.Name + "\n" + User.Group;
            //if (User.Role == 0)
            //    msg += "\nСтудент";
            //else if (User.Role == 1)
            //    msg += "\nСтароста";
            //else if (User.Role == 2)
            //    msg += "\nАдминистратор";
            //MessageBox.Show(msg);
        }

        private void buNT_Click(object sender, EventArgs e)
        {
            Form fm = new fmNewTask(User);
            fm.Show();
        }
    }
}
