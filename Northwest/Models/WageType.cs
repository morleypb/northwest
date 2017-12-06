using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest.Models
{
    [Table("WageType")]
    public class WageType
    {
        [Key]
        public int WageTypeID { get; set; }

        public string WageDescription { get; set; }
    }
}