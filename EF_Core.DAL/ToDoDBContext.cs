using EF_Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_Core.DAL
{
    public class TodoDBContext : DbContext
    {

        public TodoDBContext(DbContextOptions<TodoDBContext> options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<TheTask> Tasks { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tag>(e =>
            {
                e.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(20);
                e.HasIndex(p => p.Name, $"IX_{nameof(Tag)}_{nameof(Tag.Name)}")
                .IsUnique();
                e.Property(p => p.Description)
                .HasMaxLength(400)
                .IsRequired(false);
            });

            modelBuilder.Entity<User>(e =>
            {
                e.Property(p => p.MiddleName)
                    .IsRequired(false);
                e.HasIndex(p => new { p.Email, p.PhoneNumber },
                        $"IX_Unique_{nameof(User.Email)}{nameof(User.PhoneNumber)}")
                    .IsUnique();

            });


            modelBuilder.Entity<TheTask>()
                .Property(p => p.Description)
                .IsRequired(false);


            base.OnModelCreating(modelBuilder);

        }

    }
}