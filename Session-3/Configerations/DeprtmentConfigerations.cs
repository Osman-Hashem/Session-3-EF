using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Session_3.Models;

namespace Session_3.Configerations
{
    internal class DeprtmentConfigerations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.Id).UseIdentityColumn(100 , 100);   

            builder.Property(D => D.Name)
                   .HasColumnName("DeptName")
                   .HasColumnType("varchar")
                   .HasMaxLength(100);
        }
    }
}
