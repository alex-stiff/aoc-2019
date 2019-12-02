using System;
using System.Collections.Generic;
using System.Text;

namespace AoC2019
{
    public static class FuelCalculator
    {
        public static double CalculateFuel(double mass) => Math.Max(0, Math.Floor(mass / 3.0) - 2);
    }
}
