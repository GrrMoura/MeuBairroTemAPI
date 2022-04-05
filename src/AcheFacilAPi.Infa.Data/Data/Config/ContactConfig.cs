using AcheFacilAPi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcheFacilAPi.Infa.Data.Data.Config
{
    public class ContactConfig : IEntityTypeConfiguration<Contacts>
    {
        public void Configure(EntityTypeBuilder<Contacts> builder)
        {
            builder.ToTable("Contacts");
            builder.HasKey(c => c.BusinessId);
            builder.Property(c => c.Instagram).HasMaxLength(100);
            builder.Property(c => c.Instagram).HasMaxLength(100);
            builder.Property(c => c.Instagram).HasMaxLength(100);
        }
    }
}
