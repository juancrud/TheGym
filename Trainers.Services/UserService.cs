using System.Linq;
using Trainers.Data;
using Trainers.Data.Enums;
using Trainers.Repositories;
using Trainers.Services.Interfaces;
using Trainers.Utilities;

namespace Trainers.Services
{
    public class UserService : IUserService
    {

        public bool AuthenticateUser(string username, string password)
        {
            using (var userRepository = new UserRepository())
            {
                var user = userRepository.Get(x => x.UserName == username).FirstOrDefault();
                return user != null && user.UserStatus == UserStatus.Active && EncryptionUtility.Verify(password, user.Password);
            }
        }

        public void SaveUser(User user)
        {
            using (var repository = new UserRepository())
            {
                try
                {
                    repository.BeginTransaction();
                    user.Password = EncryptionUtility.Encrypt(user.Password);
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
