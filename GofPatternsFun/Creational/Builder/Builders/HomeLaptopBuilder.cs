namespace GofPatternsFun.Creational.Builder.Builders
{
    class HomeLaptopBuilder : LaptopBuilder
    {
        public override void SetName()
        {
            laptop.Name = "HP";
        }

        public override void SetSize()
        {
            laptop.Core = Core.Dual;
        }

        public override void SetCore()
        {
            laptop.Size = Size.Large;
        }
    }
}
