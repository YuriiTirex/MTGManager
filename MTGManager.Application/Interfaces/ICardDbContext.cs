using Microsoft.EntityFrameworkCore;
using MTGManager.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace MTGManager.Application.Interfaces
{
    public interface ICardDbContext
    {
        DbSet<Card> Cards { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
