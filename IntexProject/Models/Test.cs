using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexProject.Models
{
    [Table("Test")]
    public class Test
    {
        [Key]
        public int testID { get; set; }
        public String testName { get; set; }
        public decimal testPrice { get; set; }
        public DateTime testTime { get; set; }
    }
}