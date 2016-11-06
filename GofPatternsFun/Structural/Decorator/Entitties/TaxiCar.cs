using System;

namespace GofPatternsFun.Structural.Decorator.Entitties
{
    class TaxiCar : Car
    {
        public override void Go()
        {
            Console.WriteLine("I am taxi car and I can stop where i want. ");
            base.Go();
        }
    }
}
