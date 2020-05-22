
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
//using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace УспеваемостьСтудентов
{
    public class AnswerUser // Вспомогательный класс для десериализации JSON
    {
        public string Group { get; private set; }
        public int Role { get; private set; }
        public string Name { get; private set; }
        public AnswerUser(string group, int role, string name)
        {
            this.Group = group;
            this.Role = role;
            this.Name = name;
        }
    }
    public class User
    {
        // При работе оффлайн будет создаваться экземпляр класса OffUser, а при работе онлайн - Online_User (наследующий User)
        // Это связано с тем, что в оффлайн режиме из локальной БД будет запрашиваться только список задач
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
            this.Username = username;
            this.Password = password;
            this.Group = "";
            this.Role = -1;
            this.Name = "";
        }

        public string LoginUser()
        {
            var OS = Environment.OSVersion;
            string answer = "";
            var con = new Connection();
            try
            {
                answer = con.get("login/" + Username + "/" + Password + "/" + OS.Platform.ToString() + "/" + OS.VersionString); //Вызов метода get класса Connection, в случае успеха будет получен JSON с данными о пользователе
                if (answer is null)
                {
                    answer = "-2"; //Ошибка подключения к серверу
                }
            }   
            catch (NullReferenceException e)
            {
                MessageBox.Show(e.ToString());
            }
            JsonReader jr = new JsonTextReader(new StringReader(answer));
            JsonSerializer js = new JsonSerializer();
            if (answer == "-1" || answer == "-2") //Если введён неверный логин и пароль (-1) или возникли проблемы с подключением к серверу
                return answer;
            else
            {
                try
                {
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
                return "1";
            }
        }
        public void RefreshTasks()
        {
            var tc = new TaskCreator();
            Tasks = tc.GetTasks(this.Username, this.Password);
        }
    }
}
