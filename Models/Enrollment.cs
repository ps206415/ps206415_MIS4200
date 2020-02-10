using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ps206415_MIS4200.Models
{
    public class Enrollment
    {
        public int enrollmentID { get; set; }
        public string grade { get; set; }

        public int courseID { get; set; }
        public virtual Course Course { get; set; }
        public int studentID { get; set; }
        public virtual Student Student { get; set; }
    }
}