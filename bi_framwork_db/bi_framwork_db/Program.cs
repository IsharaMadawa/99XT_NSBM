using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bi_framwork_db
{
    class Program
    {
        static void Main(string[] args)
        {
            mysql_reader mysqlread = new mysql_reader();
            mysqlread.Read();

            mssql_reader mssqlread = new mssql_reader();
            mssqlread.Read();

            pg_reader pgread = new pg_reader();
            pgread.Read();

            mongodb_reader mongoread = new mongodb_reader();
            mongoread.Read();
        }
    }
}
