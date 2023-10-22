using Microsoft.EntityFrameworkCore;
using MultipleDbContextPractice.Models;

namespace MultipleDbContextPractice.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
