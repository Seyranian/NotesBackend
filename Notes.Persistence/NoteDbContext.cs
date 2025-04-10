using Microsoft.EntityFrameworkCore;
using Notes.Application.Interfaces;
using Notes.Domain;
using Notes.Persistence.EntityTypeConfiguration;

namespace Notes.Persistence
{
    public class NoteDbContext(DbContextOptions<NoteDbContext> option)
        : DbContext(option), INoteDbContext
    {
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NoteConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
