namespace GofPatternsFun.Creational.FactoryMethod
{
    class DbFactory
    {
        public static IConnection ConnectToDb(DbType type)
        {
            if (type == DbType.Oracle)
            {
                return new OracleConnection();
            }
            return new SqlConnection();
        }
    }
}
