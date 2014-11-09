using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RoeldeWit.Framework.Test.Classes
{
    /// <summary>
    /// Class with all the tests for Temperature class
    /// </summary>
    [TestClass]
    public class TemperatureTest
    {
        private const double Precision = 1e-6;

        /// <summary>
        /// Test temperature conversion with Celsius as starting temperature unit
        /// </summary>
        [TestMethod]
        [Owner("Roel de Wit")]
        public void Temperature_Celcius()
        {
            Temperature temperature = new Temperature(TemperatureUnit.Celsius, -273.15);

            Assert.AreEqual(-273.15, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(-459.67, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");
            Assert.AreEqual(0, temperature.DegreesKelvin, Precision, "Wrong value of degrees Kelvin");

            temperature = new Temperature(TemperatureUnit.Celsius, 0);

            Assert.AreEqual(0, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(32, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");
            Assert.AreEqual(273.15, temperature.DegreesKelvin, Precision, "Wrong value of degrees Kelvin");

            temperature = new Temperature(TemperatureUnit.Celsius, 10);

            Assert.AreEqual(10, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(50, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");
            Assert.AreEqual(283.15, temperature.DegreesKelvin, Precision, "Wrong value of degrees Kelvin");

            temperature = new Temperature(TemperatureUnit.Celsius, 21);

            Assert.AreEqual(21, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(69.8, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");
            Assert.AreEqual(294.15, temperature.DegreesKelvin, Precision, "Wrong value of degrees Kelvin");

            temperature = new Temperature(TemperatureUnit.Celsius, 37);

            Assert.AreEqual(37, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(98.6, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");
            Assert.AreEqual(310.15, temperature.DegreesKelvin, Precision, "Wrong value of degrees Kelvin");

            temperature = new Temperature(TemperatureUnit.Celsius, 100);

            Assert.AreEqual(100, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(212, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");
            Assert.AreEqual(373.15, temperature.DegreesKelvin, Precision, "Wrong value of degrees Kelvin");
        }

        /// <summary>
        /// Test temperature conversion with Fahrenheit as starting temperature unit
        /// </summary>
        [TestMethod]
        [Owner("Roel de Wit")]
        public void Temperature_Fahrenheit()
        {
            Temperature temperature = new Temperature(TemperatureUnit.Fahrenheit, -459.67);

            Assert.AreEqual(-273.15, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(-459.67, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");
            Assert.AreEqual(0, temperature.DegreesKelvin, Precision, "Wrong value of degrees Kelvin");

            temperature = new Temperature(TemperatureUnit.Fahrenheit, 32);

            Assert.AreEqual(0, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(32, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");
            Assert.AreEqual(273.15, temperature.DegreesKelvin, Precision, "Wrong value of degrees Kelvin");

            temperature = new Temperature(TemperatureUnit.Fahrenheit, 50);

            Assert.AreEqual(10, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(50, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");
            Assert.AreEqual(283.15, temperature.DegreesKelvin, Precision, "Wrong value of degrees Kelvin");

            temperature = new Temperature(TemperatureUnit.Fahrenheit, 69.8);

            Assert.AreEqual(21, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(69.8, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");
            Assert.AreEqual(294.15, temperature.DegreesKelvin, Precision, "Wrong value of degrees Kelvin");

            temperature = new Temperature(TemperatureUnit.Fahrenheit, 98.6);

            Assert.AreEqual(37, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(98.6, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");
            Assert.AreEqual(310.15, temperature.DegreesKelvin, Precision, "Wrong value of degrees Kelvin");

            temperature = new Temperature(TemperatureUnit.Fahrenheit, 212);

            Assert.AreEqual(100, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(212, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");
            Assert.AreEqual(373.15, temperature.DegreesKelvin, Precision, "Wrong value of degrees Kelvin");
        }

        /// <summary>
        /// Test temperature conversion with Kelvin as starting temperature unit
        /// </summary>
        [TestMethod]
        [Owner("Roel de Wit")]
        public void Temperature_Kelvin()
        {
            Temperature temperature = new Temperature(TemperatureUnit.Kelvin, 0);

            Assert.AreEqual(-273.15, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(-459.67, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");
            Assert.AreEqual(0, temperature.DegreesKelvin, Precision, "Wrong value of degrees Kelvin");

            temperature = new Temperature(TemperatureUnit.Kelvin, 273.15);

            Assert.AreEqual(0, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(32, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");
            Assert.AreEqual(273.15, temperature.DegreesKelvin, Precision, "Wrong value of degrees Kelvin");

            temperature = new Temperature(TemperatureUnit.Kelvin, 283.15);

            Assert.AreEqual(10, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(50, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");
            Assert.AreEqual(283.15, temperature.DegreesKelvin, Precision, "Wrong value of degrees Kelvin");

            temperature = new Temperature(TemperatureUnit.Kelvin, 294.15);

            Assert.AreEqual(21, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(69.8, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");
            Assert.AreEqual(294.15, temperature.DegreesKelvin, Precision, "Wrong value of degrees Kelvin");

            temperature = new Temperature(TemperatureUnit.Kelvin, 310.15);

            Assert.AreEqual(37, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(98.6, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");
            Assert.AreEqual(310.15, temperature.DegreesKelvin, Precision, "Wrong value of degrees Kelvin");

            temperature = new Temperature(TemperatureUnit.Kelvin, 373.15);

            Assert.AreEqual(100, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(212, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");
            Assert.AreEqual(373.15, temperature.DegreesKelvin, Precision, "Wrong value of degrees Kelvin");
        }
    }
}
