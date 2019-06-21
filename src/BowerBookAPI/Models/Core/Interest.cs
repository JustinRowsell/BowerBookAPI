using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BowerBookAPI.Models.Core
{
    [DataContract]
    public class InterestModel
    {
        [BsonId]
        public ObjectId _id { get; set; }
        [DataMember]
        public string InterestName { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public List<int> Resources { get; set; }
        [DataMember]
        public List<int> Tags { get; set; }
    }
}