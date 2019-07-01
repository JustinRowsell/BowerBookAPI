using BowerBookAPI.Data.Core;
using BowerBookAPI.Interfaces.Models;

namespace BowerBookAPI.Models.Core
{
    public class ResourceModel : IUniqueModelId
    {
        public string Id => ResourceId;
        public string ResourceId { get; set; }
        public string ResourceName { get; set; }
        public string ResourceLink { get; set; }
        public ProgressModel Progress { get; set; }
    }
}