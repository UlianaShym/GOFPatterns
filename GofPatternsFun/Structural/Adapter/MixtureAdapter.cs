using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GofPatternsFun.Structural.Adapter.NewLogic;
using GofPatternsFun.Structural.Adapter.OldLogic;

namespace GofPatternsFun.Structural.Adapter
{
    class MixtureAdapter : Mixture
    {
        public MixtureAdapter(string chemical) : base(chemical)
        {
        }

        ChemicalDatabank chemicalDatabank;

        public override void Display()
        {
            // The Adaptee
            chemicalDatabank = new ChemicalDatabank();

            molecularFormula = chemicalDatabank.GetMolecularStructure(chemical);
            boilingPoint = chemicalDatabank.GetCriticalPoint(chemical);
            Console.WriteLine("---Adapter magic--");
            base.Display();
            Console.WriteLine("Formula: {0}", molecularFormula);
            Console.WriteLine("Boiling Point: {0}", boilingPoint);
        }
    }
}
