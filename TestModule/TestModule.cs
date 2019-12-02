using NUnit.Framework;
using AoC2019;

namespace TestModule
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(12, 2)]
        [TestCase(14, 2)]
        [TestCase(1969, 654)]
        [TestCase(100756, 33583)]
        public void Test_module_mass_calculation(int mass, double expectedFuelRequired)
        {
            var module = new Module
            {
                Mass = mass
            };

            var actualFuelRequired = module.CalculateBasicFuelRequirement();

            Assert.AreEqual(expectedFuelRequired, actualFuelRequired);
        }

        [TestCase(12, 2)]
        [TestCase(14, 2)]
        [TestCase(1969, 966)]
        public void Test_module_new_mass_calculation(int mass, double expectedFuelRequired)
        {
            var module = new Module
            {
                Mass = mass
            };

            var actualFuelRequired = module.CalculateAdvancedFuelRequirement();

            Assert.AreEqual(expectedFuelRequired, actualFuelRequired);
        }
    }
}