using System.Linq;
using Trainers.Data;
using Trainers.Data.Enums;
using Trainers.Repositories;
using Trainers.Services.Interfaces;

namespace Trainers.Services
{
    public class UserService : IUserService
    {

        public bool AuthenticateUser(string username, string password)
        {
            using (var userRepository = new UserRepository())
            {
                var user = userRepository.Get(x => x.UserName == username && x.Password == password).FirstOrDefault();
                return user != null && user.UserStatus == UserStatus.Active;
            }
        }

        public void SaveUser(User user)
        {
            using (var repository = new UserRepository())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Save(user);
                }
                catch
                {
                    repository.RollbackTransaction();
                }
            }
        }

        public void DeleteUser(User user)
        {
            using (var repository = new UserRepository())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(user);
                }
                catch
                {
                    repository.RollbackTransaction();
                }
            }
        }
    }
}
