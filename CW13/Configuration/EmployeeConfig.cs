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
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.EmployeeID);
            builder.HasMany(x => x.Territories).WithMany(x => x.Employees);
            builder.HasMany(x => x.Employees).WithOne(x => x.ChailEmployee).HasForeignKey(x => x.ReportsTo).OnDelete(DeleteBehavior.Restrict); ;

        }
    }
}
