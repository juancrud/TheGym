using System;
using System.Collections.Generic;

namespace Trainers.Data
{
    public class Measurement
    {
        public virtual int MeasurementId { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual string Comments { get; set; }

        public virtual int Weight { get; set; }
        public virtual int Height { get; set; }

        public virtual IList<MeasurementItemValue> MeasurementItemValues { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Trainer Trainer { get; set; }
    }
}
