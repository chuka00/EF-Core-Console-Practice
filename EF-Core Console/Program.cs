using EF_Core.DAL;
using EF_Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Console
{
    internal class Program
    {
        static async Task Main()
        {
            //Console.WriteLine("Hello, World!");
            ToDoAppDbContextFactory toDoAppDbContextFactory = new ToDoAppDbContextFactory();
            var dbContext = toDoAppDbContextFactory.CreateDbContext(null);

            bool anyUser = await dbContext.Users.AnyAsync();
            if (!anyUser)
            {
                List<User> users = new List<User>()
                {
                    new User()
                    {
                        FirstName = "Lebron",
                        LastName = "James",
                        PhoneNumber = "08074786844",
                        Email = "Lebron@NBA.com",
                        Birthday = new DateTime(1984, 2 , 21),
                        Created= DateTime.Now,
                        IsActive = true
                    },

                    new User
                    {

                        FirstName = "David",
                        LastName = "Doe",
                        MiddleName = "Bello",
                        PhoneNumber = "09087652120",
                        Email = "david.doe@domain.com",
                        Birthday = new DateTime(2001, 1,1),
                        Created = DateTime.Now.AddYears(-2),
                        Updated = DateTime.Now,
                        IsActive = true
                    },

                    new User
                    {
                        FirstName = "John",
                        LastName = "Doe",
                        PhoneNumber = "09087652123",
                        Email = "john.doe@domain.com",
                        Birthday = new DateTime(2001, 1,1),
                        Created = DateTime.Now,
                        IsActive = true
                    },

                    new User
                    {
                        FirstName = "Mary",
                        LastName = "Doe",
                        PhoneNumber = "09087652121",
                        Email = "mary.doe@domain.com",
                        Birthday = new DateTime(2005, 1,1),
                        Created = DateTime.Now.AddYears(-4),
                        Updated = DateTime.Now
                    }

                };


                //AddRange
                Console.WriteLine("Create Users..........");
                await dbContext.Users.AddRangeAsync(users);
                Console.WriteLine(await dbContext.SaveChangesAsync());
            }

        }
    }
}