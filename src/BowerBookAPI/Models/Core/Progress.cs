using System.Collections.Generic;
using BowerBookAPI.Interfaces.Data;

namespace BowerBookAPI.Models.Core
{
    public class Progress : IUniqueId
    {
        public int Id => ProgressId;
        public int ProgressId { get; set; }
        public string ProgressName { get; set; }
        public string Color { get; set; }
        public int? Sequence { get; set; }
    }
}