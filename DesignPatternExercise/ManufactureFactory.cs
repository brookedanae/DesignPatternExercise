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
            //int numChocolate;
            double cPrice = 2.99;
            double wPrice = 9.99;
            switch (item.ToLower())
            {
                case "chocolate":
                    return new Chocolate(cPrice);
                case "wine":
                    return new Wine(wPrice);
                default:
                    throw new ArgumentOutOfRangeException(nameof(item));

            }
        }
    }
}
