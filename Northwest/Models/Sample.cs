using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest.Models
{
    [Table("Sample")]
    public class Sample
    {
        [Key]
        public int SampleID { get; set; }

        [ForeignKey("Compound")]
        public virtual int CompoundID { get; set; }

        [ForeignKey("AssayTest")]
        public virtual int AssayTestID { get; set; }

        public decimal SampleWeight { get; set; }

        public string RawResults { get; set; }

        public DateTime DateStarted { get; set; }

        public DateTime DateComplete { get; set; }
    }
}