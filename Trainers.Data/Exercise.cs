using Trainers.Data.Enums;

namespace Trainers.Data
{
    public class Exercise
    {
        public int ExerciseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ExerciseType ExerciseType { get; set; }
        
        //ImageMedia (Photos, Videos, Links)

        public Trainer Owner { get; set; }
    }
}
