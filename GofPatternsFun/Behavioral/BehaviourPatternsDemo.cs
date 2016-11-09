using GofPatternsFun.Behavioral.ChainOfResponsibility;
using GofPatternsFun.Behavioral.ChainOfResponsibility.Handlers;
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

        public static void ChainOfResponsibility()
        {
            Approver vicePresident = new VicePresident();
            Approver president = new President();
            Approver director = new Director();

            director.SetSuccessor(vicePresident);
            vicePresident.SetSuccessor(president);

            var order1 = new Purchase(2034, 350.0, "Assets");
            director.ProcessRequest(order1);
            var order2 = new Purchase(2035, 35000.0, "Assets bigger amount.");
            director.ProcessRequest(order2);
            var order3 = new Purchase(2036, 350000.0, "Assets the biggest amount.");
            director.ProcessRequest(order3);
        }
    }
}
