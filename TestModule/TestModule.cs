using NUnit.Framework;
using AoC2019;
using System.Collections.Generic;
using System.Linq;

namespace TestIntcode
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_basic_program()
        {
            var instructions = new List<int> { 1, 1, 1, 4, 99, 5, 6, 0, 99 };
            var program = new IntcodeProgram(instructions);
            var expectedOutput = new List<int> { 30, 1, 1, 4, 2, 5, 6, 0, 99 };

            program.Run();

            CollectionAssert.AreEqual(expectedOutput, program.CurrentMemory);
        }
    }
}