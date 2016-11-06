using System;

namespace GofPatternsFun.Structural.Decorator.Entitties
{
    class Car
    {
        public string BrandName { get; set; }

        public virtual void Go()
        {
            Console.WriteLine("I am {0}", BrandName);
        }
    }
}
