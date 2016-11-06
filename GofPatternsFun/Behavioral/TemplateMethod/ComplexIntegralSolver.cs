using System;

namespace GofPatternsFun.Behavioral.TemplateMethod
{
    class ComplexIntegralSolver : IntegralSolver
    {
        protected override void Solve()
        {
            Console.WriteLine("Complex integral solver via integration by parts");
        }
    }
}
