using System;

namespace GofPatternsFun.Creational.FactoryMethod
{
    class OracleConnection : IConnection
    {
        public OracleConnection()
        {
            Console.WriteLine("Successfully connected to oracle db.");
        }
        public void CreateConnection()
        {
            Console.WriteLine("Successfully connected to oracle db.");
        }
    }
}
