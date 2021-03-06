﻿using System.Collections.Generic;

namespace TheGym.Data
{
    public class RoutineItem
    {
        public virtual int RoutineItemId { get; set; }
        public virtual string Comments { get; set; }
        public virtual IList<RoutineExerciseItem> RoutineExerciseItems { get; set; }
    }
}
