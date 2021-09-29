using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MTGManager.Domain;

namespace MTGManager.Infrastructure.EntityTypeConfigurations
{
    class CardConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasKey(card => card.CardId);
            builder.HasIndex(card => card.Id).IsUnique();
        }
    }
}
