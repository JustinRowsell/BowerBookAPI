using BowerBookAPI.Interfaces.Data;

namespace BowerBookAPI.Models.Core
{
    public class Tag : IUniqueId
    {
        public int Id => TagId;
        public int TagId { get; set; }
        public string TagName { get; set; }
    }
}