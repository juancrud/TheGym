using System;
using TheGym.Data.Enums;

namespace TheGym.Data
{
    public class User
    {
        public virtual int UserId { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual UserStatus UserStatus { get; set; }
        public virtual DateTime DateCreated { get; set; }
    }
}
