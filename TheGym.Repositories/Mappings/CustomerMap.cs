using FluentNHibernate.Mapping;
using TheGym.Data;

namespace TheGym.Repositories.Mappings
{
    public class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
            Id(x => x.CustomerId).GeneratedBy.Identity();
            Map(x => x.DocumentId).Not.Nullable();
            Map(x => x.Gender).Not.Nullable();
            Map(x => x.Name).Not.Nullable();
            Map(x => x.BirthDay).Not.Nullable();
            Map(x => x.EmailAddress);
            Map(x => x.MailAddress);
            Map(x => x.PhoneNumber);
            HasMany(x => x.Measurements).Cascade.AllDeleteOrphan();
        }
    }
}
