﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntexProject.Models
{
    public class WorkOrder
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int workOrderID { get; set; }

        [DisplayName("Assay Name")]
        public String assayName { get; set; }

        [DisplayName("Number of Samples")]
        public int? numberSamples { get; set; }

        [DisplayName("Description of appearance")]
        public String apperance { get; set; }

        //[DisplayName("Total weight of samples")]
        //public String weight(mg) { get; set; }

        [DisplayName("Due date of compound")]
        //[RegularExpression("^\d{1,2}\/\d{1,2}\/\d{4}$", ErrorMessage = "Please follow the date format")]
        public String dateDue { get; set; }


    }
}