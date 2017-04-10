using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Z_Market.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [StringLength(30, ErrorMessage="the field {0} must contain between {2} and {1} characters", MinimumLength=3)]
        [Required(ErrorMessage="You most enter the field {0}")]
        [Display(Name="First Name")]
        public string  FirstName { get; set; }

        [StringLength(30, ErrorMessage = "the field {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "You most enter the field {0}")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [StringLength(30,ErrorMessage="The Field {0} must contain between {2} and {1} characters", MinimumLength=3 )]
        [Required (ErrorMessage="You most enter the field {0}")]
        public string Phone { get; set; }

        [StringLength(30, ErrorMessage="the Field {0 contain between {2} and {1} characters", MinimumLength=3)]
        [Required (ErrorMessage="You Most enter the field {0}")]
        public string Address { get; set; }

        [DataType(DataType.EmailAddress)]
        public string  Email { get; set; }

        
        [StringLength(30, ErrorMessage = "The Field {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "You most enter the field {0}")]
        [Display(Name="Document")]
        public string  Document { get; set; }

        public int DocumentTypeID { get; set; }

        public virtual DocumentType DocumentType { get; set; }

    }
}