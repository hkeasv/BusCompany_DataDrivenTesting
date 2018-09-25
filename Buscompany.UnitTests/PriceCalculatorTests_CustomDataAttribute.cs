using System;
using Xunit;
using BusCompany;

namespace Buscompany.UnitTests
{
    public class PriceCalculatorTests_CustomDataAttribute
    {
        [Theory]
        [JsonData("testdata.json")]
        public void CalculatePrice_ValidJsonData_PriceIsCorrect(int distance, string dateString, decimal expectedPrice)
        {
            //Arrange
            PriceCalculator calculator = new PriceCalculator();
            //Act
            decimal price = calculator.CalculatePrice(distance, DateTime.Parse(dateString));
            //Assert
            Assert.Equal(expectedPrice, price);
        }
    }
}
