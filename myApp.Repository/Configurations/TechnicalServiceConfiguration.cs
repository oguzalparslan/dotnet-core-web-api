using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using myApp.Core.Models;

namespace myApp.Repository.Configurations
{
    public class TechnicalServiceConfiguration : IEntityTypeConfiguration<TechnicalService>
    {
        public void Configure(EntityTypeBuilder<TechnicalService> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.ToTable("TechnicalService");
        }
    }
}
