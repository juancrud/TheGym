using Trainers.Data.Enums;

namespace Trainers.Data
{
    public class ExerciseMedia
    {
        public virtual int ExerciseMediaId { get; set; }
        public virtual ExerciseMediaType ExerciseMediaType { get; set; }
        public virtual byte[] Data { get; set; }
    }
}
