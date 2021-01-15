using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTasks
{
    public partial class fmSelectedItem : Form
    {
        public User User { get; private set; }
        public Task Task { get; private set; }
        public fmSelectedItem(ListViewItem item, User user)
        {
            User = user;
            InitializeComponent();
            // Заполнение комбобокса вариантами статусов
            cbStatus.Items.Add("Создано");
            cbStatus.Items.Add("В работе");
            cbStatus.Items.Add("Сделано");
            if (item.Tag is Task task) // Если в тэге элемента записана задача
            {
                if (User is OnlineUser u && u.Role == 2) // У администраторов скрывается комбобокс со статусами
                    cbStatus.Hide();
                Task = task; // Записываем задачу в свойство класса
                cbStatus.SelectedIndex = Convert.ToInt32(task.IdStatus); // Отметка статуса по ID статуса из задачи
                lblName.Text = task.Name + ". " + task.Type; // Задаем заголовок
                txtDescription.Text = item.SubItems[1].Text; // Записываем описание
                // Формируем дату по числу формата YYYYMMDD
                int year = Convert.ToInt32(task.ExpirationDate / 10000);
                int month = Convert.ToInt32(task.ExpirationDate / 100 - year * 100);
                int day = Convert.ToInt32(task.ExpirationDate % 100);
                DateTime expDate = new DateTime(year, month, day);
                dateTimePickerExpiration.Value = (expDate);
            }
            else
                Close(); // Форма будет закрыта, если в тэге элемента нет задачи
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            string res = "";
            // Определяем тип пользователя (онлайн/оффлайн) для определения механизма работы
            if (User is OnlineUser u)
                res = Task.UpdateOnServer(u.Username, u.Password);
            else
                //res = Task.UpdateOnLocal();
            if (res == "0") // Если успешно
            {
                MessageBox.Show("Задача сохранена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Возникла ошибка при сохранении данных " + res,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Task.IdStatus = cbStatus.SelectedIndex;
            Task.Status = cbStatus.SelectedItem.ToString();
        }
    }
}
