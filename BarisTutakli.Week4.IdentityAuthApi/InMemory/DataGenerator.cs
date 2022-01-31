using BarisTutakli.Week4.IdentityAuthApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarisTutakli.Week4.IdentityAuthApi.InMemory
{
    public class DataGenerator
    {
        public static  void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new InMemoryContext(
serviceProvider.GetRequiredService<DbContextOptions<InMemoryContext>>()))
            {
                // Look for any book.
                if (context.Users.Any())
                {
                    return;   // Data was already seeded
                }
                context.Users.AddRange(
                    new User { Name="Bob", Email="bob@hotmail.com",  Password="1234" },
                    new User { Name = "George", Email = "Georgeb@hotmail.com", Password = "123456" },
                    new User { Name = "Mary", Email = "Mary@hotmail.com", Password = "12345" }

                    );
                if (context.Roles.Any())
                {
                    return;   // Data was already seeded
                }
                context.Roles.AddRange(
                 new Role { Name="Admin", Users=new List<int> {1} },
                 new Role { Name = "RestrictedUser", Users = new List<int> { 2 } },
                 new Role { Name = "Guest", Users = new List<int> { 3 } }
                    );

                context.SaveChanges();
            }
        }
    }
}
