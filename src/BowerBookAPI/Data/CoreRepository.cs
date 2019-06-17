using BowerBookAPI.Data.Collections;
using BowerBookAPI.Interfaces.Data.Repository;
using BowerBookAPI.Models.Core;
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
            return Interest.GetAll();
        }

        public Interest GetInterest(int id)
        {
            return Interest.Get(id);
        }

        public Interests Interest { get; set; }
    }
}