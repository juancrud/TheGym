namespace Trainers.Data
{
    public class MeasurementItemValue
    {
        public virtual int MeasurementItemValueId { get; set; }
        public virtual decimal Value { get; set; }
        public virtual MeasurementItem MeasurementItem { get; set; }
        public virtual Measurement Measurement { get; set; }
    }
}
