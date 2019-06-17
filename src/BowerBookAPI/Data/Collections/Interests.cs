using BowerBookAPI.Models.Core;
using BowerBookAPI.Models.Global;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowerBookAPI.Data.Collections
{
    public class Interests : BaseCollection<Interest>
    {
        public Interests(IMongoDatabase database)
        {
            base.Init(database);
        }
        public override string CollectionName => Constants.Data.Collections.Interests;

        public override Interest Get(int id)
        {
            return Collection.AsQueryable<Interest>().FirstOrDefault(i => i.InterestId == id);
        }
    }
}
