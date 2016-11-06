using System;
using GofPatternsFun.Structural.Adapter;
using GofPatternsFun.Structural.Adapter.NewLogic;
using GofPatternsFun.Structural.Decorator;
using GofPatternsFun.Structural.Decorator.Entitties;
using GofPatternsFun.Structural.Facade;

namespace GofPatternsFun.Structural
{
    static class StructuralPatternsDemo
    {
        public static void Adapter()
        {
            Mixture mixture = new Mixture("water");
            // Display mixture info without adapter. Recewed info only about name.
            mixture.Display();
            MixtureAdapter adapter = new MixtureAdapter("water");
            adapter.Display();
        }

        public static void Decorator()
        {
            TaxiCar taxi = new TaxiCar();
            CarDecorator carDecorator = new AutoCar(taxi);
            carDecorator.Go();
        }

        public static void Facade()
        {
            SkiResortFacade facade = new SkiResortFacade();
            Console.WriteLine("You booked your tour. Price = {0}.", facade.BookSkiTour(4, 3));
        }
    }
}
