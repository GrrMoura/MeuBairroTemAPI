using AcheFacilAPi.Domain.Models;
using AcheFacilAPi.Infa.Data.Data.Config;
using Microsoft.EntityFrameworkCore;

namespace AcheFacilAPi.Infa.Data.DbApplications
{
    public class DbApplication: DbContext
    {
        public DbSet<User>? User { get; set; }
        public DbSet<Business>? Business { get; set; }
        public DbSet<Address>? Adresses { get; set; }

        public DbSet<Contacts>? Contacts { get; set; }
        public DbSet<Proficiency>? Proficiencies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdressConfig());
            modelBuilder.ApplyConfiguration(new BusinessConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new ProficiencyConfig());
          


            modelBuilder.Entity<User>().HasQueryFilter(p => p.Active == true); // para pegar apenas os ativos
            modelBuilder.Entity<Business>().HasQueryFilter(p => p.Active == true);

            base.OnModelCreating(modelBuilder);
        }

    }
}
