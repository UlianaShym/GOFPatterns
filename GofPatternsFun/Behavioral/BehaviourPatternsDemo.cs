using GofPatternsFun.Behavioral.Mediator_;
using GofPatternsFun.Behavioral.Mediator_.Colleage;

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
            mediator.Send("Bob2", "Bob", "ivub");
        }
    }
}
