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

namespace StudentTasks
{

    public class Task
    {
        [JsonProperty("description")]
        public string Description { get; set; } // Описание задачи

        [JsonProperty("expiration_date")]
        public long ExpirationDate { get; set; } // Дата "сделать до" числом в формате YYYYMMDD

        [JsonProperty("id")]
        public long Id { get; set; } // id задачи на сервере/в локальной БД

        [JsonProperty("name")]
        public string Name { get; set; } // Название задачи

        [JsonProperty("id_status")]
        public long IdStatus { get; set; } // ID статуса

        [JsonProperty("status")]
        public string Status { get; set; } // Название статуса

        [JsonProperty("id_type")]
        public long IdType { get; set; } // ID типа задачи

        [JsonProperty("type")]
        public string Type { get; set; } // Название типа задачи

        [JsonProperty("group")]
        public string Group { get; set; } // Название группы (ID группы не хранится у клиента)

        [JsonProperty("creation_date")]
        public long CreationDate { get; set; } // Дата создания задачи

        [JsonProperty("is_group")]
        public bool IsGroup { get; set; } // Является ли задача групповой

        public Task(long Id, string description, long expirationDate, string name, long id_status, long id_type, string status, string type, long creationDate, bool isGroup) // Конструктор задачи
        {
            this.Id = Id;
            this.Description = description;
            this.ExpirationDate = expirationDate;
            this.Name = name;
            this.IdStatus = id_status;
            this.IdType = id_type;
            this.Status = status;
            this.Type = type;
            this.CreationDate = creationDate;
            this.IsGroup = isGroup;
        }

        public string SendToServer(string username, string password, bool is_group) // Метод для отправки задачи на сервер
        {
            string output = JsonConvert.SerializeObject(this); // Получаем JSON объекта
            var con = new Connection();
            if (is_group) // Если задача групповая то отправляем на post_group_tasks
                return con.PostJSON($"post_group_tasks/{username}/{password}", output);
            else
                return con.PostJSON($"post_tasks/{username}/{password}", output);
        }

        // На данный момент не реализованный метод возвращает "", в будущем будет использоваться для обновления информации о задаче в клиентской БД
        internal string UpdateOnLocal() 
        {
            string res = "";
            var db = new LocalDB();
            //var res = db.UpdateTask(this);
            return res.ToString();
        }

        public string UpdateOnServer(string username, string password) // Метод для обновления задачи на сервере
        {
            string output = JsonConvert.SerializeObject(this);
            var con = new Connection();
            return con.PostJSON($"status_change/{username}/{password}", output);
        }
        public string SendToLocal() // Метод для отправки задачи в локальную БД
        {
            var db = new LocalDB();
            var res = db.AddTask(this);
            return res.ToString();
        }
    }
}
