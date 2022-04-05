using AcheFacilAPi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcheFacilAPi.Infa.Data.Data.Config
{
    public class AdressConfig:IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses");

            builder.HasKey(a => a.BusinessId);

            builder.Property(a => a.District)
                .HasMaxLength(50)
                .IsRequired();

            

            builder.Property(a => a.City)
                 .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.Street)
                 .HasMaxLength(50)
                .IsRequired();


        }

       
    }
}
