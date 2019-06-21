using BowerBookAPI.Data.Collections;
using BowerBookAPI.Data.Core;
using BowerBookAPI.Interfaces.Data.Repository;
using BowerBookAPI.Models.Core;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowerBookAPI.Data
{
    public class CoreRepository
    {
        private BaseMongoDatabase _database;
        public CoreRepository(BaseMongoDatabase database)
        {
            _database = database;
        }

        public List<Interest> GetAllInterests()
        {
            return Interests.GetAll();
        }

        public Interest GetInterest(ObjectId id)
        {
            return Interests.Get(id);
        }

        private Interests _interests;
        public Interests Interests
        {
            get
            {
                if (_interests == null)
                    _interests = new Interests(_database.Database);
                return _interests;
            }
        }
    }
}