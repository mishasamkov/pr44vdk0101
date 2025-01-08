using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
namespace TaskManager_samkov.Classes.Database
{
    public class Config
    {
        public static readonly string connection = "server=localhost;port=3306;uid=root;database=TaskManager;";
        public static readonly MySqlServerVersion version = new MySqlServerVersion(new Version(8, 0, 11));
    }
}
