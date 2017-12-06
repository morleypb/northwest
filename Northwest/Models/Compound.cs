using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest.Models
{
    [Table("Compound")]
    public class Compound
    {
        [Key]
        public int CompoundID { get; set; }

        public decimal CompoundExpectedWeight { get; set; }

        public decimal CompoundActualWeight { get; set; }

        public string Description { get; set; }

        public decimal MolecularMass { get; set; }

        public string ReportOnSample { get; set; }

        [ForeignKey("Orders")]
        public virtual int OrderID { get; set; }

        public virtual Orders Orders { get; set; }
    }
}