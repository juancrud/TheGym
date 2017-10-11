using NHibernate;
using TheGym.Data;
using TheGym.DataAccess;
using TheGym.Repositories.Interfaces;

namespace TheGym.Repositories
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
