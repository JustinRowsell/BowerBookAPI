using BowerBookAPI.Data.Core;
using BowerBookAPI.Models.Global;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq;

namespace BowerBookAPI.Data.Collections
{
    public class Progresses : BaseCollection<Progress>
    {
        public Progresses(IMongoDatabase database)
        {
            base.Init(database);
        }
        public override string CollectionName => Constants.Data.Collections.Progress;

        public override Progress Get(ObjectId id)
        {
            return Collection.AsQueryable().FirstOrDefault(i => i.ProgressId == id);
        }
    }
}
