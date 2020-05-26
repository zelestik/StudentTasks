﻿using System;
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
    public partial class fmSelectedItem : Form
    {
        public User User { get; private set; }
        public Task Task { get; private set; }
        public fmSelectedItem(ListViewItem item, User user)
        {
            User = user;
            InitializeComponent();
            cbStatus.Items.Add("Создано");
            cbStatus.Items.Add("В работе");
            cbStatus.Items.Add("Сделано");
            if (item.Tag is Task task)
            {
                if (User is OnlineUser u && u.Role == 2)
                    cbStatus.Hide();
                Task = task;
                cbStatus.SelectedIndex = Convert.ToInt32(task.IdStatus);
                laName.Text = task.Name + ". " + task.Type;
                tbDescription.Text = item.SubItems[1].Text;
                int year = Convert.ToInt32(task.ExpirationDate / 10000);
                int month = Convert.ToInt32(task.ExpirationDate / 100 - year * 100);
                int day = Convert.ToInt32(task.ExpirationDate % 100);
                DateTime expDate = new DateTime(year, month, day);
                dateTimePicker1.Value = (expDate);
            }
            else
                Close(); // Форма будет закрыта, если в тэге элемента нет задачи
        }



        private void buSave_Click(object sender, EventArgs e)
        {
            string res = "";
            if (User is OnlineUser u)
            {
                res = Task.UpdateOnServer(u.Username, u.Password);
            }
            else
            {
                //res = Task.UpdateOnLocal();
            }
            if (res == "0")
            {
                MessageBox.Show("Успешно");
                Close();
            }
            else
            {
                MessageBox.Show("Возникла ошибка при сохранении данных " + res);
            }
            // TODO
            // Обработка сохранения изменений
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Task.IdStatus = cbStatus.SelectedIndex;
            Task.Status = cbStatus.SelectedItem.ToString();
        }
    }
}
