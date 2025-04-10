using Microsoft.EntityFrameworkCore;
using Notes.Domain;

namespace Notes.application.Interfaces
{
    public interface INoteDbContext
    {
        public DbSet<Note> Notes { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
