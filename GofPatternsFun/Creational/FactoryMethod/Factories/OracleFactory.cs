namespace GofPatternsFun.Creational.FactoryMethod.Factories
{
    class OracleFactory : DbFactory
    {
        public override IConnection ConnectToDb()
        {
            return new OracleConnection();
        }
    }
}
