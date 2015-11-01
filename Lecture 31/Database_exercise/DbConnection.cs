using System;

namespace Database_exercise
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;

        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentException("ConnectionString cannot be null or empty!");

            _connectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}
