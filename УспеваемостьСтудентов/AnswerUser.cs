using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTasks
{
    public class AnswerUser // Вспомогательный класс для десериализации JSON
    {
        public string Group { get; private set; } // Имя группы
        public int Role { get; private set; } // Номер роли
        public string Name { get; private set; } // Имя
        public AnswerUser(string group, int role, string name)
        {
            Group = group;
            Role = role;
            Name = name;
        }
    }
}
