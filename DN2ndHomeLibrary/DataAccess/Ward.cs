using System;
using System.Collections.Generic;

namespace DN2ndHomeLibrary.DataAccess
{
    public partial class Ward
    {
        public int? DistrictId { get; set; }
        public string? WardName { get; set; }
        public int WardId { get; set; }

        public virtual District? District { get; set; }
    }
}
