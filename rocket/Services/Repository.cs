using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using Dapper;
using Npgsql;

namespace rocket.Services
{

    public class Landing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class Repository
    {

        private static NpgsqlConnection GetOpenNpgsqlConnection()
        {
            string cs = "Server=localhost;Port=5432;User Id=postgres;Password=1;Database=postgres";
            var conn = new NpgsqlConnection(cs);
            conn.Open();
            return conn;
        }

        public IEnumerable<Landing> GetLandings()
        {

            using (var conn = GetOpenNpgsqlConnection())
            {
                return conn.Query<Landing>("select * from landing");
            }

        }
    }
}