using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace bi_framwork_db
{
    class mssql_reader
    {
        string connectionString = "Data Source=ISHARA\\SQLEXPRESS;Initial Catalog=mssql;Integrated Security=True";
        public void Read()
        {
        mssql_connecter con = new mssql_connecter();
        SqlConnection cn=con.GetCon(connectionString);
            cn.Open();

            SqlDataReader rdr = null;

            try
            {
                SqlCommand cmd=new SqlCommand("SELECT id,first_name,last_name FROM mssql_db",cn);
                rdr=cmd.ExecuteReader();

                while(rdr.Read())
                {
                    Console.WriteLine("{0}\t{1}\t{2}", rdr["id"], rdr["first_name"], rdr["last_name"]);
                }
            }
            finally
            {
                if(rdr != null)
                {
                    rdr.Close();
                }
            }
        }
    }
}
