using System;
using System.Collections;
using System.Collections.Generic;

namespace Buscompany.UnitTests
{
    public class TestDataGenerator : IEnumerable<object[]>
    {
        static DateTime lowSeasonDate = new DateTime(2018, 9, 26);
        static DateTime highSeasonDate = new DateTime(2018, 7, 26);

        // This list is loaded as test data for data-driven unit
        // tests using the ClassData attribute.
        // The test runner will instantiate the class and call its
        // ToList() method (this is possible because the class is
        // enumerable).
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] { 0, lowSeasonDate, 2500 },
            new object[] { 1, lowSeasonDate, 2510 },
            new object[] { 1, highSeasonDate, 3012 },
            new object[] { 100, lowSeasonDate, 3498 },
            new object[] { 501, lowSeasonDate, 6704 }
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // This method is used by property data-driven unit tests
        // (i.e. unit tests using the MemberData attribute)
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { 0, lowSeasonDate, 2500 };
            yield return new object[] { 1, lowSeasonDate, 2510 };
            yield return new object[] { 1, highSeasonDate, 3012 };
            yield return new object[] { 100, lowSeasonDate, 3498 };
            yield return new object[] { 501, lowSeasonDate, 6704 };
        }

    }
}
