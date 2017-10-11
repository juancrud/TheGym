using TheGym.Data;
using TheGym.Repositories;
using TheGym.Services.Interfaces;

namespace TheGym.Services
{
    public class TrainerService : ITrainerService
    {
        public Trainer GetTrainer(int trainerId)
        {
            using (var trainerRepository = new TrainerRepository())
            {
                return trainerRepository.Get(trainerId);
            }
        }

        public void SaveTrainer(Trainer trainer)
        {
            using (var trainerRepository = new TrainerRepository())
            {
                trainerRepository.Save(trainer);
            }
        }

        public void DeleteTrainer(Trainer trainer)
        {
            using (var trainerRepository = new TrainerRepository())
            {
                trainerRepository.Delete(trainer);
            }
        }
    }
}
