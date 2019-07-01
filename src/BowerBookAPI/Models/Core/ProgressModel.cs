using System.Collections.Generic;
using BowerBookAPI.Interfaces.Data;
using BowerBookAPI.Interfaces.Models;

namespace BowerBookAPI.Models.Core
{
    public class ProgressModel : IUniqueModelId
    {
        public string Id => ProgressId;
        public string ProgressId { get; set; }
        public string ProgressName { get; set; }
        public string Color { get; set; }
        public int? Sequence { get; set; }
    }
}