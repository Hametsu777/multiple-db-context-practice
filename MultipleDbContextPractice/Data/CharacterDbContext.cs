using Microsoft.EntityFrameworkCore;
using MultipleDbContextPractice.Models;

namespace MultipleDbContextPractice.Data
{
    public class CharacterDbContext : DbContext
    {
        public CharacterDbContext(DbContextOptions<CharacterDbContext> options) : base(options)
        {

        }

        public DbSet<Character> Characters { get; set; }
    }
}
