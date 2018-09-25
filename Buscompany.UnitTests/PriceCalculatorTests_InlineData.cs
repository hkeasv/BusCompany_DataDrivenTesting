using System;
using Xunit;

namespace BusCompany.UnitTests
{
    public class PriceCalculatorTests_InlineData
    {

        [Theory]
        [InlineData(0, "09/26/2018", 2500)]
        [InlineData(1, "09/26/2018", 2510)]
        [InlineData(1, "07/26/2018", 3012)]
        [InlineData(100, "09/26/2018", 3498)]
        [InlineData(501, "09/26/2018", 6704)]
        public void CalculatePrice_ValidInlineData_PriceIsCorrect(int distance, string dateString, decimal expectedPrice)
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
