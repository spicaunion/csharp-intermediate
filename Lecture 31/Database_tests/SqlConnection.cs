using Database_exercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Database_tests
{
    [TestClass]
    public class SqlConnectionTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConnectionString_IsNullOrEmpty_ThrowsException()
        {
            var sqlConnection = new SqlConnection(null);
            sqlConnection = new SqlConnection(string.Empty);
        }
    }
}
