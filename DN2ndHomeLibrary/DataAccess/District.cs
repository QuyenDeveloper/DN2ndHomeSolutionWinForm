using System;
using System.Collections.Generic;

namespace DN2ndHomeLibrary.DataAccess
{
    public partial class District
    {
        public District()
        {
            Wards = new HashSet<Ward>();
        }

        public int DistrictId { get; set; }
        public string? DistrictName { get; set; }

        public virtual ICollection<Ward> Wards { get; set; }
    }
}
