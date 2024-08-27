using DesignPatterns.FactoryMethod;

namespace DesignPatterns.FactoryMethod
{
    // Abstract Product
    public abstract class DbConnector
    {
        protected DbConnector(string connectionString) =>
            ConnectionString = connectionString;

        public string ConnectionString { get; set; }
        public abstract Connection Connect();
    }
}
