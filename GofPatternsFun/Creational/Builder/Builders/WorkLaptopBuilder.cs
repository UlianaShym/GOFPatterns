namespace GofPatternsFun.Creational.Builder.Builders
{
    class WorkLaptopBuilder : LaptopBuilder
    {
        public override void SetName()
        {
            laptop.Name = "Asus";
        }

        public override void SetSize()
        {
            laptop.Size = Size.ExtraLarge;
        }

        public override void SetCore()
        {
            laptop.Core = Core.I7;
        }
    }
}
