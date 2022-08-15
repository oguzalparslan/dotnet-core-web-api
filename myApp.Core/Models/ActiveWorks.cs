using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApp.Core.Models
{
    public class ActiveWorks : BaseEntity
    {

            public string Date { get; set; }
            public string TrackingCode { get; set; }
            public string Problem { get; set; }

            //Foreign Keys
            public int CustomerId { get; set; }
            public int DeviceId { get; set; }
            public int TechnicalServiceId { get; set; }

        //Relationships
        public TechnicalService TechnicalService { get; set; }

    }
}
