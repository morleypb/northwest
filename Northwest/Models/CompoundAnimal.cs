using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest.Models
{
    [Table("CompoundAnimal")]
    public class CompoundAnimal
    {
        [ForeignKey("Compound")]
        public virtual int CompoundID { get; set; }

        [ForeignKey("Animal")]
        public virtual int AnimalID { get; set; }
    }
}