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
    internal class CustomerSeeds : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    Id = 1,
                    MembershipDate = "15-08-2022",
                    FirstName = "Deneme",
                    LastName = "Deneme2",
                    NickName = "DenemeNickname",
                    PhoneNumber = "DenemePhoneNumber",
                    Address = "DenemeAdres",
                    Email = "DenemeEmail",
                    DeviceId = 1
                });
        }
    }
}