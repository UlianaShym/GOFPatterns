using System;
using GofPatternsFun.Structural.Facade;

namespace GofPatternsFun.Structural
{
    static class StructuralPatternsDemo
    {
        public static void Facade()
        {
            SkiResortFacade facade = new SkiResortFacade();
            Console.WriteLine("You booked your tour. Price = {0}.", facade.BookSkiTour(4, 3));
        }

    }
}
