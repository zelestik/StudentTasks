﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УспеваемостьСтудентов
{
    public class OfflineUser : User
    {
        public OfflineUser(string username) : base(username) { }
        public void RefreshTasks()
        {
            var tc = new TaskCreator();
            Tasks = tc.GetTasksOffline();
        }
    }
}
