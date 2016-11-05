using System;

namespace GofPatternsFun.Behavioral.Mediator_.Colleage
{
    class Readonly : ParticipantBase
    {
        public Readonly(string name)
            : base(name)
        {
        }

        public override void Send(string to, string message)
        {
            Console.Write("You are a Readonly participant. You can't send a message.");
        }

        public override void Receive(string from, string message)
        {
           Console.Write("Recieved: ");
           base.Receive(from, message);
        }
    }
}
