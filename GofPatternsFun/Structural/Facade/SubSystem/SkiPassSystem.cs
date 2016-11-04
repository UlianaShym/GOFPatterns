using System;

namespace GofPatternsFun.Structural.Facade.SubSystem
{
    class SkiPassSystem
    {
        public int BuyTicket(int days)
        {
            switch (days)
            {
                case 2:
                    return 200;
                case 3:
                    return 300;
                case 4:
                    return 400;
                case 5:
                    return 500;
                default:
                    throw new ArgumentException("Please set number of days from 2 to 5.");
            }
        }
    }
}
