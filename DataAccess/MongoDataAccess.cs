using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using changelogmvc.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;



namespace changelogmvc.DataAccess
{
    public class MongoDataAccess
    {
        MongoClient _client;
        MongoServer _server;
        MongoDatabase _db;

        [Obsolete]
        public MongoDataAccess()
        {
            _client = new MongoClient("mongodb+srv://m001-student:m001-student-basics@sandbox-j4kkt.mongodb.net/changelog?retryWrites=true&w=majority");
            _server = _client.GetServer();
            _db = _server.GetDatabase("changelog");
        }

        public IEnumerable<changes> GetChangeLogs()
        {
            return _db.GetCollection<changes>("changes").FindAll().ToList();
        }
    }
}
