using FluentNHibernate.Mapping;
using Trainers.Data;

namespace Trainers.Repositories.Mappings
{
    public class TrainerMap : ClassMap<Trainer>
    {
        public TrainerMap()
        {
            Id(x => x.TrainerId).GeneratedBy.Identity();
            Map(x => x.DocumentId).Not.Nullable();
            Map(x => x.Name).Not.Nullable();
            Map(x => x.BirthDay).Not.Nullable();
            Map(x => x.EmailAddress);
            Map(x => x.MailAddress);
            Map(x => x.PhoneNumber);
            References(x => x.User).Column("UserId").Cascade.All().Not.LazyLoad();
        }
    }
}
