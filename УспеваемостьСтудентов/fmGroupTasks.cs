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
            lvGroupTasks.Clear();
            if (Tasks != null && Tasks.Count != 0)
            {
                int col_num = 6;
                lvGroupTasks.Columns.Add("Название", lvGroupTasks.Width / col_num);
                lvGroupTasks.Columns.Add("Описание", lvGroupTasks.Width / col_num);
                lvGroupTasks.Columns.Add("Сделать до", lvGroupTasks.Width / col_num);
                lvGroupTasks.Columns.Add("Тип", lvGroupTasks.Width / col_num);
                lvGroupTasks.Columns.Add("Осталось дней", lvGroupTasks.Width / col_num);
                lvGroupTasks.Columns.Add("Создано", lvGroupTasks.Width / col_num);
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
                    year = Convert.ToInt32(task.CreationDate / 10000);
                    month = Convert.ToInt32(task.CreationDate / 100 - year * 100);
                    day = Convert.ToInt32(task.CreationDate % 100);
                    var creationDate = new DateTime(year, month, day);
                    item.SubItems.Add(creationDate.ToString("dd.MM.yyyy"));
                    item.Tag = task;
                    lvGroupTasks.Items.Add(item);
                }
                btnToPersonal.Visible = false;
                btnCancel.Visible = false;
            }
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            var isChecked = false;
            foreach (var item in lvGroupTasks.CheckedItems)
                isChecked = true;
            if (isChecked)
            {
                btnToPersonal.Visible = true;
                btnCancel.Visible = true;
            }
            else
            {
                btnToPersonal.Visible = false;
                btnCancel.Visible = false;
            }
        }
    }
}
