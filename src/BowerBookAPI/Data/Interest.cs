using System;
using System.Collections.Generic;

namespace BowerBookAPI.Data
{
    public partial class Interest
    {
        public int InterestId { get; set; }
        public string InterestName { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
    }
}
