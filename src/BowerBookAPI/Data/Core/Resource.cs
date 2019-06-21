using BowerBookAPI.Interfaces.Data;

namespace BowerBookAPI.Data.Core
{
    public class Resource : IUniqueId
    {
        public int Id => ResourceId;
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public string Link { get; set; }
        public Progress Progress { get; set; }
    }
}