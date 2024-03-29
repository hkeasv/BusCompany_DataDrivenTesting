﻿using System;
using Xunit;
using BusCompany;
using System.Collections.Generic;

namespace Buscompany.UnitTests
{
    public class PriceCalculatorTests_MemberData
    {
        static DateTime lowSeasonDate = new DateTime(2018, 9, 26);
        static DateTime highSeasonDate = new DateTime(2018, 7, 26);


        public static IEnumerable<object[]> GetLocalData()
        {
            var data = new List<object[]>
            {
                new object[] { 0, lowSeasonDate, 2500 },
                new object[] { 1, lowSeasonDate, 2510 },
                new object[] { 1, highSeasonDate, 3012 },
                new object[] { 100, lowSeasonDate, 3498 },
                new object[] { 501, lowSeasonDate, 6704 }
            };

            return data;
        }




        [Theory]
        [MemberData(nameof(GetLocalData))]
        public void CalculatePrice_ValidMemberData_PriceIsCorrect(int distance, DateTime date, decimal expectedPrice)
        {
            //Arrange
            PriceCalculator calculator = new PriceCalculator();
            //Act
            decimal price = calculator.CalculatePrice(distance, date);
            //Assert
            Assert.Equal(expectedPrice, price);
        }







        [Theory]
        [MemberData(nameof(TestDataGenerator.GetData), MemberType = typeof(TestDataGenerator))]
        public void CalculatePrice_ValidExternalMemberData_PriceIsCorrect(int distance, DateTime date, decimal expectedPrice)
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
