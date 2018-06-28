namespace FlightProvider.Driver
{
    public static class FlightRelatedIntExtensions
    {
        public static SearchCriteriaBuilder.Passenger Adults(this int count)
        {
            return SearchCriteriaBuilder.Passenger.BuildAdult(count);
        }

        public static SearchCriteriaBuilder.Passenger Adult(this int count)
        {
            return count.Adults();
        }

        public static SearchCriteriaBuilder.Passenger Children(this int count)
        {
            return SearchCriteriaBuilder.Passenger.BuildChild(count);
        }

        public static SearchCriteriaBuilder.Passenger Child(this int count)
        {
            return count.Children();
        }
    }
}