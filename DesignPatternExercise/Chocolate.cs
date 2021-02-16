using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExercise
{
    class Chocolate : iManufacture
    {
        private double _cPrice;

        public Chocolate (double cPrice)
        {
            _cPrice = cPrice;

        }

        public double GetPrice()
        {
            return _cPrice;
        }
    }
}
