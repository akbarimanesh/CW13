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
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.OrderID);
            builder.HasOne(x => x.employees).WithMany(x => x.orders).HasForeignKey(x=>x.EmployeeID);
            builder.HasOne(x => x.customer).WithMany(x => x.orders).HasForeignKey(x => x.CustomerID);
            builder.HasOne(x => x.shipper).WithMany(x => x.Orders).HasForeignKey(x => x.ShipVia);
            builder.HasMany(x => x.OrderDetails).WithOne(x => x.Order);
        }
    }
}
