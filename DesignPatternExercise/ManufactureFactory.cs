using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExercise
{

    public class ManufactureFactory
    {
        public ManufactureFactory()
        {

        }
        public iManufacture Create(string item, double price)
        {
            int numChocolate = 0;
            double cPrice = 0;
            int numWine = 0;
            double wPrice = 0;
            switch (item.ToLower())
            {
                case "chocolate":
                    return new Chocolate(cPrice, numChocolate);
                case "wine":
                    return new Wine(wPrice, numWine);
                default:
                    throw new ArgumentOutOfRangeException(nameof(item));

            }
        }
    }
}
