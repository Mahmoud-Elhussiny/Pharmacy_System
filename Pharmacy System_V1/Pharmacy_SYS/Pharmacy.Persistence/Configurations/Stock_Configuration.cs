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
    internal class Stock_Configuration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Stock");
            builder.Property(o => o.Name).IsRequired();
            builder.Property(o => o.Location).IsRequired();
        }
    }
}
