using GofPatternsFun.Creational.AbstractFactory.Models;
using GofPatternsFun.Creational.AbstractFactory.Vegeterian;

namespace GofPatternsFun.Creational.AbstractFactory.Factories
{
    class VegeterianFactory : IMealFactory
    {
        public Supper GetSupper()
        {
            return new VegeterianSupper();
        }

        public Breakfast GetBreakfast()
        {
            return new VegeterianBreakfast();
        }
    }
}
