using BowerBookAPI.Interfaces.Data;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BowerBookAPI.Data.Core
{
    [BsonIgnoreExtraElements]
    public class Interest : IUniqueId
    {
        [BsonIgnore]
        public ObjectId Id => InterestId;
        [BsonElement]
        public ObjectId InterestId { get; set; }
        [BsonElement]
        public string InterestName { get; set; }
        [BsonElement]
        public string Category { get; set; }
        [BsonElement]
        public string Description { get; set; }
        [BsonElement]
        public List<ObjectId> Resources { get; set; }
        [BsonElement]
        public List<ObjectId> Tags { get; set; }
    }
}