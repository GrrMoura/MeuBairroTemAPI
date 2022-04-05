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
    internal class ProficiencyConfig : IEntityTypeConfiguration<Proficiency>
    {
        public void Configure(EntityTypeBuilder<Proficiency> builder)
        {
            builder.ToTable("Proficiencies");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Profieciencies).HasMaxLength(50);
        }
    }
}
