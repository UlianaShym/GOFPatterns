using System;
using GofPatternsFun.Structural.Decorator.Entitties;

namespace GofPatternsFun.Structural.Decorator
{
    class AutoCar : CarDecorator
    {
        public AutoCar(Car decoratedCar) : base(decoratedCar)
        {
        }

        public override void Go()
        {
            Console.WriteLine("Added auto transmission to car. Only to base class.");
            base.Go();
        }
    }
}
