using System;
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
        [Required(ErrorMessage = "This field is required")]
        public int workOrderID { get; set; }

        [DisplayName("Assay Name")]
        [Required(ErrorMessage ="This field is required")]
        public String assayName { get; set; }

        [DisplayName("Number of Samples")]
        [Required(ErrorMessage = "This field is required")]
        public int? numberSamples { get; set; }

        [DisplayName("Description of Appearance")]
        [Required(ErrorMessage = "Please enter the appearance")]
        public String apperance { get; set; }

        [DisplayName("Total weight of samples")]
        [Required(ErrorMessage = "This field is required")]
        public decimal weight { get; set; }



        [DisplayName("Due Date of Compound")]
        [Required(ErrorMessage = "Please follow the date format DD/MM/YYYY")]
        public String dateDue { get; set; }


    }
}