using System;
using GofPatternsFun.Creational.Builder;
using GofPatternsFun.Creational.Builder.Builders;
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
    }
}
