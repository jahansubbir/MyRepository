using BDCounterETokenSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace BDCounterEtokenSystem.Models
{
    public class AppDbContext:DbContext
    {
        

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        
        }

        public DbSet<User> Admins { get; set; }

        public DbSet<Counter> Counters { get; set; }
        public DbSet<TokenType> TokenTypes { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<TokenDetail> TokenDetails { get; set; }

        public DbSet<Booth> Booths { get; set; }

    }
}
