using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace УспеваемостьСтудентов
{

    public class Task
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("expiration_date")]
        public long ExpirationDate { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id_status")]
        public long IdStatus { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("id_type")]
        public long IdType { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        public Task(string description, long expDate, string name, long id_status, long id_type, string status, string type)
        {
            this.Description = description;
            this.ExpirationDate = expDate;
            this.Name = name;
            this.IdStatus = id_status;
            this.IdType = id_type;
            this.Status = status;
            this.Type = type;
        }

        public string SendToServer(string username, string password)
        {
            string output = JsonConvert.SerializeObject(this);
            var con = new Connection();
            return con.PostJSON($"post_tasks/{username}/{password}", output); ;
        }
        public string SendToLocal()
        {
            var db = new Local_db();
            var res = db.AddTask(this);
            return res.ToString();
        }
    }
    public class TaskCreator
    {
        // Если класс возвращает null - причина записана в Status, -2 - ошибка подключения к серверу, -1 ошибка доступа (неверный логин/пароль), 1 - успешно.
        public int Status { get; private set; }

        public List<Task> GetTasksOnline(string Username, string Password)
        {
            var con = new Connection();
            string connection_answer = "";
            try
            {
                connection_answer = con.GetJSON("tasks/" + Username + "/" + Password); // Получаем ответ
            }
            catch(Exception e)
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
            var db = new Local_db();
            return db.load_tasks();
        }
    }
}
