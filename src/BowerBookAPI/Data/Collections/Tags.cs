using BowerBookAPI.Data.Core;
using BowerBookAPI.Models.Global;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq;
using Tag = BowerBookAPI.Data.Core.Tag;

namespace BowerBookAPI.Data.Collections
{
    public class Tags : BaseCollection<Tag>
    {
        public Tags(IMongoDatabase database)
        {
            base.Init(database);
        }
        public override string CollectionName => Constants.Data.Collections.Tags;

        public override Tag Get(ObjectId id)
        {
            return Collection.AsQueryable().FirstOrDefault(i => i.TagId == id);
        }
    }
}
