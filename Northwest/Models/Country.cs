using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest.Models
{
    [Table("Country")]
    public class Country
    {
        [Key]
        public int CountryID { get; set; }

        public String CountryName { get; set; }
    }
}