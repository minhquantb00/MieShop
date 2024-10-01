using MieShop.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class ChatMessageParticipantStates : BaseEntity<Guid>
    {
        public Guid ChatMessageId { get; set; }
        public virtual ChatMessage? ChatMessage { get; set; }
        public bool IsSeen { get; set; } = false;
        public DateTime? SeenTime { get; set; }
        public Guid ParticipantId { get; set; }
        public virtual Participant? Participant { get; set; }
    }
}
