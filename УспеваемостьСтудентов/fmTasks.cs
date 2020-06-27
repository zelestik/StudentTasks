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

namespace StudentTasks
{
    public partial class fmTasks : Form
    {
        public User User { get; private set; }
        private ListViewColumnSorter lvwColumnSorter;
        public fmTasks(User user)
        {
            InitializeComponent();
            // Экземпляр класса сортировщика listview
            lvwColumnSorter = new ListViewColumnSorter();
            this.lvTasks.ListViewItemSorter = lvwColumnSorter;
            User = user;
            if (User is OnlineUser u)
            {
                if (u.Role == 2)
                { //Если Админ - отключаем кнопку добавления задачи, фильтры и checkBox
                    btnNewTask.Hide();
                    cboFilterByStatus.Hide();
                    cboFilterByType.Hide();
                    lvTasks.CheckBoxes = false;
                }
                if (u.Group == null) // Если не пользователь не состоит в группе - скрывае кнопку перехода в групповые задачи
                    btnGroupTasks.Hide();
                lblWelcome.Text += u.Name;
            }
            else // Особые настройки для оффлайн пользователей
            {
                btnGroupTasks.Hide();
                btnAboutMe.Hide();
                lblWelcome.Text = "Оффлайн режим";
            }
            lvTasks.FullRowSelect = true;
            RefreshTasks();
            listView1_ColumnClick(lvTasks, new ColumnClickEventArgs(2));
            // Заполнение комбоксов фильтров
            cboFilterByStatus.Items.Add("Все статусы");
            cboFilterByStatus.Items.Add("Созданные");
            cboFilterByStatus.Items.Add("В работе");
            cboFilterByStatus.Items.Add("Выполненные");
            cboFilterByStatus.Items.Add("Все невыполненные");
            cboFilterByStatus.SelectedIndex = 4;
            cboFilterByType.Items.Add("Все типы задач");
            cboFilterByType.Items.Add("Другие");
            cboFilterByType.Items.Add("Домашние задания");
            cboFilterByType.Items.Add("Лабораторные работы");
            cboFilterByType.SelectedIndex = 0;

        }
        private void RefreshTasks()
        {
            if (User is OnlineUser u_on) // Определение типа пользователя (онлайн/оффлайн)
                u_on.RefreshTasks();
            else if (User is OfflineUser u_off)
                u_off.RefreshTasks();
            RefreshList();
            // Скрываем кнопки изменения статусов
            btnToWork.Visible = false;
            btnDone.Visible = false;
        }
        private void RefreshList()
        {
            lvTasks.Clear();
            // Если не возникла ошибка при получении данных и получена как минимум одна задача
            if (User.Tasks != null && User.Tasks.Count != 0)
            {
                // Формируем шапку listview
                int col_num = 7;
                lvTasks.Columns.Add("Название", lvTasks.Width/col_num);
                lvTasks.Columns.Add("Описание", lvTasks.Width/col_num);
                lvTasks.Columns.Add("Сделать до", lvTasks.Width / col_num);
                lvTasks.Columns.Add("Тип", lvTasks.Width / col_num);
                if (User is OnlineUser u && u.Role == 2) // Для администраторов добавляется поле с названием групп и удаляются поля со статусом задач и остатком дней
                    lvTasks.Columns.Add("Группа", lvTasks.Width / col_num);
                else
                {
                    lvTasks.Columns.Add("Статус", lvTasks.Width / col_num);
                    lvTasks.Columns.Add("Осталось дней", lvTasks.Width / col_num);
                }
                lvTasks.Columns.Add("Создано", lvTasks.Width / col_num);
                // Заполнение listview
                foreach (var task in User.Tasks)
                {
                    // Работа фильтров и поиска
                    if ((task.Name.Contains(txtSearch.Text) || task.Description.Contains(txtSearch.Text)) && 
                        (cboFilterByStatus.SelectedIndex == 0 || task.IdStatus == cboFilterByStatus.SelectedIndex - 1 || (cboFilterByStatus.SelectedIndex == 4 && (task.IdStatus == 0 || task.IdStatus == 1 ))) &&
                        (cboFilterByType.SelectedIndex == 0 || task.IdType == cboFilterByType.SelectedIndex - 1))
                    {
                        // Формирование даты из числа формата YYYYMMDD
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
                        // Формирование даты из числа формата YYYYMMDD
                        year = Convert.ToInt32(task.CreationDate / 10000);
                        month = Convert.ToInt32(task.CreationDate / 100 - year * 100);
                        day = Convert.ToInt32(task.CreationDate % 100);
                        DateTime creationDate = new DateTime(year, month, day);
                        item.SubItems.Add(creationDate.ToString("dd.MM.yyyy"));
                        item.Tag = task;
                        lvTasks.Items.Add(item);
                    }
                }
            }
            else if (User.Tasks is null) // Если при получении задач получили Null - возникла ошибка при получении данных
            {
                MessageBox.Show("Возникла ошибка при получении списка задач, проверьте подключение к интернету и доступность сервера, приложение будет закрыто");
                Application.Exit();
            }
            else // Если задач нет
            {
                lvTasks.Columns.Add("", -2, HorizontalAlignment.Left);
                ListViewItem item = new ListViewItem("У Вас нет задач");
                item.Tag = "NOTASK";
                lvTasks.Items.Add(item);
            }
        }
        private void ListView1_Click(object sender, MouseEventArgs e) // Выбор задачи
        {
            if (e.Button == MouseButtons.Left)
            {
                if (lvTasks.SelectedItems[0].Tag.ToString() != "NOTASK") // Если элемент не помечен как "не задача"
                {
                    Form fm = new fmSelectedItem(lvTasks.SelectedItems[0], User);
                    fm.Show();
                }
            }
        }

