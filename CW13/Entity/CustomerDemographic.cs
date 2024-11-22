using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW13.Entity
{
    public class CustomerDemographic
    {
        public char CustomerTypeID { get; set; }
        public string CustomerDesc { get; set; }
        public List<Customer>customers{ get; set; }
    }
}
