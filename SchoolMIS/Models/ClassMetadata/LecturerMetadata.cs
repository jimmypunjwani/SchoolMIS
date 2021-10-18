using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolMIS.Models
{
    public class LecturerMetadata
    {
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string FirstName { get; set; }
    }

    //Adding partial class to connect with main class:
    [MetadataType(typeof(LecturerMetadata))]
    public partial class Lecturer
    {

    }
}