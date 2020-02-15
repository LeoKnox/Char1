using Microsoft.EntityFrameworkCore;
using MvcChar.Models;

namespace MvcChar.Data
{
    public class MvcCharacterContext : DbContext
    {
        public MvcCharacterContext(DbContextOptions<MvcCharacterContext> options) : base(options)
        {
        }

        public DbSet<Character> Character { get; set; }
    }
}