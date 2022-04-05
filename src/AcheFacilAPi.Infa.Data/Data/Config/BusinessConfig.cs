using AcheFacilAPi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcheFacilAPi.Infa.Data.Data.Config
{
    internal class BusinessConfig : IEntityTypeConfiguration<Business>
    {
        public void Configure(EntityTypeBuilder<Business> builder)
        {
            builder.ToTable("Business");
            builder.HasKey(business => business.Id);
            builder.Property(business => business.Name)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(business => business.Profession)
                .HasMaxLength(50)
                .IsRequired();
          


        }
    }
}
