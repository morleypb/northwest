using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest.Models
{
    [Table("TestMaterials")]
    public class TestMaterials
    {
        [ForeignKey("Test")]
        public virtual int TestID { get; set; }

        [ForeignKey("Materials")]
        public virtual int MaterialsID { get; set; }
    }
}