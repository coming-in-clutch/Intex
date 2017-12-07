using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntexProject.Models
{
    public class Catalog
    {
        [Key]
        [DisplayName("Assay")]
        public int assayID { get; set; }

        [DisplayName("Assay Name")]
        public String assayName { get; set; }


        [DisplayName("Number of Tests")]
        public int TestNum { get; set; }

        [DisplayName("Price")]
        public decimal assayBasePrice { get; set; }
    

        //[DisplayName("Test Name")]
        //public String testName { get; set; }


    }
}