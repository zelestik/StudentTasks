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
    class Local_db
    {
        private string dbFileName = @"localDB.sqlite3";

        public Local_db()
        {
            check_db();
        }

        private void check_db()
        {
            if (!File.Exists(dbFileName))
                SQLiteConnection.CreateFile(dbFileName);
            using (var sqlite = new SQLiteConnection("Data source =" + dbFileName))
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
                    username text not null,
                    name text not null, 
                    description text, 
                    exp_date integer not null, 
                    id_status integer default 0 not null references statuses, 
                    id_type integer references task_types, 
                    is_changed integer default 0 not null
                );";
                SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                command.ExecuteNonQuery();
            }
        }
        public List<Task> load_tasks()
        {
            var sql = "SELECT * FROM tasks";
            var tasks = new List<Task>();
            using (var con = new SQLiteConnection("Data source =" + dbFileName))
            {
                SQLiteCommand Command = new SQLiteCommand(sql, con);
                con.Open();
                using (var reader = Command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var task = new Task((string)reader["description"], (long)reader["exp_date"], (string)reader["name"], (long)reader["id_status"], (long)reader["id_type"]);
                        tasks.Add(task);
                    }
                }
                con.Close();
            }
            return tasks;
        }

        public int saveTasks(OnlineUser user)
        {
            var sql = "DELETE FROM tasks; ";
            foreach (var task in user.Tasks)
            {
                //TODO Заменить подстановку данных на sqlite (защита от sql инъекций)
                sql += $"INSERT INTO 'tasks' ('id', 'name', 'description', 'exp_date', 'id_status', 'id_type', 'is_changed', 'username') VALUES ({task.Id}, '{task.Name}', '{task.Description}', {task.ExpDate}, {task.Status}, {task.Type}, 0, '{user.Username}'); ";
            }
            using (var con = new SQLiteConnection("Data source =" + dbFileName))
            {
                SQLiteCommand Command = new SQLiteCommand(sql, con);
                con.Open();
                Command.ExecuteNonQuery();
                con.Close();
            }
            return 0;
        }
    }
}
