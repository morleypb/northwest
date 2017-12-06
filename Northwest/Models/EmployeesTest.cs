using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Northwest.Models
{
    [Table("EmployeesTest")]
    public class EmployeesTest
    {
        [ForeignKey("Employees")]
        public virtual int EmployeeID { get; set; }

        public virtual Employees Employees { get; set; }

        [ForeignKey("Test")]
        public virtual int TestID { get; set; }

        public virtual Test Test { get; set; }
    }
}