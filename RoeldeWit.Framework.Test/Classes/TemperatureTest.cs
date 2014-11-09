using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RoeldeWit.Framework.Test.Classes
{
    [TestClass]
    public class TemperatureTest
    {
        private const double Precision = 1e-6;

        [TestMethod]
        public void Temperature_Celcius()
        {
            Temperature temperature = new Temperature(TemperatureUnit.Celsius, -273.15);

            Assert.AreEqual(-273.15, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(-459.67, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");

            temperature = new Temperature(TemperatureUnit.Celsius, 0);

            Assert.AreEqual(0, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(32, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");

            temperature = new Temperature(TemperatureUnit.Celsius, 10);

            Assert.AreEqual(10, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(50, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");

            temperature = new Temperature(TemperatureUnit.Celsius, 21);

            Assert.AreEqual(21, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(69.8, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");

            temperature = new Temperature(TemperatureUnit.Celsius, 37);

            Assert.AreEqual(37, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(98.6, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");

            temperature = new Temperature(TemperatureUnit.Celsius, 100);

            Assert.AreEqual(100, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(212, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");
        }

        [TestMethod]
        public void Temperature_Fahrenheit()
        {
            Temperature temperature = new Temperature(TemperatureUnit.Fahrenheit, -459.67);

            Assert.AreEqual(-273.15, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(-459.67, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");

            temperature = new Temperature(TemperatureUnit.Fahrenheit, 32);

            Assert.AreEqual(0, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(32, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");

            temperature = new Temperature(TemperatureUnit.Fahrenheit, 50);

            Assert.AreEqual(10, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(50, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");

            temperature = new Temperature(TemperatureUnit.Fahrenheit, 69.8);

            Assert.AreEqual(21, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(69.8, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");

            temperature = new Temperature(TemperatureUnit.Fahrenheit, 98.6);

            Assert.AreEqual(37, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(98.6, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");

            temperature = new Temperature(TemperatureUnit.Fahrenheit, 212);

            Assert.AreEqual(100, temperature.DegreesCelsius, Precision, "Wrong value of degrees Celsius");
            Assert.AreEqual(212, temperature.DegreesFahrenheit, Precision, "Wrong value of degrees Fahrenheit");
        }
    }
}
