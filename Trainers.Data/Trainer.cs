using System;

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
        public virtual User User { get; set; }

        //Foto
        //Otros campos
    }
}
