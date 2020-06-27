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


namespace StudentTasks
{

    public abstract class User
    {
        // При работе оффлайн будет создаваться экземпляр класса OfflineUser, а при работе онлайн - OnlineUser
        public string Username { get; private set; } 
        public List<Task> Tasks { get;  set; } // Список задач
        public User(string username)
        {
            Username = username;
        }
    }
}
