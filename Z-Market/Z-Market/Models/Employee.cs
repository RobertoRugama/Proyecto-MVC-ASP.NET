using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Z_Market.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage="You must enter {0}")]
        [StringLength(30, ErrorMessage="the field {0} Must be between {1} and {2} characters",MinimumLength=3)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You must enter {0}")]
        [StringLength(30, ErrorMessage = "the field {0} Must be between {1} and {2} characters", MinimumLength = 3)]
        public string LastName { get; set; }

        [Display(Name = "Salary")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "You must enter {0}")]
        public decimal Salary { get; set; }

        [Display(Name = "Bonus Percent")]
        [DisplayFormat(DataFormatString = "{0:P2}", ApplyFormatInEditMode = false)]
        public float BonusPercent { get; set; }

         [Display(Name = "Date Of Birth")]
         [Required(ErrorMessage = "You must enter {0}")]
         [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
         [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "URL")]
        [DataType(DataType.Url)]
        public string URL { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name="Documet Type ID")]
        
        public int DocumentTypeID  { get; set; }
        [NotMapped]
        public int Age { get { return DateTime.Now.Year - DateOfBirth.Year; } }

        public virtual DocumentType DocumentTypes { get; set; }

    }
}