using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest.Models
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }

        public DateTime DateArrived { get; set; }

        [ForeignKey("Customers")]
        public virtual int CustomerID { get; set; }

        public virtual Customers Customers { get; set; }

        public decimal QuotePrice { get; set; }

        public string Comment { get; set; }

        public int RushOrder { get; set; }
    }
}