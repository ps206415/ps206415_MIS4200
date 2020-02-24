using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ps206415_MIS4200.Models
{
    public class Course
    {
        public int courseID { get; set; }
        public string title { get; set; }
        [Display(Name = "Title of course")]
        [StringLength(20)]
        public string courseDescription { get; set; }
        [Display(Name = "Course description")]
        [StringLength(250)]
        public ICollection<Enrollment> Enrollment { get; set; }

    }
}