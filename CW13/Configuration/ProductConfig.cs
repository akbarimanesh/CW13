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
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.ProductID);
            builder.HasMany(x => x.OrderDetails).WithOne(x => x.Product);
            builder.HasOne(x => x.category).WithMany(x => x.Products).HasForeignKey(x=>x.CategoryID);
            builder.HasOne(x => x.supplier).WithMany(x => x.Products).HasForeignKey(x=>x.SupplierID);

        }
    }
}
