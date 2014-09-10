using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace bi_framwork_db
{
    class mysql_connecter
    {
        public MySqlConnection GetCon(string con)
        {
            MySqlConnection conn = new MySqlConnection(con);
            return conn;
        }
    }
}
