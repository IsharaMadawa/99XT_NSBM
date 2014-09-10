using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;

namespace bi_framwork_db
{
    class mongodb_connecter
    {
        public MongoServer GetCon(string con)
        {
            MongoServer conn = MongoServer.Create(con);
            return conn;
        }
    }
}
