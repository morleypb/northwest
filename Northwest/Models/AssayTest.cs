using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest.Models
{
    [Table("AssayTest")]
    public class AssayTest
    {
        [Key]
        public int AssayTestID { get; set; }

        [ForeignKey("Assay")]
        public virtual int AssayID { get; set; }

        public virtual Assay Assay { get; set; }

        [ForeignKey("Test")]
        public virtual int TestID { get; set; }

        public virtual Test Test { get; set; }

        public int Required { get; set; }

        public decimal TestCost { get; set; }
    }
}