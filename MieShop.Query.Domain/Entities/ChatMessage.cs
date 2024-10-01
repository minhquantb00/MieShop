using MieShop.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class ChatMessage : BaseEntity<Guid>, IDeleteable
    {
        public Guid ConversationId { get; set; }
        public virtual Conversation? Conversation { get; set; }
        public string Content { get; set; }
        public string Photo {  get; set; }
        public Guid CreatorId { get; set; } // participantId
        public virtual Participant? Creator { get; set; }
        public Guid UserDeleteId { get; set; }
        public virtual User? UserDelete { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeleteTime { get; set; }
        public virtual ICollection<ChatMessageParticipantStates>? ChatMessageParticipantStates { get; set; }
    }
}
