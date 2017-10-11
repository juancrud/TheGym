using FluentNHibernate.Mapping;
using TheGym.Data;

namespace TheGym.Repositories.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.UserId).GeneratedBy.Identity();
            Map(x => x.UserName).Not.Nullable();
            Map(x => x.Password).Not.Nullable();
            Map(x => x.DateCreated).Not.Nullable();
            Map(x => x.UserStatus).Not.Nullable();
        }
    }
}
