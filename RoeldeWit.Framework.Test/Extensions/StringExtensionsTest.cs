using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RoeldeWit.Framework.Test.Extensions
{
    /// <summary>
    /// Class with all the tests for string extensions
    /// </summary>
    [TestClass]
    public class StringExtensionsTest
    {
        /// <summary>
        /// Test FormatCurrent extension method
        /// </summary>
        [TestMethod]
        [Owner("Roel de Wit")]
        public void String_FormatCurrent()
        {
            string test = "{0} de {1}".FormatCurrent("Roel", "Wit");

            Assert.AreEqual("Roel de Wit", test, "Wrong format of string");

            test = "{0} {1} {2}".FormatCurrent("Roel", "de", "Wit");

            Assert.AreEqual("Roel de Wit", test, "Wrong format of string");

            test = "Result: {0}-{1}".FormatCurrent(1, 3);

            Assert.AreEqual("Result: 1-3", test, "Wrong format of string");
        }

        /// <summary>
        /// Test FormatInvariant extension method
        /// </summary>
        [TestMethod]
        [Owner("Roel de Wit")]
        public void String_FormatInvariant()
        {
            string test = "{0} de {1}".FormatInvariant("Roel", "Wit");

            Assert.AreEqual("Roel de Wit", test, "Wrong format of string");

            test = "{0} {1} {2}".FormatInvariant("Roel", "de", "Wit");

            Assert.AreEqual("Roel de Wit", test, "Wrong format of string");

            test = "Result: {0}-{1}".FormatInvariant(1, 3);

            Assert.AreEqual("Result: 1-3", test, "Wrong format of string");
        }
    }
}
