using Data.Entities.Card;
using Data.Entities.Roles;
using Data.Entities.Turnstiles;
using Data.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Data.Context
{
    public class TurnstileContext : DbContext
    {
        public TurnstileContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PassTurnstile>()
                .HasKey(pt => new { pt.TurnstileId, pt.PassId });
           
            modelBuilder.Entity<PassTurnstile>()
            .HasOne(pt => pt.Pass)
            .WithMany(p => p.PassTurnstiles)
            .HasForeignKey(pt => pt.PassId);

            modelBuilder.Entity<PassTurnstile>()
                .HasOne(pt => pt.Turnstile)
                .WithMany(t => t.PassTurnstiles)
                .HasForeignKey(pt => pt.TurnstileId);
        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<Pass> Passes { get; set; }
        public DbSet<AccessRight> AccessRights { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Turnstile> Turnstiles { get; set; }
    }
}
