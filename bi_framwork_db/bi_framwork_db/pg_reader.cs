using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace bi_framwork_db
{
    class pg_reader
    {
        string connstring = string.Format("Server=127.0.0.1;Port=5432; User Id=postgres;Password=12345;Database=pg_db;");
                    
        public void Read()
        {
            pg_connecter con = new pg_connecter();
            NpgsqlConnection cn = con.GetCon(connstring);
            cn.Open();
            try
            {

                NpgsqlCommand selectData;
                selectData = cn.CreateCommand();
                selectData.CommandText="SELECT id,first_name,last_name FROM bi_db";
                NpgsqlDataReader rdr = selectData.ExecuteReader();
              while (rdr.Read())
                {
                    string id = rdr["id"].ToString();
                    string first_name = (string)rdr["first_name"];
                    string last_name = (string)rdr["last_name"];
                    Console.WriteLine(id + " " + first_name + " " + last_name);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
       
    }
}
