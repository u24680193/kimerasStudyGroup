using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace kimerasStudyGroup.Models
{
    public class StudyGroupMember
    {
        [Display(Name = "STUDENT NUMBER")] // Add as decorator
        public string StudentNumber { get; set; }

        [Display(Name = "NAME")] // Add as decorator
        public string Name { get; set; }

        [Display(Name = "SURNAME")] // Add as decorator
        public string Surname { get; set; }

        [Display(Name = "EMAIL ADDRESS")] // Add as decorator
        public string EmailAddress { get; set; }
    }
}