using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest.Models
{
    [Table("Animal")]
    public class Animal
    {
        [Key]
        public int AnimalID { get; set; }

        public string AnimalName { get; set; }
    }
}