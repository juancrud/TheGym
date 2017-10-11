using TheGym.Data;

namespace TheGym.Services.Interfaces
{
    public interface ITrainerService
    {
        Trainer GetTrainer(int trainerId);
        void SaveTrainer(Trainer trainer);
        void DeleteTrainer(Trainer trainer);
    }
}
