﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using myApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApp.Repository.Configurations
{
    public class ActiveWorksConfiguration : IEntityTypeConfiguration<ActiveWorks>
    {
        public void Configure(EntityTypeBuilder<ActiveWorks> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.ToTable("ActiveWorks");
        }
    }
}
