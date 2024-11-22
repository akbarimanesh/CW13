using CW13.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW13.Configuration
{
    public class TerritoryConfig : IEntityTypeConfiguration<Territory>
    {
        public void Configure(EntityTypeBuilder<Territory> builder)
        {
            builder.HasKey(x => x.TerritoryID);
            builder.HasOne(x => x.region).WithMany(x => x.Territories).HasForeignKey(x=>x.RegionID);
        }
    }
}
