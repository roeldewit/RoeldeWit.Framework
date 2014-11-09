using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeldeWit.Framework
{
    /// <summary>
    /// Temperature class
    /// </summary>
    public class Temperature
    {
        #region Public Properties

        /// <summary>
        /// Degrees Celsius
        /// </summary>
        public double DegreesCelsius { get; set; }

        /// <summary>
        /// Degrees Fahrenheit
        /// </summary>
        public double DegreesFahrenheit { get; set; }

        /// <summary>
        /// Degrees Kelvin
        /// </summary>
        public double DegreesKelvin { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="temperatureUnit">Temperature unit of measurement</param>
        /// <param name="degrees">Amount of degrees</param>
        public Temperature(TemperatureUnit temperatureUnit, double degrees)
        {
            switch (temperatureUnit)
            {
                case TemperatureUnit.Celsius:
                    DegreesCelsius = degrees;
                    DegreesFahrenheit = degrees * 9 / 5 + 32;
                    DegreesKelvin = degrees + 273.15;
                    break;
                case TemperatureUnit.Fahrenheit:
                    DegreesFahrenheit = degrees;
                    DegreesCelsius = (degrees - 32) * 5 / 9;
                    DegreesKelvin = (degrees + 459.67) * 5 / 9;
                    break;
                case TemperatureUnit.Kelvin:
                    DegreesKelvin = degrees;
                    DegreesFahrenheit = degrees * 9 / 5 - 459.67;
                    DegreesCelsius = degrees - 273.15;
                    break;
            }
        }

        #endregion
    }
}
