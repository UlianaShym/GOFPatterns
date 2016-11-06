using System;

namespace GofPatternsFun.Behavioral.TemplateMethod
{
    class IntegralSolver
    {
        protected virtual void Solve()
        {
            Console.WriteLine("Simle integral solver");
        }
        
        protected virtual void ShowSteps()
        {
            Console.WriteLine("Shows steps how to solve integral");
        }

        protected virtual void ShowResult()
        {
            Console.WriteLine("Draw chart");
        }

        private void DrawChart()
        {
            Console.WriteLine("Draw chart");
        }

        public void TemplateSolve()
        {
            Solve();
            ShowSteps();
            ShowResult();
            DrawChart();
        }
    }
}
