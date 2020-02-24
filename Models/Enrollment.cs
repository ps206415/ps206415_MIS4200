using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ps206415_MIS4200.Models
{
    public class Enrollment
    {
        public int enrollmentID { get; set; }
        public string grade { get; set; }
        [Display(Name = "What grade did the student earn in this course?")]
        [StringLength(1, MinimumLength =1, ErrorMessage ="Grade must be one character")]
        public int courseID { get; set; }
        public virtual Course Course { get; set; }
        public int studentID { get; set; }
        public virtual Student Student { get; set; }
    }
}