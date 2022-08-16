using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using myApp.Core.Models;


namespace myApp.Repository.Seeds
{
    internal class DeviceSeeds : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            //builder.HasData(
            //    new Device
            //    {
            //        Id = 1,
            //        MembershipDate = "15-08-2022",
            //        Brand = "asdasd",
            //        Model = "1231",
            //        SerialNumber = "ASDASDASD",
            //        ModelNumber = "A2429",
            //        CustomerId = 1
            //    },
            //      new Device
            //      {
            //          Id = 2,
            //          MembershipDate = "15-08-2022",
            //          Brand = "asdasdsad",
            //          Model = "1212",
            //          SerialNumber = "123DASDASD",
            //          ModelNumber = "A2530",
            //          CustomerId = 2
            //      }
            //    );
        }
    }
}
