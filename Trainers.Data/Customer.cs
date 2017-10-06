using System;
using System.Collections.Generic;
using Trainers.Data.Enums;

namespace Trainers.Data
{
    public class Customer
    {
        public virtual int CustomerId { get; set; }
        public virtual int DocumentId { get; set; }
        public virtual string Name { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual DateTime BirthDay { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual string MailAddress { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual User User { get; set; }

        public virtual IList<Measurement> Measurements { get; set; }

        //Foto
        //Otros campos
    }
}
