using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest.Models
{
    [Table("Wage")]
    public class Wage
    {
        [Key]
        public int WageID { get; set; }

        public decimal WageAmount { get; set; }

        [ForeignKey("WageType")]
        public virtual int WageTypeID { get; set; }
    }
}