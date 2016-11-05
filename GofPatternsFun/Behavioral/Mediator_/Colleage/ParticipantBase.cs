using System;

namespace GofPatternsFun.Behavioral.Mediator_.Colleage
{
    class ParticipantBase
    {
        private ChatRoomMediator chatroom;
        private string name;

        public ParticipantBase(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        public ChatRoomMediator Chatroom
        {
            set { chatroom = value; }
            get { return chatroom; }
        }

        // Sends message to given participant
        public virtual void Send(string to, string message)
        {
            chatroom.Send(name, to, message);
        }

        // Receives message from given participant
        public virtual void Receive(
          string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'",
              from, Name, message);
        }

    }
}
