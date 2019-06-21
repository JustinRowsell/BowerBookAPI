using BowerBookAPI.Data.Core;
using BowerBookAPI.Interfaces.Data;

namespace BowerBookAPI.Models.Core
{
    public class ResourceModel : IUniqueId
    {
        public int Id => ResourceId;
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public string Link { get; set; }
        public Progress Progress { get; set; }
    }
}