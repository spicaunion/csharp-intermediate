using System;

namespace Database_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("...");
            sqlConnection.Timeout = TimeSpan.FromSeconds(1);
            var dbCommand = new DbCommand(sqlConnection, "SQL instruction");
            dbCommand.Execute();

            var oracleConnection = new OracleConnection("...");
            dbCommand = new DbCommand(oracleConnection, "Oracle instruction");
            dbCommand.Execute();

            Console.ReadKey();
        }
    }
}
