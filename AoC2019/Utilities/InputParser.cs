using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AoC2019.Utilities
{
    public static class InputParser
    {
        public static List<int> ParseIntInput(string input)
        {
            return new List<int>(File.ReadAllLines(input).Select(int.Parse));
        }

        public static List<string> ParseStringInput(string input)
        {
            return new List<string>(File.ReadAllLines(input));
        }
    }
}
