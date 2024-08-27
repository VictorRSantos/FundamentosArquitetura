namespace DesignPatterns.FactoryMethod
{
    // Concrete product
    public class SqlServerConnector : DbConnector
    {
        public SqlServerConnector(string connectioString) : base(connectioString)
        {
            ConnectionString = connectioString;
        }

        public override Connection Connect()
        {
            Console.WriteLine("Conectando ao banco SQL Server...");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
