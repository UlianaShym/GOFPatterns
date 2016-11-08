namespace GofPatternsFun.Creational.FactoryMethod.Factories
{
    abstract class DbFactory
    {
        public abstract IConnection ConnectToDb();
    }
}
