using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntexProject.Models
{
    public class Orders
    {
        [Key]
        public int workOrderID { get; set; }
        [DisplayName("Number of Samples")]
        public int numberSamples { get; set; }
        [DisplayName("Date Arrived")]
        public DateTime dateArrived { get; set; }
        [DisplayName("Date Due")]
        public DateTime dateDue{ get; set; }

        [HiddenInput(DisplayValue = false)]
        public String statusID { get; set; }

        [DisplayName("Status")]
        public String statusDescription { get; set; }

    }
}