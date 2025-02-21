using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_3.Models;

namespace Session_3.Configerations
{
    internal class EmployeeConfigerations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(E => E.Id)
                .UseIdentityColumn(100 ,100 );

            builder.Property(E => E.Name)
                   .HasColumnName("EmpName")
                   .HasColumnType("varchar")
                   .HasMaxLength(100);

            builder.Property(E => E.Salary)
                   .HasColumnType("money");

            builder.Property(E => E.Address)
                   .HasColumnType("varchar")
                   .HasMaxLength(100);

            builder.HasOne(E => E.WorkFor)
                   .WithMany(D => D.Employees)
                   .HasForeignKey(E => E.DeptId);
        }
    }
}
