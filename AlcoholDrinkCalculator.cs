using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholCalculator
{
    internal class AlcoholDrinkCalculator
    {
        private Drink _drink;
        private Glass _glass;
        private int _glassAmount;

        public AlcoholDrinkCalculator(Drink drink, Glass glass, int glassAmount)
        {
            _drink = drink;
            _glass = glass;
            _glassAmount = glassAmount;
        }

        public double OverallVolumeOfDrink()
        {
            return _glass.Volume * _glassAmount;
        }

        public double OverallSpiritPercentageOfDrink()
        {
            return OverallVolumeOfDrink() * _drink.SpiritPercentage / 100;
        }


    }
}
