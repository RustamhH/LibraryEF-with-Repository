﻿using Library_EF_Repository.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_EF_Repository.Configurations
{
    public class LibConfiguration : IEntityTypeConfiguration<Lib>
    {
        public void Configure(EntityTypeBuilder<Lib> builder)
        {
            builder.Property(p => p.Id).ValueGeneratedNever();

            builder.HasKey(b => b.Id);
            builder.Property(b => b.FirstName).IsRequired();
            builder.Property(b => b.LastName).IsRequired();

            builder.HasMany(b => b.S_Cards).WithOne(b => b.Lib).HasForeignKey(b => b.Id_Lib);
            builder.HasMany(b => b.T_Cards).WithOne(b => b.Lib).HasForeignKey(b => b.Id_Lib);
        }
    }
}
