using BowerBookAPI.Data.Core;
using BowerBookAPI.Models.Global;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq;

namespace BowerBookAPI.Data.Collections
{
    public class Resources : BaseCollection<Resource>
    {
        public Resources(IMongoDatabase database)
        {
            base.Init(database);
        }
        public override string CollectionName => Constants.Data.Collections.Resources;

        public override Resource Get(ObjectId id)
        {
            return Collection.AsQueryable().FirstOrDefault(i => i.ResourceId == id);
        }
    }
}
