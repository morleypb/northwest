using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest.Models
{
    [Table("Customer")]
    public class Customers
    {
        [Key]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "*Required")]
        [StringLength(255, ErrorMessage = "Can only have 255 characters in your first name")]
        public string CustomerFirstName { get; set; }

        [Required(ErrorMessage = "*Required")]
        [StringLength(255, ErrorMessage = "Can only have 255 characters in your last name")]
        public string CustomerLastName { get; set; }

        [Required(ErrorMessage = "*Required")]
        [StringLength(255, ErrorMessage = "Can only have 255 characters in your street address")]
        public string CustomerStreetAddress { get; set; }

        [ForeignKey("State")]
        public virtual int StateID { get; set; }

        public virtual State State { get; set; }

        [ForeignKey("ZipCode")]
        public virtual int ZipID { get; set; }

        public virtual ZipCode ZipCode { get; set; }

        [ForeignKey("Country")]
        public virtual int CountryID { get; set; }

        public virtual Country Country { get; set; }

        [Required(ErrorMessage = "*Required")]
        [StringLength(255, ErrorMessage = "Can only have 255 characters in your phone number")]
        public string CustomerPhoneNumber { get; set; }
    }
}