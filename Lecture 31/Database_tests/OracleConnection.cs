using Database_exercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Database_tests
{
    [TestClass]
    public class OracleConnectionTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConnectionString_IsNullOrEmpty_ThrowsException()
        {
            var oracleConnection = new OracleConnection(null);
            oracleConnection = new OracleConnection(string.Empty);
        }
    }
}
