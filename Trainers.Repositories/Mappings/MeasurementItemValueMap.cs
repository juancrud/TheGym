using FluentNHibernate.Mapping;
using Trainers.Data;

namespace Trainers.Repositories.Mappings
{
    public class MeasurementItemValueMap : ClassMap<MeasurementItemValue>
    {
        public MeasurementItemValueMap()
        {
            Id(x => x.MeasurementItemValueId).GeneratedBy.Identity();
            Map(x => x.Value).Not.Nullable();
            References(x => x.MeasurementItem).Not.Nullable().Column("MeasurementItemId");
            References(x => x.Measurement).Not.Nullable().Column("MeasurementId");
        }
    }
}
