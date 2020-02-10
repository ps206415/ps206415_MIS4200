using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ps206415_MIS4200.Models
{
    public class Course
    {
        public int courseID { get; set; }
        public string title { get; set; }
        public string courseDescription { get; set; }
        public ICollection<Enrollment> Enrollment { get; set; }

    }
}