using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeService.Web.Models
{
    public class PromotionCreateModel
    {
        //public string Expertise { get; set; }
       
        public decimal Price { get; set; }
     
        public string Description { get; set; }
        
        public DateTime StartDate { get; set; }
       
        public DateTime EndDate { get; set; }
      
        public string Tags { get; set; }
    }
}