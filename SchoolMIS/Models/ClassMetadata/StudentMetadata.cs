using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolMIS.Models
{
    public class StudentMetadata
    {
        [Required]
        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Date of Enrollment")]
        public DateTime EnrollmentDate { get; set; }

        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Display(Name = "Hobby")]
        public string Hobby { get; set; }
    }

    //Adding partial class to connect with main class:
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {

    }
}