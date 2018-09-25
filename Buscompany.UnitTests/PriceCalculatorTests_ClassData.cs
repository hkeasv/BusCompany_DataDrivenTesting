using System;
using Xunit;
using BusCompany;

namespace Buscompany.UnitTests
{
    public class PriceCalculatorTests_ClassData
    {

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void CalculatePrice_ValidClassData_PriceIsCorrect(int distance, DateTime date, decimal expectedPrice)
        {
            //Arrange
            PriceCalculator calculator = new PriceCalculator();
            //Act
            decimal price = calculator.CalculatePrice(distance, date);
            //Assert
            Assert.Equal(expectedPrice, price);
        }

    }
}
