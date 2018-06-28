using System;
using FluentAssertions;
using NUnit.Framework;

namespace FlightProvider.Driver.Tests
{
    [TestFixture]
    public class SearchCriteriaBuilderFixture
    {
        [Test]
        public void Simple()
        {
            var x = SearchCriteriaBuilder
                .Flight
                .From("AYT").To("IST")
                .Dates("2014-01-01", "2014-01-07")
                .Passengers(
                    2.Adults(),
                    1.Child()
                ).Build();

            x.FromAirport.Should().Be("AYT");
            x.ToAirport.Should().Be("IST");
            x.DepartureDate.Should().Be(new DateTime(2014, 1, 1));
            x.ReturnDate.Should().Be(new DateTime(2014, 1, 7));
            x.AdultCount.Should().Be(2);
            x.ChildCount.Should().Be(1);
            x.InfantCount.Should().Be(0);
        }

        [Test]
        public void Returns_after_x_days()
        {
            var x = SearchCriteriaBuilder
                .Flight
                .From("AYT").To("IST")
                .DepartsOn(DateTime.Today)
                .ReturnsAfer(7.Days())
                .Passengers(
                    3.Adults()
                ).Build();

            x.FromAirport.Should().Be("AYT");
            x.ToAirport.Should().Be("IST");
            x.DepartureDate.Should().Be(DateTime.Today);
            x.ReturnDate.Should().Be(DateTime.Today.AddDays(7));
            x.AdultCount.Should().Be(3);
            x.ChildCount.Should().Be(0);
            x.InfantCount.Should().Be(0);
        }

        [Test]
        public void One_way()
        {
            var x = SearchCriteriaBuilder
                .Flight
                .From("AYT").To("IST")
                .DepartsOn(DateTime.Today)
                .Passengers(
                    1.Adults()
                ).Build();

            x.FromAirport.Should().Be("AYT");
            x.ToAirport.Should().Be("IST");
            x.DepartureDate.Should().Be(DateTime.Today);
            x.ReturnDate.Should().NotHaveValue();
            x.AdultCount.Should().Be(1);
            x.ChildCount.Should().Be(0);
            x.InfantCount.Should().Be(0);
        }
    }
}