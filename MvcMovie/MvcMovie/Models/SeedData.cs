using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.User.Any())
                {
                    return;   // DB has been seeded
                }

                context.User.AddRange(
                     new User
                     {
                         FirstName = "System",
                         LastName = "Administrator",
                         DOB = DateTime.Parse("01/01/2017"),
                         Email = "jeandrade@sdcoe.net"
                     },

                     new User
                     {
                         FirstName = "Test",
                         LastName = "User",
                         DOB = DateTime.Parse("01/01/2017"),
                         Email = "jeandrade@sdcoe.net"
                     }
                );
                context.SaveChanges();
            }
        }
    }
}