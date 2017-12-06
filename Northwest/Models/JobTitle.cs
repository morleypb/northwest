using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest.Models
{
    [Table("JobTitle")]
    public class JobTitle
    {
        [Key]
        public int JobTitleID { get; set; }

        public string JobTitleName { get; set; }

        [ForeignKey("Department")]
        public virtual int DepartmentID { get; set; }
    }
}