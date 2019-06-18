using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BowerBookAPI.Models.Core;
using MongoDB.Bson;

namespace BowerBookAPI.Data.Collections
{
    public abstract class BaseCollection<T>
    {
        #region Data access
        public void Init(IMongoDatabase database)
        {
            Database = database;
        }
        internal virtual IMongoDatabase Database { get; set; }

        private IMongoCollection<T> _collection;
        public IMongoCollection<T> Collection
        {
            get
            {
                if (_collection == null)
                    _collection = Database.GetCollection<T>(CollectionName);
                return _collection;
            }
            
        }

        public abstract string CollectionName { get; }
        #endregion

        #region Queries
        public abstract T Get(ObjectId id);
        public List<T> GetAll()
        {
            var documents =  Collection.Find(_ => true).ToList();
            return documents;
        }
        #endregion
    }
}
