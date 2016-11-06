using GofPatternsFun.Behavioral.Mediator_;
using GofPatternsFun.Behavioral.Mediator_.Colleage;
using GofPatternsFun.Behavioral.Strategy;
using GofPatternsFun.Behavioral.Strategy.Strategies;
using GofPatternsFun.Behavioral.TemplateMethod;

namespace GofPatternsFun.Behavioral
{
    class BehaviourPatternsDemo
    {
        public static void Mediator()
        {
            ChatRoomMediator mediator = new ChatRoomMediator();
            Writeonly writeonly = new Writeonly("Bob");
            Readonly readonlyp = new Readonly("Bob2");
            mediator.Register(writeonly);
            mediator.Register(readonlyp);
            mediator.Send("Bob", "Bob2", "Message");
            mediator.Send("Bob2", "Bob", "Text message.");
        }

        public static void TemplateMethod()
        {
            IntegralSolver integralSolver = new IntegralSolver();
            integralSolver.TemplateSolve();

            // We need to solve complex integral need to change solving step
            IntegralSolver complexIntegralSolver = new ComplexIntegralSolver();
            complexIntegralSolver.TemplateSolve();
        }

        public static void Strategy()
        {
            SortContext sortContext = new SortContext();
            sortContext.SetSortedStrategy(new MergeSortStrategy());
            sortContext.Sort();
            sortContext.SetSortedStrategy(new QuickSortStrategy());
            sortContext.Sort();
        }
    }
}
