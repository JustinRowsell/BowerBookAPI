using System;
using System.Collections.Generic;

namespace BowerBookAPI.Data
{
    public partial class Progress
    {
        public Progress()
        {
            Resource = new HashSet<Resource>();
        }

        public int ProgressId { get; set; }
        public string ProgressName { get; set; }
        public string Color { get; set; }
        public int? Sequence { get; set; }

        public virtual ICollection<Resource> Resource { get; set; }
    }
}
