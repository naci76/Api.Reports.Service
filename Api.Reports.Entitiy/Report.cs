using System;

namespace Api.Reports.Entitiy
{
    public class Report:BaseEntity
    {
        public int HotelCount { get; set; }
        public int PhoneCount { get; set; }
        public int Status { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
