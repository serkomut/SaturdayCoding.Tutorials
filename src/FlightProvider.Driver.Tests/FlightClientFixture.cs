using System;
using FakeItEasy;
using FluentAssertions;
using NUnit.Framework;

namespace FlightProvider.Driver.Tests
{
    [TestFixture]
    public class FlightClientFixture
    {
        private IFlightClient client;

        [TestFixtureSetUp]
        public void Setup()
        {
            client = A.Fake<IFlightClient>();
        }

        [Test]
        public void Without_builder()
        {
            var criteria = new SearchCriteria
                               {
                                   FromAirport = "AYT",
                                   ToAirport = "IST",
                                   DepartureDate = new DateTime(2014, 01, 01),
                                   ReturnDate = new DateTime(2014, 01, 07),
                                   AdultCount = 2,
                                   ChildCount = 1
                               };

            client.Search(criteria);
        }

        [Test]
        public void Using_builder()
        {
            var criteria =
                Flight
                    .From("AYT").To("IST")
                    .Dates("2014-01-01", "2014-01-07")
                    .Passengers(
                        2.Adults(),
                        1.Child()
                    ).Build();

            client.Search(criteria);
        }

        [Test]
        public void Implicit_builder_cast()
        {
            client.Search(
                Flight
                    .From("AYT").To("IST")
                    .Dates("2014-01-01", "2014-01-07")
                    .Passengers(
                        2.Adults(),
                        1.Child()
                    ));
        }

        [Test]
        public void Returns_in_x_days()
        {
            client.Search(
                Flight
                    .From("AYT").To("IST")
                    .DepartsOn(DateTime.Today).ReturnsAfer(7.Days())
                    .Passengers(
                        2.Adults(),
                        1.Child()
                    ));
        }

        [Test]
        [ExpectedException(
            typeof (ArgumentOutOfRangeException),
            ExpectedMessage = "You must provide at least 1 adult.",
            MatchType = MessageMatch.StartsWith)]
        public void At_least_one_adult()
        {
            client.Search(
                Flight
                    .From("AYT").To("IST")
                    .DepartsOn(DateTime.Today).ReturnsAfer(7.Days())
                    .Passengers(
                        1.Child()
                    ));
        }

        private static SearchCriteriaBuilder Flight
        {
            get { return SearchCriteriaBuilder.Flight; }
        }
    }
}