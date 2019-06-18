using BowerBookAPI.Models.Core;
using BowerBookAPI.Models.Global;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq;

namespace BowerBookAPI.Data.Collections
{
    public class Interests : BaseCollection<Interest>
    {
        public Interests(IMongoDatabase database)
        {
            base.Init(database);
        }
        public override string CollectionName => Constants.Data.Collections.Interests;

        public override Interest Get(ObjectId id)
        {
            return Collection.AsQueryable<Interest>().FirstOrDefault(i => i._id == id);
        }
    }
}
