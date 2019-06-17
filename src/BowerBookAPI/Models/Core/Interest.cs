using System.Collections.Generic;

namespace BowerBookAPI.Models.Core
{
    public class Interest
    {
        public int InterestId { get; set; }
        public string InterestName { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public List<Resource> Resources { get; set; }
        public List<Tag> Tags { get; set; }
    }
}