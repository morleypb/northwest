using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest.Models
{
    [Table("Discount")]
    public class Discount
    {
        [Key]
        public int DiscountID { get; set; }

        public string DiscountType { get; set; }

        public decimal DiscountAmount { get; set; }
    }
}