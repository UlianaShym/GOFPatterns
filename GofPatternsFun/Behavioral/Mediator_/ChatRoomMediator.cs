using System.Collections.Generic;
using GofPatternsFun.Behavioral.Mediator_.Colleage;

namespace GofPatternsFun.Behavioral.Mediator_
{
    class ChatRoomMediator
    {
        private Dictionary<string, ParticipantBase> participants =
          new Dictionary<string, ParticipantBase>();

        public void Register(ParticipantBase participant)
        {
            if (!participants.ContainsValue(participant))
            {
                participants[participant.Name] = participant;
            }

            participant.Chatroom = this;
        }

        public void Send(
          string from, string to, string message)
        {
            ParticipantBase participant = participants[to];

            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }

    }
}
