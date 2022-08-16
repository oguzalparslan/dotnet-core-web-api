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
    internal class ActiveWorksSeeds : IEntityTypeConfiguration<ActiveWorks>
    {
        public void Configure(EntityTypeBuilder<ActiveWorks> builder)
        {
            //builder.HasData(
            //    new ActiveWorks
            //    {
            //        Id = 1,
            //        MembershipDate 15.08.2022,
            //        Date = "15.08.2022",
            //        TrackingCode = "DenemeTrackingCode",
            //        Problem = "DenemeProblem",
            //        DeviceId = 1,
            //        CustomerId = 1,
            //        TechnicalServiceId = 1,
            //    }
            //    );
        }
    }
}
