using System;
using System.Collections.Generic;

namespace BowerBookAPI.Data
{
    public partial class Resource
    {
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public string Link { get; set; }
        public int? ProgressId { get; set; }

        public virtual Progress Progress { get; set; }
    }
}
