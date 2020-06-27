using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTasks
{
    public class OnlineUser : User
    {
        public string Password { get; private set; } // Пароль
        public string Group { get; private set; } // Название группы пользователя
        public int Role { get; private set; } // Номер роли пользователя
        public string Name { get; private set; } // Полное имя пользователя
        public OnlineUser(string username, string password) : base(username) // Конструктор класса
        {
            Password = password;
            Group = "";
            Role = -1;
            Name = "";
        }

        public int LoginUser()
        {
            var OS = Environment.OSVersion; // Получаем данные о системе
            string connection_answer = "";
            var con = new Connection(); // Создаём экземпляр класса для выполнения подключения
            try
            {
                connection_answer = con.GetJSON("login/" + Username + "/" + Password + "/" + OS.Platform.ToString() + "/" + OS.VersionString); //Вызов метода get класса Connection, в случае успеха будет получена строка JSON с данными о пользователе
            }
            catch (Exception e)
            {
                // Выврдим ошибку
                MessageBox.Show(e.ToString());
            }
            if (!(connection_answer is null)) // Если получили ответ - пытаемся десериализовать JSON
            {
                try
                {
                    JsonReader jr = new JsonTextReader(new StringReader(connection_answer));
                    JsonSerializer js = new JsonSerializer();
                    AnswerUser answer_user = js.Deserialize<AnswerUser>(jr);
                    this.Group = answer_user.Group;
                    this.Role = answer_user.Role;
                    this.Name = answer_user.Name;
                    RefreshTasks();
                }
                catch (Exception e)
                {
                    // Выводим сообщение об ошибке при проблемах с десериализацией JSON
                    MessageBox.Show(e.Message);
                }
            }
            return con.Status; // Возвращаем код ответа
        }
        public void RefreshTasks() // Метод получения задач с сервера
        {
            var tc = new TaskCreator();
            Tasks = tc.GetTasksOnline(this.Username, this.Password);
        }
    }
}
