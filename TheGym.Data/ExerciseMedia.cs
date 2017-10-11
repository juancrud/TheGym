using TheGym.Data.Enums;

namespace TheGym.Data
{
    public class ExerciseMedia
    {
        public virtual int ExerciseMediaId { get; set; }
        public virtual ExerciseMediaType ExerciseMediaType { get; set; }
        public virtual byte[] Data { get; set; }
    }
}
