using MieShop.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class Conversation : BaseEntity<Guid>
    {
        public string Title { get; set; }
        public string Creator {  get; set; }
        public DateTime? DeleteTime { get; set; }
        public Guid UserDeleteId { get; set; }
        public virtual User? UserDelete { get; set; }   
        public virtual ICollection<Participant>? Participants { get; set; }
        public virtual ICollection<ChatMessage>? ChatMessages { get; set; }
    }
}
