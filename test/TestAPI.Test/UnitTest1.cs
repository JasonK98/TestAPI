using System;
using Xunit;
using TestAPI.Controllers;

namespace TestAPI.Test
{
    public class UnitTest1
    {

        WeatherForecastController controller = new WeatherForecastController( null );

        [Fact]
        public void GetReturnsWeatherForecast()
        {
            // Create empty json file of expected response obviosuly this will have to be the same
            // need to think about this for future.
            var returnValue = controller.Get();
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
