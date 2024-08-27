namespace DesignPatterns.FactoryMethod
{
    // Concrete Creator
    public class SqlFactory : DbFactory
    {
        // FactoryMethod
        public override DbConnector CreateConnector(string connectionString) =>
            new SqlServerConnector(connectionString);
        
    }
}
