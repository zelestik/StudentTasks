using System;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace УспеваемостьСтудентов
{

    class LocalDB
    {
        private string dbFileName = @"localDB.sqlite3";

        public string ExceptionMessages { get; private set; } // Поле с сообщениями об ошибках для отладки

        public LocalDB()
        {
            CheckDB();
        }

        private void CheckDB() // Проверка на существование БД, при отсутствии - создаем
        {
            if (!File.Exists(dbFileName))
                SQLiteConnection.CreateFile(dbFileName);
            using (var sqlite = new SQLiteConnection("Data source =" + dbFileName))
            {
                try
                {
                    sqlite.Open();
                    string sql = @"CREATE TABLE IF NOT EXISTS statuses
                    (id integer not null constraint statuses_pk primary key autoincrement, name text not null);

                create unique index IF NOT EXISTS statuses_name_uindex on statuses(name);

                CREATE TABLE IF NOT EXISTS task_types
                (id integer not null constraint task_types_pk primary key autoincrement, 
                name text not null);

                create unique index IF NOT EXISTS task_types_name_uindex on task_types(name);

                CREATE TABLE IF NOT EXISTS tasks
                (
                    id integer not null constraint tasks_pk primary key, 
                    name text not null, 
                    description text, 
                    expiration_date integer not null, 
                    id_status integer default 0 not null references statuses, 
                    id_type integer references task_types, 
                    is_changed boolean default false not null,
                    is_group boolean default false not null,
                    creation_date integer default 0 not null
                );
                INSERT INTO task_types(id,name) SELECT 0, 'Другое' WHERE NOT EXISTS(SELECT 1 FROM task_types WHERE id = 0 AND name = 'Другое');
                INSERT INTO task_types(id,name) SELECT 1, 'Домашнее задание' WHERE NOT EXISTS(SELECT 1 FROM task_types WHERE id = 1 AND name = 'Домашнее задание');
                INSERT INTO task_types(id,name) SELECT 2, 'Лабораторная работа' WHERE NOT EXISTS(SELECT 1 FROM task_types WHERE id = 2 AND name = 'Лабораторная работа');
                INSERT INTO statuses(id,name) SELECT 0, 'Создано' WHERE NOT EXISTS(SELECT 1 FROM statuses WHERE id = 0 AND name = 'Создано');
                INSERT INTO statuses(id,name) SELECT 1, 'В работе' WHERE NOT EXISTS(SELECT 1 FROM statuses WHERE id = 1 AND name = 'В работе');
                INSERT INTO statuses(id,name) SELECT 2, 'Сделано' WHERE NOT EXISTS(SELECT 1 FROM statuses WHERE id = 2 AND name = 'Сделано');";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    ExceptionMessages = e.Message;
                }
            }
        }

        public void UpdateTask(Task task)
        {
            // Здесь будет обновление задачи на клиенте
        }

        public List<Task> LoadTasks() // Загрузка задач из БД
        {
            var sql = "SELECT tasks.id as id, description, expiration_date, tasks.name, id_status, id_type, statuses.name as status, task_types.name as task_type, creation_date, is_group FROM tasks, task_types, statuses where id_status = statuses.id and id_type = task_types.id";
            var tasks = new List<Task>();
            using (var con = new SQLiteConnection("Data source =" + dbFileName))
            {
                SQLiteCommand Command = new SQLiteCommand(sql, con);
                try
                {
                    con.Open();
                    using (var reader = Command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Task task = new Task((long)reader["id"], (string)reader["description"], (long)reader["expiration_date"], (string)reader["name"], (long)reader["id_status"], (long)reader["id_type"], (string)reader["status"], (string)reader["task_type"], (long)reader["creation_date"], (bool)reader["is_group"]);
                            tasks.Add(task);
                        }
                    }
                    con.Close();
                }
                catch(Exception e)
                {
                    ExceptionMessages = e.Message;
                    return null;
                }
            }
            return tasks;
        }

        public int SaveTasks(OnlineUser user) // Сохранение задач
        {
            var sql = "DELETE FROM tasks; ";
            foreach (var task in user.Tasks)
            {
                //TODO Заменить подстановку данных на sqlite (защита от sql инъекций)
                sql += $"INSERT INTO 'tasks' ('id', 'name', 'description', 'expiration_date', 'id_status', 'id_type', 'is_changed', 'creation_date') VALUES ({task.Id}, '{task.Name}', '{task.Description}', {task.ExpirationDate}, {task.IdStatus}, {task.IdType}, false, {task.CreationDate}); ";
            }
            using (var con = new SQLiteConnection("Data source =" + dbFileName))
            {
                try
                {
                    SQLiteCommand Command = new SQLiteCommand(sql, con);
                    con.Open();
                    Command.ExecuteNonQuery();
                    con.Close();
                }
                catch(Exception e)
                {
                    ExceptionMessages = e.Message;
                    return -2;
                }
            }
            return 0;
        }

        public int AddTask(Task task) // Добавление новой задачи
        {
            var sql = $"INSERT INTO 'tasks' ('name', 'description', 'expiration_date', 'id_status', 'id_type', 'is_changed') VALUES ('{task.Name}', '{task.Description}', {task.ExpirationDate}, {task.IdStatus}, {task.IdType}, 0); ";
            using (var con = new SQLiteConnection("Data source =" + dbFileName))
            {
                try
                {
                    SQLiteCommand Command = new SQLiteCommand(sql, con);
                    con.Open();
                    Command.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception e)
                {
                    ExceptionMessages = e.Message;
                    return -2;
                }
            }
            return 0;
        }
    }
}
