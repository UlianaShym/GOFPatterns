using System;

namespace GofPatternsFun.Structural.Adapter.NewLogic
{
    class Mixture
    {
        protected string chemical;
        protected float boilingPoint;
        protected string molecularFormula;

        // Constructor
        public Mixture(string chemical)
        {
            this.chemical = chemical;
        }

        public virtual void Display()
        {
            Console.WriteLine("Mixture: {0}", chemical);
        }
    }
}
