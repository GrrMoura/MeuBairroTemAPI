using AcheFacilAPi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcheFacilAPi.Infa.Data.Data.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.ToTable("user");

            builder.HasKey(user => user.Id);

            builder.Property(user => user.Name)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(user => user.Email)
                .HasMaxLength(50)
                .IsRequired();

          


        }
    }
}

