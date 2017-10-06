using NHibernate;
using Trainers.Data;
using Trainers.DataAccess;
using Trainers.Repositories.Interfaces;

namespace Trainers.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository()
        {
            Session = Database.OpenSession();
        }

        public UserRepository(ISession session) : base(session)
        {
        }
    }
}
