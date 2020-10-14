using System;
using Xunit;
using TestAPI.Controllers;

namespace TestAPI.Test
{
    public class Customer {
        public int Id;
        public string Name;

        public Customer( int id, string name ) {
            Id = id;
            Name = name;
        }
    }

    public class UnitTest1
    {

        WeatherForecastController controller = new WeatherForecastController( null );

        [Fact]
        public void GetReturnsWeatherForecast()
        {
            // Create empty json file of expected response obviosuly this will have to be the same
            // need to think about this for future.
            Customer actual = new Customer ( 1, "John" );
            Customer expected = new Customer ( 2, "John" );
            Assert.Equal( expected.Id, actual.Id );
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
