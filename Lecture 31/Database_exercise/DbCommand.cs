using System;

namespace Database_exercise
{
    public class DbCommand
    {
        private readonly DbConnection _dbconnection;
        private readonly string _instruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null)
                throw new ArgumentNullException("Database connection cannot be null!");

            if (string.IsNullOrEmpty(instruction))
                throw new ArgumentException("Instruction cannot be null or empty!");

            _dbconnection = dbConnection;
            _instruction = instruction;
        }

        public void Execute()
        {
            _dbconnection.Open();
            Console.WriteLine(_instruction);
            _dbconnection.Close();
        }
    }
}
