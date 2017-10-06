using System;
using Trainers.Data;
using Trainers.Data.Enums;
using Trainers.Services;
using Trainers.Services.Interfaces;

namespace TestConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IUserService userService = new UserService();

            var newUser = new User
            {
                DateCreated = DateTime.Now,
                UserName = "gaby",
                Password = "password",
                UserStatus = UserStatus.Active
            };
            userService.SaveUser(newUser);

            var auth = userService.AuthenticateUser("gaby", "password");
            Console.WriteLine(auth);

            newUser.UserStatus = UserStatus.Expired;
            userService.SaveUser(newUser);

            var auth2 = userService.AuthenticateUser("gaby", "password");
            Console.WriteLine(auth2);

            userService.DeleteUser(newUser);

            Console.ReadLine();
        }
    }
}
