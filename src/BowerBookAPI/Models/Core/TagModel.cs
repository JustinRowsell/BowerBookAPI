using BowerBookAPI.Interfaces.Data;
using BowerBookAPI.Interfaces.Models;

namespace BowerBookAPI.Models.Core
{
    public class TagModel : IUniqueModelId
    {
        public string Id => TagId;
        public string TagId { get; set; }
        public string TagName { get; set; }
    }
}