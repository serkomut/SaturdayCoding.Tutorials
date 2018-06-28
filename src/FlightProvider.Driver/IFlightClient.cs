namespace FlightProvider.Driver
{
    public interface IFlightClient
    {
        SearchResult Search(SearchCriteria criteria);
    }
}