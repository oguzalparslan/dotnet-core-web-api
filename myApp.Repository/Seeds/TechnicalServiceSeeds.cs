using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using myApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApp.Repository.Seeds
{
    internal class TechnicalServiceSeeds : IEntityTypeConfiguration<TechnicalService>
    {
        public void Configure(EntityTypeBuilder<TechnicalService> builder)
        {
            builder.HasData(
                /*
        public string BrandName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public float Rating { get; set; }
        public string Website { get; set; }
        //Foreign Keys
        public int DeviceId { get; set; }
                */
                new TechnicalService
                {
                    Id = 1,
                    MembershipDate = "15.08.2022",
                    BrandName = "DenemeBrandName",
                    PhoneNumber = "DenemePhoneNumber",
                    Address = "DenemeAddress",
                    Rating = 4.7f,
                    Website = "DenemeWebsite",
                    DeviceId = 1
                }
                );
        }
    }
}
