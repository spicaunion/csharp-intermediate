using Database_exercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Database_tests
{
    [TestClass]
    public class DbCommandTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DbCommand_DbConnectionArgumentIsNull_ThrowsException()
        {
            var dbCommand = new DbCommand(null, "...");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DbCommand_InstructionIsNullOrEmpty_ThrowsException()
        {
            var sqlConnection = new SqlConnection("...");
            var dbCommand = new DbCommand(sqlConnection, null);
            dbCommand = new DbCommand(sqlConnection, string.Empty);
        }
    }
}
