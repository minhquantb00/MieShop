using MieShop.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class Participant : BaseEntity<Guid>
    {
        public Guid ConversationId { get; set; }
        public virtual Conversation? Conversation { get; set; }
        public Guid UserId { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<ChatMessage>? ChatMessages { get; set; }
        public virtual ICollection<ChatMessageParticipantStates>? ChatMessageParticipantStates { get; set; }
    }
}
