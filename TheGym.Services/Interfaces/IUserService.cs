using TheGym.Data;

namespace TheGym.Services.Interfaces
{
    public interface IUserService
    {
        bool AuthenticateUser(string username, string password);
        void SaveUser(User user);
        void DeleteUser(User user);
    }
}
