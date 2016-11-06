using System;

namespace GofPatternsFun.Creational.FactoryMethod
{
    class SqlConnection : IConnection
    {
        public SqlConnection()
        {
            Console.WriteLine("Successfully connected to sql db.");
        }

        public void CreateConnection()
        {
            Console.WriteLine("Successfully connected to sql db.");
        }
    }
}
