using NHibernate;
using TheGym.Data;
using TheGym.DataAccess;
using TheGym.Repositories.Interfaces;

namespace TheGym.Repositories
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
