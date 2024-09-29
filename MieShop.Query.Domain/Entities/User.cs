using MieShop.Commons.Base;
using MieShop.Commons.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class User : BaseEntity<Guid>, IDeleteable, IActivatable
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string NickName { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public Enumerate.Gender? Gender { get; set; }
        public string PinCode { get; set; }
        public Guid? AddressDefaultId { get; set; }
        public int Point { get; set; } = 0;
        public string Avatar {  get; set; }
        public Guid RankCustomerId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = false;
        public virtual ICollection<User>? Users { get; set; }
        public virtual ICollection<ConfirmEmail>? ConfirmEmails { get; set; }
        public virtual ICollection<RefreshToken>? RefreshTokens { get; set; }
    }
}
