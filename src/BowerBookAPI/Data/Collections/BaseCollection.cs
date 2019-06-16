using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BowerBookAPI.Models.Core;

namespace BowerBookAPI.Data.Collections
{
    public abstract class BaseCollection
    {
        #region Data access
        public BaseCollection(IMongoDatabase baseDatabase)
        {
            Database = baseDatabase;
        }
        internal virtual IMongoDatabase Database { get; set; }

        public IMongoCollection<T> GetCollection<T>()
        {
            return Database.GetCollection<T>(CollectionName);
        }

        public abstract string CollectionName { get; }
        #endregion

        #region Queries

        #endregion
    }
}
