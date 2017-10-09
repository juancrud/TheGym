using NHibernate;
using Trainers.Data;
using Trainers.DataAccess;
using Trainers.Repositories.Interfaces;

namespace Trainers.Repositories
{
    public class TrainerRepository : BaseRepository<Trainer>, ITrainerRepository
    {
        public TrainerRepository()
        {
            Session = Database.OpenSession();
        }

        public TrainerRepository(ISession session) : base(session)
        {
        }
    }
}
