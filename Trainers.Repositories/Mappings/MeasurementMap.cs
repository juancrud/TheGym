using FluentNHibernate.Mapping;
using Trainers.Data;

namespace Trainers.Repositories.Mappings
{
    public class MeasurementMap : ClassMap<Measurement>
    {
        public MeasurementMap()
        {
            Id(x => x.MeasurementId).GeneratedBy.Identity();
            Map(x => x.Date).Not.Nullable();
            Map(x => x.Comments);
            Map(x => x.Weight).Not.Nullable();
            Map(x => x.Height).Not.Nullable();
            HasMany(x => x.MeasurementItemValues).Cascade.AllDeleteOrphan().Not.LazyLoad();
            References(x => x.Customer).Not.Nullable().Column("CustomerId");
            References(x => x.Trainer).Not.Nullable().Column("TrainerId");
        }
    }
}
