using System;
using System.Globalization;
using System.Linq;
using CuttingEdge.Conditions;

namespace FlightProvider.Driver
{
    public class SearchCriteriaBuilder
    {
        public static SearchCriteriaBuilder Flight
        {
            get { return new SearchCriteriaBuilder(); }
        }

        public SearchCriteriaBuilder From(string iataCode)
        {
            fromAirport = iataCode;
            return this;
        }

        public SearchCriteriaBuilder To(string iataCode)
        {
            toAirport = iataCode;
            return this;
        }

        public SearchCriteriaBuilder Dates(string departureDate, string returnDate = null)
        {
            this.departureDate = DateTime.Parse(departureDate, CultureInfo.InvariantCulture);
            if (!string.IsNullOrWhiteSpace(returnDate))
                this.returnDate = DateTime.Parse(returnDate, CultureInfo.InvariantCulture);
            return this;
        }

        private Passenger Adult
        {
            get
            {
                return passengers.FirstOrDefault(x => x.Type == "adult")
                       ?? Passenger.Empty;
            }
        }

        private Passenger Child
        {
            get
            {
                return passengers.FirstOrDefault(x => x.Type == "child")
                       ?? Passenger.Empty;
            }
        }

        public SearchCriteriaBuilder DepartsOn(DateTime value)
        {
            departureDate = value;
            return this;
        }

        public SearchCriteriaBuilder ReturnsAfer(TimeSpan days)
        {
            returnDate = departureDate + days;
            return this;
        }

        public SearchCriteriaBuilder Passengers(params Passenger[] value)
        {
            passengers = value;
            return this;
        }

        public SearchCriteria Build()
        {
            Validate();
            return new SearchCriteria
            {
                FromAirport = fromAirport,
                ToAirport = toAirport,
                DepartureDate = departureDate,
                ReturnDate = returnDate,
                AdultCount = Adult.Count,
                ChildCount = Child.Count
            };
        }

        private void Validate()
        {
            Condition
                .Requires(Adult.Count)
                .IsGreaterThan(0, "You must provide at least 1 adult");
            Condition
                .Requires(fromAirport)
                .IsNotNullOrWhiteSpace("You must provide departure airport");
            Condition
                .Requires(toAirport)
                .IsNotNullOrWhiteSpace("You must provide destination airport");
            Condition
                .Requires(departureDate)
                .IsGreaterOrEqual(DateTime.Today, "Departure date must be greater than today");
            if(returnDate.HasValue)
                Condition
                    .Requires(returnDate)
                    .IsGreaterThan(departureDate, "Return date must be greater than departure date");
        }

        public static implicit operator SearchCriteria(SearchCriteriaBuilder builder)
        {
            return builder.Build();
        }

        private DateTime departureDate;
        private DateTime? returnDate;
        private string fromAirport;
        private string toAirport;
        private Passenger[] passengers = new Passenger[0];

        public class Passenger
        {
            public static readonly Passenger Empty = new Passenger {Count = 0, Type = string.Empty};

            public string Type { get; set; }
            public int Count { get; set; }

            public static Passenger BuildAdult(int count)
            {
                return new Passenger
                {
                    Count = count,
                    Type = "adult"
                };
            }

            public static Passenger BuildChild(int count)
            {
                return new Passenger
                {
                    Count = count,
                    Type = "child"
                };
            }
        }
    }
}