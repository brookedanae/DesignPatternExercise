using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExercise
{
    class Wine : iManufacture
    {
        private double _wPrice;
        private int _numWine;

        public Wine(double wPrice, int numWine)
        {
            _wPrice = wPrice;
            _numWine = numWine;
        }

        public double GetPrice()
        {
            return _wPrice * _numWine;
        }
    }
}
