using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace L09_Sqlite.Service
{
    public class MyService
    {
        private SQLiteConnection conn;
        public MyService(string dbFilePath)
        {
            conn = new SQLiteConnection(dbFilePath);
            conn.CreateTable<Info>();
        }

        public void AddData(params Info[] infos)
        {
            conn.InsertAll(infos);
        }

        public int CoutInfo()
        {
            return conn.Table<Info>().Count();
        }

        public IList<Info> Query(string key)
        {
            var query = conn.Table<Info>();
            if (key != string.Empty)
                query = query.Where(c => c.Name.Contains(key));
            return query.ToList();
        }
    }

    public class Info
    {
        [PrimaryKey]
        public string Name { get; set; }
        public string Age { get; set; }
    }
}
