using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
    
namespace bi_framwork_db
{
    class mysql_reader
    {
        string connectionString = "server=localhost;database=test;userid=root;password=;";
        public void Read()
        {
            mysql_connecter con = new mysql_connecter();
            MySqlConnection cn = con.GetCon(connectionString);
            cn.Open();
            try
            {
                MySqlCommand selectData;
                selectData = cn.CreateCommand();
                selectData.CommandText = "SELECT id,first_name,last_name FROM bi_db";
                MySqlDataReader rdr = selectData.ExecuteReader();
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
