﻿using Newtonsoft.Json;
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
            User = user;
            InitializeComponent();
            comboBox1.Items.Add("Другое");
            comboBox1.Items.Add("Лабораторная работа");
            comboBox1.Items.Add("Домашняя работа");
            comboBox1.SelectedIndex = 1;
            if (User is OnlineUser u)
            {
                if (u.Role != 1) //Если не староста - убираем checkBox групповой задачи
                {
                    cbGroup.Checked = false;
                    cbGroup.Hide();
                }
            }
            else
            {
                cbGroup.Checked = false;
                cbGroup.Hide();
            }
        }

        private void buAdd_Click(object sender, EventArgs e)
        {
            int num_date = dateTimePicker1.Value.Year * 10000 + dateTimePicker1.Value.Month * 100 + dateTimePicker1.Value.Day;
            var task = new Task(textBox2.Text, num_date, textBox1.Text, 0, comboBox1.SelectedIndex, "Создано", comboBox1.SelectedItem.ToString());
            string res = "-3";
            if (User is OnlineUser u)
            {
                res = task.SendToServer(u.Username, u.Password, cbGroup.Checked);
            }
            else
            {
                res = task.SendToLocal();
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
        }
    }
}
