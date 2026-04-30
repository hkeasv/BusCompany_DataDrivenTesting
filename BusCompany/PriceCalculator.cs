using System;

namespace BusCompany
{
    public class PriceCalculator
    {
        int initialFee = 2500;
        int d1KmFee = 10;
        int d2KmFee = 8;
        int d3KmFee = 6;
        decimal highSeasonExtra = (decimal)1.2;

        public decimal CalculatePrice(int distance, DateTime date){
            int d1 = 0, d2 = 0, d3 = 0;

            if (distance < 0)
                throw new ArgumentException("Distance cannot be negative!");

            if (distance < 100)
                d1 = distance;
            else if (distance <= 500)
            {
                d1 = 99;
                d2 = distance - 99;
            }
            else{
                d1 = 99;
                d2 = 401;
                d3 = distance - 500;
            }

            decimal price = initialFee + d1KmFee*d1 + d2KmFee*d2 + d3KmFee * d3;

            // Multiply with HighSeasonExtra if the bus is rented in July.
            if (date.Month == 7)
                price *= highSeasonExtra;

            return price;
        }


    }
}
