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
        [DisplayName("Assay ID")]
        public int assayID { get; set; }

        [DisplayName("Assay Name")]
        public String assayName { get; set; }

        [DisplayName("TestID")]
        public int testID { get; set; }

        [DisplayName("Test Name")]
        public String testName { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int materialID { get; set; }

        [DisplayName("Material Name")]
        public String materialName { get; set; }




    }
}