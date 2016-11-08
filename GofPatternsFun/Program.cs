using GofPatternsFun.Behavioral;
using GofPatternsFun.Creational;
using GofPatternsFun.Structural;

namespace GofPatternsFun
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Creational
            //PatternsDemo.Singleton();
            //PatternsDemo.Singleton2Realization();
            //PatternsDemo.Builder();
            //PatternsDemo.FactoryMethod();
            //PatternsDemo.AbstractFactory();
            PatternsDemo.Prototype();

            #endregion

            #region Structural

            //StructuralPatternsDemo.Adapter();
            //StructuralPatternsDemo.Facade();
            //StructuralPatternsDemo.Decorator();

            #endregion

            #region Behaviour

            //BehaviourPatternsDemo.Mediator();
            //BehaviourPatternsDemo.TemplateMethod();
            //BehaviourPatternsDemo.Strategy();

            #endregion
        }
    }
}
