using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest.Models
{
    [Table("Employees")]
    public class Employees
    {
        [Key]
        public int EmployeeID { get; set; }

        public string EmployeeFirstName { get; set; }

        public string EmployeeLastName { get; set; }

        public string EmployeeStreetAddress { get; set; }

        public string EmployeeCity { get; set; }

        [ForeignKey("State")]
        public virtual int StateID { get; set; }

        public virtual State State { get; set; }

        [ForeignKey("ZipCode")]
        public virtual int ZipID { get; set; }

        public virtual ZipCode ZipCode { get; set; }

        [ForeignKey("Country")]
        public virtual int CountryID { get; set; }

        public virtual Country Country { get; set; }

        public string EmployeePhoneNumber { get; set; }

        [ForeignKey("Wage")]
        public virtual int WageID { get; set; }

        public virtual Wage Wage { get; set; }

        [ForeignKey("JobTitle")]
        public virtual int JobTitleID { get; set; }

        public virtual JobTitle JobTitle { get; set; }
    }
}