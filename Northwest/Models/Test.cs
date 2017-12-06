using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest.Models
{
    [Table("Test")]
    public class Test
    {
        [Key]
        public int TestID { get; set; }

        public decimal Hours { get; set; }

        public decimal BasePrice { get; set; }

        public decimal ConductingCost { get; set; }

        public decimal RequiredWeight { get; set; }
    }
}