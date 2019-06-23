using System.Collections.Generic;
using BowerBookAPI.Interfaces.Data;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BowerBookAPI.Data.Core
{
    [BsonIgnoreExtraElements]
    public class Progress : IUniqueId
    {
        [BsonIgnore]
        public ObjectId Id => ProgressId;
        [BsonElement]
        public ObjectId ProgressId { get; set; }
        [BsonElement]
        public string ProgressName { get; set; }
        [BsonElement]
        public string Color { get; set; }
        [BsonElement]
        public int? Sequence { get; set; }
    }
}