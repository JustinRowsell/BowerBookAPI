using System.Collections.Generic;

namespace BowerBookAPI.Models.Core
{
    public class InterestModel
    {
        public int InterestId { get; set; }
        public string InterestName { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public List<ResourceModel> Resources { get; set; }
        public List<TagModel> Tags { get; set; }
    }
}