using System.Collections.Generic;

namespace TheGym.Data
{
    public class Exercise
    {
        public virtual int ExerciseId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual ExerciseCategory ExerciseCategory { get; set; }
        public virtual IList<ExerciseMedia> ExerciseMedias { get; set; }
    }
}
