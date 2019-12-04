using System;

namespace AoC2019.Day1
{
    public static class FuelCalculator
    {
        public static double CalculateFuel(double mass) => Math.Max(0, Math.Floor(mass / 3.0) - 2);
        public static double CalculateAdvancedFuel(double mass)
        {
            var fuelRequired = CalculateFuel(mass);

            if (fuelRequired == 0)
            {
                return 0;
            }

            return fuelRequired + CalculateAdvancedFuel(fuelRequired);
        }
    }
}
