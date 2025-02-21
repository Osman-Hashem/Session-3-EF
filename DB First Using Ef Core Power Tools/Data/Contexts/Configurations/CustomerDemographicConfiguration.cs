﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using DB_First_Using_Ef_Core_Power_Tools.Data.Contexts;
using DB_First_Using_Ef_Core_Power_Tools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DB_First_Using_Ef_Core_Power_Tools.Data.Contexts.Configurations
{
    public partial class CustomerDemographicConfiguration : IEntityTypeConfiguration<CustomerDemographic>
    {
        public void Configure(EntityTypeBuilder<CustomerDemographic> entity)
        {
            entity.HasKey(e => e.CustomerTypeId).IsClustered(false);

            entity.Property(e => e.CustomerTypeId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CustomerTypeID");
            entity.Property(e => e.CustomerDesc).HasColumnType("ntext");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CustomerDemographic> entity);
    }
}
