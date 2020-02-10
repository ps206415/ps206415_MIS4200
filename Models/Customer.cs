using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ps206415_MIS4200.Models
{
    public class Customer
    {
        public int customerID { get; set; }
        //if you type prop for property the tab tab it will give property
        public string customerLastName { get; set; }
        public string customerFirstName { get; set; }

        public string email { get; set; }
        public string phone { get; set; }
        public DateTime customerSince { get; set; }
        public string fullName {
            get { return customerLastName + ", " + customerFirstName; } }
    }

}