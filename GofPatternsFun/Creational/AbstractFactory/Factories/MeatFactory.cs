using GofPatternsFun.Creational.AbstractFactory.Meat;
using GofPatternsFun.Creational.AbstractFactory.Models;

namespace GofPatternsFun.Creational.AbstractFactory.Factories
{
    class MeatFactory : IMealFactory
    {
        public Supper GetSupper()
        {
            return new MeatSupper();
        }

        public Breakfast GetBreakfast()
        {
            return new MeatBreakfast();
        }
    }
}