        private void fmTasks_FormClosed(object sender, FormClosedEventArgs e)
        {
            // При закрытии формы предлагается сохранить задачи в локальную БД (если не оффлайн пользователь и не алминистратор)
            if (User is OnlineUser u && u.Role != 2) //Если онлайн пользователь и не админ
            {
                var res = MessageBox.Show("Сохранить задачи на компьютер? \nВы сможете продолжить работу оффлайн", "Подтвердите действие", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    var db = new LocalDB();
                    db.SaveTasks(u);
                    File.WriteAllText(@"User", User.Username);
                }
            }
            // При закрытии данной формы закрывается всё приложение
            Application.Exit();
        }

        private void buRefresh_Click(object sender, EventArgs e)
        {
            RefreshTasks();
        }

        private void buAboutMe_Click(object sender, EventArgs e) 
        {
            // Форма "Обо мне" доступна только онлайн пользователям
            if (User is OnlineUser u)
            {
                Form fm = new fmAbout(u);
                fm.Show();
            }
        }

        private void buNewTask_Click(object sender, EventArgs e)
        {
            Form fm = new fmNewTask(User);
            fm.Show();
        }

        private void buGroupTasks_Click(object sender, EventArgs e)
        {
            // Форма с групповыми задачами доступна только онлайн пользователям, прикрепленным к группе
            if (User is OnlineUser u && u.Group != null)
            {
                Form fm = new fmGroupTasks(u);
                fm.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // При смене фильтра - обновление списка (только перерисовка списка, без обращения к серверу)
            RefreshList();
        }

        private void btnToWork_Click(object sender, EventArgs e)
        {
            // Смена статуса для каждой задачи
            foreach (ListViewItem item in lvTasks.CheckedItems)
            {
                if (item.Tag is Task task)
                {
                    task.IdStatus = 1;
                    task.Status = "В работе";
                    if (User is OnlineUser ou)
                        task.UpdateOnServer(User.Username, ou.Password);
                }
                RefreshTasks();
            }
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            // Если есть отмеченные элементы - отображаются кнопки смены статусы для задач, иначе скрываются
            var isChecked = false;
            foreach (var item in lvTasks.CheckedItems)
                isChecked = true;
            if (isChecked)
            {
                btnToWork.Visible = true;
                btnDone.Visible = true;
            }
            else
            {
                btnToWork.Visible = false;
                btnDone.Visible = false;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            // Смена статуса для каждой задачи
            foreach (ListViewItem item in lvTasks.CheckedItems)
            {
                if (item.Tag is Task task)
                {
                    task.IdStatus = 2;
                    task.Status = "Сделано";
                    if (User is OnlineUser ou)
                        task.UpdateOnServer(User.Username, ou.Password);
                }
                RefreshTasks();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            // Обновляем список при изменении запроса поиска (только перерисовка списка, без обращения к серверу)
            RefreshList();
        }

        // Данный метод сортировки listview предоставлен компанией Microsoft и не был изменён
        // Подробнее на https://support.microsoft.com/en-us/help/319401/how-to-sort-a-listview-control-by-a-column-in-visual-c
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            lvTasks.Sort();
        }
    }
}
