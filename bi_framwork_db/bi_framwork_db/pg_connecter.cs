using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace bi_framwork_db
{
    class pg_connecter
    {
        public NpgsqlConnection GetCon(string con)
        {
            NpgsqlConnection conn = new NpgsqlConnection(con);
            return conn;
        }
    }
}
