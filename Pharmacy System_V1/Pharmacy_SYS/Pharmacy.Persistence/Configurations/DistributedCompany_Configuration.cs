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
    public class DistributedCompany_Configuration : IEntityTypeConfiguration<DistributedCompany>
    {
        public void Configure(EntityTypeBuilder<DistributedCompany> builder)
        {
            builder.ToTable("DistributedCompany");
            builder.HasKey(x => x.Id);
            builder.Property(o => o.Name).IsRequired();
            builder.Property(o => o.Location).IsRequired();
            builder.Property(o => o.Phone).HasMaxLength(15);
            builder.HasOne<TheManufacturer>(o => o.TheManufacturer)
                .WithMany(o => o.distributedCompanies)
                .HasForeignKey(o => o.TheManufacturerId);
        }
    }
}
