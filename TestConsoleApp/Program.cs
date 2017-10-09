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
            TestUsers();
            TestTrainers();

            Console.ReadLine();
        }

        private static void TestUsers()
        {
            IUserService userService = new UserService();

            var newUser = CreateUser();
            userService.SaveUser(newUser);

            var auth = userService.AuthenticateUser("gaby", "password");
            Console.WriteLine(auth);

            newUser.UserStatus = UserStatus.Expired;
            userService.SaveUser(newUser);

            var auth2 = userService.AuthenticateUser("gaby", "password");
            Console.WriteLine(auth2);

            newUser.UserStatus = UserStatus.Active;
            userService.SaveUser(newUser);

            var auth3 = userService.AuthenticateUser("gaby", "password");
            Console.WriteLine(auth3);

            var auth4 = userService.AuthenticateUser("gaby", "password1");
            Console.WriteLine(auth4);

            userService.DeleteUser(newUser);
        }

        private static void TestTrainers()
        {
            ITrainerService trainerService = new TrainerService();

            var trainer = CreateTrainer();
            trainer.User = CreateUser();

            trainerService.SaveTrainer(trainer);

            trainer.PhoneNumber = 87654321;
            trainerService.SaveTrainer(trainer);

            trainerService.DeleteTrainer(trainer);
        }

        private static User CreateUser()
        {
            return new User
            {
                DateCreated = DateTime.Now,
                UserName = "gaby",
                Password = "password",
                UserStatus = UserStatus.Active
            };
        }

        private static Trainer CreateTrainer()
        {
            return new Trainer
            {
                Name = "Gabriela Sanchez",
                BirthDay = new DateTime(1984, 5, 9),
                DocumentId = 112040765,
                EmailAddress = "gabskatze@gmail.com",
                PhoneNumber = 12345678,
                MailAddress = "Los Arcos, Heredia"
            };
        }
    }
}
