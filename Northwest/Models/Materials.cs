using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest.Models
{
    [Table("Materials")]
    public class Materials
    {
        [Key]
        public int MaterialID { get; set; }

        public string MaterialName { get; set; }

        public decimal MaterialCost { get; set; }
    }
}