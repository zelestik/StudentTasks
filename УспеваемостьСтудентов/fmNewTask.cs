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


namespace StudentTasks
{
    public partial class fmNewTask : Form
    {
        public User User { get; private set; }
        public fmNewTask(User user)
        {
            User = user;
            InitializeComponent();
            // Формируем комбобокс с типами задач
            cbType.Items.Add("Другое");
            cbType.Items.Add("Лабораторная работа");
            cbType.Items.Add("Домашняя работа");
            cbType.SelectedIndex = 1;
            if (User is OnlineUser u)
            {
                //Если не староста - убираем checkBox групповой задачи
                if (u.Role != 1) 
                {
                    cbIsGroup.Checked = false;
                    cbIsGroup.Hide();
                }
            }
            //Если не онлайн режим - убираем checkBox групповой задачи
            else
            {
                cbIsGroup.Checked = false;
                cbIsGroup.Hide();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Формируем дату числом формата YYYYMMDD
            int intExpirationDate = dateTimePickerExpiration.Value.Year * 10000 
                + dateTimePickerExpiration.Value.Month * 100 + dateTimePickerExpiration.Value.Day;
            int intCurrentDate = DateTime.Today.Year * 10000 + DateTime.Today.Month * 100 + DateTime.Today.Day;
            var task = new Task(0, txtDescription.Text, intExpirationDate, txtSubject.Text, 0, 
                cbType.SelectedIndex, "Создано", cbType.SelectedItem.ToString(), intCurrentDate, false);
            string res = "-3";
            if (User is OnlineUser u) // В зависимости от типа пользователя (онлайн оффлайн) определяется механизм записи задачи
                res = task.SendToServer(u.Username, u.Password, cbIsGroup.Checked);
            else
                res = task.SendToLocal();
            if (res == "0") // Если успешный ответ
            {
                MessageBox.Show("Задача добавлена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
                MessageBox.Show("Возникла ошибка при сохранении данных " + res,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
