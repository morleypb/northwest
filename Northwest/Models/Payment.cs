using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest.Models
{
    [Table("Payment")]
    public class Payment
    {
        [Key]
        public virtual int PaymentID { get; set; }

        [ForeignKey("Customer")]
        public virtual int CustomerID { get; set; }

        public string PaymentName { get; set; }

        public string PaymentDesc { get; set; }

        public string CreditCardNum { get; set; }

        [StringLength(5, ErrorMessage = "Your CSV can only have 5 characters")]
        public string CSV { get; set; }

        public string BillingName { get; set; }

        public string BillingAddress { get; set; }

        public string BillingPhone { get; set; }

        [ForeignKey("State")]
        public virtual int StateID { get; set; }

        [ForeignKey("ZipCode")]
        public virtual int ZipID { get; set; }

        [ForeignKey("Country")]
        public virtual int CountryID { get; set; }
    }
}