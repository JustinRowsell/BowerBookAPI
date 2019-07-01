using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowerBookAPI.Data.Collections
{
    public abstract class BaseMongoDatabase
    {
        private MongoClient _client;
        public virtual MongoClient Client
        {
            get
            {
                if (_client == null)
                    _client = new MongoClient("mongodb+srv://bower:bower3214@bowerbook-7pbxs.azure.mongodb.net/test?retryWrites=true&w=majority");
                return _client;
            }
            set { _client = value; }
        }

        private IMongoDatabase _database;
        public virtual IMongoDatabase Database
        {
            get
            {
                if (_database == null)
                    _database = Client.GetDatabase(DatabaseName);
                return _database;
            }
        }

        public abstract string DatabaseName { get; }
    }
}
