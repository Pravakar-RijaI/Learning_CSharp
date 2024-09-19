using System;
using System.Security.Cryptography.X509Certificates;

namespace Classes
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if(connectionString == null || connectionString == "" || connectionString == " ")
                throw new InvalidOperationException();

            this.ConnectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }

    public class SQLConnection : DbConnection
    {
        public SQLConnection(string connectionString)
            :base(connectionString)
        {
            
        }

        public override void OpenConnection()
        {
            Console.WriteLine(this.ConnectionString + " Successfully Connected.\n Time: " + this.Timeout);
        }

        public override void CloseConnection()
        {
            Console.WriteLine(this.ConnectionString + " Successfully Disconnected.\n Time: " + this.Timeout);
        }

    }

    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            :base(connectionString)
        {
            
        }

        public override void OpenConnection()
        {
            Console.WriteLine(this.ConnectionString + " Successfully Connected.\n Time: " + this.Timeout);
        }

        public override void CloseConnection()
        {
            Console.WriteLine(this.ConnectionString + " Successfully Disconnected.\n Time: " + this.Timeout);
        }
    }

    public class DbCommand
    {
        public string Instruction { get; private set; }
        private DbConnection _connect;

        public DbCommand(DbConnection connect , string instruction)
        {
            if (connect == null)
                throw new NullReferenceException("Cannot cater null objects.");
            if (String.IsNullOrEmpty(instruction))
                throw new NullReferenceException("Instruction can't be Null or Empty.");
            this._connect = connect;
            this.Instruction = instruction;
        }

        public void Execute()
        {
            _connect.OpenConnection();
            Console.WriteLine("Instruction: " + this.Instruction);
            _connect.CloseConnection();
        }
    }
}
