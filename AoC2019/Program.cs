using AoC2019.Day1;
using AoC2019.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AoC2019
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine(RunDayOnePartOne());
            //Console.WriteLine(RunDayOnePartTwo());
            //Console.WriteLine(RunDayTwoPartOne());
            //Console.WriteLine(RunDayTwoPartTwo());
        }

        private static double RunDayOnePartOne()
        {
            return InputParser
                .ParseIntInput("Day1/input.txt")
                .Select(x => new Module { Mass = x })
                .Select(x => x.CalculateFuelRequirement())
                .Sum();
        }

        private static double RunDayOnePartTwo()
        {
            return InputParser
                .ParseIntInput("Day1/input.txt")
                .Select(x => new Module { Mass = x })
                .Select(x => x.CalculateAdvancedFuelRequirement())
                .Sum();
        }

        private static int RunDayTwoPartOne()
        {
            var initialMemory = InputParser
                .ParseStringInput("Day2/input.txt")
                .First()
                .Split(',')
                .Select(int.Parse)
                .ToList();

            var program = new IntcodeProgram(initialMemory)
            {
                Verb = 12,
                Noun = 2
            };

            program.Run();

            return program.CurrentMemory[0];
        }

        private static int RunDayTwoPartTwo()
        {
            var initialMemory = InputParser
                .ParseStringInput("Day2/input.txt")
                .First()
                .Split(',')
                .Select(int.Parse)
                .ToList();

            var program = new IntcodeProgram(initialMemory);

            for (var noun = 0; noun < 100; noun++)
            {
                for (var verb = 0; verb < 100; verb++)
                {
                    try
                    {
                        program.Reset();
                        program.Noun = noun;
                        program.Verb = verb;
                        program.Run();

                        if (program.CurrentMemory[0] == 19690720)
                        {
                            return noun * 100 + verb;
                        }
                    }
                    catch
                    {
                        // Invalid program input
                    }
                }
            }
            return 0;
        }
    }
}
