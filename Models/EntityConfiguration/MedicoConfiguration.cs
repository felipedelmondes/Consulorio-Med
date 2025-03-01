using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SisMed.Models.Entities;

namespace SisMed.Models.EntityConfiguration
{
    public class MedicoConfiguration : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.ToTable("Medicos");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Crm)
                .IsRequired()
                .HasMaxLength(20);
            builder.HasIndex(x => x.Crm).IsUnique();

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(200);
        }
    }

}