using System;
using System.Collections.Generic;

namespace Trainers.Data
{
    public class Routine
    {
        public virtual int RoutineId { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual string Objectives { get; set; }
        public virtual string Comments { get; set; }
        public virtual IList<RoutineItem> RoutineItems { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Trainer Trainer { get; set; }
        public virtual Measurement Measurement { get; set; }
    }
}
