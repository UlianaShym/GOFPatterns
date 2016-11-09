using System.Collections.Generic;
using GofPatternsFun.Behavioral.Observer.Observers;

namespace GofPatternsFun.Behavioral.Observer.Objects
{
    public abstract class Subject
    {
        private string symbol;
        private double price;
        private List<IInvestor> investors = new List<IInvestor>();

        public Subject(string symbol, double price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    Notify();
                }
            }
        }

        public string Symbol
        {
            get { return symbol; }
        }

        public void Attach(IInvestor investor)
        {
            investors.Add(investor);
        }

        public void Dettach(IInvestor investor)
        {
            investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (var investor in investors)
            {
                investor.Update(this);
            }
        }
    }
}
