using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GetMedia.Models
{
    public class GetMediaContext : DbContext
    {

        public GetMediaContext (DbContextOptions<GetMediaContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(
            @"Server=(localdb)\\mssqllocaldb;Database=GetMediaContext-6c0bc13e-adde-4fc7-a94a-170bbb5ce553;Trusted_Connection=True;MultipleActiveResultSets=true");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInOrganization>()
                .HasKey(t => new { t.UserId, t.OrganizationId });
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<UserInOrganization> UserInOrganization { get; set; }
        public DbSet<GetMedia.Models.Campaign> Campaign { get; set; }
    }
}
