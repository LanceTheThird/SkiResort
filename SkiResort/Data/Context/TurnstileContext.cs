using Data.Entities.Card;
using Data.Entities.Roles;
using Data.Entities.Turnstiles;
using Data.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class TurnstileContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Pass> Passes { get; set; }
        public DbSet<AccessRight> AccessRights { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Turnstile> Turnstiles { get; set; }
    }
}
