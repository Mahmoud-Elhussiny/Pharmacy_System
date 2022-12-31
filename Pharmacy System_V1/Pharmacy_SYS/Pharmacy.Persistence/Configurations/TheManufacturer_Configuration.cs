using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pharmacy.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Persistence.Configurations
{
    public class TheManufacturer_Configuration : IEntityTypeConfiguration<TheManufacturer>
    {
        public void Configure(EntityTypeBuilder<TheManufacturer> builder)
        {
            builder.ToTable("TheManufacturer");
            builder.HasKey(x => x.Id);
            builder.Property(o => o.Name).IsRequired();
            builder.Property(o => o.Location).IsRequired();
            builder.Property(o => o.Phone).HasMaxLength(15);

    }
    }
}
