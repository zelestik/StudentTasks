using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УспеваемостьСтудентов
{
    public partial class fmGroupTasks : Form
    {
        public OnlineUser User { get; private set; }
        public List<Task> Tasks { get; set; }
        public fmGroupTasks(OnlineUser user)
        {
            User = user;
            Text += User.Group;
            InitializeComponent();
            RefreshTasks();
        }
        public void RefreshTasks()
        {
            var tc = new TaskCreator();
            Tasks = tc.GetGroupTasks(User.Username, User.Password);
            listView1.Clear();
            if (Tasks != null && Tasks.Count != 0)
            {
                int col_num = 5;
                listView1.Columns.Add("Название", listView1.Width / col_num);
                listView1.Columns.Add("Описание", listView1.Width / col_num);
                listView1.Columns.Add("Сделать до", listView1.Width / col_num);
                listView1.Columns.Add("Тип", listView1.Width / col_num);
                listView1.Columns.Add("Осталось дней", listView1.Width / col_num);
                foreach (var task in Tasks)
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
                    if (daysLeft >= 0)
                        item.SubItems.Add(daysLeft.ToString());
                    else
                        item.SubItems.Add("Время истекло");
                    item.Tag = task;
                    listView1.Items.Add(item);
                }
            }
        }
    }
}
