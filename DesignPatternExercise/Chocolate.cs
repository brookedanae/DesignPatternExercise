using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExercise
{
    class Chocolate : iManufacture
    {
        private double _cPrice;
        private int _numChocolate;

        public Chocolate (double cPrice, int numChocolate)
        {
            _cPrice = cPrice;
            _numChocolate = numChocolate;
        }

        public double GetPrice()
        {
            return _cPrice * _numChocolate;
        }
    }
}
