using System;
using System.Collections.Generic;
using System.Text;

namespace AoC2019.Day1
{
    public class Module
    {
        public double Mass { get; set; }
        public double CalculateFuelRequirement() => FuelCalculator.CalculateFuel(Mass);
        public double CalculateAdvancedFuelRequirement() => FuelCalculator.CalculateAdvancedFuel(Mass);
    }
}
