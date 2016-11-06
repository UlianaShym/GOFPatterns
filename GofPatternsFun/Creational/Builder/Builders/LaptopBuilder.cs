using System;

namespace GofPatternsFun.Creational.Builder.Builders
{
    abstract class LaptopBuilder
    {
        protected Laptop laptop;

        public void CreateLaptop()
        {
            laptop = new Laptop();
        }

        public Laptop GetLaptop()
        {
            Console.WriteLine("Name = {0}, Size = {1}, Core = {2}", laptop.Name, laptop.Size, laptop.Core);
            return laptop;
        }

        public abstract void SetName();
        public abstract void SetSize();
        public abstract void SetCore();
    }
}
