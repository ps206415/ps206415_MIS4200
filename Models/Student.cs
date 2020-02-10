using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ps206415_MIS4200.Models
{
    public class Student
    {
        public int studentID { get; set; }
        //if you type prop for property the tab tab it will give property
        public string studentLastName { get; set; }
        public string studentFirstName { get; set; }

        public string email { get; set; }
        public string phone { get; set; }
        public DateTime studentSince { get; set; }
        public string fullName
        {
            get { return studentLastName + ", " + studentFirstName; }
        }
    }
}