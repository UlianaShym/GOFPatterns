using GofPatternsFun.Creational.AbstractFactory.Models;

namespace GofPatternsFun.Creational.AbstractFactory.Factories
{
    public interface IMealFactory
    {
        Supper GetSupper();
        Breakfast GetBreakfast();
    }
}