using System;

namespace GofPatternsFun.Behavioral.Mediator_.Colleage
{
    class Writeonly : ParticipantBase
    {
        public Writeonly(string name) : base(name)
        {
        }

        public override void Send(string to, string message)
        {
            Console.Write("To a All from Writeonly: ");
            base.Send(to, message);
        }

        public override void Receive(string from, string message)
        {
            Console.Write("You are a Writeonly participant. You can't receive message.");
        }
    }
}
