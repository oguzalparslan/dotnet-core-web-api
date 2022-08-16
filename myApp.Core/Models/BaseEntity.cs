using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApp.Core.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime MembershipDate { get; set; }
    }
}
