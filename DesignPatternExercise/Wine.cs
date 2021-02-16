using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExercise
{
    class Wine : iManufacture
    {
        private double _wPrice;

        public Wine(double wPrice)
        {
            _wPrice = wPrice;
        }

        public double GetPrice()
        {
            return _wPrice;
        }
    }
}
