namespace GofPatternsFun.Creational.FactoryMethod.Factories
{
    class SqlFactory : DbFactory
    {
        public override IConnection ConnectToDb()
        {
            return new SqlConnection();
        }
    }
}
