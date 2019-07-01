using BowerBookAPI.Interfaces.Data;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.Serialization;

namespace BowerBookAPI.Data.Core
{
    [BsonIgnoreExtraElements]
    public class Tag : IUniqueId
    {
        [BsonIgnore]
        public ObjectId Id => TagId;
        [BsonElement]
        public ObjectId TagId { get; set; }
        [BsonElement]
        public string TagName { get; set; }
    }
}