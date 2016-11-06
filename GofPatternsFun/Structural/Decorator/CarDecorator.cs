using GofPatternsFun.Structural.Decorator.Entitties;

namespace GofPatternsFun.Structural.Decorator
{
    class CarDecorator : Car
    {
        protected Car DecoratedCar;

        public CarDecorator(Car decoratedCar)
        {
            DecoratedCar = decoratedCar;
        }

        public override void Go()
        {
            DecoratedCar.Go();
        }
    }
}
