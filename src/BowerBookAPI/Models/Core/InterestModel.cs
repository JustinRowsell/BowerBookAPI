using BowerBookAPI.Interfaces.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BowerBookAPI.Models.Core
{
    public class InterestModel : IUniqueModelId
    {
        public string Id => InterestId;
        public string InterestId { get; set; }
        public string InterestName { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public List<ResourceModel> Resources { get; set; }
        public List<TagModel> Tags { get; set; }
    }
}