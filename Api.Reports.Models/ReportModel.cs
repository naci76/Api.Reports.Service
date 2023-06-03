using System;

namespace Api.Reports.Models
{
    public class ReportModel
    {
        public int Id { get; set; }
        public int HotelCount { get; set; }
        public int PhoneCount { get; set; }
        public int Status { get; set; }
        public string Lon { get; set; }
        public string Lat { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
