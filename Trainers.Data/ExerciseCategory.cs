using System.Collections.Generic;

namespace Trainers.Data
{
    public class ExerciseCategory
    {
        public virtual int ExerciseCategoryId { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Exercise> Exercises { get; set; }
    }
}
