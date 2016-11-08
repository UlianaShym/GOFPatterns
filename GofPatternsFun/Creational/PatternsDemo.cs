using System;
using GofPatternsFun.Creational.AbstractFactory.Factories;
using GofPatternsFun.Creational.Builder;
using GofPatternsFun.Creational.Builder.Builders;
using GofPatternsFun.Creational.FactoryMethod;
using GofPatternsFun.Creational.FactoryMethod.Factories;
using GofPatternsFun.Creational.Prototype;
using GofPatternsFun.Creational.Singleton;

namespace GofPatternsFun.Creational
{
    /// <summary>
    /// Helps to make object creation more simple.
    /// </summary>
    static class PatternsDemo
    {
        public static void Singleton()
        {
            int count = 0;
            var logger = Logger.GetInstance();
            logger.AddLog("Message " + ++count);
            logger.AddLog("Message " + ++count);
            logger.PrintAllLogs();

            var logger2 = Logger.GetInstance();
            logger2.AddLog("Message " + ++count);
            logger2.AddLog("Message " + ++count);
            Console.WriteLine("Second logger contains messages from first -> only 1 class instance.");
            logger2.PrintAllLogs();
        }

        public static void Singleton2Realization()
        {
            int count = 0;
            var logger = Logger2.GetInstance();
            logger.AddLog("Message " + ++count);
            logger.AddLog("Message " + ++count);
            logger.PrintAllLogs();

            var logger2 = Logger2.GetInstance();
            logger2.AddLog("Message " + ++count);
            logger2.AddLog("Message " + ++count);
            Console.WriteLine("Second logger contains messages from first -> only 1 class instance.");
            logger2.PrintAllLogs();
        }

        public static void Builder()
        {
            HomeLaptopBuilder homeLaptopBuilder = new HomeLaptopBuilder();
            BuyLaptopDirector buyLaptop = new BuyLaptopDirector();
            buyLaptop.CreateLaptopBuilder(homeLaptopBuilder);
            buyLaptop.BuildLaptop();
            buyLaptop.GetLaptop();

            CustomLaptopBuilder customLaptopBuilder = new CustomLaptopBuilder("Apple", Size.ExtraLarge, Core.I7);
            buyLaptop.CreateLaptopBuilder(customLaptopBuilder);
            buyLaptop.BuildLaptop();
            buyLaptop.GetLaptop();
        }

        public static void FactoryMethod()
        {
            DbFactory dbFactory = new SqlFactory();
            IConnection sqlConn = dbFactory.ConnectToDb();

            DbFactory dbFactory2 = new OracleFactory();
            IConnection oracleConn = dbFactory2.ConnectToDb();
        }

        public static void AbstractFactory()
        {
            MeatFactory meatFactory = new MeatFactory();
            meatFactory.GetBreakfast();
            meatFactory.GetSupper();

            VegeterianFactory vegeterianFactory = new VegeterianFactory();
            vegeterianFactory.GetBreakfast();
            vegeterianFactory.GetSupper();
        }

        public static void Prototype()
        {
            Developer dev = new Developer
            {
                PreferredLanguage = ".NET",
                Name = "Uliana",
                Role = "Junior"
            };

            Console.WriteLine(dev.GetDetails());

            // This info is very hard to get( long SQL operation)
            TechWriter writer = new TechWriter
            {
                WordsPerMinute = 156,
                Name = "Bob",
                Role = "Trainee"
            };
            Console.WriteLine(writer.GetDetails());

            // So for new writer we just copy existing info
            TechWriter writer2 = (TechWriter) writer.Clone();
            writer2.WordsPerMinute = 45;
            Console.WriteLine(writer2.GetDetails());
            Console.WriteLine(writer.GetDetails());
        }
    }
}
