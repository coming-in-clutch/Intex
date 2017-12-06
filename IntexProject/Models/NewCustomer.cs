using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntexProject.Models
{
    public class NewCustomer
    {
        [Key]
        public int customerID { get; set; }
        [DisplayName("Name")]
        public string customerName { get; set; }
        [DisplayName("Street Address")]
        public string custAddress { get; set; }
        [DisplayName("Phone Number")]
        public string custPhone { get; set; }
        [DisplayName("City")]
        public string custCity { get; set; }
        [DisplayName("State")]
        public string custState { get; set; }
        [DisplayName("Zip")]
        public string custZip { get; set; }
        [DisplayName("Email")]
        public string custEmail { get; set; }

    }
}