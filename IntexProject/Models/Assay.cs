using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntexProject.Models
{
    public class Assay
    {
        [Key]
        public int assayID { get; set; }
        public String assayName { get; set; }



    }
}