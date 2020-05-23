using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace УспеваемостьСтудентов
{
    public abstract class User
    {
        // При работе оффлайн будет создаваться экземпляр класса OfflineUser, а при работе онлайн - OnlineUser
        public List<Task> Tasks { get;  set; }
    }
    public class OfflineUser : User
    {
        public void RefreshTasks()
        {
            var tc = new TaskCreator();
            Tasks = tc.GetTasksOffline();
        }

    }
    public class OnlineUser : User
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Group { get; private set; }
        public int Role { get; private set; }
        public string Name { get; private set; }
        public OnlineUser(string username, string password)
        {
            Username = username;
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
                MessageBox.Show(e.ToString());
            }
            if (!(connection_answer is null))
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
                    MessageBox.Show(e.Message);
                }
            }
            return con.Status; // Возвращаем код ответа
        }
        public void RefreshTasks()
        {
            var tc = new TaskCreator();
            Tasks = tc.GetTasks(this.Username, this.Password);
        }
    }
    public class AnswerUser // Вспомогательный класс для десериализации JSON
    {
        public string Group { get; private set; }
        public int Role { get; private set; }
        public string Name { get; private set; }
        public AnswerUser(string group, int role, string name)
        {
            Group = group;
            Role = role;
            Name = name;
        }
    }
}
