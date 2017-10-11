using FluentNHibernate.Mapping;
using TheGym.Data;

namespace TheGym.Repositories.Mappings
{
    public class MeasurementItemMap : ClassMap<MeasurementItem>
    {
        public MeasurementItemMap()
        {
            Id(x => x.MeasurementItemId).GeneratedBy.Identity();
            Map(x => x.Name).Not.Nullable();
        }
    }
}
