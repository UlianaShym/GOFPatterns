using System;

namespace GofPatternsFun.Creational.Builder.Builders
{
    class CustomLaptopBuilder : LaptopBuilder
    {
        private Laptop _laptop = new Laptop();

        public CustomLaptopBuilder(string name, Size size, Core core)
        {
            _laptop.Name = name;
            _laptop.Size = size;
            _laptop.Core = core;
        }

        public override void SetName()
        {
            laptop.Name = _laptop.Name;
        }

        public override void SetSize()
        {
            laptop.Size = _laptop.Size;
        }

        public override void SetCore()
        {
            laptop.Core = _laptop.Core;
        }
    }
}
