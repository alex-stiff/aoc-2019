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
            var codes = ParseInput("inputs/2.txt")[0]
                .Split(',')
                .Select(int.Parse)
                .ToList();

            var program = new IntcodeProgram(codes);
            var answer = RunDayTwoPartTwo(program);
            Console.WriteLine(answer);
        }

        private static int RunDayTwoPartTwo(IntcodeProgram program)
        {
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
                            return program.Noun * 100 + program.Verb;
                        }
                    }
                    catch { }
                }
            }
            return 0;
        }

        private static List<string> ParseInput(string input)
        {
            return new List<string>(File.ReadAllLines(input));
        }
    }
}
