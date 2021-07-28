using System;
using Xunit;
using WebApi;
using System.Linq;

namespace WebApi.Tests
{
	public class UnitTest
	{
		[Fact]
		public void WeatherHasHot()
		{
			bool result = WeatherForecast.Summaries.Contains("Hot");
			Assert.True(result);
		}

		[Theory]
		[InlineData(30, 85)]
		[InlineData(45, 112)]
		public void ConvertCelsiusToFahrenheit(int celsius, int fahrenheit)
		{
			WeatherForecast weather = new();
			weather.TemperatureC = celsius;
			double result = weather.TemperatureF;
			Assert.Equal(fahrenheit, result);
		}
	}
}
