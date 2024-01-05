using System;
using System.Collections.Generic;

namespace DN2ndHomeLibrary.DataAccess
{
    public partial class PrdInfo
    {
        public int PrdId { get; set; }
        public string? PrdTitle { get; set; }
        public string? PrdDetail { get; set; }
        public decimal? Price { get; set; }
        public int? PrdStatus { get; set; }
        public int? Area { get; set; }
        public string? DetailAddress { get; set; }
        public int? DistrictId { get; set; }
        public int? WardId { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreateDay { get; set; }
        public int? Booked { get; set; }
    }
}
