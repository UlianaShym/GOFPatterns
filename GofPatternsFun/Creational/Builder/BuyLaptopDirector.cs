namespace GofPatternsFun.Creational.Builder
{
    class BuyLaptopDirector
    {
        private LaptopBuilder _lBuilder;

        public void CreateLaptop(LaptopBuilder lBuilder)
        {
            _lBuilder = lBuilder;
        }

        public Laptop GetLaptop()
        {
            return _lBuilder.GetLaptop();
        }

        public void BuildLaptop()
        {
            _lBuilder.CreateLaptop();
            _lBuilder.SetName();
            _lBuilder.SetSize();
            _lBuilder.SetCore();
        }
    }
}
