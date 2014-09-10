using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace bi_framwork_db
{
    class mssql_connecter
    {
        public SqlConnection GetCon(string con)
        {
            SqlConnection conn = new SqlConnection(con);
            return conn;
        }
    }
}
