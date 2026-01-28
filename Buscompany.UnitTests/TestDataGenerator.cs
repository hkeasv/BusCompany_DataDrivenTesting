using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Buscompany.UnitTests
{
    public class TestDataGenerator : TheoryData<int, DateTime, decimal>
    {
        static DateTime lowSeasonDate = new DateTime(2018, 9, 26);
        static DateTime highSeasonDate = new DateTime(2018, 7, 26);

        public TestDataGenerator()
        {
            // This list is loaded as test data for data-driven unit tests using the ClassData attribute.
            Add(0, lowSeasonDate, 2500);
            Add(1, lowSeasonDate, 2510);
            Add(1, highSeasonDate, 3012);
            Add(100, lowSeasonDate, 3498);
            Add(501, lowSeasonDate, 6704);
        }
        

        // This method is used by property data-driven unit tests
        // (i.e. unit tests using the MemberData attribute)
        public static TheoryData<int, DateTime, decimal> GetData()
        {
            var data = new TheoryData<int, DateTime, decimal>
            {
                { 0, lowSeasonDate, 2500 },
                { 1, lowSeasonDate, 2510 },
                { 1, highSeasonDate, 3012 },
                { 100, lowSeasonDate, 3498 },
                { 501, lowSeasonDate, 6704 }
            };

            return data;
        }

    }
}
