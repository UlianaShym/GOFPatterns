using System;
using GofPatternsFun.Behavioral.Observer.Objects;

namespace GofPatternsFun.Behavioral.Observer.Observers
{
    class Investor : IInvestor
    {
        private string name;
        // Gets or sets the stock
        public Subject Subject { get; set; }

        // Constructor
        public Investor(string name)
        {
            this.name = name;
        }

        public void Update(Subject subject)
        {
            Console.WriteLine("Notified {0} of {1}'s " +
              "change to {2:C}", name, subject.Symbol, subject.Price);
        }
    }
}
