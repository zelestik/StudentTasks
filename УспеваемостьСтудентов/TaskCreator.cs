﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УспеваемостьСтудентов
{
    public class TaskCreator
    {
        // Если класс возвращает null - причина записана в Status, -2 - ошибка подключения к серверу, -1 ошибка доступа (неверный логин/пароль), 1 - успешно.
        public int Status { get; private set; }

        public List<Task> GetTasksOnline(string username, string password)
        {
            var con = new Connection();
            string connection_answer = "";
            try
            {
                connection_answer = con.GetJSON("tasks/" + username + "/" + password); // Получаем ответ
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            if (!(connection_answer is null) && con.Status == 1)
            {
                JsonReader jr = new JsonTextReader(new StringReader(connection_answer));
                JsonSerializer js = new JsonSerializer();
                var tasks = js.Deserialize<List<Task>>(jr);
                return tasks;
            }
            else
            {
                Status = con.Status;
                if (Status == 0)
                    return new List<Task>();
                else
                    return null;
            }
        }
        public List<Task> GetTasksOffline()
        {
            var db = new LocalDB();
            return db.LoadTasks();
        }
        public List<Task> GetGroupTasks(string username, string password)
        {
            var con = new Connection();
            string connection_answer = "";
            try
            {
                connection_answer = con.GetJSON("group_tasks/" + username + "/" + password); // Получаем ответ
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            if (!(connection_answer is null) && con.Status == 1)
            {
                JsonReader jr = new JsonTextReader(new StringReader(connection_answer));
                JsonSerializer js = new JsonSerializer();
                var tasks = js.Deserialize<List<Task>>(jr);
                return tasks;
            }
            else
            {
                Status = con.Status;
                if (Status == 0)
                    return new List<Task>();
                else
                    return null;
            }
        }
    }
}
