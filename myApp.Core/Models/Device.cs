using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApp.Core.Models
{
    public class Device : BaseEntity
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string ModelNumber { get; set; }

        //Foreign Keys
        public int CustomerId { get; set; }

        //Relationships
        public Customer Customer { get; set; }
    }
}
