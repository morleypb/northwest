using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest.Models
{
    [Table("CustomerDiscounts")]
    public class CustomerDiscounts
    {
        [ForeignKey("Customers")]
        public virtual int CustomerID { get; set; }

        public virtual Customers Customers { get; set; }

        [ForeignKey("Discount")]
        public virtual int Discount { get; set; }
    }
}