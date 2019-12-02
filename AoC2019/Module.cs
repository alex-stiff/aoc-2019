using System;
using System.Collections.Generic;
using System.Text;

namespace AoC2019
{
    public class Module
    {
        public double Mass { get; set; }

        public double CalculateBasicFuelRequirement()
        {
            return FuelCalculator.CalculateFuel(Mass);
        }

        public double CalculateAdvancedFuelRequirement()
        {
            return CalculateFuelRequirement(Mass);
        }

        public double CalculateFuelRequirement(double mass)
        {
            var fuelRequired = FuelCalculator.CalculateFuel(mass);

            if (fuelRequired == 0)
            {
                return 0;
            }

            return fuelRequired + CalculateFuelRequirement(fuelRequired);
        }
    }
}
