using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Z_Market.Models
{
    public class Supplier
    {
        [Key]
        [StringLength(30, ErrorMessage="The field {0} must contain between {2} and {1} characters", MinimumLength=3)]
        [Required (ErrorMessage="you must enter the field {0}")]
        [Display(Name="Supplier Name")]
        public int SupplierId { get; set; }

        [StringLength(30, ErrorMessage="the field {0} must contain between {2} and {1} characters", MinimumLength=3)]
        [Required(ErrorMessage="you must enter the field {0}")]
        [Display(Name="Name")]
        public string  Name { get; set; }

        [StringLength(30, ErrorMessage = "the field {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "you must enter the field {0}")]
        [Display(Name = "Contact First Name")]
        public string ContactFirstName{ get; set; }

        [StringLength(30, ErrorMessage = "the field {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "you must enter the field {0}")]
        [Display(Name = "Contact Last Name")]
        public string  ContactLastName { get; set; }

        [StringLength(30, ErrorMessage = "the field {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "you must enter the field {0}")]
        [Display(Name = "Phone")]
        public string  Phone { get; set; }

        [StringLength(30, ErrorMessage = "the field {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "you must enter the field {0}")]
        public string  address { get; set; }

        [StringLength(30, ErrorMessage = "the field {0} must contain between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "you must enter the field {0}")]
        [DataType(DataType.EmailAddress)]
        public string  Email { get; set; }

        public virtual ICollection<SupplierProduct> Supplierproducts { get; set; }

    }
}