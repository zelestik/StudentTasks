using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTasks
{
    
    public class UserToAdd
    {
        public string Password { get; private set; } // Пароль
        public string UserName { get; private set; } // Логин
        public string Email { get; private set; } // Email
        public string FirstName { get; private set; } // Имя
        public string SecondName { get; private set; } // Фамилия
        public int IdRole { get; private set; } // Роль пользователя

        public UserToAdd(string firstName, string secondName, string email, string userName, string password, int idRole)
        {
            FirstName = firstName;
            SecondName = secondName;
            Email = email;
            UserName = userName;
            Password = password;
            IdRole = idRole;
        }
    }
}
