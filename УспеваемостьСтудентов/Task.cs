using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УспеваемостьСтудентов
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using System.IO;
    using System.Net;
    using System.Windows.Forms;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class Task
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("exp_date")]
        public long ExpDate { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        public Task(string description, long expDate, string name, long status, long type)
        {
            this.Description = description;
            this.ExpDate = expDate;
            this.Name = name;
            this.Status = status;
            this.Type = type;
        }
    }
    public class Task_creator
    {
        public List<Task> GetTasks(string Username, string Password)
        {
            var con = new Connection();
            var answer = con.get("tasks/" + Username + "/" + Password);
            if (answer is null)
            {
                answer = "-2"; //Ошибка подключения к серверу
            }
            JsonReader jr = new JsonTextReader(new StringReader(answer));
            JsonSerializer js = new JsonSerializer();
            if (answer == "0") //Если задач нет - сервер вернёт 0, клиент создает пустой список задач
                return new List<Task>();
            else if (answer == "-1" || answer == "-2") //Если логин или пароль неверны или случилась ошибка при подключении - вернётся null, в дальнейшем будет обрабатываться как ошибка подключения
                return null;
            else
            {
                var tasks = js.Deserialize<List<Task>>(jr);
                return tasks;
            }     
        }
    }
}
