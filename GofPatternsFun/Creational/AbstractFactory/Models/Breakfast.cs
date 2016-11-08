namespace GofPatternsFun.Creational.AbstractFactory.Models
{
    public abstract class Breakfast : Meat.Meat
    {
        protected Breakfast(string name) : base(name)
        {
        }
    }
}
