using IsmaelOrdonez_EvluacionP3.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsmaelOrdonez_EvluacionP3.Data
{
    public class ApiBDD
    {
        string _dbPath;
        private SQLiteConnection conn;

        public ApiBDD(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }

        private void Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<ApiClass>();
        }

        public int AddNewBurger(ApiClass data)
        {
            if (data.id != 0)
                return conn.Update(data);
            else
                return conn.Insert(data);
        }

        public int DeleteBurger(ApiClass data)
        {
            Init();
            return conn.Delete(data);
        }

        public List<ApiClass> GetAllBurger()
        {
            Init();
            List<ApiClass> data = conn.Table<ApiClass>().ToList();
            return data;
        }
    }
}
