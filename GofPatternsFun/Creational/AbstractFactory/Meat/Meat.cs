using System;

namespace GofPatternsFun.Creational.AbstractFactory.Meat
{
    public abstract class Meat
    {
        public string Name { get; set; }

        protected Meat(string name)
        {
            Name = name;
            Console.WriteLine(Name);
        }
    }
}
