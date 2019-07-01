using BowerBookAPI.Interfaces.Data;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.Serialization;

namespace BowerBookAPI.Data.Core
{
    [BsonIgnoreExtraElements]
    public class Resource : IUniqueId
    {
        [BsonIgnore]
        public ObjectId Id => ResourceId;
        [BsonElement]
        public ObjectId ResourceId { get; set; }
        [BsonElement]
        public string ResourceName { get; set; }
        [BsonElement]
        public string ResourceLink { get; set; }
        [BsonElement]
        public ObjectId ProgressId { get; set; }
    }
}