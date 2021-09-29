using Microsoft.EntityFrameworkCore;
using MTGManager.Application.Interfaces;
using MTGManager.Domain;
using MTGManager.Infrastructure.EntityTypeConfigurations;

namespace MTGManager.Infrastructure
{
    public class CardDbContext : DbContext, ICardDbContext
    {
        public DbSet<Card> Cards { get; set; }

        public CardDbContext(DbContextOptions<CardDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CardConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
