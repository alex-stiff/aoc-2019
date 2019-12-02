using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AoC2019
{
    class Program
    {
        static void Main(string[] args)
        {
            var codes = ParseInput("inputs/2.txt")[0].Split(',').Select(int.Parse).ToList(); // 3706713
            var program = new IntcodeProgram(codes);

            for (var noun = 0; noun < 100; noun++)
            {
                for (var verb = 0; verb < 100; verb++)
                {
                    try
                    {
                        Console.WriteLine($"{noun}, {verb}");
                        program.Reset();
                        program.Noun = noun;
                        program.Verb = verb;
                        program.Run();
                        //if (program.CurrentMemory[0] == 19690720)
                        //{
                        //    Console.WriteLine($"{noun}, {verb}");
                        //    return;
                        //}
                    }
                    catch(Exception)
                    {
                    }
                }
            }
            
            //var output = IntcodeProgram.Run(codes);
            //Console.WriteLine(string.Join(',', output));
        }

        private static List<string> ParseInput(string input)
        {
            return new List<string>(File.ReadAllLines(input));
        }
    }
}
