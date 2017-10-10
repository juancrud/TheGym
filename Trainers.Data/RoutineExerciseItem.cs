namespace Trainers.Data
{
    public class RoutineExerciseItem
    {
        public virtual int RoutineExerciseItemId { get; set; }
        public virtual Exercise Exercise { get; set; }
        public virtual int? Series { get; set; }
        public virtual int? Repetitions { get; set; }
        public virtual int? RestTime { get; set; }
        public virtual int? Weight { get; set; }
        public virtual int? Duration { get; set; }
        public virtual string Comments { get; set; }
    }
}
