using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntexProject.Models
{
    public class Material
    {
        [Key]
        public int materialID { get; set; }
        public String materialName { get; set; }
    }
}