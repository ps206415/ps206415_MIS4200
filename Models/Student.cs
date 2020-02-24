using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ps206415_MIS4200.Models
{
    public class Student
    {
        public int studentID { get; set; }
        
        //if you type prop for property the tab tab it will give property
        public string studentLastName { get; set; }
        [Display(Name = "First name")]
        [StringLength(20)]
        public string studentFirstName { get; set; }
        [Display(Name = "Last name")]
        [StringLength(20)]
        public string email { get; set; }
        [Display(Name = "Most used email address")]
        [Required]
        [EmailAddress(ErrorMessage ="Enter your most frequently used email address")]
        public string phone { get; set; }
        [Display (Name = "Mobile phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage ="Phone number must be in the format xxx-xxx-xxxx")]
        public DateTime studentSince { get; set; }

        // a student can be enrolled in several classes
        public ICollection<Enrollment> Enrollment { get; set; }

        public string fullName { get { return studentLastName + ", " + studentFirstName; } }
    }
}