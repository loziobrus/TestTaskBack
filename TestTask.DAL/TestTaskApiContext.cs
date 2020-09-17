using Microsoft.EntityFrameworkCore;
using TestTask.Core.Entities;

namespace TestTask.DAL
{
    public class TestTaskApiContext : DbContext
    {
        public DbSet<Announcement> Announcements { get; set; }

        public TestTaskApiContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Announcement>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });
        }
    }
}
