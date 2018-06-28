using System;

namespace FlightProvider.Driver
{
    public class SearchCriteria
    {
        public string FromAirport { get; set; }
        public string ToAirport { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int AdultCount { get; set; }
        public int ChildCount { get; set; }
        public int InfantCount { get; set; }
        public string ClassType { get; set; }
    }
}