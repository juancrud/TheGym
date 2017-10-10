using System;
using System.Collections.Generic;

namespace Trainers.Data
{
    public class Trainer
    {
        public virtual int TrainerId { get; set; }
        public virtual int DocumentId { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime BirthDay { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual string MailAddress { get; set; }
        public virtual int PhoneNumber { get; set; }
        public virtual byte[] Image { get; set; }
        public virtual User User { get; set; }
        public virtual IList<Measurement> Measurements { get; set; }
        public virtual IList<Routine> Routines { get; set; }
    }
}
